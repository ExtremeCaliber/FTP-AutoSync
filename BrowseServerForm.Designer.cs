namespace FTP_AutoSync
{
    partial class BrowseServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView = new TreeView();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Location = new Point(12, 88);
            treeView.Name = "treeView";
            treeView.Size = new Size(306, 240);
            treeView.TabIndex = 0;
            treeView.BeforeExpand += new TreeViewCancelEventHandler(treeView_BeforeExpand);
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(252, 350);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Select Path";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += this.btnSelect_Click;
            // 
            // BrowseServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(treeView);
            Name = "BrowseServerForm";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private Button btnSelect;
    }
}