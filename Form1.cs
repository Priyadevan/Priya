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
    public partial class LOGINFORM : Form
    {
        public static string role;
        SqlConnection con = new SqlConnection(@"Data Source=(localDb)\v11.0;Initial Catalog=mobilestore;Integrated Security=True");
        public LOGINFORM()
        {
            InitializeComponent();
        }

        //string username;
        string password;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            con.Open();

            if(comboBox1.Text=="owner")
            {
                role = "owner";
                password = passwordtxt.Text;
                SqlCommand cmd = new SqlCommand("select * from validation where username='"+comboBox1.Text+"' and password='"+password+"'",con);
                SqlDataReader rd = cmd.ExecuteReader();
                
                if (rd.Read())
                {
                    string var1 = rd[0].ToString();
                    string var2 = rd[1].ToString();
                    if (comboBox1.Text == var1 && password == var2)
                    {
                        MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                        Owner_page f = new Owner_page();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT USERNAME AND PASSWORD"+rd[0].ToString()+rd[1].ToString());
                    }
                }

            }
            else if (comboBox1.Text == "shopkeeper")
            {
                role = "shopkeeper";
                password = passwordtxt.Text;
                SqlCommand cmd1 = new SqlCommand("select * from validation where username='" + comboBox1.Text + "' and password='" + password + "'", con);
                SqlDataReader rd1 = cmd1.ExecuteReader();
                if (rd1.Read())
                {
                    if (comboBox1.Text == rd1[0].ToString() && password == rd1[1].ToString())
                    {
                        MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                        Shopkeeper_page f = new Shopkeeper_page();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("INCORRECT USERNAME AND PASSWORD");
                    }

                }

            }
            con.Close();
            
            //SqlCommand cmd = new SqlCommand();
            //cmd.ExecuteNonQuery();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
