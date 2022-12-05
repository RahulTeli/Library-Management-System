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
    public partial class RetunB : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177 ; database = lib ;integrated security = True");
        public RetunB()
        {
            InitializeComponent();
        }

        private void caan_MouseHover(object sender, EventArgs e)
        {
            caan.BackColor = Color.Red;
            caan.ForeColor = Color.WhiteSmoke;
        }

        private void caan_MouseLeave(object sender, EventArgs e)
        {
            caan.BackColor = Color.Aqua;
            caan.ForeColor = Color.Black;
        }

        private void RetunB_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            tP.Clear();
        }

       

        private void sser_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tP.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers In PRN.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select * from IRBook where S_PRN = '" + tP.Text + "' and Book_Return_Date IS NULL";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    DV.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Invalid PRN or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }
        Int64 Sprn;
        private void DV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            if (e.RowIndex >= 0)
            {
                
                Sprn = Int64.Parse(DV.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataGridViewRow row = this.DV.Rows[e.RowIndex];

                txtN.Text = row.Cells["B_Name"].Value.ToString();
                txtI.Text = row.Cells["Book_Issued_Date"].Value.ToString();
                dtpR.Text = row.Cells["Book_Return_Date"].Value.ToString();
                
            }
        }

        private void DV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            if (e.RowIndex >= 0)
            {

                Sprn = Int64.Parse(DV.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataGridViewRow row = this.DV.Rows[e.RowIndex];

                txtN.Text = row.Cells["B_Name"].Value.ToString();
                txtI.Text = row.Cells["Book_Issued_Date"].Value.ToString();
                dtpR.Text = row.Cells["Book_Return_Date"].Value.ToString();

            }

        }

        private void re_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "update IRBook set Book_Return_Date = '" + dtpR.Text + "' where S_PRN = " + tP.Text + " and  B_Name = '" + txtN.Text + "' ";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "update AddBook set B_Quan = B_Quan+1 where    B_Name = '" + txtN.Text + "' ";
            cmd1.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Return Succesful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RetunB_Load(this, null);
        }

        private void bref_Click(object sender, EventArgs e)
        {
            tP.Clear();
        }

        private void tP_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tP.Text))
            {
                panel3.Visible = false;
                DV.DataSource = null;
            }
        }

        private void cb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tP.Text))
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

        private void cbb_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void caan_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tP.Text))
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
    }
}
