using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt {
    public partial class BurgersForm : Form {
        public BurgersForm() {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e) {
            var startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }
    }
}
