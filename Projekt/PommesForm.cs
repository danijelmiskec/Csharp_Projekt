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
    public partial class PommesForm : Form {
        private Products products = new Products();
        int amount;
        public TempList podaci1 = new TempList();
        Product product = new Product();
        Sizes sizes = new Sizes();
        Size size = new Size();
        StartForm startForm;
        public PommesForm(StartForm startForm) {
            InitializeComponent();
            generateButton();
            amount = 1;
            AmountTb.Text = amount.ToString();
            SizesCb.Items.Clear();
            SizesCb.Items.AddRange((sizes.GetSizes(6)).ToArray());
            product = products.GetProduct("Pommes");
            this.podaci1 = startForm.podaci1;
            this.startForm = startForm;
        }
      
        private void generateButton() {
            FlowLayoutPanel.Controls.Clear(); // Briše prethodno generirane gumbe
            //generiranje gumbova
            foreach (Product p in products.GetProducts(7)) {
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

        private void Button_Click(object sender, EventArgs e) {
            Button clickedButton = (Button)sender;
            product = (Product)clickedButton.Tag;
            podaci1.DataList.Add(new Temp(product.ID, 1, null));

        }

        private void BackBtn_Click(object sender, EventArgs e) {
            startForm.podaci1 = podaci1;
            this.Close();
            startForm.Show();
            startForm.OsvjeziFormu();

        }

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
                MessageBox.Show("Morate odabrati velićinu y!!");
            }
        }
    }
}
