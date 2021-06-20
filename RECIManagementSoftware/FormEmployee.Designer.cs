
namespace RECIManagementSoftware
{
    partial class FormEmployee
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
            this.labelEmployee = new System.Windows.Forms.Label();
            this.panelAccountControl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelEmployeeOutput = new System.Windows.Forms.Label();
            this.buttonEmployeeDelete = new System.Windows.Forms.Button();
            this.buttonEmployeeEdit = new System.Windows.Forms.Button();
            this.buttonEmployeeAdd = new System.Windows.Forms.Button();
            this.labelEmployeeLastName = new System.Windows.Forms.Label();
            this.labelEmployeeFirstName = new System.Windows.Forms.Label();
            this.labelEmployeeStatus = new System.Windows.Forms.Label();
            this.labelEmployeeSalary = new System.Windows.Forms.Label();
            this.labelEmployeeOccupation = new System.Windows.Forms.Label();
            this.labelEmployeeBirthday = new System.Windows.Forms.Label();
            this.labelEmployeeGender = new System.Windows.Forms.Label();
            this.labelEmployeeAccountID = new System.Windows.Forms.Label();
            this.textBoxEmployeeLastName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeStatus = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeSalary = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeOccupation = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeBirthday = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeGender = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeAccountID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelAccountControl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.labelEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 63);
            this.panel1.TabIndex = 0;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmployee.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.labelEmployee.Location = new System.Drawing.Point(0, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(355, 50);
            this.labelEmployee.TabIndex = 0;
            this.labelEmployee.Text = "Manage Employees";
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
            this.panel3.Controls.Add(this.EmployeeGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 537);
            this.panel3.TabIndex = 2;
            // 
            // AccountGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccountGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AccountGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccountGridView.Location = new System.Drawing.Point(0, 86);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.RowTemplate.Height = 25;
            this.AccountGridView.Size = new System.Drawing.Size(692, 451);
            this.AccountGridView.TabIndex = 0;
            this.AccountGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // EmployeeGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeGridView.Location = new System.Drawing.Point(0, 0);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowTemplate.Height = 25;
            this.EmployeeGridView.Size = new System.Drawing.Size(692, 537);
            this.EmployeeGridView.TabIndex = 0;
            this.EmployeeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountGridView_CellContentClick);
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelEmployeeOutput);
            this.panelAccountControls.Controls.Add(this.buttonEmployeeDelete);
            this.panelAccountControls.Controls.Add(this.buttonEmployeeEdit);
            this.panelAccountControls.Controls.Add(this.buttonEmployeeAdd);
            this.panelAccountControls.Controls.Add(this.labelEmployeeLastName);
            this.panelAccountControls.Controls.Add(this.labelEmployeeFirstName);
            this.panelAccountControls.Controls.Add(this.labelEmployeeStatus);
            this.panelAccountControls.Controls.Add(this.labelEmployeeSalary);
            this.panelAccountControls.Controls.Add(this.labelEmployeeOccupation);
            this.panelAccountControls.Controls.Add(this.labelEmployeeBirthday);
            this.panelAccountControls.Controls.Add(this.labelEmployeeGender);
            this.panelAccountControls.Controls.Add(this.labelEmployeeAccountID);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeLastName);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeFirstName);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeStatus);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeSalary);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeOccupation);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeBirthday);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeGender);
            this.panelAccountControls.Controls.Add(this.textBoxEmployeeAccountID);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 0);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(327, 537);
            this.panelAccountControls.TabIndex = 1;
            // 
            // labelEmployeeOutput
            // 
            this.labelEmployeeOutput.AutoSize = true;
            this.labelEmployeeOutput.Font = new System.Drawing.Font("Clear Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeOutput.Location = new System.Drawing.Point(13, 7);
            this.labelEmployeeOutput.Name = "labelEmployeeOutput";
            this.labelEmployeeOutput.Size = new System.Drawing.Size(50, 18);
            this.labelEmployeeOutput.TabIndex = 3;
            this.labelEmployeeOutput.Text = "label1";
            this.labelEmployeeOutput.Visible = false;
            // 
            // buttonEmployeeDelete
            // 
            this.buttonEmployeeDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonEmployeeDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonEmployeeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeDelete.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployeeDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonEmployeeDelete.Location = new System.Drawing.Point(234, 317);
            this.buttonEmployeeDelete.Name = "buttonEmployeeDelete";
            this.buttonEmployeeDelete.Size = new System.Drawing.Size(87, 40);
            this.buttonEmployeeDelete.TabIndex = 2;
            this.buttonEmployeeDelete.Text = "Delete";
            this.buttonEmployeeDelete.UseVisualStyleBackColor = false;
            this.buttonEmployeeDelete.Click += new System.EventHandler(this.buttonAccountDelete_Click);
            // 
            // buttonEmployeeEdit
            // 
            this.buttonEmployeeEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonEmployeeEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonEmployeeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeEdit.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployeeEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonEmployeeEdit.Location = new System.Drawing.Point(141, 317);
            this.buttonEmployeeEdit.Name = "buttonEmployeeEdit";
            this.buttonEmployeeEdit.Size = new System.Drawing.Size(87, 40);
            this.buttonEmployeeEdit.TabIndex = 2;
            this.buttonEmployeeEdit.Text = "Edit";
            this.buttonEmployeeEdit.UseVisualStyleBackColor = false;
            this.buttonEmployeeEdit.Click += new System.EventHandler(this.buttonAccountEdit_Click);
            // 
            // buttonEmployeeAdd
            // 
            this.buttonEmployeeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonEmployeeAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeAdd.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployeeAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonEmployeeAdd.Location = new System.Drawing.Point(48, 317);
            this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
            this.buttonEmployeeAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonEmployeeAdd.TabIndex = 2;
            this.buttonEmployeeAdd.Text = "Add";
            this.buttonEmployeeAdd.UseVisualStyleBackColor = false;
            this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonAccountAdd_Click);
            // 
            // labelEmployeeLastName
            // 
            this.labelEmployeeLastName.AutoSize = true;
            this.labelEmployeeLastName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeLastName.Location = new System.Drawing.Point(12, 107);
            this.labelEmployeeLastName.Name = "labelEmployeeLastName";
            this.labelEmployeeLastName.Size = new System.Drawing.Size(93, 22);
            this.labelEmployeeLastName.TabIndex = 1;
            this.labelEmployeeLastName.Text = "Last Name:";
            // 
            // labelEmployeeFirstName
            // 
            this.labelEmployeeFirstName.AutoSize = true;
            this.labelEmployeeFirstName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeFirstName.Location = new System.Drawing.Point(12, 72);
            this.labelEmployeeFirstName.Name = "labelEmployeeFirstName";
            this.labelEmployeeFirstName.Size = new System.Drawing.Size(96, 22);
            this.labelEmployeeFirstName.TabIndex = 1;
            this.labelEmployeeFirstName.Text = "First Name:";
            // 
            // labelEmployeeStatus
            // 
            this.labelEmployeeStatus.AutoSize = true;
            this.labelEmployeeStatus.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeStatus.Location = new System.Drawing.Point(12, 282);
            this.labelEmployeeStatus.Name = "labelEmployeeStatus";
            this.labelEmployeeStatus.Size = new System.Drawing.Size(64, 22);
            this.labelEmployeeStatus.TabIndex = 1;
            this.labelEmployeeStatus.Text = "Status:";
            // 
            // labelEmployeeSalary
            // 
            this.labelEmployeeSalary.AutoSize = true;
            this.labelEmployeeSalary.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeSalary.Location = new System.Drawing.Point(12, 247);
            this.labelEmployeeSalary.Name = "labelEmployeeSalary";
            this.labelEmployeeSalary.Size = new System.Drawing.Size(62, 22);
            this.labelEmployeeSalary.TabIndex = 1;
            this.labelEmployeeSalary.Text = "Salary:";
            // 
            // labelEmployeeOccupation
            // 
            this.labelEmployeeOccupation.AutoSize = true;
            this.labelEmployeeOccupation.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeOccupation.Location = new System.Drawing.Point(12, 212);
            this.labelEmployeeOccupation.Name = "labelEmployeeOccupation";
            this.labelEmployeeOccupation.Size = new System.Drawing.Size(100, 22);
            this.labelEmployeeOccupation.TabIndex = 1;
            this.labelEmployeeOccupation.Text = "Occupation:";
            // 
            // labelEmployeeBirthday
            // 
            this.labelEmployeeBirthday.AutoSize = true;
            this.labelEmployeeBirthday.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeBirthday.Location = new System.Drawing.Point(12, 177);
            this.labelEmployeeBirthday.Name = "labelEmployeeBirthday";
            this.labelEmployeeBirthday.Size = new System.Drawing.Size(79, 22);
            this.labelEmployeeBirthday.TabIndex = 1;
            this.labelEmployeeBirthday.Text = "Birthday:";
            // 
            // labelEmployeeGender
            // 
            this.labelEmployeeGender.AutoSize = true;
            this.labelEmployeeGender.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeGender.Location = new System.Drawing.Point(12, 142);
            this.labelEmployeeGender.Name = "labelEmployeeGender";
            this.labelEmployeeGender.Size = new System.Drawing.Size(71, 22);
            this.labelEmployeeGender.TabIndex = 1;
            this.labelEmployeeGender.Text = "Gender:";
            // 
            // labelEmployeeAccountID
            // 
            this.labelEmployeeAccountID.AutoSize = true;
            this.labelEmployeeAccountID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeAccountID.Location = new System.Drawing.Point(12, 37);
            this.labelEmployeeAccountID.Name = "labelEmployeeAccountID";
            this.labelEmployeeAccountID.Size = new System.Drawing.Size(93, 22);
            this.labelEmployeeAccountID.TabIndex = 1;
            this.labelEmployeeAccountID.Text = "AccountID:";
            // 
            // textBoxEmployeeLastName
            // 
            this.textBoxEmployeeLastName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeLastName.Location = new System.Drawing.Point(134, 107);
            this.textBoxEmployeeLastName.Name = "textBoxEmployeeLastName";
            this.textBoxEmployeeLastName.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeLastName.TabIndex = 0;
            // 
            // textBoxEmployeeFirstName
            // 
            this.textBoxEmployeeFirstName.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeFirstName.Location = new System.Drawing.Point(134, 72);
            this.textBoxEmployeeFirstName.Name = "textBoxEmployeeFirstName";
            this.textBoxEmployeeFirstName.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeFirstName.TabIndex = 0;
            // 
            // textBoxEmployeeStatus
            // 
            this.textBoxEmployeeStatus.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeStatus.Location = new System.Drawing.Point(134, 282);
            this.textBoxEmployeeStatus.Name = "textBoxEmployeeStatus";
            this.textBoxEmployeeStatus.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeStatus.TabIndex = 0;
            // 
            // textBoxEmployeeSalary
            // 
            this.textBoxEmployeeSalary.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeSalary.Location = new System.Drawing.Point(134, 247);
            this.textBoxEmployeeSalary.Name = "textBoxEmployeeSalary";
            this.textBoxEmployeeSalary.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeSalary.TabIndex = 0;
            // 
            // textBoxEmployeeOccupation
            // 
            this.textBoxEmployeeOccupation.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeOccupation.Location = new System.Drawing.Point(134, 212);
            this.textBoxEmployeeOccupation.Name = "textBoxEmployeeOccupation";
            this.textBoxEmployeeOccupation.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeOccupation.TabIndex = 0;
            // 
            // textBoxEmployeeBirthday
            // 
            this.textBoxEmployeeBirthday.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeBirthday.Location = new System.Drawing.Point(134, 177);
            this.textBoxEmployeeBirthday.Name = "textBoxEmployeeBirthday";
            this.textBoxEmployeeBirthday.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeBirthday.TabIndex = 0;
            // 
            // textBoxEmployeeGender
            // 
            this.textBoxEmployeeGender.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeGender.Location = new System.Drawing.Point(134, 142);
            this.textBoxEmployeeGender.Name = "textBoxEmployeeGender";
            this.textBoxEmployeeGender.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeGender.TabIndex = 0;
            // 
            // textBoxEmployeeAccountID
            // 
            this.textBoxEmployeeAccountID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmployeeAccountID.Location = new System.Drawing.Point(134, 37);
            this.textBoxEmployeeAccountID.Name = "textBoxEmployeeAccountID";
            this.textBoxEmployeeAccountID.Size = new System.Drawing.Size(187, 29);
            this.textBoxEmployeeAccountID.TabIndex = 0;
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
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 625);
            this.Controls.Add(this.panelAccountControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployee";
            this.Text = "FormAccount";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAccountControl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Panel panelAccountControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.TextBox textBoxEmployeeAccountID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEmployeeAccountID;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.Label labelEmployeeFirstName;
        private System.Windows.Forms.TextBox textBoxEmployeeFirstName;
        private System.Windows.Forms.Label labelEmployeeLastName;
        private System.Windows.Forms.TextBox textBoxEmployeeLastName;
        private System.Windows.Forms.Label labelEmployeeGender;
        private System.Windows.Forms.TextBox textBoxEmployeeGender;
        private System.Windows.Forms.Label labelEmployeeBirthday;
        private System.Windows.Forms.TextBox textBoxEmployeeBirthday;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Button buttonEmployeeEdit;
        private System.Windows.Forms.Button buttonEmployeeAdd;
        private System.Windows.Forms.Button buttonEmployeeDelete;
        private System.Windows.Forms.Label labelEmployeeOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.Label labelEmployeeOccupation;
        private System.Windows.Forms.TextBox textBoxEmployeeOccupation;
        private System.Windows.Forms.Label labelEmployeeStatus;
        private System.Windows.Forms.Label labelEmployeeSalary;
        private System.Windows.Forms.TextBox textBoxEmployeeStatus;
        private System.Windows.Forms.TextBox textBoxEmployeeSalary;
    }
}