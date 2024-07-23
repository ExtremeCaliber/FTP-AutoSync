using System;
using System.Net;
using System.Windows.Forms;
using FluentFTP;
using System.Threading;
using System.Threading.Tasks;
using FluentFTP.Logging;
using Microsoft.VisualBasic.Logging;
using FluentFTP.GnuTLS;
using FluentFTP.GnuTLS.Enums;
using Serilog;
using Serilog.Extensions.Logging;
using Serilog.Sinks.File;
using FluentFTP.Client.BaseClient;

namespace FTP_AutoSync
{
    public partial class Form1 : Form
    {
        private FtpClient client;

        public Form1()
        {
            InitializeComponent();
        }



        private void BtnBrowseLocal_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;

                    if (!cmbLocal.Items.Contains(selectedPath))
                    {
                        cmbLocal.Items.Add(selectedPath);
                    }

                    cmbLocal.Text = selectedPath;
                }
            }
        }

        private void InHostIP_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void InUser_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void InPass_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void InPort_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            string host = InHostIP.Text;
            string user = InUser.Text;
            string pass = InPass.Text;
            string portText = InPort.Text;

            try
            {
                if (client != null && client.IsConnected)
                {
                    client.Disconnect();
                }

                client = new FtpClient(host, user, pass);
                if (!string.IsNullOrWhiteSpace(portText) && int.TryParse(portText, out int portNumber))
                {
                    client.Port = portNumber;
                }
                else
                {
                    client.Port = 21;
                }
                // create Serilog logger
                var serilogLogger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/FluentFTPLogs.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();

                // wrap with MELA ILogger
                var microsoftLogger = new SerilogLoggerFactory(serilogLogger)
                    .CreateLogger("FTP");

                // wrap with FtpLogAdapter
                client.Logger = new FtpLogAdapter(microsoftLogger);
                client.Config.LogUserName = true;
                client.Config.LogPassword = true;
                client.Config.LogHost = true;

                // Encryption and Certificate Validation
                client.Config.EncryptionMode = FtpEncryptionMode.Auto;
                client.ValidateCertificate += new FtpSslValidation(OnValidateCertificate);

                client.Connect();

                if (client.IsConnected)
                {
                    MessageBox.Show("Connected successfully!");


                }
                else
                {
                    MessageBox.Show("Failed to connect!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to FTP server: {ex.Message}");
            }
        }



        private void TreeViewFTP_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Handle tree view node selection if needed
        }

        private void TxtOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private static void OnValidateCertificate(BaseFtpClient control, FtpSslValidationEventArgs e)
        {
            if (e.PolicyErrors != System.Net.Security.SslPolicyErrors.None)
            {
                // invalid cert, do you want to accept it?
                e.Accept = true;
            }
            else
            {
                e.Accept = true;
            }
        }

        private void btnBrowseServer_Click(object sender, EventArgs e)
        {
            // Check if the client is null or not connected
            if (client == null || !client.IsConnected)
            {
                MessageBox.Show("Please connect to the FTP server first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pass the connected client to the BrowseServerForm
            using (var browseForm = new BrowseServerForm(client))
            {
                browseForm.PopulateTreeView();
                if (browseForm.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = browseForm.SelectedPath;
                    if (!cmbServer.Items.Contains(selectedPath))
                    {
                        cmbServer.Items.Add(selectedPath);
                    }
                    cmbServer.SelectedItem = selectedPath;
                }
            }
        }

        private void cmbServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
