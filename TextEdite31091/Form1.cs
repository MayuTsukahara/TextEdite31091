using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEdite31091 {
    public partial class Form1 : Form {
        //上書き保存用ファイル名
        private string fileName = "";     //Camel形式　(⇔　Pascal形式)
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        //機能の無効有効
        private void init_button() {
            //上書き
            if(fileName != "") {
                SaveToolStripMenuItem.Enabled = true;
            } else {
                SaveToolStripMenuItem.Enabled = false;
            }
            //やり直す
            if (rtTextArea.CanUndo) {
                UndoUToolStripMenuItem.Enabled = true;
            } else {
                UndoUToolStripMenuItem.Enabled = false;
            }
            //元に戻す
            if (rtTextArea.CanRedo) {
                RedoRToolStripMenuItem.Enabled = true;
            } else {
                RedoRToolStripMenuItem.Enabled = false;
            }
            if (rtTextArea.SelectedText != "") {
                CopyCToolStripMenuItem.Enabled = true;
                CutOutTToolStripMenuItem.Enabled = true;
            } else {
                CopyCToolStripMenuItem.Enabled = false;
                CutOutTToolStripMenuItem.Enabled = false;
            }
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)) {
                PastePToolStripMenuItem.Enabled = true;
            } else {
                PastePToolStripMenuItem.Enabled = false;
            }
        }

        //終了
        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //開く
        private void OpenOToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                fileName = ofdFileOpen.FileName;
                try {
                    rtTextArea.LoadFile(@ofdFileOpen.FileName);
                } catch (Exception) { }
            }
        }

        //名前を付けて保存
        private void SaveAToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try{
                    fileName = sfdFileSave.FileName;
                    rtTextArea.SaveFile(@sfdFileSave.FileName, RichTextBoxStreamType.RichText);
                }
                catch(Exception){ };
            }
        }

        //上書き保存
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fileName != "") {
                try {
                    rtTextArea.SaveFile(fileName, RichTextBoxStreamType.RichText);
                } catch (Exception) { };
            } else {
                SaveAToolStripMenuItem_Click(sender,e); 
            }
        }
        //新規作成
        private void NewNToolStripMenuItem_Click(object sender, EventArgs e) {
            fileName = "";
            rtTextArea.Clear();
        }
        //テキストの色
        private void ColorToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cdTextColor.ShowDialog() == DialogResult.OK) {
                rtTextArea.SelectionColor = cdTextColor.Color;
            }
        }
        //テキストのフォント
        private void FontToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fdTextFont.ShowDialog() == DialogResult.OK) {
                rtTextArea.SelectionFont = fdTextFont.Font;
            }
        }
        //元に戻す
        private void UndoUToolStripMenuItem_Click(object sender, EventArgs e) {
            rtTextArea.Undo();
        }
        //やり直し
        private void RedoRToolStripMenuItem_Click(object sender, EventArgs e) {
            rtTextArea.Redo();
        }
        //切り取り
        private void CutOutTToolStripMenuItem_Click(object sender, EventArgs e) {
            rtTextArea.Cut();
        }
        //コピー
        private void CopyCToolStripMenuItem_Click(object sender, EventArgs e) {
            rtTextArea.Copy();
        }
        //貼り付け
        private void PastePToolStripMenuItem_Click(object sender, EventArgs e) {
            rtTextArea.Paste();
        }
        //削除
        private void DeleteDToolStripMenuItem_Click(object sender, EventArgs e) {
            rtTextArea.Clear();
        }


        //ドロップダウンのマスク判断-------------------------------------------------------
        private void EditEToolStripMenuItem_DropDownOpened(object sender, EventArgs e) {
            init_button();
        }
        private void FileFToolStripMenuItem_DropDownOpened(object sender, EventArgs e) {
            init_button();
        }
        private void 文字コードCToolStripMenuItem_DropDownOpened(object sender, EventArgs e) {
            init_button();
        }
        private void ヘルプHToolStripMenuItem_Click(object sender, EventArgs e) {
            init_button();
        }
        //---------------------------------------------------------------------------------
    }
}
