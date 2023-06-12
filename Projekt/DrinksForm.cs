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
    public partial class DrinksForm : Form {
        private Products products = new Products();
        int amount;
        public TempList podaci1 = new TempList();
        Product product = new Product();
        Sizes sizes = new Sizes();
        Size size = new Size();
        public DrinksForm(TempList podaci1) {
            InitializeComponent();
            AmountTb.Hide();
            label2.Hide();
            UpAmountBtn.Hide();
            DownAmountBtn.Hide();
            Productlbl.Hide();
            AddToOrderBtn.Hide();
            SizesCb.Hide();
            generateButton();
            this.podaci1 = podaci1;
            SizesCb.Items.Clear();
            SizesCb.Items.AddRange((sizes.GetSizes(9)).ToArray());

        }

        private void generateButton() {
            FlowLayoutPanel.Controls.Clear(); // Briše prethodno generirane gumbe
            //generiranje gumbova
            foreach (Product p in products.GetProducts(9)) {
                Button button = new Button();
                button.Text = p.Name;
                button.Click += Button_Click; // Dodaje događaj klika na gumb
                System.Drawing.Size customSize = new System.Drawing.Size(120, 50);
                button.Size = customSize;
                button.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                button.ForeColor = Color.White;
                button.Tag = p;

                FlowLayoutPanel.Controls.Add(button); // Dodaje gumb u FlowLayoutPanel
            }
        }
        //funkcija za svaki dinamicki stvoren button
        private void Button_Click(object sender, EventArgs e) {
            Button clickedButton = (Button)sender;
            product = (Product)clickedButton.Tag;
            amount = 1;
            AmountTb.Show();
            label2.Show();
            UpAmountBtn.Show();
            DownAmountBtn.Show();
            Productlbl.Show();
            AddToOrderBtn.Show();
            SizesCb.Show();
            Productlbl.Text = product.Name;
            AmountTb.Text = amount.ToString();
        }

        private void BackBtn_Click(object sender, EventArgs e) {
            var startform = new StartForm(podaci1);
            startform.ShowDialog();
            this.Close();
        }

        //button za povecanje broja proizvoda 
        private void UpAmountBtn_Click(object sender, EventArgs e) {
            amount++;
            AmountTb.Text = amount.ToString();
        }

        //button za smanjenje broja proizvoda 
        private void DownAmountBtn_Click(object sender, EventArgs e) {
            if (amount > 1) {
                amount--;
            }
            AmountTb.Text = amount.ToString();
        }
        
        private void AddToOrderBtn_Click(object sender, EventArgs e) {
            if (SizesCb.Text != string.Empty) {
                string name = SizesCb.Text;
                size = sizes.GetSizeID(name);
                podaci1.DataList.Add(new Temp(product.ID, amount, size.ID));
            } else {
                MessageBox.Show("Morate odabrati velićinu pića!!");
            }

        }

    }
}
