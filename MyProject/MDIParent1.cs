using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class MDIParent1 : Form
    {
        int limit = 1;
        //private int childFormNumber = 0;

        public MDIParent1(string num, int limit)
        {
            InitializeComponent();
            this.limit = limit;
            string sql = "select users_name from users where users_num = '" + num + "'";
            DataTable dt = new DataTable();
            dt = Program.GetDataTable(sql);
            DataRow dr = dt.Rows[0];
            string userName = dr["users_name"].ToString();
            toolStripStatusLabel.Text = "欢迎用户:" + userName + "进入韶关学院知识产权管理员管理系统";
        }

      /*  private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {
            FrmUserManager um = new FrmUserManager();
            um.WindowState = FormWindowState.Maximized;

            //去掉边框
            um.FormBorderStyle = FormBorderStyle.None;

            um.MdiParent = this;

            //设置新窗体的Parent
            um.Parent = panel2;

            um.Show();
        }

        private void MDIParent1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void patentSearchPB_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripStatusLabel.Text, limit);
            f.WindowState = FormWindowState.Maximized;

            //去掉边框
            f.FormBorderStyle = FormBorderStyle.None;

            f.MdiParent = this;

            //设置新窗体的Parent
            f.Parent = panel2;
            f.Show();
        }

        private void exitPB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
