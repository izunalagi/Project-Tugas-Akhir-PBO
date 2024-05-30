namespace Project_Akhir_PBO.views
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.transaksi1 = new Project_Akhir_PBO.Transaksi();
            this.buyer1 = new Project_Akhir_PBO.Buyer();
            this.produk1 = new Project_Akhir_PBO.views.Produk();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "BATIK KARIMATA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Produk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buyer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(182)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 734);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(264, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "Transaksi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // transaksi1
            // 
            this.transaksi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(221)))), ((int)(((byte)(197)))));
            this.transaksi1.Location = new System.Drawing.Point(261, 0);
            this.transaksi1.Name = "transaksi1";
            this.transaksi1.Size = new System.Drawing.Size(926, 734);
            this.transaksi1.TabIndex = 8;
            // 
            // buyer1
            // 
            this.buyer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(221)))), ((int)(((byte)(197)))));
            this.buyer1.Location = new System.Drawing.Point(261, -3);
            this.buyer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buyer1.Name = "buyer1";
            this.buyer1.Size = new System.Drawing.Size(926, 734);
            this.buyer1.TabIndex = 7;
            // 
            // produk1
            // 
            this.produk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(221)))), ((int)(((byte)(197)))));
            this.produk1.Location = new System.Drawing.Point(261, -3);
            this.produk1.Name = "produk1";
            this.produk1.Size = new System.Drawing.Size(926, 734);
            this.produk1.TabIndex = 6;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 734);
            this.Controls.Add(this.produk1);
            this.Controls.Add(this.transaksi1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private Produk produk1;
        private Buyer buyer1;
        private Transaksi transaksi1;
    }
}