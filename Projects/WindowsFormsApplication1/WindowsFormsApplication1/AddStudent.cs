using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class AddStudent : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177 ; database = lib ;integrated security = True");
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Snametxt.Text) &&
             string.IsNullOrWhiteSpace(prntxt.Text) &&
              string.IsNullOrWhiteSpace(Deptxt.Text) &&
              string.IsNullOrWhiteSpace(Semtxt.Text) &&
              string.IsNullOrWhiteSpace(Conttxt.Text) &&
               string.IsNullOrWhiteSpace(Emtxt.Text))
            {
                this.Close();
               
            }

            else
            {
                if (MessageBox.Show("Are you sure You want to Cancel? Unsaved Data will be lost! ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    
                }
            }

        }

        private void btncan_MouseHover(object sender, EventArgs e)
        {
            btncan.BackColor = Color.Red;
            btncan.ForeColor = Color.WhiteSmoke;
        }

        private void btncan_MouseLeave(object sender, EventArgs e)
        {
            btncan.BackColor = Color.Aqua;
            btncan.ForeColor = Color.Black;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Snametxt.Text) ||
              string.IsNullOrWhiteSpace(prntxt.Text) ||
               string.IsNullOrWhiteSpace(Deptxt.Text) ||
               string.IsNullOrWhiteSpace(Semtxt.Text) ||
               string.IsNullOrWhiteSpace(Conttxt.Text) ||
               string.IsNullOrWhiteSpace(Emtxt.Text))
            {
                MessageBox.Show("Empty Fill Not Accepted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (System.Text.RegularExpressions.Regex.IsMatch(Conttxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers In Contact." , "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning);

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(prntxt.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers In PRN.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {

                SqlCommand cmd = new SqlCommand
                  (@"INSERT INTO [lib].[dbo].[Student]
                   ([S_Name]
                    ,[S_PRN]
                    ,[S_Dep]
                    ,[S_Sem]
                    ,[S_Cont]
                   ,[S_Email])
                 VALUES
                     ( '" + Snametxt.Text + "', " + prntxt.Text + ",'" + Deptxt.Text + "','" + Semtxt.Text + "' , " + Conttxt.Text + " ,'" + Emtxt.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Snametxt.Clear();
                prntxt.Clear();
                Deptxt.Clear();
                Semtxt.Clear();
                Conttxt.Clear();
                Emtxt.Clear();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Snametxt.Text) &&
              string.IsNullOrWhiteSpace(prntxt.Text) &&
               string.IsNullOrWhiteSpace(Deptxt.Text) &&
               string.IsNullOrWhiteSpace(Semtxt.Text) &&
               string.IsNullOrWhiteSpace(Conttxt.Text) &&
                string.IsNullOrWhiteSpace(Emtxt.Text) )
            {
                this.Close();
              
            }

            else
            {
                if (MessageBox.Show("Are you sure You want to Cancel? Unsaved Data will be lost! ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }














    }
}
