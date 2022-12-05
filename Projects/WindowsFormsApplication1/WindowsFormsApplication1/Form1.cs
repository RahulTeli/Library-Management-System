using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1;

namespace Library
{
    public partial class Form1 : Form

    {


        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177 ; database = lib;integrated security = True");
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       

        
      
        private void pic1_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '*')
            {
                pic2.BringToFront();
                txtpass.PasswordChar = '\0';
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            if (txtpass.PasswordChar == '\0')
            {
                pic1.BringToFront();
                txtpass.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picins_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/rahulteli_10/");
        }

        private void picyou_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/i6e5QyM8Igs");
        }

        private void picface_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void btnlog_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Regist WHERE Username= '" + txtuser.Text + "' and Passcode= '" + txtpass.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count!=0)
            {
                this.Close();
                WindowsFormsApplication1.Dashboard dsa = new WindowsFormsApplication1.Dashboard();
                dsa.Show();
            }
               
            else if (string.IsNullOrWhiteSpace(txtuser.Text)||
                    string.IsNullOrWhiteSpace(txtpass.Text))
            {

                MessageBox.Show("Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApplication1.Reg r = new WindowsFormsApplication1.Reg();
            r.Show();


        }

        

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Clear();
                txtpass.PasswordChar = '*';
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtpass.Text))
            {
                txtpass.Text = "Password";
                txtpass.PasswordChar = '\0';
            }
        }

       

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtuser.Text))
            {
                txtuser.Text = "Username";
            }
        }

        private void txtuser_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtuser.Text == "Username")
            {
                txtuser.Clear();
            }
        }

        

        private void fp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPass f = new ForgetPass();
            f.Show();
        }

        

        

        
        

       

        

        

       

              
    }
}
