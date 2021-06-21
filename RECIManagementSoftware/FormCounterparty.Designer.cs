
namespace RECIManagementSoftware
{
    partial class FormCounterparty
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCounterparty = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageContract = new System.Windows.Forms.TabPage();
            this.ContractGridView = new System.Windows.Forms.DataGridView();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.tabPageProperty = new System.Windows.Forms.TabPage();
            this.PropertyGridView = new System.Windows.Forms.DataGridView();
            this.CounterpartyGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelCounterpartyOutput = new System.Windows.Forms.Label();
            this.buttonCounterpartyDelete = new System.Windows.Forms.Button();
            this.buttonCounterpartyEdit = new System.Windows.Forms.Button();
            this.buttonCounterpartytAdd = new System.Windows.Forms.Button();
            this.labelCounterpartyLastName = new System.Windows.Forms.Label();
            this.labelCounterpartyFirstName = new System.Windows.Forms.Label();
            this.labelCounterpartyMobile = new System.Windows.Forms.Label();
            this.labelCounterpartyContractID = new System.Windows.Forms.Label();
            this.textBoxCounterpartyLastName = new System.Windows.Forms.TextBox();
            this.textBoxCounterpartyFirstName = new System.Windows.Forms.TextBox();
            this.textBoxCounterpartyMobile = new System.Windows.Forms.TextBox();
            this.textBoxCounterpartyContractID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractGridView)).BeginInit();
            this.tabPageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.tabPageProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.labelCounterparty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 63);
            this.panel1.TabIndex = 0;
            // 
            // labelCounterparty
            // 
            this.labelCounterparty.AutoSize = true;
            this.labelCounterparty.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCounterparty.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelCounterparty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.labelCounterparty.Location = new System.Drawing.Point(0, 0);
            this.labelCounterparty.Name = "labelCounterparty";
            this.labelCounterparty.Size = new System.Drawing.Size(427, 50);
            this.labelCounterparty.TabIndex = 0;
            this.labelCounterparty.Text = "Manage Counterparties";
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
            this.panel3.Controls.Add(this.CounterpartyGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 537);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageContract);
            this.tabControl1.Controls.Add(this.tabPageOrder);
            this.tabControl1.Controls.Add(this.tabPageProperty);
            this.tabControl1.Font = new System.Drawing.Font("Clear Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 465);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageContract
            // 
            this.tabPageContract.Controls.Add(this.ContractGridView);
            this.tabPageContract.Location = new System.Drawing.Point(4, 30);
            this.tabPageContract.Name = "tabPageContract";
            this.tabPageContract.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContract.Size = new System.Drawing.Size(684, 431);
            this.tabPageContract.TabIndex = 0;
            this.tabPageContract.Text = "Counterparty Contract";
            this.tabPageContract.UseVisualStyleBackColor = true;
            // 
            // ContractGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContractGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ContractGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ContractGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContractGridView.Location = new System.Drawing.Point(3, 3);
            this.ContractGridView.Name = "ContractGridView";
            this.ContractGridView.RowTemplate.Height = 25;
            this.ContractGridView.Size = new System.Drawing.Size(678, 425);
            this.ContractGridView.TabIndex = 1;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.OrderGridView);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 30);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(684, 431);
            this.tabPageOrder.TabIndex = 1;
            this.tabPageOrder.Text = "Order";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // OrderGridView
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.Location = new System.Drawing.Point(3, 3);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowTemplate.Height = 25;
            this.OrderGridView.Size = new System.Drawing.Size(678, 425);
            this.OrderGridView.TabIndex = 1;
            // 
            // tabPageProperty
            // 
            this.tabPageProperty.Controls.Add(this.PropertyGridView);
            this.tabPageProperty.Location = new System.Drawing.Point(4, 30);
            this.tabPageProperty.Name = "tabPageProperty";
            this.tabPageProperty.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProperty.Size = new System.Drawing.Size(684, 431);
            this.tabPageProperty.TabIndex = 2;
            this.tabPageProperty.Text = "Property";
            this.tabPageProperty.UseVisualStyleBackColor = true;
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
            this.PropertyGridView.Size = new System.Drawing.Size(678, 425);
            this.PropertyGridView.TabIndex = 1;
            // 
            // CounterpartyGridView
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CounterpartyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CounterpartyGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CounterpartyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CounterpartyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounterpartyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CounterpartyGridView.Location = new System.Drawing.Point(0, 0);
            this.CounterpartyGridView.Name = "CounterpartyGridView";
            this.CounterpartyGridView.RowTemplate.Height = 25;
            this.CounterpartyGridView.Size = new System.Drawing.Size(692, 537);
            this.CounterpartyGridView.TabIndex = 0;
            this.CounterpartyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelCounterpartyOutput);
            this.panelAccountControls.Controls.Add(this.buttonCounterpartyDelete);
            this.panelAccountControls.Controls.Add(this.buttonCounterpartyEdit);
            this.panelAccountControls.Controls.Add(this.buttonCounterpartytAdd);
            this.panelAccountControls.Controls.Add(this.labelCounterpartyLastName);
            this.panelAccountControls.Controls.Add(this.labelCounterpartyFirstName);
            this.panelAccountControls.Controls.Add(this.labelCounterpartyMobile);
            this.panelAccountControls.Controls.Add(this.labelCounterpartyContractID);
            this.panelAccountControls.Controls.Add(this.textBoxCounterpartyLastName);
            this.panelAccountControls.Controls.Add(this.textBoxCounterpartyFirstName);
            this.panelAccountControls.Controls.Add(this.textBoxCounterpartyMobile);
            this.panelAccountControls.Controls.Add(this.textBoxCounterpartyContractID);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 0);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(327, 537);
            this.panelAccountControls.TabIndex = 1;
            // 
            // labelCounterpartyOutput
            // 
            this.labelCounterpartyOutput.AutoSize = true;
            this.labelCounterpartyOutput.Font = new System.Drawing.Font("Clear Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCounterpartyOutput.Location = new System.Drawing.Point(13, 7);
            this.labelCounterpartyOutput.Name = "labelCounterpartyOutput";
            this.labelCounterpartyOutput.Size = new System.Drawing.Size(50, 18);
            this.labelCounterpartyOutput.TabIndex = 3;
            this.labelCounterpartyOutput.Text = "label1";
            this.labelCounterpartyOutput.Visible = false;
            // 
            // buttonCounterpartyDelete
            // 
            this.buttonCounterpartyDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonCounterpartyDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonCounterpartyDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCounterpartyDelete.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCounterpartyDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonCounterpartyDelete.Location = new System.Drawing.Point(234, 177);
            this.buttonCounterpartyDelete.Name = "buttonCounterpartyDelete";
            this.buttonCounterpartyDelete.Size = new System.Drawing.Size(87, 40);
            this.buttonCounterpartyDelete.TabIndex = 2;
            this.buttonCounterpartyDelete.Text = "Delete";
            this.buttonCounterpartyDelete.UseVisualStyleBackColor = false;
            this.buttonCounterpartyDelete.Click += new System.EventHandler(this.buttonAccountDelete_Click);
            // 
            // buttonCounterpartyEdit
            // 
            this.buttonCounterpartyEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonCounterpartyEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonCounterpartyEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCounterpartyEdit.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCounterpartyEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonCounterpartyEdit.Location = new System.Drawing.Point(141, 177);
            this.buttonCounterpartyEdit.Name = "buttonCounterpartyEdit";
            this.buttonCounterpartyEdit.Size = new System.Drawing.Size(87, 40);
            this.buttonCounterpartyEdit.TabIndex = 2;
            this.buttonCounterpartyEdit.Text = "Edit";
            this.buttonCounterpartyEdit.UseVisualStyleBackColor = false;
            this.buttonCounterpartyEdit.Click += new System.EventHandler(this.buttonAccountEdit_Click);
            // 
            // buttonCounterpartytAdd
            // 
            this.buttonCounterpartytAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonCounterpartytAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonCounterpartytAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCounterpartytAdd.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCounterpartytAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonCounterpartytAdd.Location = new System.Drawing.Point(48, 177);
            this.buttonCounterpartytAdd.Name = "buttonCounterpartytAdd";
            this.buttonCounterpartytAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonCounterpartytAdd.TabIndex = 2;
            this.buttonCounterpartytAdd.Text = "Add";
            this.buttonCounterpartytAdd.UseVisualStyleBackColor = false;
            this.buttonCounterpartytAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelCounterpartyLastName
            // 
            this.labelCounterpartyLastName.AutoSize = true;
            this.labelCounterpartyLastName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCounterpartyLastName.Location = new System.Drawing.Point(12, 107);
            this.labelCounterpartyLastName.Name = "labelCounterpartyLastName";
            this.labelCounterpartyLastName.Size = new System.Drawing.Size(93, 22);
            this.labelCounterpartyLastName.TabIndex = 1;
            this.labelCounterpartyLastName.Text = "Last Name:";
            // 
            // labelCounterpartyFirstName
            // 
            this.labelCounterpartyFirstName.AutoSize = true;
            this.labelCounterpartyFirstName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCounterpartyFirstName.Location = new System.Drawing.Point(12, 72);
            this.labelCounterpartyFirstName.Name = "labelCounterpartyFirstName";
            this.labelCounterpartyFirstName.Size = new System.Drawing.Size(96, 22);
            this.labelCounterpartyFirstName.TabIndex = 1;
            this.labelCounterpartyFirstName.Text = "First Name:";
            // 
            // labelCounterpartyMobile
            // 
            this.labelCounterpartyMobile.AutoSize = true;
            this.labelCounterpartyMobile.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCounterpartyMobile.Location = new System.Drawing.Point(12, 142);
            this.labelCounterpartyMobile.Name = "labelCounterpartyMobile";
            this.labelCounterpartyMobile.Size = new System.Drawing.Size(64, 22);
            this.labelCounterpartyMobile.TabIndex = 1;
            this.labelCounterpartyMobile.Text = "Mobile:";
            // 
            // labelCounterpartyContractID
            // 
            this.labelCounterpartyContractID.AutoSize = true;
            this.labelCounterpartyContractID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCounterpartyContractID.Location = new System.Drawing.Point(12, 37);
            this.labelCounterpartyContractID.Name = "labelCounterpartyContractID";
            this.labelCounterpartyContractID.Size = new System.Drawing.Size(97, 22);
            this.labelCounterpartyContractID.TabIndex = 1;
            this.labelCounterpartyContractID.Text = "ContractID:";
            // 
            // textBoxCounterpartyLastName
            // 
            this.textBoxCounterpartyLastName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCounterpartyLastName.Location = new System.Drawing.Point(134, 107);
            this.textBoxCounterpartyLastName.Name = "textBoxCounterpartyLastName";
            this.textBoxCounterpartyLastName.Size = new System.Drawing.Size(187, 29);
            this.textBoxCounterpartyLastName.TabIndex = 0;
            // 
            // textBoxCounterpartyFirstName
            // 
            this.textBoxCounterpartyFirstName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCounterpartyFirstName.Location = new System.Drawing.Point(134, 72);
            this.textBoxCounterpartyFirstName.Name = "textBoxCounterpartyFirstName";
            this.textBoxCounterpartyFirstName.Size = new System.Drawing.Size(187, 29);
            this.textBoxCounterpartyFirstName.TabIndex = 0;
            // 
            // textBoxCounterpartyMobile
            // 
            this.textBoxCounterpartyMobile.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCounterpartyMobile.Location = new System.Drawing.Point(134, 142);
            this.textBoxCounterpartyMobile.Name = "textBoxCounterpartyMobile";
            this.textBoxCounterpartyMobile.Size = new System.Drawing.Size(187, 29);
            this.textBoxCounterpartyMobile.TabIndex = 0;
            // 
            // textBoxCounterpartyContractID
            // 
            this.textBoxCounterpartyContractID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCounterpartyContractID.Location = new System.Drawing.Point(134, 37);
            this.textBoxCounterpartyContractID.Name = "textBoxCounterpartyContractID";
            this.textBoxCounterpartyContractID.Size = new System.Drawing.Size(187, 29);
            this.textBoxCounterpartyContractID.TabIndex = 0;
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
            // FormCounterparty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCounterparty";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContractGridView)).EndInit();
            this.tabPageOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.tabPageProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView CounterpartyGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxCounterpartyContractID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCounterpartyContractID;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelCounterpartyFirstName;
        private System.Windows.Forms.TextBox textBoxCounterpartyFirstName;
        private System.Windows.Forms.Label labelCounterpartyLastName;
        private System.Windows.Forms.TextBox textBoxCounterpartyLastName;
        private System.Windows.Forms.Label labelCounterpartyMobile;
        private System.Windows.Forms.TextBox textBoxCounterpartyMobile;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Button buttonContractEdit;
        private System.Windows.Forms.Button buttonContractAdd;
        private System.Windows.Forms.Button buttonContractDelete;
        private System.Windows.Forms.Label labelCounterpartyOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageContract;
        private System.Windows.Forms.DataGridView ContractGridView;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.TabPage tabPageProperty;
        private System.Windows.Forms.DataGridView PropertyGridView;
        private System.Windows.Forms.Label labelCounterparty;
        private System.Windows.Forms.Button buttonCounterpartyDelete;
        private System.Windows.Forms.Button buttonCounterpartyEdit;
        private System.Windows.Forms.Button buttonCounterpartytAdd;
    }
}