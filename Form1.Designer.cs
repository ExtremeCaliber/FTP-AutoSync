namespace FTP_AutoSync
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InHostIP = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            InUser = new TextBox();
            lblHostIP = new Label();
            InPass = new TextBox();
            lblPort = new Label();
            InPort = new TextBox();
            lblTarget = new Label();
            lblLocal = new Label();
            btnSync = new Button();
            btnAutoSync = new Button();
            cmbSyncSelect = new ComboBox();
            txtOutput = new ListBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // InHostIP
            // 
            InHostIP.Location = new Point(57, 109);
            InHostIP.Name = "InHostIP";
            InHostIP.Size = new Size(119, 23);
            InHostIP.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(220, 91);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(364, 91);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // InUser
            // 
            InUser.Location = new Point(194, 109);
            InUser.Name = "InUser";
            InUser.Size = new Size(119, 23);
            InUser.TabIndex = 2;
            // 
            // lblHostIP
            // 
            lblHostIP.AutoSize = true;
            lblHostIP.Location = new Point(96, 91);
            lblHostIP.Name = "lblHostIP";
            lblHostIP.Size = new Size(45, 15);
            lblHostIP.TabIndex = 5;
            lblHostIP.Text = "Host IP";
            // 
            // InPass
            // 
            InPass.Location = new Point(334, 109);
            InPass.Name = "InPass";
            InPass.Size = new Size(119, 23);
            InPass.TabIndex = 4;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(509, 91);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(29, 15);
            lblPort.TabIndex = 7;
            lblPort.Text = "Port";
            // 
            // InPort
            // 
            InPort.Location = new Point(470, 109);
            InPort.Name = "InPort";
            InPort.Size = new Size(119, 23);
            InPort.TabIndex = 6;
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(85, 180);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(42, 15);
            lblTarget.TabIndex = 8;
            lblTarget.Text = "Target:";
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(85, 228);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(38, 15);
            lblLocal.TabIndex = 9;
            lblLocal.Text = "Local:";
            // 
            // btnSync
            // 
            btnSync.Location = new Point(175, 313);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(75, 23);
            btnSync.TabIndex = 10;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            // 
            // btnAutoSync
            // 
            btnAutoSync.Location = new Point(378, 313);
            btnAutoSync.Name = "btnAutoSync";
            btnAutoSync.Size = new Size(75, 23);
            btnAutoSync.TabIndex = 11;
            btnAutoSync.Text = "AutoSync";
            btnAutoSync.UseVisualStyleBackColor = true;
            // 
            // cmbSyncSelect
            // 
            cmbSyncSelect.FormattingEnabled = true;
            cmbSyncSelect.Location = new Point(247, 274);
            cmbSyncSelect.Name = "cmbSyncSelect";
            cmbSyncSelect.Size = new Size(121, 23);
            cmbSyncSelect.TabIndex = 12;
            // 
            // txtOutput
            // 
            txtOutput.FormattingEnabled = true;
            txtOutput.ItemHeight = 15;
            txtOutput.Location = new Point(106, 351);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(423, 94);
            txtOutput.TabIndex = 13;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(106, 460);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(423, 23);
            progressBar1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 507);
            Controls.Add(progressBar1);
            Controls.Add(txtOutput);
            Controls.Add(cmbSyncSelect);
            Controls.Add(btnAutoSync);
            Controls.Add(btnSync);
            Controls.Add(lblLocal);
            Controls.Add(lblTarget);
            Controls.Add(lblPort);
            Controls.Add(InPort);
            Controls.Add(lblHostIP);
            Controls.Add(InPass);
            Controls.Add(lblPassword);
            Controls.Add(InUser);
            Controls.Add(lblUsername);
            Controls.Add(InHostIP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InHostIP;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox InUser;
        private Label lblHostIP;
        private TextBox InPass;
        private Label lblPort;
        private TextBox InPort;
        private Label lblTarget;
        private Label lblLocal;
        private Button btnSync;
        private Button btnAutoSync;
        private ComboBox cmbSyncSelect;
        private ListBox txtOutput;
        private ProgressBar progressBar1;
    }
}
