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
using Microsoft.Extensions.Logging;

namespace FTP_AutoSync
{
    public partial class Form1 : Form
    {
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

            int port = 2221; // Default FTP port
            if (!string.IsNullOrWhiteSpace(portText) && int.TryParse(portText, out int portNumber))
            {
                port = portNumber;
            }

            try
            {
                using FtpClient client = new FtpClient(host, user, pass);
                // create Serilog logger
                var serilogLogger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/FluentFTPLogs.txt", rollingInterval: RollingInterval.Day)
                    .CreateLogger();


                client.Config.CustomStream = typeof(GnuTlsStream);
                client.Config.CustomStreamConfig = new GnuConfig(){
                    LogLevel = 1,
                    // sample setting to use the default security suite
                    SecuritySuite = GnuSuite.Normal,

                    // sample setting to include all TLS protocols except for TLS 1.0 and TLS 1.1
                    SecurityOptions = new List<GnuOption> {
                        new GnuOption(GnuOperator.Include, GnuCommand.Protocol_All),
                        new GnuOption(GnuOperator.Exclude, GnuCommand.Protocol_Tls10),
                        new GnuOption(GnuOperator.Exclude, GnuCommand.Protocol_Tls11),
                },

                    // no profile required
                    SecurityProfile = GnuProfile.None,

                    // sample special flags (this is not normally required)
                    AdvancedOptions = [
                        GnuAdvanced.CompatibilityMode
                    ],

                    HandshakeTimeout = 5000,
                };
                // Set encryption mode to Explicit FTPS
                client.Config.EncryptionMode = FtpEncryptionMode.Explicit;
                client.Config.ValidateAnyCertificate = true;
                // Connect to the server
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
        void OnValidateCertificate(FtpClient control, FtpSslValidationEventArgs e)
        {
            // add logic to test if certificate is valid here
            e.Accept = true;
        }
    }

}
