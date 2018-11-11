using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC4FJSP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    FormGanttChart formGantt = new FormGanttChart();
                    formGantt.InitData(file);
                    formGantt.MdiParent = this;
                    formGantt.Show();
                }
            }
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //계단식 배열
        private void menuItemWindowsCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        //수평 바둑판식 배열
        private void menuItemWindowsTileHorizontailly_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        //수직 바둑판식 배열
        private void menuItemWindowsTileVertically_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        //아이콘 정렬
        private void menuItemWindowsArrangeIcon_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void 모두닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }
    }
}
