using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Ordershop_page : Form
    {
        public Ordershop_page()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Shop_brand_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Shop_brand_cb.Text == "SAMSUNG")
            {
                Shop_model_cb.Text = "";
                Shop_model_cb.Items.Add("Samsung Galaxy M30");
                Shop_model_cb.Items.Add("Samsung Galaxy A51");
                Shop_model_cb.Items.Add("Samsung Galaxy One");
                Shop_model_cb.Items.Add("Samsung Galaxy A71");
                Shop_model_cb.Items.Add("Samsung Galaxy A01");
                Shop_model_cb.Items.Add("Samsung Galaxy M31");
                Shop_model_cb.Items.Add("Samsung Galaxy A50");
                Shop_model_cb.Items.Add("Samsung Galaxy A70");
                Shop_model_cb.Items.Add("Samsung Galaxy J6");
                Shop_model_cb.Items.Add("Samsung Galaxy J2");
                Shop_model_cb.Items.Remove("Nokia E72");
                Shop_model_cb.Items.Remove("Nokia 2.3");
                Shop_model_cb.Items.Remove("Nokia 6.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 2.2");
                Shop_model_cb.Items.Remove("Nokia 5.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 8.1");
                Shop_model_cb.Items.Remove("Nokia 4.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Nokia 8.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("OPPO A9");
                Shop_model_cb.Items.Remove("OPPO F11");
                Shop_model_cb.Items.Remove("Oppo Reno 2Z");
                Shop_model_cb.Items.Remove("Oppo Reno 3");
                Shop_model_cb.Items.Remove("Oppo A5");
                Shop_model_cb.Items.Remove("OPPO F11 Pro");
                Shop_model_cb.Items.Remove("OPPO Reno 2");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("Vivo V17");
                Shop_model_cb.Items.Remove("Vivo U20");
                Shop_model_cb.Items.Remove("Vivo S1 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1 Pro");
                Shop_model_cb.Items.Remove("Vivo V17 Pro");
                Shop_model_cb.Items.Remove("Vivo U3");
                Shop_model_cb.Items.Remove("Vivo S1");
                Shop_model_cb.Items.Remove("Vivo V15 Pro");
                Shop_model_cb.Items.Remove("Vivo X30 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1x");
                Shop_model_cb.Items.Remove("Redmi Note 8 Pro");
                Shop_model_cb.Items.Remove("Redmi Note 8");
                Shop_model_cb.Items.Remove("Redmi Note 7 Pro");
                Shop_model_cb.Items.Remove("Redmi 8A");
                Shop_model_cb.Items.Remove("Redmi K20 Pro");
                Shop_model_cb.Items.Remove("Xiaomi Mi A3");
                Shop_model_cb.Items.Remove("Redmi K20");
                Shop_model_cb.Items.Remove("Redmi 7");
                Shop_model_cb.Items.Remove("Redmi 7A");
                Shop_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (Shop_brand_cb.Text == "NOKIA")
            {
                Shop_model_cb.Text = "";
                Shop_model_cb.Items.Add("Nokia E72");
                Shop_model_cb.Items.Add("Nokia 2.3");
                Shop_model_cb.Items.Add("Nokia 6.1 Plus");
                Shop_model_cb.Items.Add("Nokia 2.2");
                Shop_model_cb.Items.Add("Nokia 5.1 Plus");
                Shop_model_cb.Items.Add("Nokia 8.1");
                Shop_model_cb.Items.Add("Nokia 4.2");
                Shop_model_cb.Items.Add("Nokia 7.2");
                Shop_model_cb.Items.Add("Nokia 8.2");
                Shop_model_cb.Items.Add("Nokia 7.2");
                Shop_model_cb.Items.Remove("Samsung Galaxy M30");
                Shop_model_cb.Items.Remove("Samsung Galaxy A51");
                Shop_model_cb.Items.Remove("Samsung Galaxy One");
                Shop_model_cb.Items.Remove("Samsung Galaxy A71");
                Shop_model_cb.Items.Remove("Samsung Galaxy A01");
                Shop_model_cb.Items.Remove("Samsung Galaxy M31");
                Shop_model_cb.Items.Remove("Samsung Galaxy A50");
                Shop_model_cb.Items.Remove("Samsung Galaxy A70");
                Shop_model_cb.Items.Remove("Samsung Galaxy J6");
                Shop_model_cb.Items.Remove("Samsung Galaxy J2");
                Shop_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("OPPO A9");
                Shop_model_cb.Items.Remove("OPPO F11");
                Shop_model_cb.Items.Remove("Oppo Reno 2Z");
                Shop_model_cb.Items.Remove("Oppo Reno 3");
                Shop_model_cb.Items.Remove("Oppo A5");
                Shop_model_cb.Items.Remove("OPPO F11 Pro");
                Shop_model_cb.Items.Remove("OPPO Reno 2");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("Vivo V17");
                Shop_model_cb.Items.Remove("Vivo U20");
                Shop_model_cb.Items.Remove("Vivo S1 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1 Pro");
                Shop_model_cb.Items.Remove("Vivo V17 Pro");
                Shop_model_cb.Items.Remove("Vivo U3");
                Shop_model_cb.Items.Remove("Vivo S1");
                Shop_model_cb.Items.Remove("Vivo V15 Pro");
                Shop_model_cb.Items.Remove("Vivo X30 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1x");
                Shop_model_cb.Items.Remove("Redmi Note 8 Pro");
                Shop_model_cb.Items.Remove("Redmi Note 8");
                Shop_model_cb.Items.Remove("Redmi Note 7 Pro");
                Shop_model_cb.Items.Remove("Redmi 8A");
                Shop_model_cb.Items.Remove("Redmi K20 Pro");
                Shop_model_cb.Items.Remove("Xiaomi Mi A3");
                Shop_model_cb.Items.Remove("Redmi K20");
                Shop_model_cb.Items.Remove("Redmi 7");
                Shop_model_cb.Items.Remove("Redmi 7A");
                Shop_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (Shop_brand_cb.Text == "OPPO")
            {
                Shop_model_cb.Items.Add("Oppo Reno 3 Pro 5G");
                Shop_model_cb.Items.Add("Oppo K5");
                Shop_model_cb.Items.Add("OPPO A9");
                Shop_model_cb.Items.Add("OPPO F11");
                Shop_model_cb.Items.Add("Oppo Reno 2Z");
                Shop_model_cb.Items.Add("Oppo Reno 3");
                Shop_model_cb.Items.Add("Oppo A5");
                Shop_model_cb.Items.Add("OPPO F11 Pro");
                Shop_model_cb.Items.Add("OPPO Reno 2");
                Shop_model_cb.Items.Add("Oppo K5");
                Shop_model_cb.Items.Remove("Samsung Galaxy M30");
                Shop_model_cb.Items.Remove("Samsung Galaxy A51");
                Shop_model_cb.Items.Remove("Samsung Galaxy One");
                Shop_model_cb.Items.Remove("Samsung Galaxy A71");
                Shop_model_cb.Items.Remove("Samsung Galaxy A01");
                Shop_model_cb.Items.Remove("Samsung Galaxy M31");
                Shop_model_cb.Items.Remove("Samsung Galaxy A50");
                Shop_model_cb.Items.Remove("Samsung Galaxy A70");
                Shop_model_cb.Items.Remove("Samsung Galaxy J6");
                Shop_model_cb.Items.Remove("Samsung Galaxy J2");
                Shop_model_cb.Items.Remove("Nokia E72");
                Shop_model_cb.Items.Remove("Nokia 2.3");
                Shop_model_cb.Items.Remove("Nokia 6.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 2.2");
                Shop_model_cb.Items.Remove("Nokia 5.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 8.1");
                Shop_model_cb.Items.Remove("Nokia 4.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Nokia 8.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Vivo V17");
                Shop_model_cb.Items.Remove("Vivo U20");
                Shop_model_cb.Items.Remove("Vivo S1 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1 Pro");
                Shop_model_cb.Items.Remove("Vivo V17 Pro");
                Shop_model_cb.Items.Remove("Vivo U3");
                Shop_model_cb.Items.Remove("Vivo S1");
                Shop_model_cb.Items.Remove("Vivo V15 Pro");
                Shop_model_cb.Items.Remove("Vivo X30 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1x");
                Shop_model_cb.Items.Remove("Redmi Note 8 Pro");
                Shop_model_cb.Items.Remove("Redmi Note 8");
                Shop_model_cb.Items.Remove("Redmi Note 7 Pro");
                Shop_model_cb.Items.Remove("Redmi 8A");
                Shop_model_cb.Items.Remove("Redmi K20 Pro");
                Shop_model_cb.Items.Remove("Xiaomi Mi A3");
                Shop_model_cb.Items.Remove("Redmi K20");
                Shop_model_cb.Items.Remove("Redmi 7");
                Shop_model_cb.Items.Remove("Redmi 7A");
                Shop_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (Shop_brand_cb.Text == "VIVO")
            {
                Shop_model_cb.Items.Add("Vivo V17");
                Shop_model_cb.Items.Add("Vivo U20");
                Shop_model_cb.Items.Add("Vivo S1 Pro");
                Shop_model_cb.Items.Add("Vivo Z1 Pro");
                Shop_model_cb.Items.Add("Vivo V17 Pro");
                Shop_model_cb.Items.Add("Vivo U3");
                Shop_model_cb.Items.Add("Vivo S1");
                Shop_model_cb.Items.Add("Vivo V15 Pro");
                Shop_model_cb.Items.Add("Vivo X30 Pro");
                Shop_model_cb.Items.Add("Vivo Z1x");
                Shop_model_cb.Items.Remove("Samsung Galaxy M30");
                Shop_model_cb.Items.Remove("Samsung Galaxy A51");
                Shop_model_cb.Items.Remove("Samsung Galaxy One");
                Shop_model_cb.Items.Remove("Samsung Galaxy A71");
                Shop_model_cb.Items.Remove("Samsung Galaxy A01");
                Shop_model_cb.Items.Remove("Samsung Galaxy M31");
                Shop_model_cb.Items.Remove("Samsung Galaxy A50");
                Shop_model_cb.Items.Remove("Samsung Galaxy A70");
                Shop_model_cb.Items.Remove("Samsung Galaxy J6");
                Shop_model_cb.Items.Remove("Samsung Galaxy J2");
                Shop_model_cb.Items.Remove("Nokia E72");
                Shop_model_cb.Items.Remove("Nokia 2.3");
                Shop_model_cb.Items.Remove("Nokia 6.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 2.2");
                Shop_model_cb.Items.Remove("Nokia 5.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 8.1");
                Shop_model_cb.Items.Remove("Nokia 4.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Nokia 8.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("OPPO A9");
                Shop_model_cb.Items.Remove("OPPO F11");
                Shop_model_cb.Items.Remove("Oppo Reno 2Z");
                Shop_model_cb.Items.Remove("Oppo Reno 3");
                Shop_model_cb.Items.Remove("Oppo A5");
                Shop_model_cb.Items.Remove("OPPO F11 Pro");
                Shop_model_cb.Items.Remove("OPPO Reno 2");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("Redmi Note 8 Pro");
                Shop_model_cb.Items.Remove("Redmi Note 8");
                Shop_model_cb.Items.Remove("Redmi Note 7 Pro");
                Shop_model_cb.Items.Remove("Redmi 8A");
                Shop_model_cb.Items.Remove("Redmi K20 Pro");
                Shop_model_cb.Items.Remove("Xiaomi Mi A3");
                Shop_model_cb.Items.Remove("Redmi K20");
                Shop_model_cb.Items.Remove("Redmi 7");
                Shop_model_cb.Items.Remove("Redmi 7A");
                Shop_model_cb.Items.Remove("Redmi Note 7S");
            }
            else if (Shop_brand_cb.Text == "REDMI")
            {
                Shop_model_cb.Items.Add("Redmi Note 8 Pro");
                Shop_model_cb.Items.Add("Redmi Note 8");
                Shop_model_cb.Items.Add("Redmi Note 7 Pro");
                Shop_model_cb.Items.Add("Redmi 8A");
                Shop_model_cb.Items.Add("Redmi K20 Pro");
                Shop_model_cb.Items.Add("Xiaomi Mi A3");
                Shop_model_cb.Items.Add("Redmi K20");
                Shop_model_cb.Items.Add("Redmi 7");
                Shop_model_cb.Items.Add("Redmi 7A");
                Shop_model_cb.Items.Add("Redmi Note 7S");
                Shop_model_cb.Items.Remove("Samsung Galaxy M30");
                Shop_model_cb.Items.Remove("Samsung Galaxy A51");
                Shop_model_cb.Items.Remove("Samsung Galaxy One");
                Shop_model_cb.Items.Remove("Samsung Galaxy A71");
                Shop_model_cb.Items.Remove("Samsung Galaxy A01");
                Shop_model_cb.Items.Remove("Samsung Galaxy M31");
                Shop_model_cb.Items.Remove("Samsung Galaxy A50");
                Shop_model_cb.Items.Remove("Samsung Galaxy A70");
                Shop_model_cb.Items.Remove("Samsung Galaxy J6");
                Shop_model_cb.Items.Remove("Samsung Galaxy J2");
                Shop_model_cb.Items.Remove("Nokia E72");
                Shop_model_cb.Items.Remove("Nokia 2.3");
                Shop_model_cb.Items.Remove("Nokia 6.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 2.2");
                Shop_model_cb.Items.Remove("Nokia 5.1 Plus");
                Shop_model_cb.Items.Remove("Nokia 8.1");
                Shop_model_cb.Items.Remove("Nokia 4.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Nokia 8.2");
                Shop_model_cb.Items.Remove("Nokia 7.2");
                Shop_model_cb.Items.Remove("Oppo Reno 3 Pro 5G");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("OPPO A9");
                Shop_model_cb.Items.Remove("OPPO F11");
                Shop_model_cb.Items.Remove("Oppo Reno 2Z");
                Shop_model_cb.Items.Remove("Oppo Reno 3");
                Shop_model_cb.Items.Remove("Oppo A5");
                Shop_model_cb.Items.Remove("OPPO F11 Pro");
                Shop_model_cb.Items.Remove("OPPO Reno 2");
                Shop_model_cb.Items.Remove("Oppo K5");
                Shop_model_cb.Items.Remove("Vivo V17");
                Shop_model_cb.Items.Remove("Vivo U20");
                Shop_model_cb.Items.Remove("Vivo S1 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1 Pro");
                Shop_model_cb.Items.Remove("Vivo V17 Pro");
                Shop_model_cb.Items.Remove("Vivo U3");
                Shop_model_cb.Items.Remove("Vivo S1");
                Shop_model_cb.Items.Remove("Vivo V15 Pro");
                Shop_model_cb.Items.Remove("Vivo X30 Pro");
                Shop_model_cb.Items.Remove("Vivo Z1x");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner_page op = new Owner_page();
            op.Show();
            this.Hide();
        }

        private void homepage_btn_Click(object sender, EventArgs e)
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
    }
}
