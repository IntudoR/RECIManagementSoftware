
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Account");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Assignment");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Client");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Contract");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Counterparty");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Counterparty contract");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Employee");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Order");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Property");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Rental");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Subscription");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Vault");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tables", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.panel_Upper = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsButton_Logout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsButton_Show = new System.Windows.Forms.ToolStripButton();
            this.tsButton_Close = new System.Windows.Forms.ToolStripButton();
            this.lable_MainWindow = new System.Windows.Forms.Label();
            this.panel_Middle = new System.Windows.Forms.Panel();
            this.panel_ObjectView = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel_ObjectControl = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip_ConnectionLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_isConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Upper.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_Middle.SuspendLayout();
            this.panel_ObjectView.SuspendLayout();
            this.panel_ObjectControl.SuspendLayout();
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
            this.panel_Upper.Size = new System.Drawing.Size(1430, 94);
            this.panel_Upper.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsButton_Logout,
            this.toolStripSeparator1,
            this.tsButton_Show,
            this.tsButton_Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 69);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1430, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsButton_Logout
            // 
            this.tsButton_Logout.Image = ((System.Drawing.Image)(resources.GetObject("tsButton_Logout.Image")));
            this.tsButton_Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton_Logout.Name = "tsButton_Logout";
            this.tsButton_Logout.Size = new System.Drawing.Size(66, 22);
            this.tsButton_Logout.Text = "Logout";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsButton_Show
            // 
            this.tsButton_Show.Image = ((System.Drawing.Image)(resources.GetObject("tsButton_Show.Image")));
            this.tsButton_Show.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton_Show.Name = "tsButton_Show";
            this.tsButton_Show.Size = new System.Drawing.Size(58, 22);
            this.tsButton_Show.Text = "Show";
            // 
            // tsButton_Close
            // 
            this.tsButton_Close.Image = ((System.Drawing.Image)(resources.GetObject("tsButton_Close.Image")));
            this.tsButton_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsButton_Close.Name = "tsButton_Close";
            this.tsButton_Close.Size = new System.Drawing.Size(58, 22);
            this.tsButton_Close.Text = "Close";
            this.tsButton_Close.ToolTipText = "Close";
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
            this.panel_Middle.Size = new System.Drawing.Size(1430, 765);
            this.panel_Middle.TabIndex = 1;
            // 
            // panel_ObjectView
            // 
            this.panel_ObjectView.BackColor = System.Drawing.SystemColors.Control;
            this.panel_ObjectView.Controls.Add(this.tabControl1);
            this.panel_ObjectView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ObjectView.Location = new System.Drawing.Point(200, 0);
            this.panel_ObjectView.Name = "panel_ObjectView";
            this.panel_ObjectView.Size = new System.Drawing.Size(1230, 743);
            this.panel_ObjectView.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 743);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // panel_ObjectControl
            // 
            this.panel_ObjectControl.Controls.Add(this.treeView1);
            this.panel_ObjectControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ObjectControl.Location = new System.Drawing.Point(0, 0);
            this.panel_ObjectControl.Name = "panel_ObjectControl";
            this.panel_ObjectControl.Size = new System.Drawing.Size(200, 743);
            this.panel_ObjectControl.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.AliceBlue;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeAccount";
            treeNode1.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Account";
            treeNode2.Name = "NodeAssignments";
            treeNode2.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Assignment";
            treeNode3.Name = "NodeClient";
            treeNode3.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Client";
            treeNode4.Name = "NodeContract";
            treeNode4.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Contract";
            treeNode5.Name = "NodeCounterparty";
            treeNode5.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Counterparty";
            treeNode6.Name = "NodeCpContract";
            treeNode6.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Counterparty contract";
            treeNode7.Name = "NodeEmployee";
            treeNode7.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "Employee";
            treeNode8.Name = "NodeOrder";
            treeNode8.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "Order";
            treeNode9.Name = "NodeProperty";
            treeNode9.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "Property";
            treeNode10.Name = "NodeRental";
            treeNode10.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode10.Text = "Rental";
            treeNode11.Name = "NodeSubscription";
            treeNode11.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode11.Text = "Subscription";
            treeNode12.Name = "NodeVault";
            treeNode12.NodeFont = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode12.Text = "Vault";
            treeNode13.Name = "NodeTables";
            treeNode13.NodeFont = new System.Drawing.Font("Clear Sans", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode13.Text = "Tables";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(200, 743);
            this.treeView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Clear Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_ConnectionLable,
            this.statusStrip_isConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 743);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1430, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip_ConnectionLable
            // 
            this.statusStrip_ConnectionLable.Name = "statusStrip_ConnectionLable";
            this.statusStrip_ConnectionLable.Size = new System.Drawing.Size(110, 17);
            this.statusStrip_ConnectionLable.Text = "Connection Status:";
            this.statusStrip_ConnectionLable.Visible = false;
            // 
            // statusStrip_isConnectionStatus
            // 
            this.statusStrip_isConnectionStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this.statusStrip_isConnectionStatus.Name = "statusStrip_isConnectionStatus";
            this.statusStrip_isConnectionStatus.Size = new System.Drawing.Size(58, 17);
            this.statusStrip_isConnectionStatus.Text = "unknown";
            this.statusStrip_isConnectionStatus.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 859);
            this.Controls.Add(this.panel_Middle);
            this.Controls.Add(this.panel_Upper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "RECI Management Software";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel_Upper.ResumeLayout(false);
            this.panel_Upper.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_Middle.ResumeLayout(false);
            this.panel_Middle.PerformLayout();
            this.panel_ObjectView.ResumeLayout(false);
            this.panel_ObjectControl.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton tsButton_Logout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsButton_Show;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripButton tsButton_Close;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

