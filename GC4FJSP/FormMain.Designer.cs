namespace GC4FJSP
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowsCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowsTileHorizontailly = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowsTileVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindowsArrangeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.모두닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.창WToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.창WToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기OToolStripMenuItem,
            this.toolStripSeparator3,
            this.닫기CToolStripMenuItem,
            this.모두닫기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.종료XToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.종료XToolStripMenuItem.Text = "끝내기(&X)";
            this.종료XToolStripMenuItem.Click += new System.EventHandler(this.종료XToolStripMenuItem_Click);
            // 
            // 창WToolStripMenuItem
            // 
            this.창WToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWindowsCascade,
            this.menuItemWindowsTileHorizontailly,
            this.menuItemWindowsTileVertically,
            this.menuItemWindowsArrangeIcon,
            this.toolStripSeparator2});
            this.창WToolStripMenuItem.Name = "창WToolStripMenuItem";
            this.창WToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.창WToolStripMenuItem.Text = "창(&W)";
            // 
            // menuItemWindowsCascade
            // 
            this.menuItemWindowsCascade.Name = "menuItemWindowsCascade";
            this.menuItemWindowsCascade.Size = new System.Drawing.Size(166, 22);
            this.menuItemWindowsCascade.Text = "계단식 배열";
            this.menuItemWindowsCascade.Click += new System.EventHandler(this.menuItemWindowsCascade_Click);
            // 
            // menuItemWindowsTileHorizontailly
            // 
            this.menuItemWindowsTileHorizontailly.Name = "menuItemWindowsTileHorizontailly";
            this.menuItemWindowsTileHorizontailly.Size = new System.Drawing.Size(166, 22);
            this.menuItemWindowsTileHorizontailly.Text = "수평 바둑판 배열";
            this.menuItemWindowsTileHorizontailly.Click += new System.EventHandler(this.menuItemWindowsTileHorizontailly_Click);
            // 
            // menuItemWindowsTileVertically
            // 
            this.menuItemWindowsTileVertically.Name = "menuItemWindowsTileVertically";
            this.menuItemWindowsTileVertically.Size = new System.Drawing.Size(166, 22);
            this.menuItemWindowsTileVertically.Text = "수직 바둑판 배열";
            this.menuItemWindowsTileVertically.Click += new System.EventHandler(this.menuItemWindowsTileVertically_Click);
            // 
            // menuItemWindowsArrangeIcon
            // 
            this.menuItemWindowsArrangeIcon.Name = "menuItemWindowsArrangeIcon";
            this.menuItemWindowsArrangeIcon.Size = new System.Drawing.Size(166, 22);
            this.menuItemWindowsArrangeIcon.Text = "아이콘 정렬";
            this.menuItemWindowsArrangeIcon.Click += new System.EventHandler(this.menuItemWindowsArrangeIcon_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 696);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1076, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "TEXT 파일|*.txt|모든 파일|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Open a Data File of Gantt Chart";
            // 
            // 모두닫기ToolStripMenuItem
            // 
            this.모두닫기ToolStripMenuItem.Name = "모두닫기ToolStripMenuItem";
            this.모두닫기ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.모두닫기ToolStripMenuItem.Text = "모두 닫기";
            this.모두닫기ToolStripMenuItem.Click += new System.EventHandler(this.모두닫기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // 닫기CToolStripMenuItem
            // 
            this.닫기CToolStripMenuItem.Name = "닫기CToolStripMenuItem";
            this.닫기CToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.닫기CToolStripMenuItem.Text = "닫기(&C)";
            this.닫기CToolStripMenuItem.Click += new System.EventHandler(this.닫기CToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1076, 718);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Gantt Chart for Flexible Job-shop Scheduling Problem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 창WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowsCascade;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowsTileHorizontailly;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowsTileVertically;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindowsArrangeIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 모두닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 닫기CToolStripMenuItem;
    }
}

