using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyProject
{
    public partial class FrmMain : Form
    {
        int  limit = 1;
        public FrmMain(string num)
        {
            InitializeComponent();
            string sql = "select users_name from users where users_num = '" + num + "'";
            DataTable dt = new DataTable();
            dt = Program.GetDataTable(sql);
            DataRow dr = dt.Rows[0];
            string userName = dr["users_name"].ToString();
            toolStripMain.Text = "欢迎用户:" + userName + "进入韶关学院知识产权管理员管理系统";
        }
        public FrmMain(string num,int  limit)
        {
            InitializeComponent();
            this.limit = limit;
            string sql = "select users_name from users where users_num = '" + num + "'";
            DataTable dt = new DataTable();
            dt = Program.GetDataTable(sql);
            DataRow dr = dt.Rows[0];
            string userName = dr["users_name"].ToString();
            toolStripMain.Text = "欢迎用户:" + userName + "进入韶关学院知识产权管理员管理系统";
        }

       /* private void 数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i,toolStripMain.Text,limit);
            f.Show();

        }*/

    /*    private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 系统管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //尝试一下是否拉去成功
         
   /*     private void button1_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text,limit);
            f.Show();
        }*/


        private void 数据查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text, limit);
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void patentSearchPB_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text, limit);
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void patentAddPB_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void patentModifyPB_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text);
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void patentDeletePB_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text);
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void 新增专利ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void 删除专利ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text);
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void 修改专利ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text);
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = mdiPanel;
            f.Show();
        }

        private void exitPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 日志操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserManager um = new FrmUserManager();
            um.WindowState = FormWindowState.Maximized;

            //去掉边框
            um.FormBorderStyle = FormBorderStyle.None;

            um.MdiParent = this;

            //设置新窗体的Parent
            um.Parent = mdiPanel;
            //
            um.Show();
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            //遍历panel中的控件，
            foreach (var v in mdiPanel.Controls)
            {
                //如果是新窗体
                if (v is FrmMain)
                {
                    //新窗体先变为正常大小
                    (v as FrmMain).WindowState = FormWindowState.Normal;
                    //新窗体再变为最大化以适应新的Size
                    (v as FrmMain).WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}
