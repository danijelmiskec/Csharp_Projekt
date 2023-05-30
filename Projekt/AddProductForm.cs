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
        private Product product;
        private Products products = new Products();
        private ProductCategory category = new ProductCategory();
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
            var category = new ProductCategory();
            category = productCategorys.GetProductCategory(5);
            NameLbl.Show();
            NameTb.Show();
            PriceLbl.Show();
            PriceTb.Show();
            ProductCategoryLbl.Show();
            PreparingTimeLbl.Show();
            PreparingTimeTb.Show();
            InsertUpdateBtn.Show();
            ProductCategoryLbl.Text = category.Name;
        }


        private void PommesPictureBox_Click(object sender, EventArgs e) {
            category = productCategorys.GetProductCategory(7);
            NameLbl.Show();
            NameTb.Show();
            PriceLbl.Show();
            PriceTb.Show();
            ProductCategoryLbl.Show();
            PreparingTimeLbl.Show();
            PreparingTimeTb.Show();
            InsertUpdateBtn.Show();
            ProductCategoryLbl.Text = category.Name;
        }

        private void DrinkPictureBox_Click(object sender, EventArgs e) {
            category = productCategorys.GetProductCategory(9);
            NameLbl.Show();
            NameTb.Show();
            PriceLbl.Show();
            PriceTb.Show();
            ProductCategoryLbl.Show();
            PreparingTimeLbl.Show();
            PreparingTimeTb.Show();
            InsertUpdateBtn.Show();
            ProductCategoryLbl.Text = category.Name;

        }

        private void DessertPictureBox_Click(object sender, EventArgs e) {
            category = productCategorys.GetProductCategory(8);
            NameLbl.Show();
            NameTb.Show();
            PriceLbl.Show();
            PriceTb.Show();
            ProductCategoryLbl.Show();
            PreparingTimeLbl.Show();
            PreparingTimeTb.Show();
            InsertUpdateBtn.Show();
            ProductCategoryLbl.Text = category.Name;
        }
        private void CoffeePictureBox_Click(object sender, EventArgs e) {
            category = productCategorys.GetProductCategory(10);
            NameLbl.Show();
            NameTb.Show();
            PriceLbl.Show();
            PriceTb.Show();
            ProductCategoryLbl.Show();
            PreparingTimeLbl.Show();
            PreparingTimeTb.Show();
            InsertUpdateBtn.Show();
            ProductCategoryLbl.Text = category.Name;
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
            } else {/*
                if (product != null) {
                    product.Name = NameTb.Text;
                    product.Price = int.Parse(PriceTb.Text);
                    product.PreparingTime = int.Parse(PreparingTimeTb.Text);
                    product.CategoryID = category.ID;
                    products.UpdateNote(product);
                } else {*/
                    product = new Product(NameTb.Text, int.Parse(PriceTb.Text), int.Parse(PreparingTimeTb.Text), category.ID);
                    products.UpdateNote(product);
                //}
                
            }
        }
    }
}

