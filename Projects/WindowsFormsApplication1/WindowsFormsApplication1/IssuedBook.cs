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
    public partial class IssuedBook : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177 ; database = lib ;integrated security = True");
        public IssuedBook()
        {
            InitializeComponent();
        }

        private void IssuedBook_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select B_Name from AddBook", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    cb.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        int count;
        private void serbt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtP.Text))
            {
                MessageBox.Show("Empty fill not acccepted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtP.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers In PRN.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String prn = txtP.Text;
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Student where S_PRN = " + prn + "", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);




                // ---------------------------------------------------------------------------------------------------

                // Code to Count how many book has been issued on this PRN
                cmd.CommandText = "select count(S_PRN) from IRBook where S_PRN  = " + prn + " and Book_Return_Date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                //----------------------------------------------------------------------------------------------------

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtn.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtd.Text = ds.Tables[0].Rows[0][2].ToString();
                    txts.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtc.Text = ds.Tables[0].Rows[0][4].ToString();
                    txte.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid PRN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }



        }



        private void cn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtn.Text) &&
             string.IsNullOrWhiteSpace(txts.Text) &&
              string.IsNullOrWhiteSpace(txtd.Text) &&
              string.IsNullOrWhiteSpace(txte.Text) &&
              string.IsNullOrWhiteSpace(txtc.Text))
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

        private void cn_MouseHover(object sender, EventArgs e)
        {
            cn.BackColor = Color.Red;
            cn.ForeColor = Color.WhiteSmoke;
        }

        private void cn_MouseLeave(object sender, EventArgs e)
        {
            cn.BackColor = Color.Aqua;
            cn.ForeColor = Color.Black;
        }

        private void canb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtn.Text) &&
             string.IsNullOrWhiteSpace(txts.Text) &&
              string.IsNullOrWhiteSpace(txtd.Text) &&
              string.IsNullOrWhiteSpace(txte.Text) &&
              string.IsNullOrWhiteSpace(txtc.Text))
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

        private void isu_Click(object sender, EventArgs e)
        {

            

            if (String.IsNullOrWhiteSpace(txtn.Text))
            {
                MessageBox.Show("Enter Valid PRN", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtn.Text != " ")
            {
                if (cb.SelectedIndex != -1 && count <= 2 )
                {
                    String Dtp = dtp.Text;
                    SqlCommand cmd = new SqlCommand
                (@"INSERT INTO [lib].[dbo].[IRBook]
                   ([S_PRN]
                  ,[S_Name]
                  ,[S_Dep]
                  ,[S_Sem]
                  ,[S_Cont]
                 ,[S_Email]
                 ,[B_Name]
                 ,[Book_Issued_Date])
                         VALUES
                       (" + txtP.Text + " , '" + txtn.Text + "' , '" + txtd.Text + "' , '" + txts.Text + "', " + txtc.Text + " , '" + txte.Text + "' , '" + cb.Text + "' , '" + Dtp + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    String q = "update AddBook set B_Quan=B_Quan-1 where B_Name = '"+cb.Text+"' ";
                    SqlCommand cmd1 = new SqlCommand(q, con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Select Book OR Maximum number of Books ISSUED OR Book not available ", " No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            
            
               
            
            
           
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtP.Text))
            {
                txtn.Clear();
                txts.Clear();
                txtd.Clear();
                txte.Clear();
                txtc.Clear();
            }

        }

        private void btnref_Click(object sender, EventArgs e)
        {
            txtP.Clear();
           
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   
    
    
    }
}
