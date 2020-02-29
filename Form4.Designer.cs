namespace WindowsFormsApplication1
{
    partial class Specification_page
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
            this.spec_purchase_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Specification_GV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Specification_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Specification_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // spec_purchase_btn
            // 
            this.spec_purchase_btn.Location = new System.Drawing.Point(441, 482);
            this.spec_purchase_btn.Name = "spec_purchase_btn";
            this.spec_purchase_btn.Size = new System.Drawing.Size(153, 45);
            this.spec_purchase_btn.TabIndex = 2;
            this.spec_purchase_btn.Text = "PURCHASE MOBILE";
            this.spec_purchase_btn.UseVisualStyleBackColor = true;
            this.spec_purchase_btn.Click += new System.EventHandler(this.spec_purchase_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(951, 31);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 22);
            this.Home_btn.TabIndex = 4;
            this.Home_btn.Text = "HOME";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Specification_GV
            // 
            this.Specification_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Specification_GV.Location = new System.Drawing.Point(86, 190);
            this.Specification_GV.Name = "Specification_GV";
            this.Specification_GV.Size = new System.Drawing.Size(940, 266);
            this.Specification_GV.TabIndex = 6;
            this.Specification_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Specification_GV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MOBILE BRAND";
            // 
            // Specification_cb
            // 
            this.Specification_cb.FormattingEnabled = true;
            this.Specification_cb.Items.AddRange(new object[] {
            "SAMSUNG",
            "NOKIA",
            "OPPO",
            "VIVO",
            "REDMI"});
            this.Specification_cb.Location = new System.Drawing.Point(558, 106);
            this.Specification_cb.Name = "Specification_cb";
            this.Specification_cb.Size = new System.Drawing.Size(121, 21);
            this.Specification_cb.TabIndex = 8;
            this.Specification_cb.SelectedIndexChanged += new System.EventHandler(this.Specification_cb_SelectedIndexChanged);
            // 
            // Specification_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1057, 539);
            this.Controls.Add(this.Specification_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Specification_GV);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.spec_purchase_btn);
            this.Name = "Specification_page";
            this.Text = "MOBILE SPECIFICATION";
            this.Load += new System.EventHandler(this.Specification_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Specification_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spec_purchase_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.DataGridView Specification_GV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Specification_cb;
    }
}