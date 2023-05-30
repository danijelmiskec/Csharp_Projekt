using System.Drawing;

namespace Projekt {
    partial class BurgersForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurgersForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductCategoryLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DownAmount = new System.Windows.Forms.Button();
            this.UpAmount = new System.Windows.Forms.Button();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.Productlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BackButton.Location = new System.Drawing.Point(12, 971);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(190, 50);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Povratak";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.FlowLayoutPanel.Location = new System.Drawing.Point(12, 109);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(600, 856);
            this.FlowLayoutPanel.TabIndex = 7;
            // 
            // ProductCategoryLbl
            // 
            this.ProductCategoryLbl.AutoSize = true;
            this.ProductCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProductCategoryLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.ProductCategoryLbl.Location = new System.Drawing.Point(183, 39);
            this.ProductCategoryLbl.Name = "ProductCategoryLbl";
            this.ProductCategoryLbl.Size = new System.Drawing.Size(346, 32);
            this.ProductCategoryLbl.TabIndex = 40;
            this.ProductCategoryLbl.Text = "Burgers and sandwiches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(701, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "Amount";
            // 
            // DownAmount
            // 
            this.DownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DownAmount.Location = new System.Drawing.Point(653, 226);
            this.DownAmount.Name = "DownAmount";
            this.DownAmount.Size = new System.Drawing.Size(48, 30);
            this.DownAmount.TabIndex = 44;
            this.DownAmount.Text = "-";
            this.DownAmount.UseVisualStyleBackColor = true;
            this.DownAmount.Click += new System.EventHandler(this.DownAmountBtn_Click);
            // 
            // UpAmount
            // 
            this.UpAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpAmount.Location = new System.Drawing.Point(825, 226);
            this.UpAmount.Name = "UpAmount";
            this.UpAmount.Size = new System.Drawing.Size(48, 30);
            this.UpAmount.TabIndex = 43;
            this.UpAmount.Text = "+";
            this.UpAmount.UseVisualStyleBackColor = true;
            this.UpAmount.Click += new System.EventHandler(this.UpAmountBtn_Click);
            // 
            // AmountTb
            // 
            this.AmountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AmountTb.Location = new System.Drawing.Point(707, 226);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(112, 30);
            this.AmountTb.TabIndex = 42;
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Productlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.Productlbl.Location = new System.Drawing.Point(649, 142);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Size = new System.Drawing.Size(70, 25);
            this.Productlbl.TabIndex = 47;
            this.Productlbl.Text = "label1";
            // 
            // BurgersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.Productlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DownAmount);
            this.Controls.Add(this.ProductCategoryLbl);
            this.Controls.Add(this.UpAmount);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.BackButton);
            this.Name = "BurgersForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "BurgersForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Label ProductCategoryLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DownAmount;
        private System.Windows.Forms.Button UpAmount;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label Productlbl;
    }
}