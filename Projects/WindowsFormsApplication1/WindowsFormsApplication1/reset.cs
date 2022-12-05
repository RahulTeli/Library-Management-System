using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class reset : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177; database = lib ;integrated security = True");
        public reset()
        {
            InitializeComponent();
        }

       

        private void can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void can_MouseHover(object sender, EventArgs e)
        {
            can.BackColor = Color.Red;
            can.ForeColor = Color.WhiteSmoke;
        }

        private void can_MouseLeave(object sender, EventArgs e)
        {
            can.BackColor = Color.Aqua;
            can.ForeColor = Color.Black;
        }

        private void verify_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(passc.Text) ||
                string.IsNullOrWhiteSpace(passcc.Text))
            {
                MessageBox.Show("Enter Password" , "Enter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passc.Text != passcc.Text)
            {
                MessageBox.Show("Password Not Matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                con.Open();
            SqlCommand cmd = new SqlCommand("update Regist set Passcode = '"+passcc.Text+"' where EmailId = '"+Email.Text+"'  ", con);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Password Reset Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                new Form1().Show();
                this.Close();
            }

            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Email_Leave(object sender, EventArgs e)
        {
            String pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(Email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.Email, "Please Provide Valid EmailId");
                return;
            }
        }

        

        
    }
}
