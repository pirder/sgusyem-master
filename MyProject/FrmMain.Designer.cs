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
            this.日志操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新增专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitPB = new System.Windows.Forms.PictureBox();
            this.patentModifyPB = new System.Windows.Forms.PictureBox();
            this.patentDeletePB = new System.Windows.Forms.PictureBox();
            this.patentAddPB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patentSearchPB = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mdiPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuPanel.SuspendLayout();
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
            this.日志操作ToolStripMenuItem,
            this.系统管理ToolStripMenuItem,
            this.数据查询ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 日志操作ToolStripMenuItem
            // 
            this.日志操作ToolStripMenuItem.Name = "日志操作ToolStripMenuItem";
            this.日志操作ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.日志操作ToolStripMenuItem.Text = "用户管理";
            this.日志操作ToolStripMenuItem.Click += new System.EventHandler(this.日志操作ToolStripMenuItem_Click);
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.系统管理ToolStripMenuItem.Text = "日志操作";
            this.系统管理ToolStripMenuItem.Click += new System.EventHandler(this.系统管理ToolStripMenuItem_Click);
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoToolTip = true;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Padding = new System.Windows.Forms.Padding(600, 0, 0, 0);
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(789, 20);
            this.toolStripStatusLabel2.Text = "由创想工作室提供技术支持";
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.AutoSize = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.exitPB);
            this.menuPanel.Controls.Add(this.patentModifyPB);
            this.menuPanel.Controls.Add(this.patentDeletePB);
            this.menuPanel.Controls.Add(this.patentAddPB);
            this.menuPanel.Controls.Add(this.label4);
            this.menuPanel.Controls.Add(this.patentSearchPB);
            this.menuPanel.Controls.Add(this.label5);
            this.menuPanel.Controls.Add(this.label3);
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Location = new System.Drawing.Point(0, 31);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1253, 153);
            this.menuPanel.TabIndex = 7;
            // 
            // exitPB
            // 
            this.exitPB.Image = ((System.Drawing.Image)(resources.GetObject("exitPB.Image")));
            this.exitPB.Location = new System.Drawing.Point(848, 3);
            this.exitPB.Name = "exitPB";
            this.exitPB.Size = new System.Drawing.Size(143, 113);
            this.exitPB.TabIndex = 20;
            this.exitPB.TabStop = false;
            this.exitPB.Click += new System.EventHandler(this.exitPB_Click);
            // 
            // patentModifyPB
            // 
            this.patentModifyPB.Image = ((System.Drawing.Image)(resources.GetObject("patentModifyPB.Image")));
            this.patentModifyPB.Location = new System.Drawing.Point(420, 3);
            this.patentModifyPB.Name = "patentModifyPB";
            this.patentModifyPB.Size = new System.Drawing.Size(129, 112);
            this.patentModifyPB.TabIndex = 19;
            this.patentModifyPB.TabStop = false;
            this.patentModifyPB.Click += new System.EventHandler(this.patentModifyPB_Click);
            // 
            // patentDeletePB
            // 
            this.patentDeletePB.Image = ((System.Drawing.Image)(resources.GetObject("patentDeletePB.Image")));
            this.patentDeletePB.Location = new System.Drawing.Point(629, 3);
            this.patentDeletePB.Name = "patentDeletePB";
            this.patentDeletePB.Size = new System.Drawing.Size(139, 117);
            this.patentDeletePB.TabIndex = 18;
            this.patentDeletePB.TabStop = false;
            this.patentDeletePB.Click += new System.EventHandler(this.patentDeletePB_Click);
            // 
            // patentAddPB
            // 
            this.patentAddPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patentAddPB.Image = ((System.Drawing.Image)(resources.GetObject("patentAddPB.Image")));
            this.patentAddPB.Location = new System.Drawing.Point(224, 10);
            this.patentAddPB.Name = "patentAddPB";
            this.patentAddPB.Size = new System.Drawing.Size(119, 108);
            this.patentAddPB.TabIndex = 17;
            this.patentAddPB.TabStop = false;
            this.patentAddPB.Click += new System.EventHandler(this.patentAddPB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 14F);
            this.label4.Location = new System.Drawing.Point(36, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "专利查询";
            // 
            // patentSearchPB
            // 
            this.patentSearchPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patentSearchPB.Image = ((System.Drawing.Image)(resources.GetObject("patentSearchPB.Image")));
            this.patentSearchPB.Location = new System.Drawing.Point(40, 7);
            this.patentSearchPB.Name = "patentSearchPB";
            this.patentSearchPB.Size = new System.Drawing.Size(101, 108);
            this.patentSearchPB.TabIndex = 15;
            this.patentSearchPB.TabStop = false;
            this.patentSearchPB.Click += new System.EventHandler(this.patentSearchPB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 14F);
            this.label5.Location = new System.Drawing.Point(844, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "退出系统";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 14F);
            this.label3.Location = new System.Drawing.Point(425, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "修改专利";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 14F);
            this.label2.Location = new System.Drawing.Point(635, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "删除专利";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 14F);
            this.label1.Location = new System.Drawing.Point(222, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "新增专利";
            // 
            // mdiPanel
            // 
            this.mdiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdiPanel.Location = new System.Drawing.Point(12, 190);
            this.mdiPanel.Name = "mdiPanel";
            this.mdiPanel.Size = new System.Drawing.Size(1229, 365);
            this.mdiPanel.TabIndex = 10;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 日志操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 数据查询ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新增专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.Panel mdiPanel;
        private System.Windows.Forms.PictureBox patentAddPB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox patentSearchPB;
        private System.Windows.Forms.PictureBox patentDeletePB;
        private System.Windows.Forms.PictureBox patentModifyPB;
        private System.Windows.Forms.PictureBox exitPB;
    }
}