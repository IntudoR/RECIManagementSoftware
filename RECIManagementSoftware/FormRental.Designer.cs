
namespace RECIManagementSoftware
{
    partial class FormRental
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelContracts = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRentalClient = new System.Windows.Forms.TabPage();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.tabPageContractProperty = new System.Windows.Forms.TabPage();
            this.PropertyGridView = new System.Windows.Forms.DataGridView();
            this.tabPageContractCounterparty = new System.Windows.Forms.TabPage();
            this.CounterpartyGridView = new System.Windows.Forms.DataGridView();
            this.RentalGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelContractOutput = new System.Windows.Forms.Label();
            this.buttonContractDelete = new System.Windows.Forms.Button();
            this.buttonContractEdit = new System.Windows.Forms.Button();
            this.buttonContractAdd = new System.Windows.Forms.Button();
            this.labelContractMonthlyPayment = new System.Windows.Forms.Label();
            this.labelContractOrderID = new System.Windows.Forms.Label();
            this.textBoxContractMonthlyPayment = new System.Windows.Forms.TextBox();
            this.textBoxContractOrderID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRentalClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            this.tabPageContractProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).BeginInit();
            this.tabPageContractCounterparty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGridView)).BeginInit();
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
            this.labelContracts.Size = new System.Drawing.Size(297, 50);
            this.labelContracts.TabIndex = 0;
            this.labelContracts.Text = "Manage Rentals";
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
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.RentalGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 537);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRentalClient);
            this.tabControl1.Controls.Add(this.tabPageContractProperty);
            this.tabControl1.Controls.Add(this.tabPageContractCounterparty);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Clear Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 455);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageRentalClient
            // 
            this.tabPageRentalClient.Controls.Add(this.ClientGridView);
            this.tabPageRentalClient.Location = new System.Drawing.Point(4, 30);
            this.tabPageRentalClient.Name = "tabPageRentalClient";
            this.tabPageRentalClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRentalClient.Size = new System.Drawing.Size(684, 421);
            this.tabPageRentalClient.TabIndex = 0;
            this.tabPageRentalClient.Text = "Client";
            this.tabPageRentalClient.UseVisualStyleBackColor = true;
            // 
            // ClientGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientGridView.Location = new System.Drawing.Point(3, 3);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.RowTemplate.Height = 25;
            this.ClientGridView.Size = new System.Drawing.Size(678, 415);
            this.ClientGridView.TabIndex = 1;
            // 
            // tabPageContractProperty
            // 
            this.tabPageContractProperty.Controls.Add(this.PropertyGridView);
            this.tabPageContractProperty.Location = new System.Drawing.Point(4, 30);
            this.tabPageContractProperty.Name = "tabPageContractProperty";
            this.tabPageContractProperty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContractProperty.Size = new System.Drawing.Size(684, 421);
            this.tabPageContractProperty.TabIndex = 2;
            this.tabPageContractProperty.Text = "Property";
            this.tabPageContractProperty.UseVisualStyleBackColor = true;
            // 
            // PropertyGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropertyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.PropertyGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PropertyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PropertyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGridView.Location = new System.Drawing.Point(3, 3);
            this.PropertyGridView.Name = "PropertyGridView";
            this.PropertyGridView.RowTemplate.Height = 25;
            this.PropertyGridView.Size = new System.Drawing.Size(678, 415);
            this.PropertyGridView.TabIndex = 1;
            // 
            // tabPageContractCounterparty
            // 
            this.tabPageContractCounterparty.Controls.Add(this.CounterpartyGridView);
            this.tabPageContractCounterparty.Location = new System.Drawing.Point(4, 30);
            this.tabPageContractCounterparty.Name = "tabPageContractCounterparty";
            this.tabPageContractCounterparty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContractCounterparty.Size = new System.Drawing.Size(684, 421);
            this.tabPageContractCounterparty.TabIndex = 3;
            this.tabPageContractCounterparty.Text = "Counterparty";
            this.tabPageContractCounterparty.UseVisualStyleBackColor = true;
            // 
            // CounterpartyGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CounterpartyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.CounterpartyGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CounterpartyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CounterpartyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounterpartyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CounterpartyGridView.Location = new System.Drawing.Point(3, 3);
            this.CounterpartyGridView.Name = "CounterpartyGridView";
            this.CounterpartyGridView.RowTemplate.Height = 25;
            this.CounterpartyGridView.Size = new System.Drawing.Size(678, 415);
            this.CounterpartyGridView.TabIndex = 1;
            // 
            // RentalGridView
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentalGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.RentalGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RentalGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.RentalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalGridView.Location = new System.Drawing.Point(0, 0);
            this.RentalGridView.Name = "RentalGridView";
            this.RentalGridView.RowTemplate.Height = 25;
            this.RentalGridView.Size = new System.Drawing.Size(692, 537);
            this.RentalGridView.TabIndex = 0;
            this.RentalGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelContractOutput);
            this.panelAccountControls.Controls.Add(this.buttonContractDelete);
            this.panelAccountControls.Controls.Add(this.buttonContractEdit);
            this.panelAccountControls.Controls.Add(this.buttonContractAdd);
            this.panelAccountControls.Controls.Add(this.labelContractMonthlyPayment);
            this.panelAccountControls.Controls.Add(this.labelContractOrderID);
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
            this.buttonContractDelete.Location = new System.Drawing.Point(234, 115);
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
            this.buttonContractEdit.Location = new System.Drawing.Point(141, 115);
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
            this.buttonContractAdd.Location = new System.Drawing.Point(48, 115);
            this.buttonContractAdd.Name = "buttonContractAdd";
            this.buttonContractAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonContractAdd.TabIndex = 2;
            this.buttonContractAdd.Text = "Add";
            this.buttonContractAdd.UseVisualStyleBackColor = false;
            this.buttonContractAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelContractMonthlyPayment
            // 
            this.labelContractMonthlyPayment.AutoSize = true;
            this.labelContractMonthlyPayment.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractMonthlyPayment.Location = new System.Drawing.Point(12, 72);
            this.labelContractMonthlyPayment.Name = "labelContractMonthlyPayment";
            this.labelContractMonthlyPayment.Size = new System.Drawing.Size(75, 22);
            this.labelContractMonthlyPayment.TabIndex = 1;
            this.labelContractMonthlyPayment.Text = "ClientID:";
            // 
            // labelContractOrderID
            // 
            this.labelContractOrderID.AutoSize = true;
            this.labelContractOrderID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractOrderID.Location = new System.Drawing.Point(12, 37);
            this.labelContractOrderID.Name = "labelContractOrderID";
            this.labelContractOrderID.Size = new System.Drawing.Size(98, 22);
            this.labelContractOrderID.TabIndex = 1;
            this.labelContractOrderID.Text = "PropertyID:";
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
            // FormRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRental";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRentalClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            this.tabPageContractProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).EndInit();
            this.tabPageContractCounterparty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelContracts;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView RentalGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxContractOrderID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelContractOrderID;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelContractMonthlyPayment;
        private System.Windows.Forms.TextBox textBoxContractMonthlyPayment;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Button buttonContractEdit;
        private System.Windows.Forms.Button buttonContractAdd;
        private System.Windows.Forms.Button buttonContractDelete;
        private System.Windows.Forms.Label labelContractOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRentalClient;
        private System.Windows.Forms.DataGridView ClientGridView;
        private System.Windows.Forms.TabPage tabPageContractProperty;
        private System.Windows.Forms.DataGridView PropertyGridView;
        private System.Windows.Forms.TabPage tabPageContractCounterparty;
        private System.Windows.Forms.DataGridView CounterpartyGridView;
    }
}