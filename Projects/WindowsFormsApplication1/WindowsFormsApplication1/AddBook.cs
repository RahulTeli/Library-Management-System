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
    public partial class AddBook : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177 ; database = lib ;integrated security = True");
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void btncan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) &&
                string.IsNullOrWhiteSpace(txtBookName.Text) &&
               string.IsNullOrWhiteSpace(txtBookAu.Text) &&
                string.IsNullOrWhiteSpace(txtBookPub.Text) &&
                string.IsNullOrWhiteSpace(txtBookPr.Text) &&
                string.IsNullOrWhiteSpace(txtBookQua.Text))
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) ||
                string.IsNullOrWhiteSpace(txtBookName.Text) ||
               string.IsNullOrWhiteSpace(txtBookAu.Text) ||
                string.IsNullOrWhiteSpace(txtBookPub.Text) ||
                string.IsNullOrWhiteSpace(txtBookPr.Text) ||
                string.IsNullOrWhiteSpace(Date.Text) ||
                string.IsNullOrWhiteSpace(txtBookQua.Text))
            {
                MessageBox.Show("Empty Fill Not Accepted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtid.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtBookPr.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtBookQua.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Quantity ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
               
                SqlCommand cmd = new SqlCommand 
                  (@"INSERT INTO [lib].[dbo].[AddBook]
                   ( [B_ID]
                    ,[B_Name]
                  ,[B_Author]
                 ,[B_Pub]
                 ,[B_Pub_Date]
                 ,[B_Price]
                 ,[B_Quan])
                VALUES
                     ( '" + txtid.Text + "', '" + txtBookName.Text + "', '" + txtBookAu.Text + "','" + txtBookPub.Text + "','" + Date.Text + "' , '" + txtBookPr.Text + "' ,'" + txtBookQua.Text + "')", con);
                     con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Added " ,"Success" ,MessageBoxButtons.OK , MessageBoxIcon.Asterisk);

                    txtid.Clear();
                    txtBookName.Clear();
                    txtBookQua.Clear();
                    txtBookPub.Clear();
                    txtBookPr.Clear();
                    txtBookAu.Clear();

            }


        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            label8.BackColor = Color.Red;
            label8.ForeColor = Color.WhiteSmoke;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Aqua;
            label8.ForeColor = Color.Black;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) &&
                string.IsNullOrWhiteSpace(txtBookName.Text) &&
               string.IsNullOrWhiteSpace(txtBookAu.Text) &&
                string.IsNullOrWhiteSpace(txtBookPub.Text) &&
                string.IsNullOrWhiteSpace(txtBookPr.Text) &&
                string.IsNullOrWhiteSpace(txtBookQua.Text))
            {
                this.Close();
                
            }

            else
            {
                if (MessageBox.Show("Are you sure You want to Close? Unsaved Data will be lost!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                   
                }
            }

        }

        

       

       

        
        
        
    }
}
