namespace Projekt {
    partial class CoffeeForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeForm));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductCategoryLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackColor = System.Drawing.Color.Red;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(138, 91);
            this.LogoPictureBox.TabIndex = 8;
            this.LogoPictureBox.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 971);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(190, 50);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Povratak";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FlowLayoutPanel.Location = new System.Drawing.Point(11, 88);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(1881, 856);
            this.FlowLayoutPanel.TabIndex = 9;
            // 
            // ProductCategoryLbl
            // 
            this.ProductCategoryLbl.AutoSize = true;
            this.ProductCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductCategoryLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.ProductCategoryLbl.Location = new System.Drawing.Point(183, 39);
            this.ProductCategoryLbl.Name = "ProductCategoryLbl";
            this.ProductCategoryLbl.Size = new System.Drawing.Size(112, 32);
            this.ProductCategoryLbl.TabIndex = 40;
            this.ProductCategoryLbl.Text = "Coffees";
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ProductCategoryLbl);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.BackBtn);
            this.Name = "CoffeeForm";
            this.Text = "CaffeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Label ProductCategoryLbl;
    }
}