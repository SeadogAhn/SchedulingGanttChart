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
    public partial class FormGanttChart : Form
    {
        public FormGanttChart()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
        }

        public void InitData(string GanttDataFile)
        {
            userControlGanttChartImage1.InitData(GanttDataFile);
            this.Text = GanttDataFile;
        }

        private void toolStripButtonZoomFitSize_Click(object sender, EventArgs e)
        {
            userControlGanttChartImage1.ChangeSize(this.customPanel1.ClientSize.Width, this.customPanel1.ClientSize.Height);
            userControlGanttChartImage1.fitSizeToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonZoomIn_Click(object sender, EventArgs e)
        {
            userControlGanttChartImage1.zoomInToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonZoomOut_Click(object sender, EventArgs e)
        {
            userControlGanttChartImage1.zoomOutToolStripMenuItem_Click(sender, e);
        }

        private void FormGanttChart_Resize(object sender, EventArgs e)
        {
            userControlGanttChartImage1.ChangeSize(this.customPanel1.ClientSize.Width, this.customPanel1.ClientSize.Height);
            userControlGanttChartImage1.fitSizeToolStripMenuItem_Click(sender, e);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userControlGanttChartImage1.ColorMode = toolStripComboBox1.SelectedItem as string;
        }
    }
}
