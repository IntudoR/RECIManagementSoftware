
namespace RECIManagementSoftware
{
    partial class FormOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClient = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PropertyGridView = new System.Windows.Forms.DataGridView();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelClientOutput = new System.Windows.Forms.Label();
            this.buttonClientDelete = new System.Windows.Forms.Button();
            this.buttonClientEdit = new System.Windows.Forms.Button();
            this.buttonClientAdd = new System.Windows.Forms.Button();
            this.labelOrderDeadline = new System.Windows.Forms.Label();
            this.labelOrderDescription = new System.Windows.Forms.Label();
            this.labelOrderPropertyID = new System.Windows.Forms.Label();
            this.labelOrderPrice = new System.Windows.Forms.Label();
            this.textBoxClientLastName = new System.Windows.Forms.TextBox();
            this.textBoxClientFirstName = new System.Windows.Forms.TextBox();
            this.textBoxClientGender = new System.Windows.Forms.TextBox();
            this.textBoxClientAccountID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.labelClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 63);
            this.panel1.TabIndex = 0;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelClient.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.labelClient.Location = new System.Drawing.Point(0, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(287, 50);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Manage Clients";
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
            this.panel3.Controls.Add(this.PropertyGridView);
            this.panel3.Controls.Add(this.OrderGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 537);
            this.panel3.TabIndex = 2;
            // 
            // PropertyGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PropertyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PropertyGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PropertyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PropertyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PropertyGridView.Location = new System.Drawing.Point(0, 117);
            this.PropertyGridView.Name = "PropertyGridView";
            this.PropertyGridView.RowTemplate.Height = 25;
            this.PropertyGridView.Size = new System.Drawing.Size(692, 420);
            this.PropertyGridView.TabIndex = 0;
            this.PropertyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // OrderGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.OrderGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.Location = new System.Drawing.Point(0, 0);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowTemplate.Height = 25;
            this.OrderGridView.Size = new System.Drawing.Size(692, 537);
            this.OrderGridView.TabIndex = 0;
            this.OrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelClientOutput);
            this.panelAccountControls.Controls.Add(this.buttonClientDelete);
            this.panelAccountControls.Controls.Add(this.buttonClientEdit);
            this.panelAccountControls.Controls.Add(this.buttonClientAdd);
            this.panelAccountControls.Controls.Add(this.labelOrderDeadline);
            this.panelAccountControls.Controls.Add(this.labelOrderDescription);
            this.panelAccountControls.Controls.Add(this.labelOrderPropertyID);
            this.panelAccountControls.Controls.Add(this.labelOrderPrice);
            this.panelAccountControls.Controls.Add(this.textBoxClientLastName);
            this.panelAccountControls.Controls.Add(this.textBoxClientFirstName);
            this.panelAccountControls.Controls.Add(this.textBoxClientGender);
            this.panelAccountControls.Controls.Add(this.textBoxClientAccountID);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 0);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(327, 537);
            this.panelAccountControls.TabIndex = 1;
            // 
            // labelClientOutput
            // 
            this.labelClientOutput.AutoSize = true;
            this.labelClientOutput.Font = new System.Drawing.Font("Clear Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClientOutput.Location = new System.Drawing.Point(13, 7);
            this.labelClientOutput.Name = "labelClientOutput";
            this.labelClientOutput.Size = new System.Drawing.Size(50, 18);
            this.labelClientOutput.TabIndex = 3;
            this.labelClientOutput.Text = "label1";
            this.labelClientOutput.Visible = false;
            // 
            // buttonClientDelete
            // 
            this.buttonClientDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonClientDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonClientDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientDelete.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClientDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonClientDelete.Location = new System.Drawing.Point(234, 177);
            this.buttonClientDelete.Name = "buttonClientDelete";
            this.buttonClientDelete.Size = new System.Drawing.Size(87, 40);
            this.buttonClientDelete.TabIndex = 2;
            this.buttonClientDelete.Text = "Delete";
            this.buttonClientDelete.UseVisualStyleBackColor = false;
            this.buttonClientDelete.Click += new System.EventHandler(this.buttonAccountDelete_Click);
            // 
            // buttonClientEdit
            // 
            this.buttonClientEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonClientEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonClientEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientEdit.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClientEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonClientEdit.Location = new System.Drawing.Point(141, 177);
            this.buttonClientEdit.Name = "buttonClientEdit";
            this.buttonClientEdit.Size = new System.Drawing.Size(87, 40);
            this.buttonClientEdit.TabIndex = 2;
            this.buttonClientEdit.Text = "Edit";
            this.buttonClientEdit.UseVisualStyleBackColor = false;
            this.buttonClientEdit.Click += new System.EventHandler(this.buttonAccountEdit_Click);
            // 
            // buttonClientAdd
            // 
            this.buttonClientAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonClientAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonClientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientAdd.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClientAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonClientAdd.Location = new System.Drawing.Point(48, 177);
            this.buttonClientAdd.Name = "buttonClientAdd";
            this.buttonClientAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonClientAdd.TabIndex = 2;
            this.buttonClientAdd.Text = "Add";
            this.buttonClientAdd.UseVisualStyleBackColor = false;
            this.buttonClientAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelOrderDeadline
            // 
            this.labelOrderDeadline.AutoSize = true;
            this.labelOrderDeadline.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderDeadline.Location = new System.Drawing.Point(12, 107);
            this.labelOrderDeadline.Name = "labelOrderDeadline";
            this.labelOrderDeadline.Size = new System.Drawing.Size(80, 22);
            this.labelOrderDeadline.TabIndex = 1;
            this.labelOrderDeadline.Text = "Deadline:";
            // 
            // labelOrderDescription
            // 
            this.labelOrderDescription.AutoSize = true;
            this.labelOrderDescription.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderDescription.Location = new System.Drawing.Point(12, 72);
            this.labelOrderDescription.Name = "labelOrderDescription";
            this.labelOrderDescription.Size = new System.Drawing.Size(100, 22);
            this.labelOrderDescription.TabIndex = 1;
            this.labelOrderDescription.Text = "Description:";
            // 
            // labelOrderPropertyID
            // 
            this.labelOrderPropertyID.AutoSize = true;
            this.labelOrderPropertyID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderPropertyID.Location = new System.Drawing.Point(12, 142);
            this.labelOrderPropertyID.Name = "labelOrderPropertyID";
            this.labelOrderPropertyID.Size = new System.Drawing.Size(98, 22);
            this.labelOrderPropertyID.TabIndex = 1;
            this.labelOrderPropertyID.Text = "PropertyID:";
            // 
            // labelOrderPrice
            // 
            this.labelOrderPrice.AutoSize = true;
            this.labelOrderPrice.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOrderPrice.Location = new System.Drawing.Point(12, 37);
            this.labelOrderPrice.Name = "labelOrderPrice";
            this.labelOrderPrice.Size = new System.Drawing.Size(53, 22);
            this.labelOrderPrice.TabIndex = 1;
            this.labelOrderPrice.Text = "Price:";
            // 
            // textBoxClientLastName
            // 
            this.textBoxClientLastName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxClientLastName.Location = new System.Drawing.Point(134, 107);
            this.textBoxClientLastName.Name = "textBoxClientLastName";
            this.textBoxClientLastName.Size = new System.Drawing.Size(187, 29);
            this.textBoxClientLastName.TabIndex = 0;
            // 
            // textBoxClientFirstName
            // 
            this.textBoxClientFirstName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxClientFirstName.Location = new System.Drawing.Point(134, 72);
            this.textBoxClientFirstName.Name = "textBoxClientFirstName";
            this.textBoxClientFirstName.Size = new System.Drawing.Size(187, 29);
            this.textBoxClientFirstName.TabIndex = 0;
            // 
            // textBoxClientGender
            // 
            this.textBoxClientGender.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxClientGender.Location = new System.Drawing.Point(134, 142);
            this.textBoxClientGender.Name = "textBoxClientGender";
            this.textBoxClientGender.Size = new System.Drawing.Size(187, 29);
            this.textBoxClientGender.TabIndex = 0;
            // 
            // textBoxClientAccountID
            // 
            this.textBoxClientAccountID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxClientAccountID.Location = new System.Drawing.Point(134, 37);
            this.textBoxClientAccountID.Name = "textBoxClientAccountID";
            this.textBoxClientAccountID.Size = new System.Drawing.Size(187, 29);
            this.textBoxClientAccountID.TabIndex = 0;
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
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxClientAccountID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelOrderPrice;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelOrderDescription;
        private System.Windows.Forms.TextBox textBoxClientFirstName;
        private System.Windows.Forms.Label labelOrderDeadline;
        private System.Windows.Forms.TextBox textBoxClientLastName;
        private System.Windows.Forms.Label labelOrderPropertyID;
        private System.Windows.Forms.TextBox textBoxClientGender;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Button buttonClientEdit;
        private System.Windows.Forms.Button buttonClientAdd;
        private System.Windows.Forms.Button buttonClientDelete;
        private System.Windows.Forms.Label labelClientOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView PropertyGridView;
    }
}