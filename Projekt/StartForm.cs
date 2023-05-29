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
        private Admins Admins = new Admins();
        public StartForm() {
            InitializeComponent();
            UsernameLbl.Hide();
            UsernameTb.Hide();
            PasswordLbl.Hide();
            PasswordTb.Hide();
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

        private void CoffeePictureBox_Click(object sender, EventArgs e) {
            var caffeForm = new CoffeeForm();
            caffeForm.ShowDialog();
            this.Close();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e) {
            if (UsernameTb.Visible) {
                if ((UsernameTb.Text == null || UsernameTb.Text == string.Empty) || (PasswordTb.Text == null || PasswordTb.Text == string.Empty)) {
                    MessageBox.Show("Niste unjeli username ili password!!",
                                    "Greska kod prijave",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                } else {
                    foreach (var a in Admins.GetAdmins()) {
                        if ((a.Username.Equals(UsernameTb.Text)) && (a.Password.Equals(PasswordTb.Text))) {
                            MessageBox.Show("Uspjesna prijava!!",
                                            "Uspjesna prijava",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            break;
                        } else {
                            MessageBox.Show("Pogrešan username ili password!!",
                                            "Greska kod prijave",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }

                    }

                }

            } else {
                UsernameLbl.Show();
                UsernameTb.Show();
                PasswordLbl.Show();
                PasswordTb.Show();
            }



        }


    }
}
