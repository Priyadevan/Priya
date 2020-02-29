using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Owner_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");
        public Owner_page()
        {
            InitializeComponent();
        }
        //string available;
        //int mobile_ID;


        private void stock_available_btn_Click(object sender, EventArgs e)
        {
            Stock_Available s =new Stock_Available();
            s.Show();
            this.Hide();
         
        }

        private void STOCK_ORDERED_BTN_Click(object sender, EventArgs e)
        {
            Mobile_Detail f = new Mobile_Detail();
            f.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order_page f = new Order_page();
            f.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Payment_page f1 = new Payment_page();
            f1.Show();
            this.Hide();
        }

        private void Owner_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGINFORM lf = new LOGINFORM();
            lf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Specification_page s1 = new Specification_page();
            s1.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Order_page op = new Order_page();
            op.Show();
            this.Hide();
        }
         

           
                   
                  
    }
}
