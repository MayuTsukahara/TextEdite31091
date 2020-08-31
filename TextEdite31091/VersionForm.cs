using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEdite31091 {
    public partial class VersionForm : Form {
        //インスタンス作成
        private static VersionForm _singleInstance;

        public static　VersionForm GetInstance() {
            if (_singleInstance == null) {
                _singleInstance = new VersionForm();
            }
            return _singleInstance;
        }
        private VersionForm() {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void VersionForm_FormClosed(object sender, FormClosedEventArgs e) {
            _singleInstance = null;
        }
    }
}
