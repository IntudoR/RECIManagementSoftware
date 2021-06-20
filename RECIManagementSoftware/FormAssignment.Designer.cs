
namespace RECIManagementSoftware
{
    partial class FormAssignment
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
            this.labelAssignment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAssignmentsView = new System.Windows.Forms.Panel();
            this.CounterpartyGridView = new System.Windows.Forms.DataGridView();
            this.AssignmentGridView = new System.Windows.Forms.DataGridView();
            this.panelAccountControls = new System.Windows.Forms.Panel();
            this.labelAssignmentOutput = new System.Windows.Forms.Label();
            this.buttonAssignmentDelete = new System.Windows.Forms.Button();
            this.buttonAssignmentEdit = new System.Windows.Forms.Button();
            this.buttonAssignmentAdd = new System.Windows.Forms.Button();
            this.labelAccountPassword = new System.Windows.Forms.Label();
            this.labelAssignmentstCounterpartyID = new System.Windows.Forms.Label();
            this.textBoxAssignmentDate = new System.Windows.Forms.TextBox();
            this.textBoxAssignmentCounterpartyID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAssignmentsView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGridView)).BeginInit();
            this.panelAccountControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.labelAssignment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 63);
            this.panel1.TabIndex = 1;
            // 
            // labelAssignment
            // 
            this.labelAssignment.AutoSize = true;
            this.labelAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAssignment.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelAssignment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.labelAssignment.Location = new System.Drawing.Point(0, 0);
            this.labelAssignment.Name = "labelAssignment";
            this.labelAssignment.Size = new System.Drawing.Size(391, 50);
            this.labelAssignment.TabIndex = 0;
            this.labelAssignment.Text = "Manage Assignments";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 25);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelAssignmentsView);
            this.panel3.Controls.Add(this.panelAccountControls);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 484);
            this.panel3.TabIndex = 3;
            // 
            // panelAssignmentsView
            // 
            this.panelAssignmentsView.Controls.Add(this.CounterpartyGridView);
            this.panelAssignmentsView.Controls.Add(this.AssignmentGridView);
            this.panelAssignmentsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignmentsView.Location = new System.Drawing.Point(340, 0);
            this.panelAssignmentsView.Name = "panelAssignmentsView";
            this.panelAssignmentsView.Size = new System.Drawing.Size(613, 484);
            this.panelAssignmentsView.TabIndex = 4;
            // 
            // CounterpartyGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CounterpartyGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CounterpartyGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CounterpartyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CounterpartyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CounterpartyGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CounterpartyGridView.Location = new System.Drawing.Point(0, 130);
            this.CounterpartyGridView.Name = "CounterpartyGridView";
            this.CounterpartyGridView.RowTemplate.Height = 25;
            this.CounterpartyGridView.Size = new System.Drawing.Size(613, 354);
            this.CounterpartyGridView.TabIndex = 1;
            // 
            // AssignmentGridView
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AssignmentGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.AssignmentGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssignmentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AssignmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentGridView.Location = new System.Drawing.Point(0, 0);
            this.AssignmentGridView.Name = "AssignmentGridView";
            this.AssignmentGridView.RowTemplate.Height = 25;
            this.AssignmentGridView.Size = new System.Drawing.Size(613, 484);
            this.AssignmentGridView.TabIndex = 2;
            // 
            // panelAccountControls
            // 
            this.panelAccountControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.panelAccountControls.Controls.Add(this.labelAssignmentOutput);
            this.panelAccountControls.Controls.Add(this.buttonAssignmentDelete);
            this.panelAccountControls.Controls.Add(this.buttonAssignmentEdit);
            this.panelAccountControls.Controls.Add(this.buttonAssignmentAdd);
            this.panelAccountControls.Controls.Add(this.labelAccountPassword);
            this.panelAccountControls.Controls.Add(this.labelAssignmentstCounterpartyID);
            this.panelAccountControls.Controls.Add(this.textBoxAssignmentDate);
            this.panelAccountControls.Controls.Add(this.textBoxAssignmentCounterpartyID);
            this.panelAccountControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAccountControls.Location = new System.Drawing.Point(0, 0);
            this.panelAccountControls.Name = "panelAccountControls";
            this.panelAccountControls.Size = new System.Drawing.Size(340, 484);
            this.panelAccountControls.TabIndex = 2;
            // 
            // labelAssignmentOutput
            // 
            this.labelAssignmentOutput.AutoSize = true;
            this.labelAssignmentOutput.Font = new System.Drawing.Font("Clear Sans Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAssignmentOutput.Location = new System.Drawing.Point(13, 7);
            this.labelAssignmentOutput.Name = "labelAssignmentOutput";
            this.labelAssignmentOutput.Size = new System.Drawing.Size(50, 18);
            this.labelAssignmentOutput.TabIndex = 3;
            this.labelAssignmentOutput.Text = "label1";
            this.labelAssignmentOutput.Visible = false;
            // 
            // buttonAssignmentDelete
            // 
            this.buttonAssignmentDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAssignmentDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAssignmentDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignmentDelete.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAssignmentDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonAssignmentDelete.Location = new System.Drawing.Point(247, 107);
            this.buttonAssignmentDelete.Name = "buttonAssignmentDelete";
            this.buttonAssignmentDelete.Size = new System.Drawing.Size(87, 40);
            this.buttonAssignmentDelete.TabIndex = 2;
            this.buttonAssignmentDelete.Text = "Delete";
            this.buttonAssignmentDelete.UseVisualStyleBackColor = false;
            this.buttonAssignmentDelete.Click += new System.EventHandler(this.buttonAssignmenttDelete_Click);
            // 
            // buttonAssignmentEdit
            // 
            this.buttonAssignmentEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAssignmentEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAssignmentEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignmentEdit.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAssignmentEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonAssignmentEdit.Location = new System.Drawing.Point(154, 107);
            this.buttonAssignmentEdit.Name = "buttonAssignmentEdit";
            this.buttonAssignmentEdit.Size = new System.Drawing.Size(87, 40);
            this.buttonAssignmentEdit.TabIndex = 2;
            this.buttonAssignmentEdit.Text = "Edit";
            this.buttonAssignmentEdit.UseVisualStyleBackColor = false;
            this.buttonAssignmentEdit.Click += new System.EventHandler(this.buttonAssignmentEdit_Click);
            // 
            // buttonAssignmentAdd
            // 
            this.buttonAssignmentAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAssignmentAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonAssignmentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignmentAdd.Font = new System.Drawing.Font("Clear Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAssignmentAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.buttonAssignmentAdd.Location = new System.Drawing.Point(61, 107);
            this.buttonAssignmentAdd.Name = "buttonAssignmentAdd";
            this.buttonAssignmentAdd.Size = new System.Drawing.Size(87, 40);
            this.buttonAssignmentAdd.TabIndex = 2;
            this.buttonAssignmentAdd.Text = "Add";
            this.buttonAssignmentAdd.UseVisualStyleBackColor = false;
            this.buttonAssignmentAdd.Click += new System.EventHandler(this.buttonAssignmentAdd_Click);
            // 
            // labelAccountPassword
            // 
            this.labelAccountPassword.AutoSize = true;
            this.labelAccountPassword.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountPassword.Location = new System.Drawing.Point(12, 72);
            this.labelAccountPassword.Name = "labelAccountPassword";
            this.labelAccountPassword.Size = new System.Drawing.Size(49, 22);
            this.labelAccountPassword.TabIndex = 1;
            this.labelAccountPassword.Text = "Date:";
            // 
            // labelAssignmentstCounterpartyID
            // 
            this.labelAssignmentstCounterpartyID.AutoSize = true;
            this.labelAssignmentstCounterpartyID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAssignmentstCounterpartyID.Location = new System.Drawing.Point(12, 37);
            this.labelAssignmentstCounterpartyID.Name = "labelAssignmentstCounterpartyID";
            this.labelAssignmentstCounterpartyID.Size = new System.Drawing.Size(133, 22);
            this.labelAssignmentstCounterpartyID.TabIndex = 1;
            this.labelAssignmentstCounterpartyID.Text = "CounterpartyID:";
            // 
            // textBoxAssignmentDate
            // 
            this.textBoxAssignmentDate.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAssignmentDate.Location = new System.Drawing.Point(147, 72);
            this.textBoxAssignmentDate.Name = "textBoxAssignmentDate";
            this.textBoxAssignmentDate.Size = new System.Drawing.Size(187, 29);
            this.textBoxAssignmentDate.TabIndex = 0;
            // 
            // textBoxAssignmentCounterpartyID
            // 
            this.textBoxAssignmentCounterpartyID.Font = new System.Drawing.Font("Fog Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAssignmentCounterpartyID.Location = new System.Drawing.Point(147, 37);
            this.textBoxAssignmentCounterpartyID.Name = "textBoxAssignmentCounterpartyID";
            this.textBoxAssignmentCounterpartyID.Size = new System.Drawing.Size(187, 29);
            this.textBoxAssignmentCounterpartyID.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 572);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAssignment";
            this.Text = "AssignmentForm";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelAssignmentsView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CounterpartyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignmentGridView)).EndInit();
            this.panelAccountControls.ResumeLayout(false);
            this.panelAccountControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAssignment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAccountControls;
        private System.Windows.Forms.Label labelAssignmentOutput;
        private System.Windows.Forms.Button buttonAssignmentDelete;
        private System.Windows.Forms.Button buttonAssignmentEdit;
        private System.Windows.Forms.Button buttonAssignmentAdd;
        private System.Windows.Forms.Label labelAccountPassword;
        private System.Windows.Forms.Label labelAssignmentstCounterpartyID;
        private System.Windows.Forms.TextBox textBoxAssignmentDate;
        private System.Windows.Forms.TextBox textBoxAssignmentCounterpartyID;
        private System.Windows.Forms.Panel panelAssignmentsView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView CounterpartyGridView;
        private System.Windows.Forms.DataGridView AssignmentGridView;
    }
}