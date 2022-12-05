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
    public partial class ViewB : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177; database = lib ;integrated security = True");
        public ViewB()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.Open();
            String query = "select * from Addbook";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DV.DataSource = ds.Tables[0];
            con.Close();


        }

        private void ViewB_Load(object sender, EventArgs e)
        {

            populate();

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

            if ((txtBn.Text == "Book Name") &&
                (txtBAN.Text == "Book Author Name") &&
                (txtBP.Text == "Book Publication Name") &&
                (txtBPr.Text == "Book Price") &&
                (txtBQ.Text == "Book Quantity"))
            {
                this.Close();
                
            }

            else if (string.IsNullOrWhiteSpace(txtBP.Text) ||
               string.IsNullOrWhiteSpace(txtBQ.Text) ||
                string.IsNullOrWhiteSpace(txtBPr.Text) ||
                string.IsNullOrWhiteSpace(txtBAN.Text) ||
                string.IsNullOrWhiteSpace(txtBn.Text))
            {
                if (MessageBox.Show("Are you sure You want to Close? Unsaved Data will be lost!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    
                }
            }

            else
            {
                if (MessageBox.Show("Are you sure You want to Close? Unsaved Data will be lost!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    
                }
            }
        }
        private void id_MouseClick(object sender, MouseEventArgs e)
        {
            if (id.Text == "Book ID")
            {
                id.Clear();
                id.ForeColor = Color.Black;
            }
        }
       

        private void id_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(id.Text))
            {
                id.Text = "Book ID";
                id.ForeColor = Color.DimGray;
            }
        }
        private void txtBn_Enter(object sender, EventArgs e)
        {
            if (txtBn.Text == "Book Name")
            {
                txtBn.Clear();
                txtBn.ForeColor = Color.Black;
            }
        }

        private void txtBn_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBn.Text))
            {
                txtBn.Text = "Book Name";
                txtBn.ForeColor = Color.DimGray;
            }
        }

        private void txtBAN_Enter(object sender, EventArgs e)
        {
            if (txtBAN.Text == "Book Author Name")
            {
                txtBAN.Clear();
                txtBAN.ForeColor = Color.Black;
            }
        }

        private void txtBAN_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBAN.Text))
            {
                txtBAN.Text = "Book Author Name";
                txtBAN.ForeColor = Color.DimGray;
            }
        }

        private void txtBP_Enter(object sender, EventArgs e)
        {
            if (txtBP.Text == "Book Publication Name")
            {
                txtBP.Clear();
                txtBP.ForeColor = Color.Black;
            }
        }

        private void txtBP_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBP.Text))
            {
                txtBP.Text = "Book Publication Name";
                txtBP.ForeColor = Color.DimGray;
            }
        }

        

        private void txtBPr_Enter(object sender, EventArgs e)
        {
            if (txtBPr.Text == "Book Price")
            {
                txtBPr.Clear();
                txtBPr.ForeColor = Color.Black;
            }
        }

        private void txtBPr_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBPr.Text))
            {
                txtBPr.Text = "Book Price";
                txtBPr.ForeColor = Color.DimGray;
            }
        }

        private void txtBQ_Enter(object sender, EventArgs e)
        {
            if (txtBQ.Text == "Book Quantity")
            {
                txtBQ.Clear();
                txtBQ.ForeColor = Color.Black;
            }
        }

        private void txtBQ_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBQ.Text))
            {
                txtBQ.Text = "Book Quantity";
                txtBQ.ForeColor = Color.DimGray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtBn.Text == "Book Name") &&
                (txtBAN.Text == "Book Author Name") &&
                (txtBP.Text == "Book Publication Name") &&
                (txtBPr.Text == "Book Price") &&
                (txtBQ.Text == "Book Quantity"))
            {
                this.Close();
                
            }

            else if (string.IsNullOrWhiteSpace(txtBP.Text) ||
               string.IsNullOrWhiteSpace(txtBQ.Text) ||
                string.IsNullOrWhiteSpace(txtBPr.Text) ||
                string.IsNullOrWhiteSpace(txtBAN.Text) ||
                string.IsNullOrWhiteSpace(txtBn.Text))
            {
                if (MessageBox.Show("Are you sure you want to Close? Unsaved Data will be lost!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                    
                }
            }

            else
            {
                if (MessageBox.Show("Are you sure you want to Close? Unsaved Data will be lost!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                   
                }
            }
        }



        private void txtSear_TextChanged(object sender, EventArgs e)
        {
            if (txtSear.Text != " ")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from AddBook where B_Name LIKE '" + txtSear.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DV.DataSource = ds.Tables[0];
                con.Close();

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from AddBook ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                DV.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void btnrefr_Click(object sender, EventArgs e)
        {
            txtSear.Clear();
        }

        Int64 bid;

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if ((id.Text == "Book ID") &&
                (txtBn.Text == "Book Name") &&
                (txtBAN.Text == "Book Author Name") &&
                (txtBP.Text == "Book Publication Name") &&
                (txtBPr.Text == "Book Price") &&
                (txtBQ.Text == "Book Quantity"))
            {
                MessageBox.Show("Enter Valid Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(id.Text ,"[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch( txtBPr.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch( txtBQ.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Quantity ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
            String Bid = id.Text; 
            String BName = txtBn.Text;
            String BAut = txtBAN.Text;
            String BPu = txtBP.Text;
            String BpD = BPD.Text;
            String BPr = txtBPr.Text;
            String BQ = txtBQ.Text;

            con.Open();


            

            if (MessageBox.Show("UPDATE!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                String query = "update AddBook set B_ID = '" + Bid + "' , B_Name = '" + BName + "' ,  B_Author ='" + BAut + "' ,  B_Pub ='" + BPu + "' ,  B_Pub_Date='" + BpD + "' ,  B_Price= '" + BPr + "' , B_Quan = '" + BQ + "' WHERE B_ID = '"+bid+"' ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
           
            con.Close();
            populate();
            }
            

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((id.Text == "Book ID") &&
                (txtBn.Text == "Book Name") &&
                (txtBAN.Text == "Book Author Name") &&
                (txtBP.Text == "Book Publication Name") &&
                (txtBPr.Text == "Book Price") &&
                (txtBQ.Text == "Book Quantity"))
            {
                MessageBox.Show("Enter Valid Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();



                if (MessageBox.Show("DELETE!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    String query = "delete from AddBook where B_ID = " + bid + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                populate();
            }
        }

        

        private void DV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                bid = Int64.Parse(DV.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataGridViewRow row = this.DV.Rows[e.RowIndex];

                id.Text = row.Cells["B_ID"].Value.ToString();
                txtBn.Text = row.Cells["B_Name"].Value.ToString();
                txtBAN.Text = row.Cells["B_Author"].Value.ToString();
                txtBP.Text = row.Cells["B_Pub"].Value.ToString();
                BPD.Text = row.Cells["B_Pub_Date"].Value.ToString();
                txtBPr.Text = row.Cells["B_Price"].Value.ToString();
                txtBQ.Text = row.Cells["B_Quan"].Value.ToString();
            }

        }

        private void DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bid = Int64.Parse(DV.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataGridViewRow row = this.DV.Rows[e.RowIndex];

                id.Text = row.Cells["B_ID"].Value.ToString();
                txtBn.Text = row.Cells["B_Name"].Value.ToString();
                txtBAN.Text = row.Cells["B_Author"].Value.ToString();
                txtBP.Text = row.Cells["B_Pub"].Value.ToString();
                BPD.Text = row.Cells["B_Pub_Date"].Value.ToString();
                txtBPr.Text = row.Cells["B_Price"].Value.ToString();
                txtBQ.Text = row.Cells["B_Quan"].Value.ToString();
            }
        }

       

        

       
    }
}
