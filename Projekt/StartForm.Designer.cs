namespace Projekt {
    partial class StartForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BurgerPictureBox = new System.Windows.Forms.PictureBox();
            this.PommesPictureBox = new System.Windows.Forms.PictureBox();
            this.DessertPictureBox = new System.Windows.Forms.PictureBox();
            this.DrinkPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PommesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DessertPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt.Properties.Resources.output_onlinepngtools;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BurgerPictureBox
            // 
            this.BurgerPictureBox.BackColor = System.Drawing.Color.White;
            this.BurgerPictureBox.Image = global::Projekt.Properties.Resources.Burger;
            resources.ApplyResources(this.BurgerPictureBox, "BurgerPictureBox");
            this.BurgerPictureBox.Name = "BurgerPictureBox";
            this.BurgerPictureBox.TabStop = false;
            this.BurgerPictureBox.Click += new System.EventHandler(this.BurgerPictureBox_Click);
            // 
            // PommesPictureBox
            // 
            this.PommesPictureBox.BackColor = System.Drawing.Color.White;
            this.PommesPictureBox.Image = global::Projekt.Properties.Resources.Pommes;
            resources.ApplyResources(this.PommesPictureBox, "PommesPictureBox");
            this.PommesPictureBox.Name = "PommesPictureBox";
            this.PommesPictureBox.TabStop = false;
            this.PommesPictureBox.Click += new System.EventHandler(this.PommesPictureBox_Click);
            // 
            // DessertPictureBox
            // 
            this.DessertPictureBox.BackColor = System.Drawing.Color.White;
            this.DessertPictureBox.Image = global::Projekt.Properties.Resources.Dessert;
            resources.ApplyResources(this.DessertPictureBox, "DessertPictureBox");
            this.DessertPictureBox.Name = "DessertPictureBox";
            this.DessertPictureBox.TabStop = false;
            this.DessertPictureBox.Click += new System.EventHandler(this.DessertPictureBox_Click);
            // 
            // DrinkPictureBox
            // 
            this.DrinkPictureBox.BackColor = System.Drawing.Color.White;
            this.DrinkPictureBox.Image = global::Projekt.Properties.Resources.Drink;
            resources.ApplyResources(this.DrinkPictureBox, "DrinkPictureBox");
            this.DrinkPictureBox.Name = "DrinkPictureBox";
            this.DrinkPictureBox.TabStop = false;
            this.DrinkPictureBox.Click += new System.EventHandler(this.DrinkPictureBox_Click);
            // 
            // StartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.DrinkPictureBox);
            this.Controls.Add(this.DessertPictureBox);
            this.Controls.Add(this.PommesPictureBox);
            this.Controls.Add(this.BurgerPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PommesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DessertPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BurgerPictureBox;
        private System.Windows.Forms.PictureBox PommesPictureBox;
        private System.Windows.Forms.PictureBox DessertPictureBox;
        private System.Windows.Forms.PictureBox DrinkPictureBox;
    }
}

