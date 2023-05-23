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
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BurgerPictureBox = new System.Windows.Forms.PictureBox();
            this.PommesPictureBox = new System.Windows.Forms.PictureBox();
            this.DessertPictureBox = new System.Windows.Forms.PictureBox();
            this.DrinkPictureBox = new System.Windows.Forms.PictureBox();
            this.LbPriprema = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbPredaja = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PommesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DessertPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // BurgerPictureBox
            // 
            this.BurgerPictureBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.BurgerPictureBox, "BurgerPictureBox");
            this.BurgerPictureBox.Name = "BurgerPictureBox";
            this.BurgerPictureBox.TabStop = false;
            this.BurgerPictureBox.Click += new System.EventHandler(this.BurgerPictureBox_Click);
            // 
            // PommesPictureBox
            // 
            this.PommesPictureBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.PommesPictureBox, "PommesPictureBox");
            this.PommesPictureBox.Name = "PommesPictureBox";
            this.PommesPictureBox.TabStop = false;
            this.PommesPictureBox.Click += new System.EventHandler(this.PommesPictureBox_Click);
            // 
            // DessertPictureBox
            // 
            this.DessertPictureBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DessertPictureBox, "DessertPictureBox");
            this.DessertPictureBox.Name = "DessertPictureBox";
            this.DessertPictureBox.TabStop = false;
            this.DessertPictureBox.Click += new System.EventHandler(this.DessertPictureBox_Click);
            // 
            // DrinkPictureBox
            // 
            this.DrinkPictureBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DrinkPictureBox, "DrinkPictureBox");
            this.DrinkPictureBox.Name = "DrinkPictureBox";
            this.DrinkPictureBox.TabStop = false;
            this.DrinkPictureBox.Click += new System.EventHandler(this.DrinkPictureBox_Click);
            // 
            // LbPriprema
            // 
            this.LbPriprema.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.LbPriprema, "LbPriprema");
            this.LbPriprema.ForeColor = System.Drawing.SystemColors.Window;
            this.LbPriprema.FormattingEnabled = true;
            this.LbPriprema.Name = "LbPriprema";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Name = "label2";
            // 
            // LbPredaja
            // 
            this.LbPredaja.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.LbPredaja, "LbPredaja");
            this.LbPredaja.ForeColor = System.Drawing.SystemColors.Window;
            this.LbPredaja.FormattingEnabled = true;
            this.LbPredaja.Name = "LbPredaja";
            // 
            // StartForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbPredaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPriprema);
            this.Controls.Add(this.DrinkPictureBox);
            this.Controls.Add(this.DessertPictureBox);
            this.Controls.Add(this.PommesPictureBox);
            this.Controls.Add(this.BurgerPictureBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "StartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PommesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DessertPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox BurgerPictureBox;
        private System.Windows.Forms.PictureBox PommesPictureBox;
        private System.Windows.Forms.PictureBox DessertPictureBox;
        private System.Windows.Forms.PictureBox DrinkPictureBox;
        private System.Windows.Forms.ListBox LbPriprema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbPredaja;
    }
}

