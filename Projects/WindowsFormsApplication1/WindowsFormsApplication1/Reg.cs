using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    public partial class Reg : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177 ; database = lib;integrated security = True");

        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }






        private void btnsign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuser.Text) ||
               string.IsNullOrWhiteSpace(txtpass.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCPass.Text) ||
                string.IsNullOrWhiteSpace(cmgend.Text) ||
                string.IsNullOrEmpty(cb.Text) ||
                string.IsNullOrWhiteSpace(ans.Text)
                )
            {
                MessageBox.Show("Empty Fill Not Accepted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtEmail.Text == "EmailId") &&
                (txtuser.Text == "Username") &&
                (txtpass.Text == "Password") &&
                (txtCPass.Text == "Confirm Password") &&
                (ans.Text == "Answer")
                )
            {
                MessageBox.Show("Fill Valid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCPass.Text != txtpass.Text)
            {
                MessageBox.Show("Password Not Matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlCommand cmd = new SqlCommand
                    (@"INSERT INTO [lib].[dbo].[Regist] 
                ([EmailId]
                ,[Username]
                  ,[Passcode]
                 ,[Gender]
                 ,[SecQ]
                    ,[Answ])
            VALUES
           ('" + txtEmail.Text + "' , '" + txtuser.Text + "' , '" + txtCPass.Text + "' ,'" + cmgend.SelectedItem.ToString() + "' , '" + cb.SelectedItem.ToString() + "' , '" + ans.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                txtEmail.Clear();
                txtuser.Clear();
                txtpass.Clear();
                txtCPass.Clear();
                cmgend.Text = string.Empty;
                ans.Clear();
                cb.Text = string.Empty;





            }



        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Library.Form1 f = new Library.Form1();
            f.Show();
            this.Hide();

        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.Black;

            }
        }


       

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DarkGray;

            }
            String pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "Please Provide Valid EmailId");
                return;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtuser.Text))
            {
                txtuser.Text = "Username";
                txtuser.ForeColor = Color.DarkGray;

            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Username")
            {
                txtuser.Clear();
                txtuser.ForeColor = Color.Black;

            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtpass.Text))
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.DarkGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Clear();
                txtpass.ForeColor = Color.Black;
            }
        }

        private void txtCPass_Enter(object sender, EventArgs e)
        {
            if (txtCPass.Text == "Confirm Password")
            {
                txtCPass.Clear();
                txtCPass.ForeColor = Color.Black;
            }

        }

        private void txtCPass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCPass.Text))
            {
                txtCPass.Text = "Confirm Password";
                txtCPass.ForeColor = Color.DarkGray;
            }
        }

        private void ans_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ans.Text))
            {
                ans.Text = "Answer";
                ans.ForeColor = Color.DarkGray;
            }
        }

        private void ans_Enter(object sender, EventArgs e)
        {
            if (ans.Text == "Answer")
            {
                ans.Clear();
                ans.ForeColor = Color.Black;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        




    }
}
