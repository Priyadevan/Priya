using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Shopkeeper_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");
        public Shopkeeper_page()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void sk_model_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void sk_brand_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void sk_check_btn_Click(object sender, EventArgs e)
        {
            Stock_Available f = new Stock_Available();
            f.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment_page sa = new Payment_page();
            sa.Show();
            this.Hide();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Specification_page f4 = new Specification_page();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LOGINFORM lf1 = new LOGINFORM();
            lf1.Show();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order_page op = new Order_page();
            op.Show();
            this.Hide();
        }
    }
}
