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
    public partial class Mobile_Detail : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");
        public Mobile_Detail()
        {
            InitializeComponent();
        }


        private void submit_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into information values(" + mobile_id_txt.Text + ",'" + mobile_brand_cb.Text + "','" + info_model_cb.Text + "', " + price_txt.Text + ",'" + ram_txt.Text + "','" + processor_txt.Text + "','" + battery_txt.Text + "','" + display_txt.Text + "','" + camera_txt.Text + "','" + memory_card_txt.Text + "'," + available_rtb.Text + "," + quantity_txtbox.Text + ")", con);


            //int qty = int.Parse(quantity_txtbox.Text);
          //  SqlCommand cmdd = new SqlCommand("select available from information where mobile_name='" + info_model_cb.Text + "'", con);
           // int avail = Convert.ToInt32(cmd.ExecuteScalar());
            //int qty = Convert.ToInt32(quantity_txtbox.Text);
            //avail = avail + qty;
            //available_rtb.AppendText(avail.ToString());

            SqlCommand cd = new SqlCommand("update information set available=available+" + quantity_txtbox.Text + " where mobile_name='" + info_model_cb.Text + "'", con);


            int t = Convert.ToInt32(cmd.ExecuteNonQuery());
            //cmdd.ExecuteNonQuery();
            cd.ExecuteNonQuery();

            if (t > 0)
            {
                MessageBox.Show("Mobile Information saved");
            }

            con.Close();
          
            Owner_page op = new Owner_page();
            op.Show();
            this.Hide();


        }

        private void mobile_brand_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mobile_brand_cb.Text == "SAMSUNG")
            {
                info_model_cb.Text = "";
                info_model_cb.Items.Add("Samsung Galaxy M30");
                info_model_cb.Items.Add("Samsung Galaxy A51");
                info_model_cb.Items.Add("Samsung Galaxy One");
                info_model_cb.Items.Add("Samsung Galaxy A71");
                info_model_cb.Items.Add("Samsung Galaxy A01");
                info_model_cb.Items.Add("Samsung Galaxy M31");
                info_model_cb.Items.Add("Samsung Galaxy A50");
                info_model_cb.Items.Add("Samsung Galaxy A70");
                info_model_cb.Items.Add("Samsung Galaxy J6");
                info_model_cb.Items.Add("Samsung Galaxy J2");
                info_model_cb.Items.Remove("Nokia E72");
                info_model_cb.Items.Remove("Nokia 2.3");
                info_model_cb.Items.Remove("Nokia 6.1 Plus");
                info_model_cb.Items.Remove("Nokia 2.2");
                info_model_cb.Items.Remove("Nokia 5.1 Plus");
                info_model_cb.Items.Remove("Nokia 8.1");
                info_model_cb.Items.Remove("Nokia 4.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Nokia 8.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("OPPO A9");
                info_model_cb.Items.Remove("OPPO F11");
                info_model_cb.Items.Remove("Oppo Reno 2Z");
                info_model_cb.Items.Remove("Oppo Reno 3");
                info_model_cb.Items.Remove("Oppo A5");
                info_model_cb.Items.Remove("OPPO F11 Pro");
                info_model_cb.Items.Remove("OPPO Reno 2");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("Vivo V17");
                info_model_cb.Items.Remove("Vivo U20");
                info_model_cb.Items.Remove("Vivo S1 Pro");
                info_model_cb.Items.Remove("Vivo Z1 Pro");
                info_model_cb.Items.Remove("Vivo V17 Pro");
                info_model_cb.Items.Remove("Vivo U3");
                info_model_cb.Items.Remove("Vivo S1");
                info_model_cb.Items.Remove("Vivo V15 Pro");
                info_model_cb.Items.Remove("Vivo X30 Pro");
                info_model_cb.Items.Remove("Vivo Z1x");
                info_model_cb.Items.Remove("Redmi Note 8 Pro");
                info_model_cb.Items.Remove("Redmi Note 8");
                info_model_cb.Items.Remove("Redmi Note 7 Pro");
                info_model_cb.Items.Remove("Redmi 8A");
                info_model_cb.Items.Remove("Redmi K20 Pro");
                info_model_cb.Items.Remove("Xiaomi Mi A3");
                info_model_cb.Items.Remove("Redmi K20");
                info_model_cb.Items.Remove("Redmi 7");
                info_model_cb.Items.Remove("Redmi 7A");
                info_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (mobile_brand_cb.Text == "NOKIA")
            {
                info_model_cb.Text = "";
                info_model_cb.Items.Add("Nokia E72");
                info_model_cb.Items.Add("Nokia 2.3");
                info_model_cb.Items.Add("Nokia 6.1 Plus");
                info_model_cb.Items.Add("Nokia 2.2");
                info_model_cb.Items.Add("Nokia 5.1 Plus");
                info_model_cb.Items.Add("Nokia 8.1");
                info_model_cb.Items.Add("Nokia 4.2");
                info_model_cb.Items.Add("Nokia 7.2");
                info_model_cb.Items.Add("Nokia 8.2");
                info_model_cb.Items.Add("Nokia 7.2");
                info_model_cb.Items.Remove("Samsung Galaxy M30");
                info_model_cb.Items.Remove("Samsung Galaxy A51");
                info_model_cb.Items.Remove("Samsung Galaxy One");
                info_model_cb.Items.Remove("Samsung Galaxy A71");
                info_model_cb.Items.Remove("Samsung Galaxy A01");
                info_model_cb.Items.Remove("Samsung Galaxy M31");
                info_model_cb.Items.Remove("Samsung Galaxy A50");
                info_model_cb.Items.Remove("Samsung Galaxy A70");
                info_model_cb.Items.Remove("Samsung Galaxy J6");
                info_model_cb.Items.Remove("Samsung Galaxy J2");
                info_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("OPPO A9");
                info_model_cb.Items.Remove("OPPO F11");
                info_model_cb.Items.Remove("Oppo Reno 2Z");
                info_model_cb.Items.Remove("Oppo Reno 3");
                info_model_cb.Items.Remove("Oppo A5");
                info_model_cb.Items.Remove("OPPO F11 Pro");
                info_model_cb.Items.Remove("OPPO Reno 2");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("Vivo V17");
                info_model_cb.Items.Remove("Vivo U20");
                info_model_cb.Items.Remove("Vivo S1 Pro");
                info_model_cb.Items.Remove("Vivo Z1 Pro");
                info_model_cb.Items.Remove("Vivo V17 Pro");
                info_model_cb.Items.Remove("Vivo U3");
                info_model_cb.Items.Remove("Vivo S1");
                info_model_cb.Items.Remove("Vivo V15 Pro");
                info_model_cb.Items.Remove("Vivo X30 Pro");
                info_model_cb.Items.Remove("Vivo Z1x");
                info_model_cb.Items.Remove("Redmi Note 8 Pro");
                info_model_cb.Items.Remove("Redmi Note 8");
                info_model_cb.Items.Remove("Redmi Note 7 Pro");
                info_model_cb.Items.Remove("Redmi 8A");
                info_model_cb.Items.Remove("Redmi K20 Pro");
                info_model_cb.Items.Remove("Xiaomi Mi A3");
                info_model_cb.Items.Remove("Redmi K20");
                info_model_cb.Items.Remove("Redmi 7");
                info_model_cb.Items.Remove("Redmi 7A");
                info_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (mobile_brand_cb.Text == "OPPO")
            {
                info_model_cb.Items.Add("Oppo Reno 3 Pro 5G");
                info_model_cb.Items.Add("Oppo K5");
                info_model_cb.Items.Add("OPPO A9");
                info_model_cb.Items.Add("OPPO F11");
                info_model_cb.Items.Add("Oppo Reno 2Z");
                info_model_cb.Items.Add("Oppo Reno 3");
                info_model_cb.Items.Add("Oppo A5");
                info_model_cb.Items.Add("OPPO F11 Pro");
                info_model_cb.Items.Add("OPPO Reno 2");
                info_model_cb.Items.Add("Oppo K5");
                info_model_cb.Items.Remove("Samsung Galaxy M30");
                info_model_cb.Items.Remove("Samsung Galaxy A51");
                info_model_cb.Items.Remove("Samsung Galaxy One");
                info_model_cb.Items.Remove("Samsung Galaxy A71");
                info_model_cb.Items.Remove("Samsung Galaxy A01");
                info_model_cb.Items.Remove("Samsung Galaxy M31");
                info_model_cb.Items.Remove("Samsung Galaxy A50");
                info_model_cb.Items.Remove("Samsung Galaxy A70");
                info_model_cb.Items.Remove("Samsung Galaxy J6");
                info_model_cb.Items.Remove("Samsung Galaxy J2");
                info_model_cb.Items.Remove("Nokia E72");
                info_model_cb.Items.Remove("Nokia 2.3");
                info_model_cb.Items.Remove("Nokia 6.1 Plus");
                info_model_cb.Items.Remove("Nokia 2.2");
                info_model_cb.Items.Remove("Nokia 5.1 Plus");
                info_model_cb.Items.Remove("Nokia 8.1");
                info_model_cb.Items.Remove("Nokia 4.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Nokia 8.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Vivo V17");
                info_model_cb.Items.Remove("Vivo U20");
                info_model_cb.Items.Remove("Vivo S1 Pro");
                info_model_cb.Items.Remove("Vivo Z1 Pro");
                info_model_cb.Items.Remove("Vivo V17 Pro");
                info_model_cb.Items.Remove("Vivo U3");
                info_model_cb.Items.Remove("Vivo S1");
                info_model_cb.Items.Remove("Vivo V15 Pro");
                info_model_cb.Items.Remove("Vivo X30 Pro");
                info_model_cb.Items.Remove("Vivo Z1x");
                info_model_cb.Items.Remove("Redmi Note 8 Pro");
                info_model_cb.Items.Remove("Redmi Note 8");
                info_model_cb.Items.Remove("Redmi Note 7 Pro");
                info_model_cb.Items.Remove("Redmi 8A");
                info_model_cb.Items.Remove("Redmi K20 Pro");
                info_model_cb.Items.Remove("Xiaomi Mi A3");
                info_model_cb.Items.Remove("Redmi K20");
                info_model_cb.Items.Remove("Redmi 7");
                info_model_cb.Items.Remove("Redmi 7A");
                info_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (mobile_brand_cb.Text == "VIVO")
            {
                info_model_cb.Items.Add("Vivo V17");
                info_model_cb.Items.Add("Vivo U20");
                info_model_cb.Items.Add("Vivo S1 Pro");
                info_model_cb.Items.Add("Vivo Z1 Pro");
                info_model_cb.Items.Add("Vivo V17 Pro");
                info_model_cb.Items.Add("Vivo U3");
                info_model_cb.Items.Add("Vivo S1");
                info_model_cb.Items.Add("Vivo V15 Pro");
                info_model_cb.Items.Add("Vivo X30 Pro");
                info_model_cb.Items.Add("Vivo Z1x");
                info_model_cb.Items.Remove("Samsung Galaxy M30");
                info_model_cb.Items.Remove("Samsung Galaxy A51");
                info_model_cb.Items.Remove("Samsung Galaxy One");
                info_model_cb.Items.Remove("Samsung Galaxy A71");
                info_model_cb.Items.Remove("Samsung Galaxy A01");
                info_model_cb.Items.Remove("Samsung Galaxy M31");
                info_model_cb.Items.Remove("Samsung Galaxy A50");
                info_model_cb.Items.Remove("Samsung Galaxy A70");
                info_model_cb.Items.Remove("Samsung Galaxy J6");
                info_model_cb.Items.Remove("Samsung Galaxy J2");
                info_model_cb.Items.Remove("Nokia E72");
                info_model_cb.Items.Remove("Nokia 2.3");
                info_model_cb.Items.Remove("Nokia 6.1 Plus");
                info_model_cb.Items.Remove("Nokia 2.2");
                info_model_cb.Items.Remove("Nokia 5.1 Plus");
                info_model_cb.Items.Remove("Nokia 8.1");
                info_model_cb.Items.Remove("Nokia 4.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Nokia 8.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("OPPO A9");
                info_model_cb.Items.Remove("OPPO F11");
                info_model_cb.Items.Remove("Oppo Reno 2Z");
                info_model_cb.Items.Remove("Oppo Reno 3");
                info_model_cb.Items.Remove("Oppo A5");
                info_model_cb.Items.Remove("OPPO F11 Pro");
                info_model_cb.Items.Remove("OPPO Reno 2");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("Redmi Note 8 Pro");
                info_model_cb.Items.Remove("Redmi Note 8");
                info_model_cb.Items.Remove("Redmi Note 7 Pro");
                info_model_cb.Items.Remove("Redmi 8A");
                info_model_cb.Items.Remove("Redmi K20 Pro");
                info_model_cb.Items.Remove("Xiaomi Mi A3");
                info_model_cb.Items.Remove("Redmi K20");
                info_model_cb.Items.Remove("Redmi 7");
                info_model_cb.Items.Remove("Redmi 7A");
                info_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (mobile_brand_cb.Text == "REDMI")
            {
                info_model_cb.Items.Add("Redmi Note 8 Pro");
                info_model_cb.Items.Add("Redmi Note 8");
                info_model_cb.Items.Add("Redmi Note 7 Pro");
                info_model_cb.Items.Add("Redmi 8A");
                info_model_cb.Items.Add("Redmi K20 Pro");
                info_model_cb.Items.Add("Xiaomi Mi A3");
                info_model_cb.Items.Add("Redmi K20");
                info_model_cb.Items.Add("Redmi 7");
                info_model_cb.Items.Add("Redmi 7A");
                info_model_cb.Items.Add("Redmi Note 7S");
                info_model_cb.Items.Remove("Samsung Galaxy M30");
                info_model_cb.Items.Remove("Samsung Galaxy A51");
                info_model_cb.Items.Remove("Samsung Galaxy One");
                info_model_cb.Items.Remove("Samsung Galaxy A71");
                info_model_cb.Items.Remove("Samsung Galaxy A01");
                info_model_cb.Items.Remove("Samsung Galaxy M31");
                info_model_cb.Items.Remove("Samsung Galaxy A50");
                info_model_cb.Items.Remove("Samsung Galaxy A70");
                info_model_cb.Items.Remove("Samsung Galaxy J6");
                info_model_cb.Items.Remove("Samsung Galaxy J2");
                info_model_cb.Items.Remove("Nokia E72");
                info_model_cb.Items.Remove("Nokia 2.3");
                info_model_cb.Items.Remove("Nokia 6.1 Plus");
                info_model_cb.Items.Remove("Nokia 2.2");
                info_model_cb.Items.Remove("Nokia 5.1 Plus");
                info_model_cb.Items.Remove("Nokia 8.1");
                info_model_cb.Items.Remove("Nokia 4.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Nokia 8.2");
                info_model_cb.Items.Remove("Nokia 7.2");
                info_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("OPPO A9");
                info_model_cb.Items.Remove("OPPO F11");
                info_model_cb.Items.Remove("Oppo Reno 2Z");
                info_model_cb.Items.Remove("Oppo Reno 3");
                info_model_cb.Items.Remove("Oppo A5");
                info_model_cb.Items.Remove("OPPO F11 Pro");
                info_model_cb.Items.Remove("OPPO Reno 2");
                info_model_cb.Items.Remove("Oppo K5");
                info_model_cb.Items.Remove("Vivo V17");
                info_model_cb.Items.Remove("Vivo U20");
                info_model_cb.Items.Remove("Vivo S1 Pro");
                info_model_cb.Items.Remove("Vivo Z1 Pro");
                info_model_cb.Items.Remove("Vivo V17 Pro");
                info_model_cb.Items.Remove("Vivo U3");
                info_model_cb.Items.Remove("Vivo S1");
                info_model_cb.Items.Remove("Vivo V15 Pro");
                info_model_cb.Items.Remove("Vivo X30 Pro");
                info_model_cb.Items.Remove("Vivo Z1x");
            }
        }

        private void Mobile_Detail_Load(object sender, EventArgs e)
        {

            mobile_ID_GV.Visible = false;
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




        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void info_model_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            mobile_ID_GV.Visible = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("select mobile_ID,price from information where mobile_name='" + info_model_cb.Text + "'", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {


                mobile_ID_GV.DataSource = ds.Tables[0];
            }
            con.Close();
        }
        void clear()
        {
            mobile_id_txt.Text = "";
            mobile_brand_cb.Text = "";
            info_model_cb.Text = " ";
            price_txt.Text = "";
            ram_txt.Text = "";
            processor_txt.Text = "";
            battery_txt.Text = "";
            display_txt.Text = "";
            camera_txt.Text = "";
            memory_card_txt.Text = "";
            quantity_txtbox.Text = "";
            available_rtb.Text = "";

        }

        private void quantity_txtbox_TextChanged(object sender, EventArgs e)
        {
          con.Open();
           
            SqlCommand cmd = new SqlCommand("select available from information where mobile_name='" + info_model_cb.Text + "'", con);
            int avail = Convert.ToInt32(cmd.ExecuteScalar());
           int qty = Convert.ToInt32(quantity_txtbox.Text);
           avail = avail + qty;
            available_rtb.AppendText(avail.ToString());
              //clear();
            //SqlCommand cd = new SqlCommand("update information set available="+avail+" where mobile_name='" + info_model_cb.Text + "'", con);

            // cd.ExecuteNonQuery();
            con.Close();
        }

    }
}
