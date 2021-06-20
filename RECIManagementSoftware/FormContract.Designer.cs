
namespace RECIManagementSoftware
{
    partial class FormContract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccount = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.tabPageRental = new System.Windows.Forms.TabPage();
            this.RentalGridView = new System.Windows.Forms.DataGridView();
            this.tabPageContractProperty = new System.Windows.Forms.TabPage();
            this.PropertyGridView = new System.Windows.Forms.DataGridView();
            this.tabPageContractClient = new System.Windows.Forms.TabPage();
            this.ClientGridView = new System.Windows.Forms.DataGridView();
            this.ContractGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelContractOutput = new System.Windows.Forms.Label();
            this.buttonContractDelete = new System.Windows.Forms.Button();
            this.buttonContractEdit = new System.Windows.Forms.Button();
            this.buttonContractAdd = new System.Windows.Forms.Button();
            this.labelContractPayment = new System.Windows.Forms.Label();
            this.labelContractRentalID = new System.Windows.Forms.Label();
            this.labelContractExpires = new System.Windows.Forms.Label();
            this.labelContractDate = new System.Windows.Forms.Label();
            this.labelContractPaid = new System.Windows.Forms.Label();
            this.labelContractEmployeeID = new System.Windows.Forms.Label();
            this.textBoxContractPayment = new System.Windows.Forms.TextBox();
            this.textBoxContractRentalID = new System.Windows.Forms.TextBox();
            this.textBoxContractExpires = new System.Windows.Forms.TextBox();
            this.textBoxContractDate = new System.Windows.Forms.TextBox();
            this.textBoxContractPaid = new System.Windows.Forms.TextBox();
            this.textBoxContractEmployeeID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.tabPageRental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGridView)).BeginInit();
            this.tabPageContractProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).BeginInit();
            this.tabPageContractClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractGridView)).BeginInit();
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
            this.labelAccount.Size = new System.Drawing.Size(335, 50);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "Manage Contracts";
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
            this.panel3.Controls.Add(this.ContractGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 537);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageRental);
            this.tabControl1.Controls.Add(this.tabPageContractProperty);
            this.tabControl1.Controls.Add(this.tabPageContractClient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Clear Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 455);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.EmployeeGridView);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 30);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(684, 421);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Employee";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.Location = new System.Drawing.Point(3, 3);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowTemplate.Height = 25;
            this.EmployeeGridView.Size = new System.Drawing.Size(678, 415);
            this.EmployeeGridView.TabIndex = 1;
            // 
            // tabPageRental
            // 
            this.tabPageRental.Controls.Add(this.RentalGridView);
            this.tabPageRental.Location = new System.Drawing.Point(4, 30);
            this.tabPageRental.Name = "tabPageRental";
            this.tabPageRental.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRental.Size = new System.Drawing.Size(684, 421);
            this.tabPageRental.TabIndex = 1;
            this.tabPageRental.Text = "Rental";
            this.tabPageRental.UseVisualStyleBackColor = true;
            // 
            // RentalGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentalGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.RentalGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.RentalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalGridView.Location = new System.Drawing.Point(3, 3);
            this.RentalGridView.Name = "RentalGridView";
            this.RentalGridView.RowTemplate.Height = 25;
            this.RentalGridView.Size = new System.Drawing.Size(678, 415);
            this.RentalGridView.TabIndex = 1;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropertyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PropertyGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PropertyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PropertyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGridView.Location = new System.Drawing.Point(3, 3);
            this.PropertyGridView.Name = "PropertyGridView";
            this.PropertyGridView.RowTemplate.Height = 25;
            this.PropertyGridView.Size = new System.Drawing.Size(678, 415);
            this.PropertyGridView.TabIndex = 1;
            // 
            // tabPageContractClient
            // 
            this.tabPageContractClient.Controls.Add(this.ClientGridView);
            this.tabPageContractClient.Location = new System.Drawing.Point(4, 30);
            this.tabPageContractClient.Name = "tabPageContractClient";
            this.tabPageContractClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContractClient.Size = new System.Drawing.Size(684, 421);
            this.tabPageContractClient.TabIndex = 3;
            this.tabPageContractClient.Text = "Client";
            this.tabPageContractClient.UseVisualStyleBackColor = true;
            // 
            // ClientGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClientGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ClientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientGridView.Location = new System.Drawing.Point(3, 3);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.RowTemplate.Height = 25;
            this.ClientGridView.Size = new System.Drawing.Size(678, 415);
            this.ClientGridView.TabIndex = 1;
            // 
            // ContractGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContractGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ContractGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContractGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ContractGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractGridView.Location = new System.Drawing.Point(0, 0);
            this.ContractGridView.Name = "ContractGridView";
            this.ContractGridView.RowTemplate.Height = 25;
            this.ContractGridView.Size = new System.Drawing.Size(692, 537);
            this.ContractGridView.TabIndex = 0;
            this.ContractGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelContractOutput);
            this.panelAccountControls.Controls.Add(this.buttonContractDelete);
            this.panelAccountControls.Controls.Add(this.buttonContractEdit);
            this.panelAccountControls.Controls.Add(this.buttonContractAdd);
            this.panelAccountControls.Controls.Add(this.labelContractPayment);
            this.panelAccountControls.Controls.Add(this.labelContractRentalID);
            this.panelAccountControls.Controls.Add(this.labelContractExpires);
            this.panelAccountControls.Controls.Add(this.labelContractDate);
            this.panelAccountControls.Controls.Add(this.labelContractPaid);
            this.panelAccountControls.Controls.Add(this.labelContractEmployeeID);
            this.panelAccountControls.Controls.Add(this.textBoxContractPayment);
            this.panelAccountControls.Controls.Add(this.textBoxContractRentalID);
            this.panelAccountControls.Controls.Add(this.textBoxContractExpires);
            this.panelAccountControls.Controls.Add(this.textBoxContractDate);
            this.panelAccountControls.Controls.Add(this.textBoxContractPaid);
            this.panelAccountControls.Controls.Add(this.textBoxContractEmployeeID);
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
            this.buttonContractDelete.Location = new System.Drawing.Point(234, 247);
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
            this.buttonContractEdit.Location = new System.Drawing.Point(141, 247);
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
            this.buttonContractAdd.Location = new System.Drawing.Point(48, 247);
            this.buttonContractAdd.Name = "buttonContractAdd";
            this.buttonContractAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonContractAdd.TabIndex = 2;
            this.buttonContractAdd.Text = "Add";
            this.buttonContractAdd.UseVisualStyleBackColor = false;
            this.buttonContractAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelContractPayment
            // 
            this.labelContractPayment.AutoSize = true;
            this.labelContractPayment.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractPayment.Location = new System.Drawing.Point(12, 107);
            this.labelContractPayment.Name = "labelContractPayment";
            this.labelContractPayment.Size = new System.Drawing.Size(81, 22);
            this.labelContractPayment.TabIndex = 1;
            this.labelContractPayment.Text = "Payment:";
            // 
            // labelContractRentalID
            // 
            this.labelContractRentalID.AutoSize = true;
            this.labelContractRentalID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractRentalID.Location = new System.Drawing.Point(12, 72);
            this.labelContractRentalID.Name = "labelContractRentalID";
            this.labelContractRentalID.Size = new System.Drawing.Size(80, 22);
            this.labelContractRentalID.TabIndex = 1;
            this.labelContractRentalID.Text = "RentalID:";
            // 
            // labelContractExpires
            // 
            this.labelContractExpires.AutoSize = true;
            this.labelContractExpires.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractExpires.Location = new System.Drawing.Point(12, 212);
            this.labelContractExpires.Name = "labelContractExpires";
            this.labelContractExpires.Size = new System.Drawing.Size(70, 22);
            this.labelContractExpires.TabIndex = 1;
            this.labelContractExpires.Text = "Expires:";
            // 
            // labelContractDate
            // 
            this.labelContractDate.AutoSize = true;
            this.labelContractDate.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractDate.Location = new System.Drawing.Point(12, 177);
            this.labelContractDate.Name = "labelContractDate";
            this.labelContractDate.Size = new System.Drawing.Size(49, 22);
            this.labelContractDate.TabIndex = 1;
            this.labelContractDate.Text = "Date:";
            // 
            // labelContractPaid
            // 
            this.labelContractPaid.AutoSize = true;
            this.labelContractPaid.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractPaid.Location = new System.Drawing.Point(12, 142);
            this.labelContractPaid.Name = "labelContractPaid";
            this.labelContractPaid.Size = new System.Drawing.Size(48, 22);
            this.labelContractPaid.TabIndex = 1;
            this.labelContractPaid.Text = "Paid:";
            // 
            // labelContractEmployeeID
            // 
            this.labelContractEmployeeID.AutoSize = true;
            this.labelContractEmployeeID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContractEmployeeID.Location = new System.Drawing.Point(12, 37);
            this.labelContractEmployeeID.Name = "labelContractEmployeeID";
            this.labelContractEmployeeID.Size = new System.Drawing.Size(104, 22);
            this.labelContractEmployeeID.TabIndex = 1;
            this.labelContractEmployeeID.Text = "EmployeeID:";
            // 
            // textBoxContractPayment
            // 
            this.textBoxContractPayment.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractPayment.Location = new System.Drawing.Point(134, 107);
            this.textBoxContractPayment.Name = "textBoxContractPayment";
            this.textBoxContractPayment.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractPayment.TabIndex = 0;
            // 
            // textBoxContractRentalID
            // 
            this.textBoxContractRentalID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractRentalID.Location = new System.Drawing.Point(134, 72);
            this.textBoxContractRentalID.Name = "textBoxContractRentalID";
            this.textBoxContractRentalID.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractRentalID.TabIndex = 0;
            // 
            // textBoxContractExpires
            // 
            this.textBoxContractExpires.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractExpires.Location = new System.Drawing.Point(134, 212);
            this.textBoxContractExpires.Name = "textBoxContractExpires";
            this.textBoxContractExpires.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractExpires.TabIndex = 0;
            // 
            // textBoxContractDate
            // 
            this.textBoxContractDate.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractDate.Location = new System.Drawing.Point(134, 177);
            this.textBoxContractDate.Name = "textBoxContractDate";
            this.textBoxContractDate.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractDate.TabIndex = 0;
            // 
            // textBoxContractPaid
            // 
            this.textBoxContractPaid.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractPaid.Location = new System.Drawing.Point(134, 142);
            this.textBoxContractPaid.Name = "textBoxContractPaid";
            this.textBoxContractPaid.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractPaid.TabIndex = 0;
            // 
            // textBoxContractEmployeeID
            // 
            this.textBoxContractEmployeeID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractEmployeeID.Location = new System.Drawing.Point(134, 37);
            this.textBoxContractEmployeeID.Name = "textBoxContractEmployeeID";
            this.textBoxContractEmployeeID.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractEmployeeID.TabIndex = 0;
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
            // FormContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContract";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.tabPageRental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentalGridView)).EndInit();
            this.tabPageContractProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).EndInit();
            this.tabPageContractClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ContractGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxContractEmployeeID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelContractEmployeeID;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelContractRentalID;
        private System.Windows.Forms.TextBox textBoxContractRentalID;
        private System.Windows.Forms.Label labelContractPayment;
        private System.Windows.Forms.TextBox textBoxContractPayment;
        private System.Windows.Forms.Label labelContractPaid;
        private System.Windows.Forms.TextBox textBoxContractPaid;
        private System.Windows.Forms.Label labelContractDate;
        private System.Windows.Forms.TextBox textBoxContractDate;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox textBoxContractExpires;
        private System.Windows.Forms.Button buttonContractEdit;
        private System.Windows.Forms.Button buttonContractAdd;
        private System.Windows.Forms.Button buttonContractDelete;
        private System.Windows.Forms.Label labelContractExpires;
        private System.Windows.Forms.Label labelContractOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.TabPage tabPageRental;
        private System.Windows.Forms.DataGridView RentalGridView;
        private System.Windows.Forms.TabPage tabPageContractProperty;
        private System.Windows.Forms.DataGridView PropertyGridView;
        private System.Windows.Forms.TabPage tabPageContractClient;
        private System.Windows.Forms.DataGridView ClientGridView;
    }
}