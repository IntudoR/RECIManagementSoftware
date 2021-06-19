
namespace RECIManagementSoftware
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_Login = new System.Windows.Forms.Panel();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.checkBox_isRemoteServer = new System.Windows.Forms.CheckBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_ServerName = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_InocorrectStatus = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_ServerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.label_SignInTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Login.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.panel_Upper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_Login.Controls.Add(this.checkBox_ShowPassword);
            this.panel_Login.Controls.Add(this.checkBox_isRemoteServer);
            this.panel_Login.Controls.Add(this.textBox_Password);
            this.panel_Login.Controls.Add(this.textBox_ServerName);
            this.panel_Login.Controls.Add(this.textBox_Username);
            this.panel_Login.Controls.Add(this.panel_Bottom);
            this.panel_Login.Controls.Add(this.label_InocorrectStatus);
            this.panel_Login.Controls.Add(this.label_Password);
            this.panel_Login.Controls.Add(this.label_ServerName);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Controls.Add(this.panel_Upper);
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(375, 316);
            this.panel_Login.TabIndex = 0;
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Font = new System.Drawing.Font("Clear Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(61, 193);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(110, 21);
            this.checkBox_ShowPassword.TabIndex = 4;
            this.checkBox_ShowPassword.Text = "show password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            this.checkBox_ShowPassword.Click += new System.EventHandler(this.checkBox_isRemoteServer_Click);
            // 
            // checkBox_isRemoteServer
            // 
            this.checkBox_isRemoteServer.AutoSize = true;
            this.checkBox_isRemoteServer.Font = new System.Drawing.Font("Clear Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_isRemoteServer.Location = new System.Drawing.Point(217, 193);
            this.checkBox_isRemoteServer.Name = "checkBox_isRemoteServer";
            this.checkBox_isRemoteServer.Size = new System.Drawing.Size(102, 21);
            this.checkBox_isRemoteServer.TabIndex = 4;
            this.checkBox_isRemoteServer.Text = "remote server";
            this.checkBox_isRemoteServer.UseVisualStyleBackColor = true;
            this.checkBox_isRemoteServer.Click += new System.EventHandler(this.checkBox_isRemoteServer_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password.Location = new System.Drawing.Point(168, 163);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(151, 24);
            this.textBox_Password.TabIndex = 3;
            // 
            // textBox_ServerName
            // 
            this.textBox_ServerName.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ServerName.Location = new System.Drawing.Point(168, 103);
            this.textBox_ServerName.Name = "textBox_ServerName";
            this.textBox_ServerName.Size = new System.Drawing.Size(151, 24);
            this.textBox_ServerName.TabIndex = 3;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Username.Location = new System.Drawing.Point(168, 133);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(151, 24);
            this.textBox_Username.TabIndex = 3;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_Bottom.Controls.Add(this.button_Login);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 262);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(375, 54);
            this.panel_Bottom.TabIndex = 2;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.MintCream;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("Clear Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Login.Location = new System.Drawing.Point(264, 9);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(99, 33);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_InocorrectStatus
            // 
            this.label_InocorrectStatus.AutoSize = true;
            this.label_InocorrectStatus.Font = new System.Drawing.Font("Clear Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_InocorrectStatus.ForeColor = System.Drawing.Color.Crimson;
            this.label_InocorrectStatus.Location = new System.Drawing.Point(86, 228);
            this.label_InocorrectStatus.Name = "label_InocorrectStatus";
            this.label_InocorrectStatus.Size = new System.Drawing.Size(205, 18);
            this.label_InocorrectStatus.TabIndex = 1;
            this.label_InocorrectStatus.Text = "Inocorrect username or password";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Clear Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Password.Location = new System.Drawing.Point(61, 163);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(67, 18);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // label_ServerName
            // 
            this.label_ServerName.AutoSize = true;
            this.label_ServerName.Font = new System.Drawing.Font("Clear Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ServerName.Location = new System.Drawing.Point(61, 103);
            this.label_ServerName.Name = "label_ServerName";
            this.label_ServerName.Size = new System.Drawing.Size(86, 18);
            this.label_ServerName.TabIndex = 1;
            this.label_ServerName.Text = "Server name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clear Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // panel_Upper
            // 
            this.panel_Upper.BackColor = System.Drawing.Color.GhostWhite;
            this.panel_Upper.BackgroundImage = global::RECIManagementSoftware.Properties.Resources.RECI_Background3;
            this.panel_Upper.Controls.Add(this.label_SignInTitle);
            this.panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Upper.Location = new System.Drawing.Point(0, 0);
            this.panel_Upper.Name = "panel_Upper";
            this.panel_Upper.Size = new System.Drawing.Size(375, 69);
            this.panel_Upper.TabIndex = 0;
            // 
            // label_SignInTitle
            // 
            this.label_SignInTitle.AutoSize = true;
            this.label_SignInTitle.BackColor = System.Drawing.Color.Transparent;
            this.label_SignInTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_SignInTitle.Font = new System.Drawing.Font("Fog Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SignInTitle.ForeColor = System.Drawing.Color.LightCyan;
            this.label_SignInTitle.Location = new System.Drawing.Point(0, 0);
            this.label_SignInTitle.Name = "label_SignInTitle";
            this.label_SignInTitle.Size = new System.Drawing.Size(136, 65);
            this.label_SignInTitle.TabIndex = 0;
            this.label_SignInTitle.Text = "RECI";
            this.label_SignInTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 316);
            this.Controls.Add(this.panel_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Upper.ResumeLayout(false);
            this.panel_Upper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Panel panel_Upper;
        private System.Windows.Forms.Label label_SignInTitle;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_InocorrectStatus;
        private System.Windows.Forms.Label label_Password;
        public System.Windows.Forms.TextBox textBox_ServerName;
        private System.Windows.Forms.Label label_ServerName;
        private System.Windows.Forms.CheckBox checkBox_isRemoteServer;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private System.Windows.Forms.Timer timer1;
    }
}