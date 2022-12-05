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
    public partial class viewStudent : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177; database = lib ;integrated security = True");
        public viewStudent()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            String query = @"SELECT 
               [S_PRN]            
              ,[S_Name]
              ,[S_Dep]
           ,[S_Sem]
             ,[S_Cont]
            ,[S_Email]
               FROM [lib].[dbo].[Student]";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dv.DataSource = ds.Tables[0];
            con.Close();


        }
        private void viewStudent_Load(object sender, EventArgs e)
        {
            populate();
        }
       
        private void btnc_MouseHover(object sender, EventArgs e)
        {
            btnc.BackColor = Color.Red;
            btnc.ForeColor = Color.WhiteSmoke;
        }

        private void btnc_MouseLeave(object sender, EventArgs e)
        {
            btnc.BackColor = Color.Aqua;
            btnc.ForeColor = Color.Black;
        }
        


        
        private void btnc_Click(object sender, EventArgs e)
        {
            if ((txtName.Text == "Name") &&
               (txtPRN.Text == "PRN") &&
               (txtDep.Text == "Department") &&
               (txtSem.Text == "Semester") &&
               (txtCon.Text == "Contact") &&
               (txtEm.Text == "Email"))
            {
                this.Close();

            }

            else if (string.IsNullOrWhiteSpace(txtName.Text) ||
                   string.IsNullOrWhiteSpace(txtPRN.Text) ||
                    string.IsNullOrWhiteSpace(txtDep.Text) ||
                    string.IsNullOrWhiteSpace(txtCon.Text) ||
                    string.IsNullOrWhiteSpace(txtSem.Text) ||
                     string.IsNullOrWhiteSpace(txtEm.Text))
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
        
       private void BtnCan_Click_1(object sender, EventArgs e)
       {
           if ((txtName.Text == "Name") &&
               (txtPRN.Text == "PRN") &&
               (txtDep.Text == "Department") &&
               (txtSem.Text == "Semester") &&
               (txtCon.Text == "Contact") &&
               (txtEm.Text == "Email"))
           {
               this.Close();

           }

           else if (string.IsNullOrWhiteSpace(txtName.Text) ||
                  string.IsNullOrWhiteSpace(txtPRN.Text) ||
                   string.IsNullOrWhiteSpace(txtDep.Text) ||
                   string.IsNullOrWhiteSpace(txtCon.Text) ||
                   string.IsNullOrWhiteSpace(txtSem.Text) ||
                    string.IsNullOrWhiteSpace(txtEm.Text))
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
        

        private void txtName_Enter_1(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Clear();
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.DimGray;
            }
        }
        private void txtPRN_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPRN.Text == "PRN")
            {
                txtPRN.Clear();
                txtPRN.ForeColor = Color.Black;
            }
        }
       

        private void txtPRN_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPRN.Text))
            {
                txtPRN.Text = "PRN";
                txtPRN.ForeColor = Color.DimGray;
            }
        }

        private void txtDep_Enter(object sender, EventArgs e)
        {
            if (txtDep.Text == "Department")
            {
                txtDep.Clear();
                txtDep.ForeColor = Color.Black;
            }
        }

        private void txtDep_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDep.Text))
            {
                txtDep.Text = "Department";
                txtDep.ForeColor = Color.DimGray;
            }
        }

        private void txtSem_Enter(object sender, EventArgs e)
        {
            if (txtSem.Text == "Semester")
            {
                txtSem.Clear();
                txtSem.ForeColor = Color.Black;
            }
        }

        private void txtSem_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSem.Text))
            {
                txtSem.Text = "Semester";
                txtSem.ForeColor = Color.DimGray;
            }
        }

        private void txtCon_Enter(object sender, EventArgs e)
        {
            if (txtCon.Text == "Contact")
            {
                txtCon.Clear();
                txtCon.ForeColor = Color.Black;
            }
        }

        private void txtCon_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtCon.Text))
            {
                txtCon.Text = "Contact";
                txtCon.ForeColor = Color.DimGray;
            }
        }
        private void txtEm_Enter_1(object sender, EventArgs e)
        {
            if (txtEm.Text == "Email")
            {
                txtEm.Clear();
                txtEm.ForeColor = Color.Black;
            }
        }

        private void txtEm_Leave_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEm.Text))
            {
                txtEm.Text = "Email";
                txtEm.ForeColor = Color.DimGray;
            }
        }
        
        

        private void txtSerPRN_TextChanged(object sender, EventArgs e)
        {
            if (txtSerPRN.Text != " ")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from Student where S_PRN LIKE '" + txtSerPRN.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dv.DataSource = ds.Tables[0];
                con.Close();

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from Student ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dv.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void btnrefrprn_Click(object sender, EventArgs e)
        {
            txtSerPRN.Clear();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
             if ((txtName.Text == "Name") &&
               (txtPRN.Text == "PRN") &&
               (txtDep.Text == "Department") &&
               (txtSem.Text == "Semester") &&
               (txtCon.Text == "Contact") &&
               (txtEm.Text == "Email"))
            {
                MessageBox.Show("Enter Valid Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(txtCon.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in Contact ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
             else if (System.Text.RegularExpressions.Regex.IsMatch(txtPRN.Text, "[^0-9]"))
             {
                 MessageBox.Show("Please enter only numbers in PRN ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

             }

            else
            {

                String prn = txtPRN.Text;
                String name = txtName.Text;
                String dep = txtDep.Text;
                String sem = txtSem.Text;
                String Con = txtCon.Text;
                String em = txtEm.Text;

                con.Open();




                if (MessageBox.Show("UPDATE!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    String query = "update Student set     S_PRN ='" + prn + "' , S_Name = '" + name + "' , S_Dep ='" + dep + "' ,  S_Sem='" + sem + "' ,  S_Cont= '" + Con + "' , S_Email = '" + em + "' where S_PRN = '" + Sprn + "' ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }

                con.Close();
                populate();
            }
            
        }

        Int64 Sprn;
        private void dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Sprn = Int64.Parse(dv.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataGridViewRow row = this.dv.Rows[e.RowIndex];

                txtPRN.Text = row.Cells["S_PRN"].Value.ToString();
                txtName.Text = row.Cells["S_Name"].Value.ToString();
                txtDep.Text = row.Cells["S_Dep"].Value.ToString();
                txtSem.Text = row.Cells["S_Sem"].Value.ToString();
                txtCon.Text = row.Cells["S_Cont"].Value.ToString();
                txtEm.Text = row.Cells["S_Email"].Value.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((txtPRN.Text == "PRN") &&
                (txtName.Text == "Name") &&
                (txtDep.Text == "Department") &&
                (txtSem.Text == "Semester") &&
                (txtCon.Text == "Contact") &&
                (txtEm.Text == "Email"))
            {
                MessageBox.Show("Enter Valid Details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();



                if (MessageBox.Show("DELETE!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    String query = "delete from Student where S_PRN = " + Sprn + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                populate();
            }
        }

        private void dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Sprn = Int64.Parse(dv.Rows[e.RowIndex].Cells[0].Value.ToString());
                DataGridViewRow row = this.dv.Rows[e.RowIndex];

                txtPRN.Text = row.Cells["S_PRN"].Value.ToString();
                txtName.Text = row.Cells["S_Name"].Value.ToString();
                txtDep.Text = row.Cells["S_Dep"].Value.ToString();
                txtSem.Text = row.Cells["S_Sem"].Value.ToString();
                txtCon.Text = row.Cells["S_Cont"].Value.ToString();
                txtEm.Text = row.Cells["S_Email"].Value.ToString();
            }
        }

       

       

       
        
        
        

        

        

        

        

        









     
    }
}
