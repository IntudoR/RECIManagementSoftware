
namespace RECIManagementSoftware
{
    partial class FormSubscription
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelContracts = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.SubscriptionGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelContractOutput = new System.Windows.Forms.Label();
            this.buttonContractDelete = new System.Windows.Forms.Button();
            this.buttonContractEdit = new System.Windows.Forms.Button();
            this.buttonContractAdd = new System.Windows.Forms.Button();
            this.labelSubscriptionExpires = new System.Windows.Forms.Label();
            this.labelSubscriptionPayment = new System.Windows.Forms.Label();
            this.labelSubscriptiontAccountID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxContractMonthlyPayment = new System.Windows.Forms.TextBox();
            this.textBoxContractOrderID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionGridView)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.labelContracts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 63);
            this.panel1.TabIndex = 0;
            // 
            // labelContracts
            // 
            this.labelContracts.AutoSize = true;
            this.labelContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContracts.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.labelContracts.Location = new System.Drawing.Point(0, 0);
            this.labelContracts.Name = "labelContracts";
            this.labelContracts.Size = new System.Drawing.Size(374, 50);
            this.labelContracts.TabIndex = 0;
            this.labelContracts.Text = "Manage Subscribers";
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
            this.panel3.Controls.Add(this.SubscriptionGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 537);
            this.panel3.TabIndex = 2;
            // 
            // AccountGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.AccountGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccountGridView.Location = new System.Drawing.Point(0, 87);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.RowTemplate.Height = 25;
            this.AccountGridView.Size = new System.Drawing.Size(692, 450);
            this.AccountGridView.TabIndex = 1;
            // 
            // SubscriptionGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubscriptionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.SubscriptionGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubscriptionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SubscriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubscriptionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscriptionGridView.Location = new System.Drawing.Point(0, 0);
            this.SubscriptionGridView.Name = "SubscriptionGridView";
            this.SubscriptionGridView.RowTemplate.Height = 25;
            this.SubscriptionGridView.Size = new System.Drawing.Size(692, 537);
            this.SubscriptionGridView.TabIndex = 0;
            this.SubscriptionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelContractOutput);
            this.panelAccountControls.Controls.Add(this.buttonContractDelete);
            this.panelAccountControls.Controls.Add(this.buttonContractEdit);
            this.panelAccountControls.Controls.Add(this.buttonContractAdd);
            this.panelAccountControls.Controls.Add(this.labelSubscriptionExpires);
            this.panelAccountControls.Controls.Add(this.labelSubscriptionPayment);
            this.panelAccountControls.Controls.Add(this.labelSubscriptiontAccountID);
            this.panelAccountControls.Controls.Add(this.textBox1);
            this.panelAccountControls.Controls.Add(this.textBoxContractMonthlyPayment);
            this.panelAccountControls.Controls.Add(this.textBoxContractOrderID);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 0);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(327, 537);
            this.panelAccountControls.TabIndex = 1;
            // 
            // labelContractOutput
            // 
            this.labelContractOutput.AutoSize = true;
            this.labelContractOutput.Font = new System.Drawing.Font("Clear Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractOutput.Location = new System.Drawing.Point(13, 7);
            this.labelContractOutput.Name = "labelContractOutput";
            this.labelContractOutput.Size = new System.Drawing.Size(50, 18);
            this.labelContractOutput.TabIndex = 3;
            this.labelContractOutput.Text = "label1";
            this.labelContractOutput.Visible = false;
            // 
            // buttonContractDelete
            // 
            this.buttonContractDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonContractDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonContractDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContractDelete.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonContractDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonContractDelete.Location = new System.Drawing.Point(234, 142);
            this.buttonContractDelete.Name = "buttonContractDelete";
            this.buttonContractDelete.Size = new System.Drawing.Size(87, 40);
            this.buttonContractDelete.TabIndex = 2;
            this.buttonContractDelete.Text = "Delete";
            this.buttonContractDelete.UseVisualStyleBackColor = false;
            this.buttonContractDelete.Click += new System.EventHandler(this.buttonAccountDelete_Click);
            // 
            // buttonContractEdit
            // 
            this.buttonContractEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonContractEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonContractEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContractEdit.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonContractEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonContractEdit.Location = new System.Drawing.Point(141, 142);
            this.buttonContractEdit.Name = "buttonContractEdit";
            this.buttonContractEdit.Size = new System.Drawing.Size(87, 40);
            this.buttonContractEdit.TabIndex = 2;
            this.buttonContractEdit.Text = "Edit";
            this.buttonContractEdit.UseVisualStyleBackColor = false;
            this.buttonContractEdit.Click += new System.EventHandler(this.buttonAccountEdit_Click);
            // 
            // buttonContractAdd
            // 
            this.buttonContractAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonContractAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonContractAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContractAdd.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonContractAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonContractAdd.Location = new System.Drawing.Point(48, 142);
            this.buttonContractAdd.Name = "buttonContractAdd";
            this.buttonContractAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonContractAdd.TabIndex = 2;
            this.buttonContractAdd.Text = "Add";
            this.buttonContractAdd.UseVisualStyleBackColor = false;
            this.buttonContractAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelSubscriptionExpires
            // 
            this.labelSubscriptionExpires.AutoSize = true;
            this.labelSubscriptionExpires.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubscriptionExpires.Location = new System.Drawing.Point(12, 107);
            this.labelSubscriptionExpires.Name = "labelSubscriptionExpires";
            this.labelSubscriptionExpires.Size = new System.Drawing.Size(70, 22);
            this.labelSubscriptionExpires.TabIndex = 1;
            this.labelSubscriptionExpires.Text = "Expires:";
            // 
            // labelSubscriptionPayment
            // 
            this.labelSubscriptionPayment.AutoSize = true;
            this.labelSubscriptionPayment.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubscriptionPayment.Location = new System.Drawing.Point(12, 72);
            this.labelSubscriptionPayment.Name = "labelSubscriptionPayment";
            this.labelSubscriptionPayment.Size = new System.Drawing.Size(81, 22);
            this.labelSubscriptionPayment.TabIndex = 1;
            this.labelSubscriptionPayment.Text = "Payment:";
            // 
            // labelSubscriptiontAccountID
            // 
            this.labelSubscriptiontAccountID.AutoSize = true;
            this.labelSubscriptiontAccountID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubscriptiontAccountID.Location = new System.Drawing.Point(12, 37);
            this.labelSubscriptiontAccountID.Name = "labelSubscriptiontAccountID";
            this.labelSubscriptiontAccountID.Size = new System.Drawing.Size(93, 22);
            this.labelSubscriptiontAccountID.TabIndex = 1;
            this.labelSubscriptiontAccountID.Text = "AccountID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(134, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 29);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxContractMonthlyPayment
            // 
            this.textBoxContractMonthlyPayment.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractMonthlyPayment.Location = new System.Drawing.Point(134, 72);
            this.textBoxContractMonthlyPayment.Name = "textBoxContractMonthlyPayment";
            this.textBoxContractMonthlyPayment.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractMonthlyPayment.TabIndex = 0;
            // 
            // textBoxContractOrderID
            // 
            this.textBoxContractOrderID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractOrderID.Location = new System.Drawing.Point(134, 37);
            this.textBoxContractOrderID.Name = "textBoxContractOrderID";
            this.textBoxContractOrderID.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractOrderID.TabIndex = 0;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSubscription";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelContracts;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView SubscriptionGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxContractOrderID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSubscriptiontAccountID;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelSubscriptionPayment;
        private System.Windows.Forms.TextBox textBoxContractMonthlyPayment;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Button buttonContractEdit;
        private System.Windows.Forms.Button buttonContractAdd;
        private System.Windows.Forms.Button buttonContractDelete;
        private System.Windows.Forms.Label labelContractOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.Label labelSubscriptionExpires;
        private System.Windows.Forms.TextBox textBox1;
    }
}