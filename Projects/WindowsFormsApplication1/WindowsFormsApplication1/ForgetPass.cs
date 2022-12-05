using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using Library;

namespace WindowsFormsApplication1
{
    public partial class ForgetPass : Form
    {
       SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177; database = lib ;integrated security = True");

        public ForgetPass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void can_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void verify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(user.Text) ||
                string.IsNullOrWhiteSpace(txtem.Text) ||

                string.IsNullOrWhiteSpace(ans.Text) ||
                string.IsNullOrWhiteSpace(cb.SelectedItem.ToString()))
            {
                MessageBox.Show("Fill Valid Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (user.Text != "" && txtem.Text != "" && ans.Text != "" && cb.SelectedItem != "")
            {
              

                    con.Open();
                    SqlCommand cmdd = new SqlCommand("select * from Regist  where EmailId = '" + txtem.Text + "' and Username='" + user.Text + "' and SecQ='" + cb.SelectedItem.ToString() + "'  and Answ='" + ans.Text + "' ", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmdd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmdd.ExecuteNonQuery();

                    if (dt.Rows.Count > 0)
                    {
                        
                      
                        new reset().Show();
                        this.Visible = false;
                        

                    }
                    else
                    {
                        MessageBox.Show("User not exists...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    con.Close();




            }


        }


        private void txtem_Leave(object sender, EventArgs e)
        {
            String pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtem.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtem, "Please Provide Valid EmailId");
                return;
            }
        }

        
       
    }
}
