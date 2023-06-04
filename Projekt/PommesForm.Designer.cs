namespace Projekt {
    partial class PommesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PommesForm));
            this.BackBtn = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SizesCb = new System.Windows.Forms.ComboBox();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.UpAmountBtn = new System.Windows.Forms.Button();
            this.DownAmountBtn = new System.Windows.Forms.Button();
            this.ProductCategoryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddToOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackBtn.Location = new System.Drawing.Point(12, 971);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(190, 50);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Povratak";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(138, 91);
            this.LogoPictureBox.TabIndex = 6;
            this.LogoPictureBox.TabStop = false;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Location = new System.Drawing.Point(11, 301);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(600, 643);
            this.FlowLayoutPanel.TabIndex = 8;
            // 
            // SizesCb
            // 
            this.SizesCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SizesCb.FormattingEnabled = true;
            this.SizesCb.Location = new System.Drawing.Point(12, 141);
            this.SizesCb.Name = "SizesCb";
            this.SizesCb.Size = new System.Drawing.Size(273, 33);
            this.SizesCb.TabIndex = 9;
            // 
            // AmountTb
            // 
            this.AmountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AmountTb.Location = new System.Drawing.Point(102, 225);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(100, 30);
            this.AmountTb.TabIndex = 10;
            this.AmountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpAmountBtn
            // 
            this.UpAmountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpAmountBtn.Location = new System.Drawing.Point(208, 225);
            this.UpAmountBtn.Name = "UpAmountBtn";
            this.UpAmountBtn.Size = new System.Drawing.Size(48, 30);
            this.UpAmountBtn.TabIndex = 11;
            this.UpAmountBtn.Text = "+";
            this.UpAmountBtn.UseVisualStyleBackColor = true;
            this.UpAmountBtn.Click += new System.EventHandler(this.UpAmountBtn_Click);
            // 
            // DownAmountBtn
            // 
            this.DownAmountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DownAmountBtn.Location = new System.Drawing.Point(48, 225);
            this.DownAmountBtn.Name = "DownAmountBtn";
            this.DownAmountBtn.Size = new System.Drawing.Size(48, 30);
            this.DownAmountBtn.TabIndex = 12;
            this.DownAmountBtn.Text = "-";
            this.DownAmountBtn.UseVisualStyleBackColor = true;
            this.DownAmountBtn.Click += new System.EventHandler(this.DownAmountBtn_Click);
            // 
            // ProductCategoryLbl
            // 
            this.ProductCategoryLbl.AutoSize = true;
            this.ProductCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductCategoryLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.ProductCategoryLbl.Location = new System.Drawing.Point(183, 39);
            this.ProductCategoryLbl.Name = "ProductCategoryLbl";
            this.ProductCategoryLbl.Size = new System.Drawing.Size(294, 32);
            this.ProductCategoryLbl.TabIndex = 39;
            this.ProductCategoryLbl.Text = "Pommes and souces";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 40;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(96, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 41;
            this.label2.Text = "Amount";
            // 
            // AddToOrderBtn
            // 
            this.AddToOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddToOrderBtn.Location = new System.Drawing.Point(341, 205);
            this.AddToOrderBtn.Name = "AddToOrderBtn";
            this.AddToOrderBtn.Size = new System.Drawing.Size(220, 50);
            this.AddToOrderBtn.TabIndex = 42;
            this.AddToOrderBtn.Text = "Dodaj u narudzbu";
            this.AddToOrderBtn.UseVisualStyleBackColor = true;
            this.AddToOrderBtn.Click += new System.EventHandler(this.AddToOrderBtn_Click);
            // 
            // PommesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.AddToOrderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductCategoryLbl);
            this.Controls.Add(this.DownAmountBtn);
            this.Controls.Add(this.UpAmountBtn);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.SizesCb);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.BackBtn);
            this.Name = "PommesForm";
            this.Text = "PommesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.ComboBox SizesCb;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Button UpAmountBtn;
        private System.Windows.Forms.Button DownAmountBtn;
        private System.Windows.Forms.Label ProductCategoryLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddToOrderBtn;
    }
}