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
    public partial class Stock_Available : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");
        public Stock_Available()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Stock_available_GV.Visible = false;

        }

        private void check_avail_gb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
         
            SqlCommand cmd = new SqlCommand("select * from mobile_available where mobile_brand='" + check_avail_gb.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
               
               
                Stock_available_GV.DataSource = ds.Tables[0];
            }
            Stock_available_GV.Visible = true;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LOGINFORM.role == "owner")
            {
                Owner_page op = new Owner_page();
                op.Show();
                this.Hide();
            }
            else if (LOGINFORM.role == "shopkeeper")
            {
                Shopkeeper_page s1 = new Shopkeeper_page();
                s1.Show();
                this.Hide();
            }
        }

        private void Shopkeeper_home_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Stock_available_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
