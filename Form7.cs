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
    public partial class Payment_page : Form
    {
        int t;
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");
        public Payment_page()
        {
            InitializeComponent();
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into payment(Customer_name,Customer_Phoneno,Customer_Address,Mobile_brand,Mobile_model,price,quantity) values('"+ cust_name_txt.Text + "'," + cust_phone_txt.Text + ",'" + address_txt.Text + "', '" + pay_brand_cb.Text + "','" + pay_model_cb.Text + "'," + price_txt.Text + ","+quantity_txtbox.Text+")",con);
            t=int.Parse(quantity_txtbox.Text);

            
           
            SqlCommand cd = new SqlCommand("update information set available=available-"+quantity_txtbox.Text+" where mobile_name='" + pay_model_cb.Text + "'", con);
            //MessageBox.Show("PAYMENT RECEIVED");
            cmd.ExecuteNonQuery();
            cd.ExecuteNonQuery();
            MessageBox.Show("PAYMENT RECEIVED");
           

            con.Close();
            //clear();
            

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
        }

        private void pay_brand_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (pay_brand_cb.Text == "SAMSUNG")
            {
                pay_model_cb.Text = "";
                pay_model_cb.Items.Add("Samsung Galaxy M30");
                pay_model_cb.Items.Add("Samsung Galaxy A51");
                pay_model_cb.Items.Add("Samsung Galaxy One");
                pay_model_cb.Items.Add("Samsung Galaxy A71");
                pay_model_cb.Items.Add("Samsung Galaxy A01");
                pay_model_cb.Items.Add("Samsung Galaxy M31");
                pay_model_cb.Items.Add("Samsung Galaxy A50");
                pay_model_cb.Items.Add("Samsung Galaxy A70");
                pay_model_cb.Items.Add("Samsung Galaxy J6");
                pay_model_cb.Items.Add("Samsung Galaxy J2");
                pay_model_cb.Items.Remove("Nokia E72");
                pay_model_cb.Items.Remove("Nokia 2.3");
                pay_model_cb.Items.Remove("Nokia 6.1 Plus");
                pay_model_cb.Items.Remove("Nokia 2.2");
                pay_model_cb.Items.Remove("Nokia 5.1 Plus");
                pay_model_cb.Items.Remove("Nokia 8.1");
                pay_model_cb.Items.Remove("Nokia 4.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Nokia 8.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("OPPO A9");
                pay_model_cb.Items.Remove("OPPO F11");
                pay_model_cb.Items.Remove("Oppo Reno 2Z");
                pay_model_cb.Items.Remove("Oppo Reno 3");
                pay_model_cb.Items.Remove("Oppo A5");
                pay_model_cb.Items.Remove("OPPO F11 Pro");
                pay_model_cb.Items.Remove("OPPO Reno 2");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("Vivo V17");
                pay_model_cb.Items.Remove("Vivo U20");
                pay_model_cb.Items.Remove("Vivo S1 Pro");
                pay_model_cb.Items.Remove("Vivo Z1 Pro");
                pay_model_cb.Items.Remove("Vivo V17 Pro");
                pay_model_cb.Items.Remove("Vivo U3");
                pay_model_cb.Items.Remove("Vivo S1");
                pay_model_cb.Items.Remove("Vivo V15 Pro");
                pay_model_cb.Items.Remove("Vivo X30 Pro");
                pay_model_cb.Items.Remove("Vivo Z1x");
                pay_model_cb.Items.Remove("Redmi Note 8 Pro");
                pay_model_cb.Items.Remove("Redmi Note 8");
                pay_model_cb.Items.Remove("Redmi Note 7 Pro");
                pay_model_cb.Items.Remove("Redmi 8A");
                pay_model_cb.Items.Remove("Redmi K20 Pro");
                pay_model_cb.Items.Remove("Xiaomi Mi A3");
                pay_model_cb.Items.Remove("Redmi K20");
                pay_model_cb.Items.Remove("Redmi 7");
                pay_model_cb.Items.Remove("Redmi 7A");
                pay_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (pay_brand_cb.Text == "NOKIA")
            {
                pay_model_cb.Text = "";
                pay_model_cb.Items.Add("Nokia E72");
                pay_model_cb.Items.Add("Nokia 2.3");
                pay_model_cb.Items.Add("Nokia 6.1 Plus");
                pay_model_cb.Items.Add("Nokia 2.2");
                pay_model_cb.Items.Add("Nokia 5.1 Plus");
                pay_model_cb.Items.Add("Nokia 8.1");
                pay_model_cb.Items.Add("Nokia 4.2");
                pay_model_cb.Items.Add("Nokia 7.2");
                pay_model_cb.Items.Add("Nokia 8.2");
                pay_model_cb.Items.Add("Nokia 7.2");
                pay_model_cb.Items.Remove("Samsung Galaxy M30");
                pay_model_cb.Items.Remove("Samsung Galaxy A51");
                pay_model_cb.Items.Remove("Samsung Galaxy One");
                pay_model_cb.Items.Remove("Samsung Galaxy A71");
                pay_model_cb.Items.Remove("Samsung Galaxy A01");
                pay_model_cb.Items.Remove("Samsung Galaxy M31");
                pay_model_cb.Items.Remove("Samsung Galaxy A50");
                pay_model_cb.Items.Remove("Samsung Galaxy A70");
                pay_model_cb.Items.Remove("Samsung Galaxy J6");
                pay_model_cb.Items.Remove("Samsung Galaxy J2");
                pay_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("OPPO A9");
                pay_model_cb.Items.Remove("OPPO F11");
                pay_model_cb.Items.Remove("Oppo Reno 2Z");
                pay_model_cb.Items.Remove("Oppo Reno 3");
                pay_model_cb.Items.Remove("Oppo A5");
                pay_model_cb.Items.Remove("OPPO F11 Pro");
                pay_model_cb.Items.Remove("OPPO Reno 2");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("Vivo V17");
                pay_model_cb.Items.Remove("Vivo U20");
                pay_model_cb.Items.Remove("Vivo S1 Pro");
                pay_model_cb.Items.Remove("Vivo Z1 Pro");
                pay_model_cb.Items.Remove("Vivo V17 Pro");
                pay_model_cb.Items.Remove("Vivo U3");
                pay_model_cb.Items.Remove("Vivo S1");
                pay_model_cb.Items.Remove("Vivo V15 Pro");
                pay_model_cb.Items.Remove("Vivo X30 Pro");
                pay_model_cb.Items.Remove("Vivo Z1x");
                pay_model_cb.Items.Remove("Redmi Note 8 Pro");
                pay_model_cb.Items.Remove("Redmi Note 8");
                pay_model_cb.Items.Remove("Redmi Note 7 Pro");
                pay_model_cb.Items.Remove("Redmi 8A");
                pay_model_cb.Items.Remove("Redmi K20 Pro");
                pay_model_cb.Items.Remove("Xiaomi Mi A3");
                pay_model_cb.Items.Remove("Redmi K20");
                pay_model_cb.Items.Remove("Redmi 7");
                pay_model_cb.Items.Remove("Redmi 7A");
                pay_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (pay_brand_cb.Text == "OPPO")
            {
                pay_model_cb.Items.Add("Oppo Reno 3 Pro 5G");
                pay_model_cb.Items.Add("Oppo K5");
                pay_model_cb.Items.Add("OPPO A9");
                pay_model_cb.Items.Add("OPPO F11");
                pay_model_cb.Items.Add("Oppo Reno 2Z");
                pay_model_cb.Items.Add("Oppo Reno 3");
                pay_model_cb.Items.Add("Oppo A5");
                pay_model_cb.Items.Add("OPPO F11 Pro");
                pay_model_cb.Items.Add("OPPO Reno 2");
                pay_model_cb.Items.Add("Oppo K5");
                pay_model_cb.Items.Remove("Samsung Galaxy M30");
                pay_model_cb.Items.Remove("Samsung Galaxy A51");
                pay_model_cb.Items.Remove("Samsung Galaxy One");
                pay_model_cb.Items.Remove("Samsung Galaxy A71");
                pay_model_cb.Items.Remove("Samsung Galaxy A01");
                pay_model_cb.Items.Remove("Samsung Galaxy M31");
                pay_model_cb.Items.Remove("Samsung Galaxy A50");
                pay_model_cb.Items.Remove("Samsung Galaxy A70");
                pay_model_cb.Items.Remove("Samsung Galaxy J6");
                pay_model_cb.Items.Remove("Samsung Galaxy J2");
                pay_model_cb.Items.Remove("Nokia E72");
                pay_model_cb.Items.Remove("Nokia 2.3");
                pay_model_cb.Items.Remove("Nokia 6.1 Plus");
                pay_model_cb.Items.Remove("Nokia 2.2");
                pay_model_cb.Items.Remove("Nokia 5.1 Plus");
                pay_model_cb.Items.Remove("Nokia 8.1");
                pay_model_cb.Items.Remove("Nokia 4.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Nokia 8.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Vivo V17");
                pay_model_cb.Items.Remove("Vivo U20");
                pay_model_cb.Items.Remove("Vivo S1 Pro");
                pay_model_cb.Items.Remove("Vivo Z1 Pro");
                pay_model_cb.Items.Remove("Vivo V17 Pro");
                pay_model_cb.Items.Remove("Vivo U3");
                pay_model_cb.Items.Remove("Vivo S1");
                pay_model_cb.Items.Remove("Vivo V15 Pro");
                pay_model_cb.Items.Remove("Vivo X30 Pro");
                pay_model_cb.Items.Remove("Vivo Z1x");
                pay_model_cb.Items.Remove("Redmi Note 8 Pro");
                pay_model_cb.Items.Remove("Redmi Note 8");
                pay_model_cb.Items.Remove("Redmi Note 7 Pro");
                pay_model_cb.Items.Remove("Redmi 8A");
                pay_model_cb.Items.Remove("Redmi K20 Pro");
                pay_model_cb.Items.Remove("Xiaomi Mi A3");
                pay_model_cb.Items.Remove("Redmi K20");
                pay_model_cb.Items.Remove("Redmi 7");
                pay_model_cb.Items.Remove("Redmi 7A");
                pay_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (pay_brand_cb.Text == "VIVO")
            {
                pay_model_cb.Items.Add("Vivo V17");
                pay_model_cb.Items.Add("Vivo U20");
                pay_model_cb.Items.Add("Vivo S1 Pro");
                pay_model_cb.Items.Add("Vivo Z1 Pro");
                pay_model_cb.Items.Add("Vivo V17 Pro");
                pay_model_cb.Items.Add("Vivo U3");
                pay_model_cb.Items.Add("Vivo S1");
                pay_model_cb.Items.Add("Vivo V15 Pro");
                pay_model_cb.Items.Add("Vivo X30 Pro");
                pay_model_cb.Items.Add("Vivo Z1x");
                pay_model_cb.Items.Remove("Samsung Galaxy M30");
                pay_model_cb.Items.Remove("Samsung Galaxy A51");
                pay_model_cb.Items.Remove("Samsung Galaxy One");
                pay_model_cb.Items.Remove("Samsung Galaxy A71");
                pay_model_cb.Items.Remove("Samsung Galaxy A01");
                pay_model_cb.Items.Remove("Samsung Galaxy M31");
                pay_model_cb.Items.Remove("Samsung Galaxy A50");
                pay_model_cb.Items.Remove("Samsung Galaxy A70");
                pay_model_cb.Items.Remove("Samsung Galaxy J6");
                pay_model_cb.Items.Remove("Samsung Galaxy J2");
                pay_model_cb.Items.Remove("Nokia E72");
                pay_model_cb.Items.Remove("Nokia 2.3");
                pay_model_cb.Items.Remove("Nokia 6.1 Plus");
                pay_model_cb.Items.Remove("Nokia 2.2");
                pay_model_cb.Items.Remove("Nokia 5.1 Plus");
                pay_model_cb.Items.Remove("Nokia 8.1");
                pay_model_cb.Items.Remove("Nokia 4.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Nokia 8.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("OPPO A9");
                pay_model_cb.Items.Remove("OPPO F11");
                pay_model_cb.Items.Remove("Oppo Reno 2Z");
                pay_model_cb.Items.Remove("Oppo Reno 3");
                pay_model_cb.Items.Remove("Oppo A5");
                pay_model_cb.Items.Remove("OPPO F11 Pro");
                pay_model_cb.Items.Remove("OPPO Reno 2");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("Redmi Note 8 Pro");
                pay_model_cb.Items.Remove("Redmi Note 8");
                pay_model_cb.Items.Remove("Redmi Note 7 Pro");
                pay_model_cb.Items.Remove("Redmi 8A");
                pay_model_cb.Items.Remove("Redmi K20 Pro");
                pay_model_cb.Items.Remove("Xiaomi Mi A3");
                pay_model_cb.Items.Remove("Redmi K20");
                pay_model_cb.Items.Remove("Redmi 7");
                pay_model_cb.Items.Remove("Redmi 7A");
                pay_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (pay_brand_cb.Text == "REDMI")
            {
                pay_model_cb.Items.Add("Redmi Note 8 Pro");
                pay_model_cb.Items.Add("Redmi Note 8");
                pay_model_cb.Items.Add("Redmi Note 7 Pro");
                pay_model_cb.Items.Add("Redmi 8A");
                pay_model_cb.Items.Add("Redmi K20 Pro");
                pay_model_cb.Items.Add("Xiaomi Mi A3");
                pay_model_cb.Items.Add("Redmi K20");
                pay_model_cb.Items.Add("Redmi 7");
                pay_model_cb.Items.Add("Redmi 7A");
                pay_model_cb.Items.Add("Redmi Note 7S");
                pay_model_cb.Items.Remove("Samsung Galaxy M30");
                pay_model_cb.Items.Remove("Samsung Galaxy A51");
                pay_model_cb.Items.Remove("Samsung Galaxy One");
                pay_model_cb.Items.Remove("Samsung Galaxy A71");
                pay_model_cb.Items.Remove("Samsung Galaxy A01");
                pay_model_cb.Items.Remove("Samsung Galaxy M31");
                pay_model_cb.Items.Remove("Samsung Galaxy A50");
                pay_model_cb.Items.Remove("Samsung Galaxy A70");
                pay_model_cb.Items.Remove("Samsung Galaxy J6");
                pay_model_cb.Items.Remove("Samsung Galaxy J2");
                pay_model_cb.Items.Remove("Nokia E72");
                pay_model_cb.Items.Remove("Nokia 2.3");
                pay_model_cb.Items.Remove("Nokia 6.1 Plus");
                pay_model_cb.Items.Remove("Nokia 2.2");
                pay_model_cb.Items.Remove("Nokia 5.1 Plus");
                pay_model_cb.Items.Remove("Nokia 8.1");
                pay_model_cb.Items.Remove("Nokia 4.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Nokia 8.2");
                pay_model_cb.Items.Remove("Nokia 7.2");
                pay_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("OPPO A9");
                pay_model_cb.Items.Remove("OPPO F11");
                pay_model_cb.Items.Remove("Oppo Reno 2Z");
                pay_model_cb.Items.Remove("Oppo Reno 3");
                pay_model_cb.Items.Remove("Oppo A5");
                pay_model_cb.Items.Remove("OPPO F11 Pro");
                pay_model_cb.Items.Remove("OPPO Reno 2");
                pay_model_cb.Items.Remove("Oppo K5");
                pay_model_cb.Items.Remove("Vivo V17");
                pay_model_cb.Items.Remove("Vivo U20");
                pay_model_cb.Items.Remove("Vivo S1 Pro");
                pay_model_cb.Items.Remove("Vivo Z1 Pro");
                pay_model_cb.Items.Remove("Vivo V17 Pro");
                pay_model_cb.Items.Remove("Vivo U3");
                pay_model_cb.Items.Remove("Vivo S1");
                pay_model_cb.Items.Remove("Vivo V15 Pro");
                pay_model_cb.Items.Remove("Vivo X30 Pro");
                pay_model_cb.Items.Remove("Vivo Z1x");
            }
        }

        private void Shopkeeper_homebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void Payment_page_Load(object sender, EventArgs e)
        {
            payment__price_GV.Visible = false;
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

        private void cust_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pay_model_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            payment__price_GV.Visible = true;

            con.Open();
            SqlCommand cmd = new SqlCommand("select mobile_brand,mobile_name,price from information where mobile_name='" + pay_model_cb.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {


                payment__price_GV.DataSource = ds.Tables[0];
            }
            con.Close();
        }

        private void payment__price_GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void price_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cust_phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quantity_txtbox_TextChanged(object sender, EventArgs e)
        {
            int price = int.Parse(price_txt.Text);
            int qty = int.Parse(quantity_txtbox.Text);
            total_price_txtbox.Text = (price * qty).ToString();
        }

        private void total_price_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
