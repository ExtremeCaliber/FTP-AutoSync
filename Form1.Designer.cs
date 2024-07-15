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
            btnBrowseLocal = new Button();
            cmbLocal = new ComboBox();
            btnConnect = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // InHostIP
            // 
            InHostIP.Location = new Point(36, 152);
            InHostIP.Name = "InHostIP";
            InHostIP.Size = new Size(119, 23);
            InHostIP.TabIndex = 0;
            InHostIP.TextChanged += InHostIP_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(189, 134);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(310, 134);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // InUser
            // 
            InUser.Location = new Point(162, 152);
            InUser.Name = "InUser";
            InUser.Size = new Size(119, 23);
            InUser.TabIndex = 2;
            InUser.TextChanged += InUser_TextChanged;
            // 
            // lblHostIP
            // 
            lblHostIP.AutoSize = true;
            lblHostIP.Location = new Point(71, 134);
            lblHostIP.Name = "lblHostIP";
            lblHostIP.Size = new Size(45, 15);
            lblHostIP.TabIndex = 5;
            lblHostIP.Text = "Host IP";
            // 
            // InPass
            // 
            InPass.Location = new Point(287, 152);
            InPass.Name = "InPass";
            InPass.Size = new Size(119, 23);
            InPass.TabIndex = 4;
            InPass.TextChanged += InPass_TextChanged;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(457, 134);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(29, 15);
            lblPort.TabIndex = 7;
            lblPort.Text = "Port";
            // 
            // InPort
            // 
            InPort.Location = new Point(412, 152);
            InPort.Name = "InPort";
            InPort.Size = new Size(119, 23);
            InPort.TabIndex = 6;
            InPort.TextChanged += InPort_TextChanged;
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Location = new Point(89, 220);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(42, 15);
            lblTarget.TabIndex = 8;
            lblTarget.Text = "Target:";
            // 
            // lblLocal
            // 
            lblLocal.AutoSize = true;
            lblLocal.Location = new Point(89, 257);
            lblLocal.Name = "lblLocal";
            lblLocal.Size = new Size(38, 15);
            lblLocal.TabIndex = 9;
            lblLocal.Text = "Local:";
            // 
            // btnSync
            // 
            btnSync.Location = new Point(175, 331);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(75, 23);
            btnSync.TabIndex = 10;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            // 
            // btnAutoSync
            // 
            btnAutoSync.Location = new Point(387, 331);
            btnAutoSync.Name = "btnAutoSync";
            btnAutoSync.Size = new Size(75, 23);
            btnAutoSync.TabIndex = 11;
            btnAutoSync.Text = "AutoSync";
            btnAutoSync.UseVisualStyleBackColor = true;
            // 
            // cmbSyncSelect
            // 
            cmbSyncSelect.FormattingEnabled = true;
            cmbSyncSelect.Location = new Point(249, 302);
            cmbSyncSelect.Name = "cmbSyncSelect";
            cmbSyncSelect.Size = new Size(134, 23);
            cmbSyncSelect.TabIndex = 12;
            // 
            // txtOutput
            // 
            txtOutput.FormattingEnabled = true;
            txtOutput.ItemHeight = 15;
            txtOutput.Location = new Point(106, 360);
            txtOutput.MultiColumn = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(423, 94);
            txtOutput.TabIndex = 13;
            txtOutput.SelectedIndexChanged += TxtOutput_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(106, 460);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(423, 23);
            progressBar1.TabIndex = 14;
            // 
            // btnBrowseLocal
            // 
            btnBrowseLocal.Location = new Point(478, 254);
            btnBrowseLocal.Name = "btnBrowseLocal";
            btnBrowseLocal.Size = new Size(75, 23);
            btnBrowseLocal.TabIndex = 15;
            btnBrowseLocal.Text = "Browse";
            btnBrowseLocal.UseVisualStyleBackColor = true;
            btnBrowseLocal.Click += BtnBrowseLocal_Click;
            // 
            // cmbLocal
            // 
            cmbLocal.FormattingEnabled = true;
            cmbLocal.Location = new Point(148, 254);
            cmbLocal.Name = "cmbLocal";
            cmbLocal.Size = new Size(324, 23);
            cmbLocal.TabIndex = 16;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(537, 152);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 17;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += BtnConnect_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(324, 23);
            comboBox1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(478, 216);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CSULOGO;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 507);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(btnConnect);
            Controls.Add(cmbLocal);
            Controls.Add(btnBrowseLocal);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnBrowseLocal;
        private ComboBox cmbLocal;
        private Button btnConnect;
        private ComboBox comboBox1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
