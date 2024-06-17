using System;
using System.Net;
using System.Windows.Forms;
using FluentFTP;
using System.Threading.Tasks;

namespace FTP_AutoSync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseLocal_Click(object sender, EventArgs e)
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

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            string host = InHostIP.Text;
            string user = InUser.Text;
            string pass = InPass.Text;
            string portText = InPort.Text;

            int port = 21; // Default FTP port
            if (!string.IsNullOrWhiteSpace(portText) && int.TryParse(portText, out int portNumber))
            {
                port = portNumber;
            }

            try
            {
                var client = new FtpClient(host, user, pass);

                // Set encryption mode to Auto
                client.Config.EncryptionMode = FtpEncryptionMode.Auto;


                // Connect to the server
                client.Connect();

                if (client.IsConnected)
                {
                    MessageBox.Show("Connected successfully!");

                    var items = client.GetListing("/");

                    foreach (var item in items)
                    {
                        Console.WriteLine($"{item.Type} - {item.FullName}");
                    }
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
    }
}