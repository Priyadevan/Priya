namespace WindowsFormsApplication1
{
    partial class Stock_Available
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
            this.check_avail_gb = new System.Windows.Forms.ComboBox();
            this.Stock_available_GV = new System.Windows.Forms.DataGridView();
            this.Home_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Stock_available_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOBILE BRAND";
            // 
            // check_avail_gb
            // 
            this.check_avail_gb.FormattingEnabled = true;
            this.check_avail_gb.Items.AddRange(new object[] {
            "SAMSUNG",
            "NOKIA",
            "OPPO",
            "VIVO",
            "REDMI"});
            this.check_avail_gb.Location = new System.Drawing.Point(525, 100);
            this.check_avail_gb.Name = "check_avail_gb";
            this.check_avail_gb.Size = new System.Drawing.Size(121, 21);
            this.check_avail_gb.TabIndex = 1;
            this.check_avail_gb.SelectedIndexChanged += new System.EventHandler(this.check_avail_gb_SelectedIndexChanged);
            // 
            // Stock_available_GV
            // 
            this.Stock_available_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stock_available_GV.Location = new System.Drawing.Point(236, 200);
            this.Stock_available_GV.Name = "Stock_available_GV";
            this.Stock_available_GV.Size = new System.Drawing.Size(621, 267);
            this.Stock_available_GV.TabIndex = 2;
            this.Stock_available_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stock_available_GV_CellContentClick);
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(935, 30);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 3;
            this.Home_btn.Text = "HOME";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please select MOBILE BRAND to check the available stock!!!";
            // 
            // Stock_Available
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1051, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.Stock_available_GV);
            this.Controls.Add(this.check_avail_gb);
            this.Controls.Add(this.label1);
            this.Name = "Stock_Available";
            this.Text = "STOCK AVAILABLE";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stock_available_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox check_avail_gb;
        private System.Windows.Forms.DataGridView Stock_available_GV;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Label label2;
    }
}