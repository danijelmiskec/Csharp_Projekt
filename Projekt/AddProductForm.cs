using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt {
    public partial class AddProductForm : Form {
        private ProductCategorys productCategorys = new ProductCategorys();
        public AddProductForm() {
            InitializeComponent();
            ProductCategoryLbl.Hide();
            NameLbl.Hide();
            NameTb.Hide();
            PriceLbl.Hide();
            PriceTb.Hide();
            PreparingTimeLbl.Hide();
            PreparingTimeTb.Hide();
            InsertUpdateBtn.Hide();
        }
        private void BurgerPictureBox_Click(object sender, EventArgs e) {
            foreach (var c in productCategorys.GetProductCategories(5)) {
                NameLbl.Show();
                NameTb.Show();
                PriceLbl.Show();
                PriceTb.Show();
                ProductCategoryLbl.Show();
                PreparingTimeTb.Show();
                InsertUpdateBtn.Show();
                ProductCategoryLbl.Text = c.Name;


            }
        }


        private void PommesPictureBox_Click(object sender, EventArgs e) {
            foreach (var c in productCategorys.GetProductCategories(7)) {
                NameLbl.Show();
                NameTb.Show();
                PriceLbl.Show();
                PriceTb.Show();
                ProductCategoryLbl.Show();
                PreparingTimeTb.Show();
                InsertUpdateBtn.Show();
                ProductCategoryLbl.Text = c.Name;
            }
        }

        private void DrinkPictureBox_Click(object sender, EventArgs e) {
            foreach (var c in productCategorys.GetProductCategories(9)) {
                NameLbl.Show();
                NameTb.Show();
                PriceLbl.Show();
                PriceTb.Show();
                ProductCategoryLbl.Show();
                PreparingTimeTb.Show();
                InsertUpdateBtn.Show();
                ProductCategoryLbl.Text = c.Name;
            }
        }

        private void DessertPictureBox_Click(object sender, EventArgs e) {
            foreach (var c in productCategorys.GetProductCategories(8)) {
                NameLbl.Show();
                NameTb.Show();
                PriceLbl.Show();
                PriceTb.Show();
                ProductCategoryLbl.Show();
                PreparingTimeTb.Show();
                InsertUpdateBtn.Show();
                ProductCategoryLbl.Text = c.Name;
            }

        }
        private void CoffeePictureBox_Click(object sender, EventArgs e) {
            foreach (var c in productCategorys.GetProductCategories(10)) {
                NameLbl.Show();
                NameTb.Show();
                PriceLbl.Show();
                PriceTb.Show();
                ProductCategoryLbl.Show();
                PreparingTimeTb.Show();
                InsertUpdateBtn.Show();
                ProductCategoryLbl.Text = c.Name;
            }
        }




        private void BackBtn_Click(object sender, EventArgs e) {
            var startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }

        private void InsertUpdateBtn_Click(object sender, EventArgs e) {
            if ((NameTb.Text == null || NameTb.Text == string.Empty) || (PreparingTimeTb.Text == null || PreparingTimeTb.Text == string.Empty) || (PriceTb.Text == null || PriceTb.Text == string.Empty)) {
                MessageBox.Show("Niste unjeli podatak za Name, price ili Preparing time!!",
                                "Greska kod unosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            } else {

            }
        }


    }
}

