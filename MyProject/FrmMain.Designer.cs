namespace MyProject
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新增专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitPanel = new System.Windows.Forms.Panel();
            this.exitPB = new System.Windows.Forms.PictureBox();
            this.exitLB = new System.Windows.Forms.Label();
            this.patentModifyPB = new System.Windows.Forms.PictureBox();
            this.patentDeletePB = new System.Windows.Forms.PictureBox();
            this.patentAddPB = new System.Windows.Forms.PictureBox();
            this.patentSearchLB = new System.Windows.Forms.Label();
            this.patentSearchPB = new System.Windows.Forms.PictureBox();
            this.patentModifyLB = new System.Windows.Forms.Label();
            this.patentDeleteLB = new System.Windows.Forms.Label();
            this.patentAddLB = new System.Windows.Forms.Label();
            this.mdiPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.exitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentModifyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentDeletePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentAddPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentSearchPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.日志操作ToolStripMenuItem,
            this.数据查询ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 日志操作ToolStripMenuItem
            // 
            this.日志操作ToolStripMenuItem.Name = "日志操作ToolStripMenuItem";
            this.日志操作ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.日志操作ToolStripMenuItem.Text = "日志操作";
            // 
            // 数据查询ToolStripMenuItem
            // 
            this.数据查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据查询ToolStripMenuItem1,
            this.新增专利ToolStripMenuItem,
            this.删除专利ToolStripMenuItem,
            this.修改专利ToolStripMenuItem});
            this.数据查询ToolStripMenuItem.Name = "数据查询ToolStripMenuItem";
            this.数据查询ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.数据查询ToolStripMenuItem.Text = "专利数据操作";
            // 
            // 数据查询ToolStripMenuItem1
            // 
            this.数据查询ToolStripMenuItem1.Name = "数据查询ToolStripMenuItem1";
            this.数据查询ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.数据查询ToolStripMenuItem1.Text = "专利查询";
            this.数据查询ToolStripMenuItem1.Click += new System.EventHandler(this.数据查询ToolStripMenuItem1_Click);
            // 
            // 新增专利ToolStripMenuItem
            // 
            this.新增专利ToolStripMenuItem.Name = "新增专利ToolStripMenuItem";
            this.新增专利ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新增专利ToolStripMenuItem.Text = "新增专利";
            this.新增专利ToolStripMenuItem.Click += new System.EventHandler(this.新增专利ToolStripMenuItem_Click);
            // 
            // 删除专利ToolStripMenuItem
            // 
            this.删除专利ToolStripMenuItem.Name = "删除专利ToolStripMenuItem";
            this.删除专利ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.删除专利ToolStripMenuItem.Text = "删除专利";
            this.删除专利ToolStripMenuItem.Click += new System.EventHandler(this.删除专利ToolStripMenuItem_Click);
            // 
            // 修改专利ToolStripMenuItem
            // 
            this.修改专利ToolStripMenuItem.Name = "修改专利ToolStripMenuItem";
            this.修改专利ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.修改专利ToolStripMenuItem.Text = "修改专利";
            this.修改专利ToolStripMenuItem.Click += new System.EventHandler(this.修改专利ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(125)))), ((int)(((byte)(191)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMain,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1253, 25);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(167, 20);
            this.toolStripMain.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1058, 20);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "由创想工作室提供技术支持";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.AutoSize = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.exitPanel);
            this.menuPanel.Controls.Add(this.patentModifyPB);
            this.menuPanel.Controls.Add(this.patentDeletePB);
            this.menuPanel.Controls.Add(this.patentAddPB);
            this.menuPanel.Controls.Add(this.patentSearchLB);
            this.menuPanel.Controls.Add(this.patentSearchPB);
            this.menuPanel.Controls.Add(this.patentModifyLB);
            this.menuPanel.Controls.Add(this.patentDeleteLB);
            this.menuPanel.Controls.Add(this.patentAddLB);
            this.menuPanel.Location = new System.Drawing.Point(0, 31);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1253, 90);
            this.menuPanel.TabIndex = 7;
            // 
            // exitPanel
            // 
            this.exitPanel.Controls.Add(this.exitPB);
            this.exitPanel.Controls.Add(this.exitLB);
            this.exitPanel.Location = new System.Drawing.Point(592, 3);
            this.exitPanel.Name = "exitPanel";
            this.exitPanel.Size = new System.Drawing.Size(90, 80);
            this.exitPanel.TabIndex = 21;
            this.exitPanel.MouseEnter += new System.EventHandler(this.exitPanel_MouseEnter);
            this.exitPanel.MouseLeave += new System.EventHandler(this.exitPanel_MouseLeave);
            // 
            // exitPB
            // 
            this.exitPB.Image = ((System.Drawing.Image)(resources.GetObject("exitPB.Image")));
            this.exitPB.Location = new System.Drawing.Point(14, 0);
            this.exitPB.Name = "exitPB";
            this.exitPB.Size = new System.Drawing.Size(62, 56);
            this.exitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPB.TabIndex = 20;
            this.exitPB.TabStop = false;
            this.exitPB.Click += new System.EventHandler(this.exitPB_Click);
            this.exitPB.MouseEnter += new System.EventHandler(this.exitPB_MouseEnter);
            this.exitPB.MouseLeave += new System.EventHandler(this.exitPB_MouseLeave);
            // 
            // exitLB
            // 
            this.exitLB.AutoSize = true;
            this.exitLB.Font = new System.Drawing.Font("隶书", 10F);
            this.exitLB.Location = new System.Drawing.Point(5, 59);
            this.exitLB.Name = "exitLB";
            this.exitLB.Size = new System.Drawing.Size(80, 17);
            this.exitLB.TabIndex = 14;
            this.exitLB.Text = "退出系统";
            // 
            // patentModifyPB
            // 
            this.patentModifyPB.Image = ((System.Drawing.Image)(resources.GetObject("patentModifyPB.Image")));
            this.patentModifyPB.Location = new System.Drawing.Point(314, 3);
            this.patentModifyPB.Name = "patentModifyPB";
            this.patentModifyPB.Size = new System.Drawing.Size(60, 56);
            this.patentModifyPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patentModifyPB.TabIndex = 19;
            this.patentModifyPB.TabStop = false;
            this.patentModifyPB.Click += new System.EventHandler(this.patentModifyPB_Click);
            // 
            // patentDeletePB
            // 
            this.patentDeletePB.Image = ((System.Drawing.Image)(resources.GetObject("patentDeletePB.Image")));
            this.patentDeletePB.Location = new System.Drawing.Point(454, 3);
            this.patentDeletePB.Name = "patentDeletePB";
            this.patentDeletePB.Size = new System.Drawing.Size(58, 56);
            this.patentDeletePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patentDeletePB.TabIndex = 18;
            this.patentDeletePB.TabStop = false;
            this.patentDeletePB.Click += new System.EventHandler(this.patentDeletePB_Click);
            // 
            // patentAddPB
            // 
            this.patentAddPB.Image = ((System.Drawing.Image)(resources.GetObject("patentAddPB.Image")));
            this.patentAddPB.Location = new System.Drawing.Point(176, 3);
            this.patentAddPB.Name = "patentAddPB";
            this.patentAddPB.Size = new System.Drawing.Size(58, 56);
            this.patentAddPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patentAddPB.TabIndex = 17;
            this.patentAddPB.TabStop = false;
            this.patentAddPB.Click += new System.EventHandler(this.patentAddPB_Click);
            // 
            // patentSearchLB
            // 
            this.patentSearchLB.AutoSize = true;
            this.patentSearchLB.Font = new System.Drawing.Font("隶书", 10F);
            this.patentSearchLB.Location = new System.Drawing.Point(30, 66);
            this.patentSearchLB.Name = "patentSearchLB";
            this.patentSearchLB.Size = new System.Drawing.Size(80, 17);
            this.patentSearchLB.TabIndex = 16;
            this.patentSearchLB.Text = "专利查询";
            // 
            // patentSearchPB
            // 
            this.patentSearchPB.Image = ((System.Drawing.Image)(resources.GetObject("patentSearchPB.Image")));
            this.patentSearchPB.Location = new System.Drawing.Point(40, 3);
            this.patentSearchPB.Name = "patentSearchPB";
            this.patentSearchPB.Size = new System.Drawing.Size(56, 56);
            this.patentSearchPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.patentSearchPB.TabIndex = 15;
            this.patentSearchPB.TabStop = false;
            this.patentSearchPB.Click += new System.EventHandler(this.patentSearchPB_Click);
            // 
            // patentModifyLB
            // 
            this.patentModifyLB.AutoSize = true;
            this.patentModifyLB.Font = new System.Drawing.Font("隶书", 10F);
            this.patentModifyLB.Location = new System.Drawing.Point(306, 66);
            this.patentModifyLB.Name = "patentModifyLB";
            this.patentModifyLB.Size = new System.Drawing.Size(80, 17);
            this.patentModifyLB.TabIndex = 12;
            this.patentModifyLB.Text = "修改专利";
            // 
            // patentDeleteLB
            // 
            this.patentDeleteLB.AutoSize = true;
            this.patentDeleteLB.Font = new System.Drawing.Font("隶书", 10F);
            this.patentDeleteLB.Location = new System.Drawing.Point(445, 66);
            this.patentDeleteLB.Name = "patentDeleteLB";
            this.patentDeleteLB.Size = new System.Drawing.Size(80, 17);
            this.patentDeleteLB.TabIndex = 11;
            this.patentDeleteLB.Text = "删除专利";
            // 
            // patentAddLB
            // 
            this.patentAddLB.AutoSize = true;
            this.patentAddLB.Font = new System.Drawing.Font("隶书", 10F);
            this.patentAddLB.Location = new System.Drawing.Point(168, 66);
            this.patentAddLB.Name = "patentAddLB";
            this.patentAddLB.Size = new System.Drawing.Size(80, 17);
            this.patentAddLB.TabIndex = 10;
            this.patentAddLB.Text = "新增专利";
            // 
            // mdiPanel
            // 
            this.mdiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdiPanel.Location = new System.Drawing.Point(0, 131);
            this.mdiPanel.Name = "mdiPanel";
            this.mdiPanel.Size = new System.Drawing.Size(1253, 434);
            this.mdiPanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(754, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 80);
            this.panel1.TabIndex = 22;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 593);
            this.Controls.Add(this.mdiPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "欢迎来到知识产权管理系统！";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.exitPanel.ResumeLayout(false);
            this.exitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentModifyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentDeletePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentAddPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentSearchPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMain;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label patentDeleteLB;
        private System.Windows.Forms.Label patentAddLB;
        private System.Windows.Forms.Label exitLB;
        private System.Windows.Forms.Label patentModifyLB;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新增专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Panel mdiPanel;
        private System.Windows.Forms.PictureBox patentAddPB;
        private System.Windows.Forms.Label patentSearchLB;
        private System.Windows.Forms.PictureBox patentSearchPB;
        private System.Windows.Forms.PictureBox patentDeletePB;
        private System.Windows.Forms.PictureBox patentModifyPB;
        private System.Windows.Forms.PictureBox exitPB;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel exitPanel;
        private System.Windows.Forms.Panel panel1;
    }
}