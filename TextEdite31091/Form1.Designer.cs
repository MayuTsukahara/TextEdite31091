namespace TextEdite31091 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutOutTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PastePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字コードCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtTextArea = new System.Windows.Forms.RichTextBox();
            this.cdTextColor = new System.Windows.Forms.ColorDialog();
            this.fdTextFont = new System.Windows.Forms.FontDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.Filter = "ファイル|*.rtf|すべてのファイル|*.*";
            // 
            // sfdFileSave
            // 
            this.sfdFileSave.DefaultExt = "rtf";
            this.sfdFileSave.Filter = "ファイル|*.rtf|すべてのファイル|*.*";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.EditEToolStripMenuItem,
            this.文字コードCToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNToolStripMenuItem,
            this.OpenOToolStripMenuItem,
            this.toolStripSeparator2,
            this.SaveToolStripMenuItem,
            this.SaveAToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitXToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.FileFToolStripMenuItem.Text = "ファイル(&F)";
            this.FileFToolStripMenuItem.DropDownOpened += new System.EventHandler(this.FileFToolStripMenuItem_DropDownOpened);
            // 
            // NewNToolStripMenuItem
            // 
            this.NewNToolStripMenuItem.Name = "NewNToolStripMenuItem";
            this.NewNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewNToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.NewNToolStripMenuItem.Text = "新規作成(&N)";
            this.NewNToolStripMenuItem.Click += new System.EventHandler(this.NewNToolStripMenuItem_Click);
            // 
            // OpenOToolStripMenuItem
            // 
            this.OpenOToolStripMenuItem.Name = "OpenOToolStripMenuItem";
            this.OpenOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenOToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.OpenOToolStripMenuItem.Text = "開く(&O)...";
            this.OpenOToolStripMenuItem.Click += new System.EventHandler(this.OpenOToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.SaveToolStripMenuItem.Text = "上書き保存(&S)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAToolStripMenuItem
            // 
            this.SaveAToolStripMenuItem.Name = "SaveAToolStripMenuItem";
            this.SaveAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SaveAToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.SaveAToolStripMenuItem.Text = "名前を付けて保存(&A)...";
            this.SaveAToolStripMenuItem.Click += new System.EventHandler(this.SaveAToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // ExitXToolStripMenuItem
            // 
            this.ExitXToolStripMenuItem.Name = "ExitXToolStripMenuItem";
            this.ExitXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitXToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ExitXToolStripMenuItem.Text = "終了(&X)";
            this.ExitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // EditEToolStripMenuItem
            // 
            this.EditEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoUToolStripMenuItem,
            this.RedoRToolStripMenuItem,
            this.toolStripSeparator3,
            this.CutOutTToolStripMenuItem,
            this.CopyCToolStripMenuItem,
            this.PastePToolStripMenuItem,
            this.DeleteDToolStripMenuItem,
            this.toolStripSeparator4,
            this.ColorToolStripMenuItem,
            this.FontToolStripMenuItem});
            this.EditEToolStripMenuItem.Name = "EditEToolStripMenuItem";
            this.EditEToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.EditEToolStripMenuItem.Text = "編集(&E)";
            this.EditEToolStripMenuItem.DropDownOpened += new System.EventHandler(this.EditEToolStripMenuItem_DropDownOpened);
            // 
            // UndoUToolStripMenuItem
            // 
            this.UndoUToolStripMenuItem.Name = "UndoUToolStripMenuItem";
            this.UndoUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UndoUToolStripMenuItem.Text = "元に戻す(&U)";
            this.UndoUToolStripMenuItem.Click += new System.EventHandler(this.UndoUToolStripMenuItem_Click);
            // 
            // RedoRToolStripMenuItem
            // 
            this.RedoRToolStripMenuItem.Name = "RedoRToolStripMenuItem";
            this.RedoRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RedoRToolStripMenuItem.Text = "やり直し(&R)";
            this.RedoRToolStripMenuItem.Click += new System.EventHandler(this.RedoRToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // CutOutTToolStripMenuItem
            // 
            this.CutOutTToolStripMenuItem.Name = "CutOutTToolStripMenuItem";
            this.CutOutTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutOutTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CutOutTToolStripMenuItem.Text = "切り取り(&T)";
            this.CutOutTToolStripMenuItem.Click += new System.EventHandler(this.CutOutTToolStripMenuItem_Click);
            // 
            // CopyCToolStripMenuItem
            // 
            this.CopyCToolStripMenuItem.Name = "CopyCToolStripMenuItem";
            this.CopyCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyCToolStripMenuItem.Text = "コピー(&C)";
            this.CopyCToolStripMenuItem.Click += new System.EventHandler(this.CopyCToolStripMenuItem_Click);
            // 
            // PastePToolStripMenuItem
            // 
            this.PastePToolStripMenuItem.Name = "PastePToolStripMenuItem";
            this.PastePToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PastePToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PastePToolStripMenuItem.Text = "貼り付け(&P)";
            this.PastePToolStripMenuItem.Click += new System.EventHandler(this.PastePToolStripMenuItem_Click);
            // 
            // DeleteDToolStripMenuItem
            // 
            this.DeleteDToolStripMenuItem.Name = "DeleteDToolStripMenuItem";
            this.DeleteDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteDToolStripMenuItem.Text = "削除(&D)";
            this.DeleteDToolStripMenuItem.Click += new System.EventHandler(this.DeleteDToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ColorToolStripMenuItem.Text = "色...";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FontToolStripMenuItem.Text = "フォント...";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // 文字コードCToolStripMenuItem
            // 
            this.文字コードCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.文字コードCToolStripMenuItem.Name = "文字コードCToolStripMenuItem";
            this.文字コードCToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.文字コードCToolStripMenuItem.Text = "文字コード(&C)";
            this.文字コードCToolStripMenuItem.DropDownOpened += new System.EventHandler(this.文字コードCToolStripMenuItem_DropDownOpened);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            this.ヘルプHToolStripMenuItem.Click += new System.EventHandler(this.ヘルプHToolStripMenuItem_Click);
            // 
            // rtTextArea
            // 
            this.rtTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextArea.EnableAutoDragDrop = true;
            this.rtTextArea.Location = new System.Drawing.Point(0, 24);
            this.rtTextArea.Name = "rtTextArea";
            this.rtTextArea.Size = new System.Drawing.Size(1008, 513);
            this.rtTextArea.TabIndex = 1;
            this.rtTextArea.Text = "";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.rtTextArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TextEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitXToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtTextArea;
        private System.Windows.Forms.ToolStripMenuItem EditEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字コードCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutOutTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PastePToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteDToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdTextColor;
        private System.Windows.Forms.FontDialog fdTextFont;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

