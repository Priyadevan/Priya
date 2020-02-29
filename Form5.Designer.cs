namespace WindowsFormsApplication1
{
    partial class Ordershop_page
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
            this.homepage_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Shop_brand_cb = new System.Windows.Forms.ComboBox();
            this.Shop_model_cb = new System.Windows.Forms.ComboBox();
            this.Price_txtbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // homepage_btn
            // 
            this.homepage_btn.Location = new System.Drawing.Point(945, 36);
            this.homepage_btn.Name = "homepage_btn";
            this.homepage_btn.Size = new System.Drawing.Size(77, 24);
            this.homepage_btn.TabIndex = 8;
            this.homepage_btn.Text = "HOME";
            this.homepage_btn.UseVisualStyleBackColor = true;
            this.homepage_btn.Click += new System.EventHandler(this.homepage_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "MOBILE BRAND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MOBILE MODEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "PRICE";
            // 
            // Shop_brand_cb
            // 
            this.Shop_brand_cb.FormattingEnabled = true;
            this.Shop_brand_cb.Items.AddRange(new object[] {
            "SAMSUNG",
            "NOKIA",
            "OPPO",
            "VIVO",
            "REDMI"});
            this.Shop_brand_cb.Location = new System.Drawing.Point(571, 162);
            this.Shop_brand_cb.Name = "Shop_brand_cb";
            this.Shop_brand_cb.Size = new System.Drawing.Size(121, 21);
            this.Shop_brand_cb.TabIndex = 12;
            this.Shop_brand_cb.SelectedIndexChanged += new System.EventHandler(this.Shop_brand_cb_SelectedIndexChanged);
            // 
            // Shop_model_cb
            // 
            this.Shop_model_cb.FormattingEnabled = true;
            this.Shop_model_cb.Location = new System.Drawing.Point(571, 229);
            this.Shop_model_cb.Name = "Shop_model_cb";
            this.Shop_model_cb.Size = new System.Drawing.Size(121, 21);
            this.Shop_model_cb.TabIndex = 13;
            // 
            // Price_txtbx
            // 
            this.Price_txtbx.Location = new System.Drawing.Point(571, 302);
            this.Price_txtbx.Name = "Price_txtbx";
            this.Price_txtbx.Size = new System.Drawing.Size(100, 20);
            this.Price_txtbx.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "ORDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ordershop_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1051, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Price_txtbx);
            this.Controls.Add(this.Shop_model_cb);
            this.Controls.Add(this.Shop_brand_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homepage_btn);
            this.Name = "Ordershop_page";
            this.Text = "ORDER MOBILE FOR SHOP";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button homepage_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Shop_brand_cb;
        private System.Windows.Forms.ComboBox Shop_model_cb;
        private System.Windows.Forms.TextBox Price_txtbx;
        private System.Windows.Forms.Button button1;
    }
}