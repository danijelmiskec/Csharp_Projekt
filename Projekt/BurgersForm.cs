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
        private Products products = new Products(); 
        public BurgersForm() {
            InitializeComponent();
            generateButton();
        }

        private void generateButton() {
            FlowLayoutPanel.Controls.Clear(); // Briše prethodno generirane gumbe

            // Dohvati podatke iz baze podataka i generiraj gumbe
            // Ovdje ide vaš kod za dohvaćanje podataka iz baze podataka

            // Primjer generiranja gumbova
            foreach (Product p in products.GetProducts(5)) {
                Button button = new Button();
                button.Text = p.Name;
                button.Click += Button_Click; // Dodaje događaj klika na gumb
                System.Drawing.Size customSize = new System.Drawing.Size(120, 50);
                button.Size = customSize;
                button.Font = new Font("Microsoft Sans Serif", 12);


                FlowLayoutPanel.Controls.Add(button); // Dodaje gumb u FlowLayoutPanel
            }
        }
        private void Button_Click(object sender, EventArgs e) {
            MessageBox.Show("da");
        }


        private void BackBtn_Click(object sender, EventArgs e) {
            var startform = new StartForm();
            startform.ShowDialog();
            this.Close();
        }

    }
}
