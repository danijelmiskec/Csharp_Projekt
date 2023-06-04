using System;
using System.Collections;
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
        public Podaci podaci1 = new Podaci();
        Products products = new Products();
        Lists Lists = new Lists();
        Orders orders = new Orders();
        public StartForm() {
            InitializeComponent();
            UsernameLbl.Hide();
            UsernameTb.Hide();
            PasswordLbl.Hide();
            PasswordTb.Hide();
            AddProductBtn.Hide();
            if(podaci1.ListaPodataka != null) {
                foreach (var t in podaci1.ListaPodataka) {
                    CurrentOrderLb.Items.Add(t.ToString());
                }
            }
        }
            public StartForm(Podaci podaci) {
            InitializeComponent();
            UsernameLbl.Hide();
            UsernameTb.Hide();
            PasswordLbl.Hide();
            PasswordTb.Hide();
            AddProductBtn.Hide();
            podaci1 = podaci;
            if (podaci1.ListaPodataka != null) {
                foreach (var t in podaci1.ListaPodataka) {
                    CurrentOrderLb.Items.Add(t.ToString());
                }
            }
        }


        private void BurgerPictureBox_Click(object sender, EventArgs e) {
            var burgerForm = new BurgersForm(podaci1);
            burgerForm.ShowDialog();
            //burgerForm.
            this.Close();
        }

        private void PommesPictureBox_Click(object sender, EventArgs e) {
            var pommesForm = new PommesForm(podaci1);
            // pommesForm.array = array;
            pommesForm.ShowDialog();
            this.Close();
        }

        private void DessertPictureBox_Click(object sender, EventArgs e) {
            var dessertsForm = new DessertsForm(podaci1);
            //dessertsForm.array = array;
            dessertsForm.ShowDialog();
            this.Close();
        }

        private void DrinkPictureBox_Click(object sender, EventArgs e) {
            var drinksForm = new DrinksForm(podaci1);
            //drinksForm.array = array;
            drinksForm.ShowDialog();
            this.Close();
        }

        private void CoffeePictureBox_Click(object sender, EventArgs e) {
            var caffeForm = new CoffeeForm(podaci1);
            //caffeForm.array = array;
            caffeForm.ShowDialog();
            this.Close();
        }

        //Button za prijavu admina
        private void AdminLoginBtn_Click(object sender, EventArgs e) {
            //provjera dal su username i password textBox vidljivi
            if (UsernameTb.Visible) {
                //provjera da li su prazni textBox-ovi za username i password
                if ((UsernameTb.Text == null || UsernameTb.Text == string.Empty) || (PasswordTb.Text == null || PasswordTb.Text == string.Empty)) {
                    MessageBox.Show("Niste unjeli username ili password!!",
                                    "Greska kod prijave",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                } else {
                    //Provjera username i password za svaki admin zapis u tablici
                    if (Admins.GetAdmin(UsernameTb.Text, PasswordTb.Text) != null) {
                        AddProductBtn.Show();
                    } else {
                        MessageBox.Show("Pogrešan username ili password!!",
                                        "Greska kod prijave",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        UsernameTb.Clear();
                        PasswordTb.Clear();
                    }
                }
            } else {
                UsernameLbl.Show();
                UsernameTb.Show();
                PasswordLbl.Show();
                PasswordTb.Show();
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e) {
            var AddProductForm = new AddProductForm();
            AddProductForm.ShowDialog();
            this.Close();
        }

        private void EndOrderBtn_Click(object sender, EventArgs e) {
            int TotalPreparingTime = 0;
            int? TotalPrice = 0;
            MessageBox.Show("Narudzba je zavrsena");
            Order order = new Order();
            foreach (var n in podaci1.ListaPodataka) {
                Product product = new Product();
                product = products.GetProduct(n.ProductID);
                TotalPreparingTime += n.Amount *product.PreparingTime ;
                TotalPrice += product.Price* n.Amount;
            }
            order.PriceSum = TotalPrice;
            order.SumPreparingTIme = TotalPreparingTime;
            order.Status = "U PRIPREMI";
            orders.InsertOrder(order);
            order = orders.GetOrder(order);
            Lists.InsertLists(podaci1, order);
            podaci1.ListaPodataka.Clear();
            CurrentOrderLb.Items.Clear();
        }

        private void CancleOrderBtn_Click(object sender, EventArgs e) {
            MessageBox.Show("Narudzba je ponistena!!");
            podaci1.ListaPodataka.Clear();
            CurrentOrderLb.Items.Clear();
        }
    }
}
