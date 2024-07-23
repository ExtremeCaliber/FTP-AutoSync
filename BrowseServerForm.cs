using System;
using System.Windows.Forms;
using FluentFTP;

namespace FTP_AutoSync
{
    public partial class BrowseServerForm : Form
    {
        private string selectedPath;
        private FtpClient client;

        public string SelectedPath
        {
            get { return selectedPath; }
        }

        public BrowseServerForm(FtpClient ftpClient)
        {
            InitializeComponent();
            client = ftpClient ?? throw new ArgumentNullException(nameof(ftpClient));
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Set the selected path when the Select button is clicked
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag is FtpListItem item)
            {
                selectedPath = item.FullName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a directory or file from the tree view.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PopulateTreeView()
        {
            try
            {
                // Get a listing of files and directories in the current working directory
                foreach (var item in client.GetListing())
                {
                    TreeNode node = new TreeNode(item.Name)
                    {
                        Tag = item
                    };
                    treeView.Nodes.Add(node);

                    if (item.Type == FtpObjectType.Directory)
                    {
                        AddDummyNode(node); // Add dummy node to indicate expandable directories
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDummyNode(TreeNode node)
        {
            // Add a dummy node to indicate that the directory can be expanded
            node.Nodes.Add(new TreeNode("Loading..."));
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // Load child nodes when a node is expanded
            if (e.Node.Nodes[0].Text == "Loading...")
            {
                e.Node.Nodes.Clear();
                LoadChildNodes(e.Node);
            }
        }

        private void LoadChildNodes(TreeNode parentNode)
        {
            if (parentNode.Tag is FtpListItem parentItem)
            {
                try
                {
                    // Get a listing of files and directories in the specified directory
                    foreach (var item in client.GetListing(parentItem.FullName))
                    {
                        TreeNode node = new TreeNode(item.Name)
                        {
                            Tag = item
                        };
                        parentNode.Nodes.Add(node);

                        if (item.Type == FtpObjectType.Directory)
                        {
                            AddDummyNode(node); // Add dummy node to indicate expandable directories
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
