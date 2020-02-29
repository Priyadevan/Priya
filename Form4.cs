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
    public partial class Specification_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");
        public Specification_page()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void spec_purchase_btn_Click(object sender, EventArgs e)
        {
            Payment_page f7 = new Payment_page();
            f7.Show();
            this.Hide();
        }

        private void Specification_page_Load(object sender, EventArgs e)
        {
            Specification_GV.Visible = false;
        }

        private void Specification_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
          
            SqlCommand cmd = new SqlCommand("select * from information where mobile_brand='" + Specification_cb.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("PLEASE CHECK WITH THE INFORMATION PROVIDED");

                Specification_GV.DataSource = ds.Tables[0];
            }
            Specification_GV.Visible = true;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (LOGINFORM.role == "owner")
            {
                Owner_page op = new Owner_page();
                op.Show();
                this.Hide();
            }
            else if(LOGINFORM.role=="shopkeeper")
            {
                Shopkeeper_page s1 = new Shopkeeper_page();
                s1.Show();
                this.Hide();
            }
        }

        private void Specification_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
