namespace WindowsFormsApplication1
{
    partial class Order_page
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
            this.label2 = new System.Windows.Forms.Label();
            this.order_brand_cb = new System.Windows.Forms.ComboBox();
            this.order_model_cb = new System.Windows.Forms.ComboBox();
            this.order_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.order_info_gv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.order_info_gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOBILE BRAND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MOBILE MODEL";
            // 
            // order_brand_cb
            // 
            this.order_brand_cb.FormattingEnabled = true;
            this.order_brand_cb.Items.AddRange(new object[] {
            "SAMSUNG",
            "NOKIA",
            "OPPO",
            "VIVO",
            "REDMI"});
            this.order_brand_cb.Location = new System.Drawing.Point(527, 148);
            this.order_brand_cb.Name = "order_brand_cb";
            this.order_brand_cb.Size = new System.Drawing.Size(121, 21);
            this.order_brand_cb.TabIndex = 2;
            this.order_brand_cb.SelectedIndexChanged += new System.EventHandler(this.order_brand_cb_SelectedIndexChanged);
            // 
            // order_model_cb
            // 
            this.order_model_cb.FormattingEnabled = true;
            this.order_model_cb.Location = new System.Drawing.Point(527, 215);
            this.order_model_cb.Name = "order_model_cb";
            this.order_model_cb.Size = new System.Drawing.Size(176, 21);
            this.order_model_cb.TabIndex = 3;
            this.order_model_cb.SelectedIndexChanged += new System.EventHandler(this.order_model_cb_SelectedIndexChanged);
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(429, 300);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(101, 33);
            this.order_btn.TabIndex = 4;
            this.order_btn.Text = "ORDER";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "MOBILE ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(468, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "PLEASE SELECT MOBILE MODEL AND CLICK HERE IF MOBILE ID NEEDED";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // order_info_gv
            // 
            this.order_info_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_info_gv.Location = new System.Drawing.Point(268, 472);
            this.order_info_gv.Name = "order_info_gv";
            this.order_info_gv.Size = new System.Drawing.Size(411, 90);
            this.order_info_gv.TabIndex = 9;
            // 
            // Order_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1073, 543);
            this.Controls.Add(this.order_info_gv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.order_model_cb);
            this.Controls.Add(this.order_brand_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order_page";
            this.Text = "ORDERFORM";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_info_gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox order_brand_cb;
        private System.Windows.Forms.ComboBox order_model_cb;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView order_info_gv;
    }
}