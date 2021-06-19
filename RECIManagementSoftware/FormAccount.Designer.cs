
namespace RECIManagementSoftware
{
    partial class FormAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccount = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.buttonAccountDelete = new System.Windows.Forms.Button();
            this.buttonAccountEdit = new System.Windows.Forms.Button();
            this.buttonAccountAdd = new System.Windows.Forms.Button();
            this.labelAccountStatus = new System.Windows.Forms.Label();
            this.labelAccountPassword = new System.Windows.Forms.Label();
            this.labelAccountEmail = new System.Windows.Forms.Label();
            this.labelAccountMobile = new System.Windows.Forms.Label();
            this.labelAccountBalance = new System.Windows.Forms.Label();
            this.labelRegisterTime = new System.Windows.Forms.Label();
            this.labelAccountUsername = new System.Windows.Forms.Label();
            this.textBoxAccountStatus = new System.Windows.Forms.TextBox();
            this.textBoxAccountPassword = new System.Windows.Forms.TextBox();
            this.textBoxAccountEmail = new System.Windows.Forms.TextBox();
            this.textBoxAccountMobile = new System.Windows.Forms.TextBox();
            this.textBoxAccountBalance = new System.Windows.Forms.TextBox();
            this.textBoxAccountRegisterTime = new System.Windows.Forms.TextBox();
            this.textBoxAccountUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.labelAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 63);
            this.panel1.TabIndex = 0;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAccount.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.labelAccount.Location = new System.Drawing.Point(0, 0);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(327, 50);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "Manage Accounts";
            // 
            // panelAccountControl
            // 
            this.panelAccountControl.Controls.Add(this.panel3);
            this.panelAccountControl.Controls.Add(this.panelAccountControls);
            this.panelAccountControl.Controls.Add(this.panel2);
            this.panelAccountControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccountControl.Location = new System.Drawing.Point(0, 63);
            this.panelAccountControl.Name = "panelAccountControl";
            this.panelAccountControl.Size = new System.Drawing.Size(1019, 562);
            this.panelAccountControl.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AccountGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 537);
            this.panel3.TabIndex = 2;
            // 
            // AccountGridView
            // 
            this.AccountGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountGridView.Location = new System.Drawing.Point(0, 0);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.RowTemplate.Height = 25;
            this.AccountGridView.Size = new System.Drawing.Size(692, 537);
            this.AccountGridView.TabIndex = 0;
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.Controls.Add(this.buttonAccountDelete);
            this.panelAccountControls.Controls.Add(this.buttonAccountEdit);
            this.panelAccountControls.Controls.Add(this.buttonAccountAdd);
            this.panelAccountControls.Controls.Add(this.labelAccountStatus);
            this.panelAccountControls.Controls.Add(this.labelAccountPassword);
            this.panelAccountControls.Controls.Add(this.labelAccountEmail);
            this.panelAccountControls.Controls.Add(this.labelAccountMobile);
            this.panelAccountControls.Controls.Add(this.labelAccountBalance);
            this.panelAccountControls.Controls.Add(this.labelRegisterTime);
            this.panelAccountControls.Controls.Add(this.labelAccountUsername);
            this.panelAccountControls.Controls.Add(this.textBoxAccountStatus);
            this.panelAccountControls.Controls.Add(this.textBoxAccountPassword);
            this.panelAccountControls.Controls.Add(this.textBoxAccountEmail);
            this.panelAccountControls.Controls.Add(this.textBoxAccountMobile);
            this.panelAccountControls.Controls.Add(this.textBoxAccountBalance);
            this.panelAccountControls.Controls.Add(this.textBoxAccountRegisterTime);
            this.panelAccountControls.Controls.Add(this.textBoxAccountUsername);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 0);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(327, 537);
            this.panelAccountControls.TabIndex = 1;
            // 
            // buttonAccountDelete
            // 
            this.buttonAccountDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAccountDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountDelete.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccountDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonAccountDelete.Location = new System.Drawing.Point(234, 282);
            this.buttonAccountDelete.Name = "buttonAccountDelete";
            this.buttonAccountDelete.Size = new System.Drawing.Size(87, 40);
            this.buttonAccountDelete.TabIndex = 2;
            this.buttonAccountDelete.Text = "Delete";
            this.buttonAccountDelete.UseVisualStyleBackColor = false;
            // 
            // buttonAccountEdit
            // 
            this.buttonAccountEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAccountEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountEdit.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccountEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonAccountEdit.Location = new System.Drawing.Point(141, 282);
            this.buttonAccountEdit.Name = "buttonAccountEdit";
            this.buttonAccountEdit.Size = new System.Drawing.Size(87, 40);
            this.buttonAccountEdit.TabIndex = 2;
            this.buttonAccountEdit.Text = "Edit";
            this.buttonAccountEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAccountAdd
            // 
            this.buttonAccountAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAccountAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountAdd.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAccountAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonAccountAdd.Location = new System.Drawing.Point(48, 282);
            this.buttonAccountAdd.Name = "buttonAccountAdd";
            this.buttonAccountAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonAccountAdd.TabIndex = 2;
            this.buttonAccountAdd.Text = "Add";
            this.buttonAccountAdd.UseVisualStyleBackColor = false;
            this.buttonAccountAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelAccountStatus
            // 
            this.labelAccountStatus.AutoSize = true;
            this.labelAccountStatus.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountStatus.Location = new System.Drawing.Point(12, 107);
            this.labelAccountStatus.Name = "labelAccountStatus";
            this.labelAccountStatus.Size = new System.Drawing.Size(64, 22);
            this.labelAccountStatus.TabIndex = 1;
            this.labelAccountStatus.Text = "Status:";
            // 
            // labelAccountPassword
            // 
            this.labelAccountPassword.AutoSize = true;
            this.labelAccountPassword.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountPassword.Location = new System.Drawing.Point(12, 72);
            this.labelAccountPassword.Name = "labelAccountPassword";
            this.labelAccountPassword.Size = new System.Drawing.Size(88, 22);
            this.labelAccountPassword.TabIndex = 1;
            this.labelAccountPassword.Text = "Password:";
            // 
            // labelAccountEmail
            // 
            this.labelAccountEmail.AutoSize = true;
            this.labelAccountEmail.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountEmail.Location = new System.Drawing.Point(12, 247);
            this.labelAccountEmail.Name = "labelAccountEmail";
            this.labelAccountEmail.Size = new System.Drawing.Size(55, 22);
            this.labelAccountEmail.TabIndex = 1;
            this.labelAccountEmail.Text = "Email:";
            // 
            // labelAccountMobile
            // 
            this.labelAccountMobile.AutoSize = true;
            this.labelAccountMobile.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountMobile.Location = new System.Drawing.Point(12, 212);
            this.labelAccountMobile.Name = "labelAccountMobile";
            this.labelAccountMobile.Size = new System.Drawing.Size(64, 22);
            this.labelAccountMobile.TabIndex = 1;
            this.labelAccountMobile.Text = "Mobile:";
            // 
            // labelAccountBalance
            // 
            this.labelAccountBalance.AutoSize = true;
            this.labelAccountBalance.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountBalance.Location = new System.Drawing.Point(12, 177);
            this.labelAccountBalance.Name = "labelAccountBalance";
            this.labelAccountBalance.Size = new System.Drawing.Size(74, 22);
            this.labelAccountBalance.TabIndex = 1;
            this.labelAccountBalance.Text = "Balance:";
            // 
            // labelRegisterTime
            // 
            this.labelRegisterTime.AutoSize = true;
            this.labelRegisterTime.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegisterTime.Location = new System.Drawing.Point(12, 142);
            this.labelRegisterTime.Name = "labelRegisterTime";
            this.labelRegisterTime.Size = new System.Drawing.Size(114, 22);
            this.labelRegisterTime.TabIndex = 1;
            this.labelRegisterTime.Text = "RegisterTime:";
            // 
            // labelAccountUsername
            // 
            this.labelAccountUsername.AutoSize = true;
            this.labelAccountUsername.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountUsername.Location = new System.Drawing.Point(12, 37);
            this.labelAccountUsername.Name = "labelAccountUsername";
            this.labelAccountUsername.Size = new System.Drawing.Size(92, 22);
            this.labelAccountUsername.TabIndex = 1;
            this.labelAccountUsername.Text = "Username:";
            // 
            // textBoxAccountStatus
            // 
            this.textBoxAccountStatus.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccountStatus.Location = new System.Drawing.Point(134, 107);
            this.textBoxAccountStatus.Name = "textBoxAccountStatus";
            this.textBoxAccountStatus.Size = new System.Drawing.Size(187, 29);
            this.textBoxAccountStatus.TabIndex = 0;
            // 
            // textBoxAccountPassword
            // 
            this.textBoxAccountPassword.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccountPassword.Location = new System.Drawing.Point(134, 72);
            this.textBoxAccountPassword.Name = "textBoxAccountPassword";
            this.textBoxAccountPassword.Size = new System.Drawing.Size(187, 29);
            this.textBoxAccountPassword.TabIndex = 0;
            // 
            // textBoxAccountEmail
            // 
            this.textBoxAccountEmail.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccountEmail.Location = new System.Drawing.Point(134, 247);
            this.textBoxAccountEmail.Name = "textBoxAccountEmail";
            this.textBoxAccountEmail.Size = new System.Drawing.Size(187, 29);
            this.textBoxAccountEmail.TabIndex = 0;
            // 
            // textBoxAccountMobile
            // 
            this.textBoxAccountMobile.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccountMobile.Location = new System.Drawing.Point(134, 212);
            this.textBoxAccountMobile.Name = "textBoxAccountMobile";
            this.textBoxAccountMobile.Size = new System.Drawing.Size(187, 29);
            this.textBoxAccountMobile.TabIndex = 0;
            // 
            // textBoxAccountBalance
            // 
            this.textBoxAccountBalance.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccountBalance.Location = new System.Drawing.Point(134, 177);
            this.textBoxAccountBalance.Name = "textBoxAccountBalance";
            this.textBoxAccountBalance.Size = new System.Drawing.Size(187, 29);
            this.textBoxAccountBalance.TabIndex = 0;
            // 
            // textBoxAccountRegisterTime
            // 
            this.textBoxAccountRegisterTime.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccountRegisterTime.Location = new System.Drawing.Point(134, 142);
            this.textBoxAccountRegisterTime.Name = "textBoxAccountRegisterTime";
            this.textBoxAccountRegisterTime.Size = new System.Drawing.Size(187, 29);
            this.textBoxAccountRegisterTime.TabIndex = 0;
            // 
            // textBoxAccountUsername
            // 
            this.textBoxAccountUsername.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAccountUsername.Location = new System.Drawing.Point(134, 37);
            this.textBoxAccountUsername.Name = "textBoxAccountUsername";
            this.textBoxAccountUsername.Size = new System.Drawing.Size(187, 29);
            this.textBoxAccountUsername.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 25);
            this.panel2.TabIndex = 0;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccount";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxAccountUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAccountUsername;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelAccountPassword;
        private System.Windows.Forms.TextBox textBoxAccountPassword;
        private System.Windows.Forms.Label labelAccountStatus;
        private System.Windows.Forms.TextBox textBoxAccountStatus;
        private System.Windows.Forms.Label labelRegisterTime;
        private System.Windows.Forms.TextBox textBoxAccountRegisterTime;
        private System.Windows.Forms.Label labelAccountBalance;
        private System.Windows.Forms.TextBox textBoxAccountBalance;
        private System.Windows.Forms.Label labelAccountEmail;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox textBoxAccountEmail;
        private System.Windows.Forms.TextBox textBoxAccountMobile;
        private System.Windows.Forms.Button buttonAccountEdit;
        private System.Windows.Forms.Button buttonAccountAdd;
        private System.Windows.Forms.Button buttonAccountDelete;
        private System.Windows.Forms.Label labelAccountMobile;
    }
}