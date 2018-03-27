namespace MyProject
{
    partial class MDIParent1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.专利查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除专利ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.exitPB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patentDeletePB = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patentModifyPB = new System.Windows.Forms.PictureBox();
            this.patentAddPB = new System.Windows.Forms.PictureBox();
            this.patentSearchPB = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentDeletePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentModifyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentAddPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentSearchPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(159)))), ((int)(((byte)(215)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(948, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(81, 24);
            this.fileMenu.Text = "用户管理";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(81, 24);
            this.editMenu.Text = "日志操作";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.专利查询ToolStripMenuItem,
            this.新增专利ToolStripMenuItem,
            this.修改专利ToolStripMenuItem,
            this.删除专利ToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(111, 24);
            this.viewMenu.Text = "专利数据操作";
            // 
            // 专利查询ToolStripMenuItem
            // 
            this.专利查询ToolStripMenuItem.Name = "专利查询ToolStripMenuItem";
            this.专利查询ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.专利查询ToolStripMenuItem.Text = "专利查询";
            // 
            // 新增专利ToolStripMenuItem
            // 
            this.新增专利ToolStripMenuItem.Name = "新增专利ToolStripMenuItem";
            this.新增专利ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新增专利ToolStripMenuItem.Text = "新增专利";
            // 
            // 修改专利ToolStripMenuItem
            // 
            this.修改专利ToolStripMenuItem.Name = "修改专利ToolStripMenuItem";
            this.修改专利ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.修改专利ToolStripMenuItem.Text = "修改专利";
            // 
            // 删除专利ToolStripMenuItem
            // 
            this.删除专利ToolStripMenuItem.Name = "删除专利ToolStripMenuItem";
            this.删除专利ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.删除专利ToolStripMenuItem.Text = "删除专利";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(73, 24);
            this.helpMenu.Text = "帮助(&H)";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.contentsToolStripMenuItem.Text = "目录(&C)";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.indexToolStripMenuItem.Text = "索引(&I)";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.searchToolStripMenuItem.Text = "搜索(&S)";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(194, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.aboutToolStripMenuItem.Text = "关于(&A) ... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 568);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exitPB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.patentDeletePB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.patentModifyPB);
            this.panel1.Controls.Add(this.patentAddPB);
            this.panel1.Controls.Add(this.patentSearchPB);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 141);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 14F);
            this.label5.Location = new System.Drawing.Point(629, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "退出系统";
            // 
            // exitPB
            // 
            this.exitPB.Image = ((System.Drawing.Image)(resources.GetObject("exitPB.Image")));
            this.exitPB.Location = new System.Drawing.Point(629, 6);
            this.exitPB.Name = "exitPB";
            this.exitPB.Size = new System.Drawing.Size(89, 94);
            this.exitPB.TabIndex = 11;
            this.exitPB.TabStop = false;
            this.exitPB.Click += new System.EventHandler(this.exitPB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 14F);
            this.label4.Location = new System.Drawing.Point(465, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "删除专利";
            // 
            // patentDeletePB
            // 
            this.patentDeletePB.Image = ((System.Drawing.Image)(resources.GetObject("patentDeletePB.Image")));
            this.patentDeletePB.Location = new System.Drawing.Point(469, 6);
            this.patentDeletePB.Name = "patentDeletePB";
            this.patentDeletePB.Size = new System.Drawing.Size(94, 94);
            this.patentDeletePB.TabIndex = 9;
            this.patentDeletePB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 14F);
            this.label3.Location = new System.Drawing.Point(307, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "修改专利";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 14F);
            this.label2.Location = new System.Drawing.Point(154, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "新增专利";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 14F);
            this.label1.Location = new System.Drawing.Point(10, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "专利查询";
            // 
            // patentModifyPB
            // 
            this.patentModifyPB.Image = ((System.Drawing.Image)(resources.GetObject("patentModifyPB.Image")));
            this.patentModifyPB.Location = new System.Drawing.Point(311, 6);
            this.patentModifyPB.Name = "patentModifyPB";
            this.patentModifyPB.Size = new System.Drawing.Size(97, 94);
            this.patentModifyPB.TabIndex = 4;
            this.patentModifyPB.TabStop = false;
            // 
            // patentAddPB
            // 
            this.patentAddPB.Image = ((System.Drawing.Image)(resources.GetObject("patentAddPB.Image")));
            this.patentAddPB.Location = new System.Drawing.Point(158, 6);
            this.patentAddPB.Name = "patentAddPB";
            this.patentAddPB.Size = new System.Drawing.Size(89, 94);
            this.patentAddPB.TabIndex = 2;
            this.patentAddPB.TabStop = false;
            // 
            // patentSearchPB
            // 
            this.patentSearchPB.Image = ((System.Drawing.Image)(resources.GetObject("patentSearchPB.Image")));
            this.patentSearchPB.Location = new System.Drawing.Point(14, 10);
            this.patentSearchPB.Name = "patentSearchPB";
            this.patentSearchPB.Size = new System.Drawing.Size(85, 90);
            this.patentSearchPB.TabIndex = 0;
            this.patentSearchPB.TabStop = false;
            this.patentSearchPB.Click += new System.EventHandler(this.patentSearchPB_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(12, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 380);
            this.panel2.TabIndex = 6;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(948, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MDIParent1";
            this.Text = "欢迎来到知识产权管理系统！";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent1_FormClosed);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentDeletePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentModifyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentAddPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patentSearchPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox patentSearchPB;
        private System.Windows.Forms.PictureBox patentAddPB;
        private System.Windows.Forms.PictureBox patentModifyPB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox patentDeletePB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox exitPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem 专利查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改专利ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除专利ToolStripMenuItem;
    }
}



