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
    public partial class StartForm : Form {
        public StartForm() {
            InitializeComponent();
        }

        private void BurgerPictureBox_Click(object sender, EventArgs e) {
            var burgerForm = new BurgersForm();
            burgerForm.ShowDialog();
            this.Close();
            
        }

        private void PommesPictureBox_Click(object sender, EventArgs e) {
            var pommesForm = new PommesForm();
            pommesForm.ShowDialog();
            this.Close();
        }

        private void DessertPictureBox_Click(object sender, EventArgs e) {
            var dessertsForm = new DessertsForm();
            dessertsForm.ShowDialog();
            this.Close();
        }

        private void DrinkPictureBox_Click(object sender, EventArgs e) {
            var drinksForm = new DrinksForm();
            drinksForm.ShowDialog();
            this.Close();
        }
    }
}
