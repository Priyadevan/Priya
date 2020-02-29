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
    public partial class Order_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");

        public Order_page()
        {
            InitializeComponent();
        }

        private void order_brand_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (order_brand_cb.Text == "SAMSUNG")
            {
                order_model_cb.Text = "";
                order_model_cb.Items.Add("Samsung Galaxy M30");
                order_model_cb.Items.Add("Samsung Galaxy A51");
                order_model_cb.Items.Add("Samsung Galaxy One");
                order_model_cb.Items.Add("Samsung Galaxy A71");
                order_model_cb.Items.Add("Samsung Galaxy A01");
                order_model_cb.Items.Add("Samsung Galaxy M31");
                order_model_cb.Items.Add("Samsung Galaxy A50");
                order_model_cb.Items.Add("Samsung Galaxy A70");
                order_model_cb.Items.Add("Samsung Galaxy J6");
                order_model_cb.Items.Add("Samsung Galaxy J2");
                order_model_cb.Items.Remove("Nokia E72");
                order_model_cb.Items.Remove("Nokia 2.3");
                order_model_cb.Items.Remove("Nokia 6.1 Plus");
                order_model_cb.Items.Remove("Nokia 2.2");
                order_model_cb.Items.Remove("Nokia 5.1 Plus");
                order_model_cb.Items.Remove("Nokia 8.1");
                order_model_cb.Items.Remove("Nokia 4.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Nokia 8.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("OPPO A9");
                order_model_cb.Items.Remove("OPPO F11");
                order_model_cb.Items.Remove("Oppo Reno 2Z");
                order_model_cb.Items.Remove("Oppo Reno 3");
                order_model_cb.Items.Remove("Oppo A5");
                order_model_cb.Items.Remove("OPPO F11 Pro");
                order_model_cb.Items.Remove("OPPO Reno 2");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("Vivo V17");
                order_model_cb.Items.Remove("Vivo U20");
                order_model_cb.Items.Remove("Vivo S1 Pro");
                order_model_cb.Items.Remove("Vivo Z1 Pro");
                order_model_cb.Items.Remove("Vivo V17 Pro");
                order_model_cb.Items.Remove("Vivo U3");
                order_model_cb.Items.Remove("Vivo S1");
                order_model_cb.Items.Remove("Vivo V15 Pro");
                order_model_cb.Items.Remove("Vivo X30 Pro");
                order_model_cb.Items.Remove("Vivo Z1x");
                order_model_cb.Items.Remove("Redmi Note 8 Pro");
                order_model_cb.Items.Remove("Redmi Note 8");
                order_model_cb.Items.Remove("Redmi Note 7 Pro");
                order_model_cb.Items.Remove("Redmi 8A");
                order_model_cb.Items.Remove("Redmi K20 Pro");
                order_model_cb.Items.Remove("Xiaomi Mi A3");
                order_model_cb.Items.Remove("Redmi K20");
                order_model_cb.Items.Remove("Redmi 7");
                order_model_cb.Items.Remove("Redmi 7A");
                order_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (order_brand_cb.Text == "NOKIA")
            {
                order_model_cb.Text = "";
                order_model_cb.Items.Add("Nokia E72");
                order_model_cb.Items.Add("Nokia 2.3");
                order_model_cb.Items.Add("Nokia 6.1 Plus");
                order_model_cb.Items.Add("Nokia 2.2");
                order_model_cb.Items.Add("Nokia 5.1 Plus");
                order_model_cb.Items.Add("Nokia 8.1");
                order_model_cb.Items.Add("Nokia 4.2");
                order_model_cb.Items.Add("Nokia 7.2");
                order_model_cb.Items.Add("Nokia 8.2");
                order_model_cb.Items.Add("Nokia 7.2");
                order_model_cb.Items.Remove("Samsung Galaxy M30");
                order_model_cb.Items.Remove("Samsung Galaxy A51");
                order_model_cb.Items.Remove("Samsung Galaxy One");
                order_model_cb.Items.Remove("Samsung Galaxy A71");
                order_model_cb.Items.Remove("Samsung Galaxy A01");
                order_model_cb.Items.Remove("Samsung Galaxy M31");
                order_model_cb.Items.Remove("Samsung Galaxy A50");
                order_model_cb.Items.Remove("Samsung Galaxy A70");
                order_model_cb.Items.Remove("Samsung Galaxy J6");
                order_model_cb.Items.Remove("Samsung Galaxy J2");
                order_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("OPPO A9");
                order_model_cb.Items.Remove("OPPO F11");
                order_model_cb.Items.Remove("Oppo Reno 2Z");
                order_model_cb.Items.Remove("Oppo Reno 3");
                order_model_cb.Items.Remove("Oppo A5");
                order_model_cb.Items.Remove("OPPO F11 Pro");
                order_model_cb.Items.Remove("OPPO Reno 2");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("Vivo V17");
                order_model_cb.Items.Remove("Vivo U20");
                order_model_cb.Items.Remove("Vivo S1 Pro");
                order_model_cb.Items.Remove("Vivo Z1 Pro");
                order_model_cb.Items.Remove("Vivo V17 Pro");
                order_model_cb.Items.Remove("Vivo U3");
                order_model_cb.Items.Remove("Vivo S1");
                order_model_cb.Items.Remove("Vivo V15 Pro");
                order_model_cb.Items.Remove("Vivo X30 Pro");
                order_model_cb.Items.Remove("Vivo Z1x");
                order_model_cb.Items.Remove("Redmi Note 8 Pro");
                order_model_cb.Items.Remove("Redmi Note 8");
                order_model_cb.Items.Remove("Redmi Note 7 Pro");
                order_model_cb.Items.Remove("Redmi 8A");
                order_model_cb.Items.Remove("Redmi K20 Pro");
                order_model_cb.Items.Remove("Xiaomi Mi A3");
                order_model_cb.Items.Remove("Redmi K20");
                order_model_cb.Items.Remove("Redmi 7");
                order_model_cb.Items.Remove("Redmi 7A");
                order_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (order_brand_cb.Text == "OPPO")
            {
                order_model_cb.Items.Add("Oppo Reno 3 Pro 5G");
                order_model_cb.Items.Add("Oppo K5");
                order_model_cb.Items.Add("OPPO A9");
                order_model_cb.Items.Add("OPPO F11");
                order_model_cb.Items.Add("Oppo Reno 2Z");
                order_model_cb.Items.Add("Oppo Reno 3");
                order_model_cb.Items.Add("Oppo A5");
                order_model_cb.Items.Add("OPPO F11 Pro");
                order_model_cb.Items.Add("OPPO Reno 2");
                order_model_cb.Items.Add("Oppo K5");
                order_model_cb.Items.Remove("Samsung Galaxy M30");
                order_model_cb.Items.Remove("Samsung Galaxy A51");
                order_model_cb.Items.Remove("Samsung Galaxy One");
                order_model_cb.Items.Remove("Samsung Galaxy A71");
                order_model_cb.Items.Remove("Samsung Galaxy A01");
                order_model_cb.Items.Remove("Samsung Galaxy M31");
                order_model_cb.Items.Remove("Samsung Galaxy A50");
                order_model_cb.Items.Remove("Samsung Galaxy A70");
                order_model_cb.Items.Remove("Samsung Galaxy J6");
                order_model_cb.Items.Remove("Samsung Galaxy J2");
                order_model_cb.Items.Remove("Nokia E72");
                order_model_cb.Items.Remove("Nokia 2.3");
                order_model_cb.Items.Remove("Nokia 6.1 Plus");
                order_model_cb.Items.Remove("Nokia 2.2");
                order_model_cb.Items.Remove("Nokia 5.1 Plus");
                order_model_cb.Items.Remove("Nokia 8.1");
                order_model_cb.Items.Remove("Nokia 4.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Nokia 8.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Vivo V17");
                order_model_cb.Items.Remove("Vivo U20");
                order_model_cb.Items.Remove("Vivo S1 Pro");
                order_model_cb.Items.Remove("Vivo Z1 Pro");
                order_model_cb.Items.Remove("Vivo V17 Pro");
                order_model_cb.Items.Remove("Vivo U3");
                order_model_cb.Items.Remove("Vivo S1");
                order_model_cb.Items.Remove("Vivo V15 Pro");
                order_model_cb.Items.Remove("Vivo X30 Pro");
                order_model_cb.Items.Remove("Vivo Z1x");
                order_model_cb.Items.Remove("Redmi Note 8 Pro");
                order_model_cb.Items.Remove("Redmi Note 8");
                order_model_cb.Items.Remove("Redmi Note 7 Pro");
                order_model_cb.Items.Remove("Redmi 8A");
                order_model_cb.Items.Remove("Redmi K20 Pro");
                order_model_cb.Items.Remove("Xiaomi Mi A3");
                order_model_cb.Items.Remove("Redmi K20");
                order_model_cb.Items.Remove("Redmi 7");
                order_model_cb.Items.Remove("Redmi 7A");
                order_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (order_brand_cb.Text == "VIVO")
            {
                order_model_cb.Items.Add("Vivo V17");
                order_model_cb.Items.Add("Vivo U20");
                order_model_cb.Items.Add("Vivo S1 Pro");
                order_model_cb.Items.Add("Vivo Z1 Pro");
                order_model_cb.Items.Add("Vivo V17 Pro");
                order_model_cb.Items.Add("Vivo U3");
                order_model_cb.Items.Add("Vivo S1");
                order_model_cb.Items.Add("Vivo V15 Pro");
                order_model_cb.Items.Add("Vivo X30 Pro");
                order_model_cb.Items.Add("Vivo Z1x");
                order_model_cb.Items.Remove("Samsung Galaxy M30");
                order_model_cb.Items.Remove("Samsung Galaxy A51");
                order_model_cb.Items.Remove("Samsung Galaxy One");
                order_model_cb.Items.Remove("Samsung Galaxy A71");
                order_model_cb.Items.Remove("Samsung Galaxy A01");
                order_model_cb.Items.Remove("Samsung Galaxy M31");
                order_model_cb.Items.Remove("Samsung Galaxy A50");
                order_model_cb.Items.Remove("Samsung Galaxy A70");
                order_model_cb.Items.Remove("Samsung Galaxy J6");
                order_model_cb.Items.Remove("Samsung Galaxy J2");
                order_model_cb.Items.Remove("Nokia E72");
                order_model_cb.Items.Remove("Nokia 2.3");
                order_model_cb.Items.Remove("Nokia 6.1 Plus");
                order_model_cb.Items.Remove("Nokia 2.2");
                order_model_cb.Items.Remove("Nokia 5.1 Plus");
                order_model_cb.Items.Remove("Nokia 8.1");
                order_model_cb.Items.Remove("Nokia 4.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Nokia 8.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("OPPO A9");
                order_model_cb.Items.Remove("OPPO F11");
                order_model_cb.Items.Remove("Oppo Reno 2Z");
                order_model_cb.Items.Remove("Oppo Reno 3");
                order_model_cb.Items.Remove("Oppo A5");
                order_model_cb.Items.Remove("OPPO F11 Pro");
                order_model_cb.Items.Remove("OPPO Reno 2");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("Redmi Note 8 Pro");
                order_model_cb.Items.Remove("Redmi Note 8");
                order_model_cb.Items.Remove("Redmi Note 7 Pro");
                order_model_cb.Items.Remove("Redmi 8A");
                order_model_cb.Items.Remove("Redmi K20 Pro");
                order_model_cb.Items.Remove("Xiaomi Mi A3");
                order_model_cb.Items.Remove("Redmi K20");
                order_model_cb.Items.Remove("Redmi 7");
                order_model_cb.Items.Remove("Redmi 7A");
                order_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (order_brand_cb.Text == "REDMI")
            {
                order_model_cb.Items.Add("Redmi Note 8 Pro");
                order_model_cb.Items.Add("Redmi Note 8");
                order_model_cb.Items.Add("Redmi Note 7 Pro");
                order_model_cb.Items.Add("Redmi 8A");
                order_model_cb.Items.Add("Redmi K20 Pro");
                order_model_cb.Items.Add("Xiaomi Mi A3");
                order_model_cb.Items.Add("Redmi K20");
                order_model_cb.Items.Add("Redmi 7");
                order_model_cb.Items.Add("Redmi 7A");
                order_model_cb.Items.Add("Redmi Note 7S");
                order_model_cb.Items.Remove("Samsung Galaxy M30");
                order_model_cb.Items.Remove("Samsung Galaxy A51");
                order_model_cb.Items.Remove("Samsung Galaxy One");
                order_model_cb.Items.Remove("Samsung Galaxy A71");
                order_model_cb.Items.Remove("Samsung Galaxy A01");
                order_model_cb.Items.Remove("Samsung Galaxy M31");
                order_model_cb.Items.Remove("Samsung Galaxy A50");
                order_model_cb.Items.Remove("Samsung Galaxy A70");
                order_model_cb.Items.Remove("Samsung Galaxy J6");
                order_model_cb.Items.Remove("Samsung Galaxy J2");
                order_model_cb.Items.Remove("Nokia E72");
                order_model_cb.Items.Remove("Nokia 2.3");
                order_model_cb.Items.Remove("Nokia 6.1 Plus");
                order_model_cb.Items.Remove("Nokia 2.2");
                order_model_cb.Items.Remove("Nokia 5.1 Plus");
                order_model_cb.Items.Remove("Nokia 8.1");
                order_model_cb.Items.Remove("Nokia 4.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Nokia 8.2");
                order_model_cb.Items.Remove("Nokia 7.2");
                order_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("OPPO A9");
                order_model_cb.Items.Remove("OPPO F11");
                order_model_cb.Items.Remove("Oppo Reno 2Z");
                order_model_cb.Items.Remove("Oppo Reno 3");
                order_model_cb.Items.Remove("Oppo A5");
                order_model_cb.Items.Remove("OPPO F11 Pro");
                order_model_cb.Items.Remove("OPPO Reno 2");
                order_model_cb.Items.Remove("Oppo K5");
                order_model_cb.Items.Remove("Vivo V17");
                order_model_cb.Items.Remove("Vivo U20");
                order_model_cb.Items.Remove("Vivo S1 Pro");
                order_model_cb.Items.Remove("Vivo Z1 Pro");
                order_model_cb.Items.Remove("Vivo V17 Pro");
                order_model_cb.Items.Remove("Vivo U3");
                order_model_cb.Items.Remove("Vivo S1");
                order_model_cb.Items.Remove("Vivo V15 Pro");
                order_model_cb.Items.Remove("Vivo X30 Pro");
                order_model_cb.Items.Remove("Vivo Z1x");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            order_info_gv.Visible = false;
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            if (LOGINFORM.role == "owner")
            {
                MessageBox.Show("Mobile Ordered");
                Owner_page op = new Owner_page();
                op.Show();
                this.Hide();
            }
            else if (LOGINFORM.role == "shopkeeper")
            {
                MessageBox.Show("Information passed to the Owner");
                Shopkeeper_page s1 = new Shopkeeper_page();
                s1.Show();
                this.Hide();
            }
            
        }

        private void order_model_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            order_info_gv.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select mobile_ID,mobile_brand,mobile_name from information where mobile_name='" + order_model_cb.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {


                order_info_gv.DataSource = ds.Tables[0];
            }
            con.Close();
        }
    }
}
