
namespace RECIManagementSoftware
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.lable_MainWindow = new System.Windows.Forms.Label();
            this.panel_Middle = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip_ConnectionLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_isConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_ObjectControl = new System.Windows.Forms.Panel();
            this.panel_ObjectView = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel_Upper.SuspendLayout();
            this.panel_Middle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Upper
            // 
            this.panel_Upper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel_Upper.Controls.Add(this.toolStrip1);
            this.panel_Upper.Controls.Add(this.lable_MainWindow);
            this.panel_Upper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Upper.Location = new System.Drawing.Point(0, 0);
            this.panel_Upper.Name = "panel_Upper";
            this.panel_Upper.Size = new System.Drawing.Size(959, 94);
            this.panel_Upper.TabIndex = 0;
            // 
            // lable_MainWindow
            // 
            this.lable_MainWindow.AutoSize = true;
            this.lable_MainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lable_MainWindow.Font = new System.Drawing.Font("Fog Sans", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lable_MainWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(225)))));
            this.lable_MainWindow.Location = new System.Drawing.Point(0, 0);
            this.lable_MainWindow.Name = "lable_MainWindow";
            this.lable_MainWindow.Size = new System.Drawing.Size(502, 50);
            this.lable_MainWindow.TabIndex = 0;
            this.lable_MainWindow.Text = "RECI Management Software";
            // 
            // panel_Middle
            // 
            this.panel_Middle.Controls.Add(this.panel_ObjectView);
            this.panel_Middle.Controls.Add(this.panel_ObjectControl);
            this.panel_Middle.Controls.Add(this.statusStrip1);
            this.panel_Middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Middle.Location = new System.Drawing.Point(0, 94);
            this.panel_Middle.Name = "panel_Middle";
            this.panel_Middle.Size = new System.Drawing.Size(959, 446);
            this.panel_Middle.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_ConnectionLable,
            this.statusStrip_isConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(959, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip_ConnectionLable
            // 
            this.statusStrip_ConnectionLable.Name = "statusStrip_ConnectionLable";
            this.statusStrip_ConnectionLable.Size = new System.Drawing.Size(107, 17);
            this.statusStrip_ConnectionLable.Text = "Connection Status:";
            // 
            // statusStrip_isConnectionStatus
            // 
            this.statusStrip_isConnectionStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this.statusStrip_isConnectionStatus.Name = "statusStrip_isConnectionStatus";
            this.statusStrip_isConnectionStatus.Size = new System.Drawing.Size(57, 17);
            this.statusStrip_isConnectionStatus.Text = "unknown";
            // 
            // panel_ObjectControl
            // 
            this.panel_ObjectControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ObjectControl.Location = new System.Drawing.Point(0, 0);
            this.panel_ObjectControl.Name = "panel_ObjectControl";
            this.panel_ObjectControl.Size = new System.Drawing.Size(200, 424);
            this.panel_ObjectControl.TabIndex = 1;
            // 
            // panel_ObjectView
            // 
            this.panel_ObjectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ObjectView.Location = new System.Drawing.Point(200, 0);
            this.panel_ObjectView.Name = "panel_ObjectView";
            this.panel_ObjectView.Size = new System.Drawing.Size(759, 424);
            this.panel_ObjectView.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(0, 69);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 540);
            this.Controls.Add(this.panel_Middle);
            this.Controls.Add(this.panel_Upper);
            this.Name = "MainWindow";
            this.Text = "RECI";
            this.panel_Upper.ResumeLayout(false);
            this.panel_Upper.PerformLayout();
            this.panel_Middle.ResumeLayout(false);
            this.panel_Middle.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Upper;
        private System.Windows.Forms.Panel panel_Middle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lable_MainWindow;
        private System.Windows.Forms.Panel panel_ObjectControl;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_ConnectionLable;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_isConnectionStatus;
        private System.Windows.Forms.Panel panel_ObjectView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_isConnectionStatus;
    }
}

