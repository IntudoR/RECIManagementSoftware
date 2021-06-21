
namespace RECIManagementSoftware
{
    partial class FormVault
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVault = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VaultGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelContractOutput = new System.Windows.Forms.Label();
            this.buttonContractDelete = new System.Windows.Forms.Button();
            this.buttonContractEdit = new System.Windows.Forms.Button();
            this.buttonContractAdd = new System.Windows.Forms.Button();
            this.labelSubscriptionPayment = new System.Windows.Forms.Label();
            this.labelVaultSubscriptionID = new System.Windows.Forms.Label();
            this.textBoxContractMonthlyPayment = new System.Windows.Forms.TextBox();
            this.textBoxContractOrderID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAssignment = new System.Windows.Forms.TabPage();
            this.AssignmentGridView = new System.Windows.Forms.DataGridView();
            this.tabPageCounterparty = new System.Windows.Forms.TabPage();
            this.CounterpartyGridView = new System.Windows.Forms.DataGridView();
            this.tabPageSubsription = new System.Windows.Forms.TabPage();
            this.SubscriptionGridView = new System.Windows.Forms.DataGridView();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.tabPageCounterpartiesContract = new System.Windows.Forms.TabPage();
            this.CounterpartiesContractsGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VaultGridView)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageAssignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGridView)).BeginInit();
            this.tabPageCounterparty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).BeginInit();
            this.tabPageSubsription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionGridView)).BeginInit();
            this.tabPageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            this.tabPageCounterpartiesContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartiesContractsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.labelVault);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 63);
            this.panel1.TabIndex = 0;
            // 
            // labelVault
            // 
            this.labelVault.AutoSize = true;
            this.labelVault.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVault.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelVault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.labelVault.Location = new System.Drawing.Point(0, 0);
            this.labelVault.Name = "labelVault";
            this.labelVault.Size = new System.Drawing.Size(256, 50);
            this.labelVault.TabIndex = 0;
            this.labelVault.Text = "Manage Vault";
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
            this.panel3.Controls.Add(this.VaultGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(343, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 537);
            this.panel3.TabIndex = 2;
            // 
            // VaultGridView
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VaultGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.VaultGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VaultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.VaultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VaultGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VaultGridView.Location = new System.Drawing.Point(0, 0);
            this.VaultGridView.Name = "VaultGridView";
            this.VaultGridView.RowTemplate.Height = 25;
            this.VaultGridView.Size = new System.Drawing.Size(676, 537);
            this.VaultGridView.TabIndex = 0;
            this.VaultGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelContractOutput);
            this.panelAccountControls.Controls.Add(this.buttonContractDelete);
            this.panelAccountControls.Controls.Add(this.buttonContractEdit);
            this.panelAccountControls.Controls.Add(this.buttonContractAdd);
            this.panelAccountControls.Controls.Add(this.labelSubscriptionPayment);
            this.panelAccountControls.Controls.Add(this.labelVaultSubscriptionID);
            this.panelAccountControls.Controls.Add(this.textBoxContractMonthlyPayment);
            this.panelAccountControls.Controls.Add(this.textBoxContractOrderID);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 0);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(343, 537);
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
            this.buttonContractDelete.Location = new System.Drawing.Point(250, 107);
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
            this.buttonContractEdit.Location = new System.Drawing.Point(157, 107);
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
            this.buttonContractAdd.Location = new System.Drawing.Point(64, 107);
            this.buttonContractAdd.Name = "buttonContractAdd";
            this.buttonContractAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonContractAdd.TabIndex = 2;
            this.buttonContractAdd.Text = "Add";
            this.buttonContractAdd.UseVisualStyleBackColor = false;
            this.buttonContractAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelSubscriptionPayment
            // 
            this.labelSubscriptionPayment.AutoSize = true;
            this.labelSubscriptionPayment.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSubscriptionPayment.Location = new System.Drawing.Point(12, 72);
            this.labelSubscriptionPayment.Name = "labelSubscriptionPayment";
            this.labelSubscriptionPayment.Size = new System.Drawing.Size(128, 22);
            this.labelSubscriptionPayment.TabIndex = 1;
            this.labelSubscriptionPayment.Text = "SubscriptionID:";
            // 
            // labelVaultSubscriptionID
            // 
            this.labelVaultSubscriptionID.AutoSize = true;
            this.labelVaultSubscriptionID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVaultSubscriptionID.Location = new System.Drawing.Point(12, 37);
            this.labelVaultSubscriptionID.Name = "labelVaultSubscriptionID";
            this.labelVaultSubscriptionID.Size = new System.Drawing.Size(93, 22);
            this.labelVaultSubscriptionID.TabIndex = 1;
            this.labelVaultSubscriptionID.Text = "AccountID:";
            // 
            // textBoxContractMonthlyPayment
            // 
            this.textBoxContractMonthlyPayment.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractMonthlyPayment.Location = new System.Drawing.Point(150, 72);
            this.textBoxContractMonthlyPayment.Name = "textBoxContractMonthlyPayment";
            this.textBoxContractMonthlyPayment.Size = new System.Drawing.Size(187, 29);
            this.textBoxContractMonthlyPayment.TabIndex = 0;
            // 
            // textBoxContractOrderID
            // 
            this.textBoxContractOrderID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxContractOrderID.Location = new System.Drawing.Point(150, 37);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAssignment);
            this.tabControl1.Controls.Add(this.tabPageCounterparty);
            this.tabControl1.Controls.Add(this.tabPageSubsription);
            this.tabControl1.Controls.Add(this.tabPageAccount);
            this.tabControl1.Controls.Add(this.tabPageCounterpartiesContract);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Clear Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 455);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageAssignment
            // 
            this.tabPageAssignment.Controls.Add(this.AssignmentGridView);
            this.tabPageAssignment.Location = new System.Drawing.Point(4, 30);
            this.tabPageAssignment.Name = "tabPageAssignment";
            this.tabPageAssignment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssignment.Size = new System.Drawing.Size(668, 421);
            this.tabPageAssignment.TabIndex = 0;
            this.tabPageAssignment.Text = "Assignment";
            this.tabPageAssignment.UseVisualStyleBackColor = true;
            // 
            // AssignmentGridView
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AssignmentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.AssignmentGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.AssignmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentGridView.Location = new System.Drawing.Point(3, 3);
            this.AssignmentGridView.Name = "AssignmentGridView";
            this.AssignmentGridView.RowTemplate.Height = 25;
            this.AssignmentGridView.Size = new System.Drawing.Size(662, 415);
            this.AssignmentGridView.TabIndex = 1;
            // 
            // tabPageCounterparty
            // 
            this.tabPageCounterparty.Controls.Add(this.CounterpartyGridView);
            this.tabPageCounterparty.Location = new System.Drawing.Point(4, 30);
            this.tabPageCounterparty.Name = "tabPageCounterparty";
            this.tabPageCounterparty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCounterparty.Size = new System.Drawing.Size(668, 421);
            this.tabPageCounterparty.TabIndex = 1;
            this.tabPageCounterparty.Text = "Counterparty";
            this.tabPageCounterparty.UseVisualStyleBackColor = true;
            // 
            // CounterpartyGridView
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CounterpartyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.CounterpartyGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.CounterpartyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounterpartyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CounterpartyGridView.Location = new System.Drawing.Point(3, 3);
            this.CounterpartyGridView.Name = "CounterpartyGridView";
            this.CounterpartyGridView.RowTemplate.Height = 25;
            this.CounterpartyGridView.Size = new System.Drawing.Size(662, 415);
            this.CounterpartyGridView.TabIndex = 1;
            // 
            // tabPageSubsription
            // 
            this.tabPageSubsription.Controls.Add(this.SubscriptionGridView);
            this.tabPageSubsription.Location = new System.Drawing.Point(4, 30);
            this.tabPageSubsription.Name = "tabPageSubsription";
            this.tabPageSubsription.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubsription.Size = new System.Drawing.Size(668, 421);
            this.tabPageSubsription.TabIndex = 2;
            this.tabPageSubsription.Text = "Subsribers";
            this.tabPageSubsription.UseVisualStyleBackColor = true;
            // 
            // SubscriptionGridView
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubscriptionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.SubscriptionGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubscriptionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.SubscriptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubscriptionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscriptionGridView.Location = new System.Drawing.Point(3, 3);
            this.SubscriptionGridView.Name = "SubscriptionGridView";
            this.SubscriptionGridView.RowTemplate.Height = 25;
            this.SubscriptionGridView.Size = new System.Drawing.Size(662, 415);
            this.SubscriptionGridView.TabIndex = 1;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.AccountGridView);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 30);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(668, 421);
            this.tabPageAccount.TabIndex = 3;
            this.tabPageAccount.Text = "Account";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // AccountGridView
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.AccountGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountGridView.Location = new System.Drawing.Point(3, 3);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.RowTemplate.Height = 25;
            this.AccountGridView.Size = new System.Drawing.Size(662, 415);
            this.AccountGridView.TabIndex = 1;
            // 
            // tabPageCounterpartiesContract
            // 
            this.tabPageCounterpartiesContract.Controls.Add(this.CounterpartiesContractsGridView);
            this.tabPageCounterpartiesContract.Location = new System.Drawing.Point(4, 30);
            this.tabPageCounterpartiesContract.Name = "tabPageCounterpartiesContract";
            this.tabPageCounterpartiesContract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCounterpartiesContract.Size = new System.Drawing.Size(668, 421);
            this.tabPageCounterpartiesContract.TabIndex = 4;
            this.tabPageCounterpartiesContract.Text = "Counterparties Contracts";
            this.tabPageCounterpartiesContract.UseVisualStyleBackColor = true;
            // 
            // CounterpartiesContractsGridView
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CounterpartiesContractsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.CounterpartiesContractsGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CounterpartiesContractsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.CounterpartiesContractsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounterpartiesContractsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CounterpartiesContractsGridView.Location = new System.Drawing.Point(3, 3);
            this.CounterpartiesContractsGridView.Name = "CounterpartiesContractsGridView";
            this.CounterpartiesContractsGridView.RowTemplate.Height = 25;
            this.CounterpartiesContractsGridView.Size = new System.Drawing.Size(662, 415);
            this.CounterpartiesContractsGridView.TabIndex = 2;
            // 
            // FormVault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVault";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VaultGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAssignment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGridView)).EndInit();
            this.tabPageCounterparty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).EndInit();
            this.tabPageSubsription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubscriptionGridView)).EndInit();
            this.tabPageAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            this.tabPageCounterpartiesContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartiesContractsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVault;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView VaultGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxContractOrderID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelVaultSubscriptionID;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelSubscriptionPayment;
        private System.Windows.Forms.TextBox textBoxContractMonthlyPayment;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Button buttonContractEdit;
        private System.Windows.Forms.Button buttonContractAdd;
        private System.Windows.Forms.Button buttonContractDelete;
        private System.Windows.Forms.Label labelContractOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAssignment;
        private System.Windows.Forms.DataGridView AssignmentGridView;
        private System.Windows.Forms.TabPage tabPageCounterparty;
        private System.Windows.Forms.DataGridView CounterpartyGridView;
        private System.Windows.Forms.TabPage tabPageSubsription;
        private System.Windows.Forms.DataGridView SubscriptionGridView;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.TabPage tabPageCounterpartiesContract;
        private System.Windows.Forms.DataGridView CounterpartiesContractsGridView;
    }
}