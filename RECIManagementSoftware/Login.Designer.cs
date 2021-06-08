
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
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_SignInTitle = new System.Windows.Forms.Label();
            this.panel_Login.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_Login.Controls.Add(this.panel1);
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Login.Location = new System.Drawing.Point(0, 0);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(375, 366);
            this.panel_Login.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.label_SignInTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 67);
            this.panel1.TabIndex = 0;
            // 
            // label_SignInTitle
            // 
            this.label_SignInTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_SignInTitle.AutoSize = true;
            this.label_SignInTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SignInTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_SignInTitle.Location = new System.Drawing.Point(134, 9);
            this.label_SignInTitle.Name = "label_SignInTitle";
            this.label_SignInTitle.Size = new System.Drawing.Size(88, 45);
            this.label_SignInTitle.TabIndex = 0;
            this.label_SignInTitle.Text = "RECI";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 366);
            this.Controls.Add(this.panel_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.panel_Login.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_SignInTitle;
    }
}