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

        private string fn = "";
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //開く

        private void OpenOToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                fn = ofdFileOpen.FileName;
                try {
                    using (StreamReader sr = new StreamReader(ofdFileOpen.FileName, Encoding.GetEncoding("utf-8"), false)) {
                        rtTextArea.Text = sr.ReadToEnd();
                    }
                } catch (Exception) { }
            }
        }

        //名前を付けて保存
        private void SaveAToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                try{
                    using (StreamWriter sw = new StreamWriter(sfdFileSave.FileName, false, Encoding.GetEncoding("utf-8"))) {
                        sw.WriteLine(rtTextArea.Text);
                    }
                }
                catch(Exception){ };
            }
        }

        //上書き保存
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fn != "") {
                try {
                    using (StreamWriter sw = new StreamWriter(fn, false, Encoding.GetEncoding("utf-8"))) {
                        sw.WriteLine(rtTextArea.Text);
                    }
                } catch (Exception) { };
            }
        }
    }
}
