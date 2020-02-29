namespace WindowsFormsApplication1
{
    partial class Payment_page
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cust_name_txt = new System.Windows.Forms.TextBox();
            this.cust_phone_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.pay_brand_cb = new System.Windows.Forms.ComboBox();
            this.pay_model_cb = new System.Windows.Forms.ComboBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.paybtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.payment__price_GV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.quantity_txtbox = new System.Windows.Forms.TextBox();
            this.total_price_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.payment__price_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CUSTOMER\'S PHONE NUMBER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADDRESS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MOBILE BRAND";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MOBILE MODEL";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "PRICE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cust_name_txt
            // 
            this.cust_name_txt.Location = new System.Drawing.Point(469, 69);
            this.cust_name_txt.Name = "cust_name_txt";
            this.cust_name_txt.Size = new System.Drawing.Size(121, 20);
            this.cust_name_txt.TabIndex = 7;
            this.cust_name_txt.TextChanged += new System.EventHandler(this.cust_name_txt_TextChanged);
            // 
            // cust_phone_txt
            // 
            this.cust_phone_txt.Location = new System.Drawing.Point(469, 124);
            this.cust_phone_txt.Name = "cust_phone_txt";
            this.cust_phone_txt.Size = new System.Drawing.Size(121, 20);
            this.cust_phone_txt.TabIndex = 8;
            this.cust_phone_txt.TextChanged += new System.EventHandler(this.cust_phone_txt_TextChanged);
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(469, 178);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(121, 20);
            this.address_txt.TabIndex = 9;
            this.address_txt.TextChanged += new System.EventHandler(this.address_txt_TextChanged);
            // 
            // pay_brand_cb
            // 
            this.pay_brand_cb.FormattingEnabled = true;
            this.pay_brand_cb.Items.AddRange(new object[] {
            "SAMSUNG",
            "NOKIA",
            "VIVO",
            "OPPO",
            "REDMI"});
            this.pay_brand_cb.Location = new System.Drawing.Point(469, 227);
            this.pay_brand_cb.Name = "pay_brand_cb";
            this.pay_brand_cb.Size = new System.Drawing.Size(121, 21);
            this.pay_brand_cb.TabIndex = 10;
            this.pay_brand_cb.SelectedIndexChanged += new System.EventHandler(this.pay_brand_cb_SelectedIndexChanged);
            // 
            // pay_model_cb
            // 
            this.pay_model_cb.FormattingEnabled = true;
            this.pay_model_cb.Location = new System.Drawing.Point(469, 280);
            this.pay_model_cb.Name = "pay_model_cb";
            this.pay_model_cb.Size = new System.Drawing.Size(121, 21);
            this.pay_model_cb.TabIndex = 11;
            this.pay_model_cb.SelectedIndexChanged += new System.EventHandler(this.pay_model_cb_SelectedIndexChanged);
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(469, 335);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(121, 20);
            this.price_txt.TabIndex = 12;
            this.price_txt.TextChanged += new System.EventHandler(this.price_txt_TextChanged);
            // 
            // paybtn
            // 
            this.paybtn.Location = new System.Drawing.Point(367, 477);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(75, 23);
            this.paybtn.TabIndex = 13;
            this.paybtn.Text = "PAY";
            this.paybtn.UseVisualStyleBackColor = true;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // payment__price_GV
            // 
            this.payment__price_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment__price_GV.Location = new System.Drawing.Point(654, 288);
            this.payment__price_GV.Name = "payment__price_GV";
            this.payment__price_GV.Size = new System.Drawing.Size(350, 59);
            this.payment__price_GV.TabIndex = 15;
            this.payment__price_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payment__price_GV_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "QUANTITY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "TOTAL PRICE";
            // 
            // quantity_txtbox
            // 
            this.quantity_txtbox.Location = new System.Drawing.Point(469, 378);
            this.quantity_txtbox.Name = "quantity_txtbox";
            this.quantity_txtbox.Size = new System.Drawing.Size(121, 20);
            this.quantity_txtbox.TabIndex = 18;
            this.quantity_txtbox.TextChanged += new System.EventHandler(this.quantity_txtbox_TextChanged);
            // 
            // total_price_txtbox
            // 
            this.total_price_txtbox.Location = new System.Drawing.Point(469, 426);
            this.total_price_txtbox.Name = "total_price_txtbox";
            this.total_price_txtbox.Size = new System.Drawing.Size(121, 20);
            this.total_price_txtbox.TabIndex = 19;
            this.total_price_txtbox.TextChanged += new System.EventHandler(this.total_price_txtbox_TextChanged);
            // 
            // Payment_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1027, 563);
            this.Controls.Add(this.total_price_txtbox);
            this.Controls.Add(this.quantity_txtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.payment__price_GV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.paybtn);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.pay_model_cb);
            this.Controls.Add(this.pay_brand_cb);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.cust_phone_txt);
            this.Controls.Add(this.cust_name_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Payment_page";
            this.Text = "PAYMENT";
            this.Load += new System.EventHandler(this.Payment_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment__price_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cust_name_txt;
        private System.Windows.Forms.TextBox cust_phone_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.ComboBox pay_brand_cb;
        private System.Windows.Forms.ComboBox pay_model_cb;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView payment__price_GV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantity_txtbox;
        private System.Windows.Forms.TextBox total_price_txtbox;
    }
}