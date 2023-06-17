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
        private ProductCategory category = new ProductCategory();
        private Product product = new Product();
        private Products products = new Products();
        int categoryID;
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
            ProductsCb.Hide();
        }

        private void ProductsCbAdd(int categoryID) {
            string Empty = " ";
            ProductsCb.Items.Clear();
            ProductsCb.Items.Add(Empty);
            ProductsCb.Items.AddRange((products.GetProducts(categoryID)).ToArray());
        }

        private void FormElementsShow() {
            NameLbl.Show();
            NameTb.Show();
            PriceLbl.Show();
            PriceTb.Show();
            ProductCategoryLbl.Show();
            PreparingTimeLbl.Show();
            PreparingTimeTb.Show();
            InsertUpdateBtn.Show();
            ProductsCb.Show();
        }

        private void BurgerPictureBox_Click(object sender, EventArgs e) {
            categoryID = 5;
            category = productCategorys.GetProductCategory(categoryID);
            ProductsCbAdd(categoryID);
            FormElementsShow();
            ProductCategoryLbl.Text = category.Name;
        }

        private void PommesPictureBox_Click(object sender, EventArgs e) {
            categoryID = 7;
            category = productCategorys.GetProductCategory(categoryID);
            ProductsCbAdd(categoryID);
            FormElementsShow();
            ProductCategoryLbl.Text = category.Name;
        }

        private void DrinkPictureBox_Click(object sender, EventArgs e) {
            categoryID = 9;
            category = productCategorys.GetProductCategory(categoryID);
            ProductsCbAdd(categoryID);
            FormElementsShow();
            ProductCategoryLbl.Text = category.Name;
        }

        private void DessertPictureBox_Click(object sender, EventArgs e) {
            categoryID = 8;
            category = productCategorys.GetProductCategory(categoryID);
            ProductsCbAdd(categoryID);
            FormElementsShow();
            ProductCategoryLbl.Text = category.Name;
        }

        private void CoffeePictureBox_Click(object sender, EventArgs e) {
            categoryID = 10;
            category = productCategorys.GetProductCategory(categoryID);
            ProductsCbAdd(categoryID);
            FormElementsShow();
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
            } else {
                if (ProductsCb.Text != null && ProductsCb.Text != string.Empty) {
                    product = products.GetProduct(NameTb.Text);
                    product.Name = NameTb.Text;
                    product.Price = int.Parse(PriceTb.Text);
                    product.PreparingTime = int.Parse(PreparingTimeTb.Text);
                    product.CategoryID = categoryID;
                    products.UpdateProduct(product);
                } else {
                    product = new Product(NameTb.Text, int.Parse(PriceTb.Text), int.Parse(PreparingTimeTb.Text), categoryID);
                    products.UpdateProduct(product);
                }               
            }
        }

        private void ProductsCb_SelectedIndexChanged(object sender, EventArgs e) {
            NameTb.Text = ProductsCb.Text;
        }
    }
}

