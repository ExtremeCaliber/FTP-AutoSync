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

                // Show the dialog box
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;

                    // Add the selected path to the ComboBox if it's not already in the list
                    if (!cmbLocal.Items.Contains(selectedPath))
                    {
                        cmbLocal.Items.Add(selectedPath);
                    }

                    // Set the ComboBox text to the selected path
                    cmbLocal.Text = selectedPath;
                }
            }
        }
    }
}
