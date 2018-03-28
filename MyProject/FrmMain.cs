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
        int limit = 1;

        public static FrmSelect fmselect = null;
        public static FrmUserManager fmusermanager = null;
        public static FrmAdd fmadd =null;
        public Form[] frm = {fmselect, fmusermanager , fmadd };
        int fmselectindex = 0;
        int fmusermanggerindex = 1;
        int fmaddindex = 2;
        
       
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

            frm[fmusermanggerindex] = null;
            frm[fmaddindex] = null;
            if (frm[fmselectindex] != null)
            {
                frm[fmselectindex].Activate();
                return;
            }
            fmselect = new FrmSelect(0, limit);
            frm[fmselectindex] = fmselect;
            fmselect.WindowState = FormWindowState.Maximized;
            //去掉边框
            fmselect.FormBorderStyle = FormBorderStyle.None;
            fmselect.MdiParent = this;
            //设置新窗体的Parent
            fmselect.Parent = mdiPanel;
            fmselect.Show();
        }

        private void patentSearchPB_Click(object sender, EventArgs e)
        {

            frm[fmusermanggerindex] = null;
            frm[fmaddindex] = null;
            if (frm[fmselectindex] != null)
            {
                frm[fmselectindex].Activate();
                return;
            }
            fmselect = new FrmSelect(0, limit);
            frm[fmselectindex] = fmselect;
            fmselect.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmselect.FormBorderStyle = FormBorderStyle.None;

            fmselect.MdiParent = this;

            //设置新窗体的Parent
            fmselect.Parent = mdiPanel;
            fmselect.Show();
        }

        private void patentAddPB_Click(object sender, EventArgs e)
        {
            frm[fmusermanggerindex] = null;
            frm[fmselectindex] = null;
            if (frm[fmaddindex] != null)
            {
                frm[fmaddindex].Activate();
                return;
            }
            fmadd = new FrmAdd();
            frm[fmaddindex] = fmadd;
            fmadd.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmadd.FormBorderStyle = FormBorderStyle.None;

            fmadd.MdiParent = this;

            //设置新窗体的Parent
            fmadd.Parent = mdiPanel;
            fmadd.Show();
        }

        private void patentModifyPB_Click(object sender, EventArgs e)
        {


            frm[fmusermanggerindex] = null;
            frm[fmaddindex] = null;
            if (frm[fmselectindex] != null)
            {
                frm[fmselectindex].Activate();
                return;
            }
            fmselect = new FrmSelect(0, limit);
            frm[fmselectindex] = fmselect;
            fmselect.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmselect.FormBorderStyle = FormBorderStyle.None;

            fmselect.MdiParent = this;

            //设置新窗体的Parent
            fmselect.Parent = mdiPanel;
            fmselect.Show();
        }

        private void patentDeletePB_Click(object sender, EventArgs e)
        {

            frm[fmusermanggerindex] = null;
            frm[fmaddindex] = null;
            if (frm[fmselectindex] != null)
            {
                frm[fmselectindex].Activate();
                return;
            }
            fmselect = new FrmSelect(0, limit);
            frm[fmselectindex] = fmselect;
            fmselect.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmselect.FormBorderStyle = FormBorderStyle.None;

            fmselect.MdiParent = this;

            //设置新窗体的Parent
            fmselect.Parent = mdiPanel;
            fmselect.Show();
        }

        private void 新增专利ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm[fmusermanggerindex] = null;
            frm[fmselectindex] = null;
            if (frm[fmaddindex] != null)
            {
                frm[fmaddindex].Activate();
                return;
            }
            fmadd = new FrmAdd();
            frm[fmaddindex] = fmadd;
            fmadd.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmadd.FormBorderStyle = FormBorderStyle.None;

            fmadd.MdiParent = this;

            //设置新窗体的Parent
            fmadd.Parent = mdiPanel;
            fmadd.Show();
        }

        private void 删除专利ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frm[fmusermanggerindex] = null;
            frm[fmaddindex] = null;
            if (frm[fmselectindex] != null)
            {
                frm[fmselectindex].Activate();
                return;
            }
            fmselect = new FrmSelect(0, limit);
            frm[fmselectindex] = fmselect;
            fmselect.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmselect.FormBorderStyle = FormBorderStyle.None;

            fmselect.MdiParent = this;

            //设置新窗体的Parent
            fmselect.Parent = mdiPanel;
            fmselect.Show();
        }

        private void 修改专利ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frm[fmusermanggerindex] = null;
            frm[fmaddindex] = null;
            if (frm[fmselectindex] != null)
            {
                frm[fmselectindex].Activate();
                return;
            }
            fmselect = new FrmSelect(0, limit);
            frm[fmselectindex] = fmselect;
            fmselect.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmselect.FormBorderStyle = FormBorderStyle.None;

            fmselect.MdiParent = this;

            //设置新窗体的Parent
            fmselect.Parent = mdiPanel;
            fmselect.Show();
        }

        private void exitPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {

            //遍历panel中的控件，
            /*  foreach (var v in mdiPanel.Controls)
              {
                  //如果是新窗体
                  if (v is FrmMain)
                 // if (this.WindowState == FormWindowState.Maximized)
                  {
                      //新窗体先变为正常大小
                      (v as FrmMain).WindowState = FormWindowState.Normal;
                      //新窗体再变为最大化以适应新的Size
                      (v as FrmMain).WindowState = FormWindowState.Maximized;
                  }            

              }*/
            //Form2 subform = new Form2();//
          
            if (this.WindowState == FormWindowState.Maximized)
            {
               
                for (int i = 0; i < frm.Length; i++)
                {
                    if (frm[i] == null)
                       continue;
                    frm[i].WindowState = FormWindowState.Normal;
                    frm[i].WindowState = FormWindowState.Maximized;
                }
            }
            if (this.WindowState == FormWindowState.Normal)
            {             
                for (int i = 0; i < frm.Length; i++)
                {
                    if (frm[i] == null)
                        continue;
                    frm[i].WindowState = FormWindowState.Normal;
                    frm[i].WindowState = FormWindowState.Maximized;
                }
            }
            
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {      
            frm[fmselectindex] = null;
            frm[fmaddindex] = null;
            if (frm[fmusermanggerindex] != null)
            {
                frm[fmusermanggerindex].Activate();
                return;
            }
            fmusermanager = new FrmUserManager();
            frm[fmusermanggerindex] = fmusermanager;
            fmusermanager.WindowState = FormWindowState.Maximized;

            //去掉边框
            fmusermanager.FormBorderStyle = FormBorderStyle.None;

            fmusermanager.MdiParent = this;

            //设置新窗体的Parent
            fmusermanager.Parent = mdiPanel;
            fmusermanager.Show();
        }


        private void exitPanel_MouseEnter(object sender, EventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(207, 222, 244);
        }

        private void exitPanel_MouseLeave(object sender, EventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(241, 248, 255);
        }

        private void exitPB_MouseEnter(object sender, EventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(207, 222, 244);
        }

        private void exitPB_MouseLeave(object sender, EventArgs e)
        {
            exitPanel.BackColor = Color.FromArgb(241, 248, 255);
        }
    }
}
