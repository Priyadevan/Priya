namespace WindowsFormsApplication1
{
    partial class Owner_page
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
            this.stock_available_btn = new System.Windows.Forms.Button();
            this.STOCK_ORDERED_BTN = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Check_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO OUR MOBILE SHOP!!!";
            // 
            // stock_available_btn
            // 
            this.stock_available_btn.Location = new System.Drawing.Point(135, 177);
            this.stock_available_btn.Name = "stock_available_btn";
            this.stock_available_btn.Size = new System.Drawing.Size(151, 48);
            this.stock_available_btn.TabIndex = 1;
            this.stock_available_btn.Text = "STOCK-AVAILABLE";
            this.stock_available_btn.UseVisualStyleBackColor = true;
            this.stock_available_btn.Click += new System.EventHandler(this.stock_available_btn_Click);
            // 
            // STOCK_ORDERED_BTN
            // 
            this.STOCK_ORDERED_BTN.Location = new System.Drawing.Point(426, 177);
            this.STOCK_ORDERED_BTN.Name = "STOCK_ORDERED_BTN";
            this.STOCK_ORDERED_BTN.Size = new System.Drawing.Size(148, 45);
            this.STOCK_ORDERED_BTN.TabIndex = 2;
            this.STOCK_ORDERED_BTN.Text = "NEW-STOCK ARRIVAL";
            this.STOCK_ORDERED_BTN.UseVisualStyleBackColor = true;
            this.STOCK_ORDERED_BTN.Click += new System.EventHandler(this.STOCK_ORDERED_BTN_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "ORDER MOBILE FOR SHOP";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(135, 402);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "ORDER MOBILE FOR CUSTOMER";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "LOGIN_PAGE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check_btn
            // 
            this.Check_btn.Location = new System.Drawing.Point(712, 177);
            this.Check_btn.Name = "Check_btn";
            this.Check_btn.Size = new System.Drawing.Size(153, 48);
            this.Check_btn.TabIndex = 10;
            this.Check_btn.Text = "CHECK SPECIFICATION";
            this.Check_btn.UseVisualStyleBackColor = true;
            this.Check_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "MOBILE NEED TO BE ORDERED";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Owner_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1066, 516);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Check_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.STOCK_ORDERED_BTN);
            this.Controls.Add(this.stock_available_btn);
            this.Controls.Add(this.label1);
            this.Name = "Owner_page";
            this.Text = "OWNER-HOMEPAGE";
            this.Load += new System.EventHandler(this.Owner_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stock_available_btn;
        private System.Windows.Forms.Button STOCK_ORDERED_BTN;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Check_btn;
        private System.Windows.Forms.Button button2;

    }
}