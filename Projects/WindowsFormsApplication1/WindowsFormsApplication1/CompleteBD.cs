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
    public partial class CompleteBD : Form
    {
        SqlConnection con = new SqlConnection("data source = DESKTOP-F2HI177 ; database = lib ;integrated security = True");
        public CompleteBD()
        {
            InitializeComponent();
        }

        private void CompleteBD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libDataSet1.IRBook' table. You can move, or remove it, as needed.
            this.iRBookTableAdapter1.Fill(this.libDataSet1.IRBook);
            // TODO: This line of code loads data into the 'libDataSet.IRBook' table. You can move, or remove it, as needed.
            this.iRBookTableAdapter.Fill(this.libDataSet.IRBook);
            
        }

        private void t1_TextChanged(object sender, EventArgs e)
        {
            if (t1.Text != " ")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from IRBook where S_PRN LIKE '" + t1.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dv1.DataSource = ds.Tables[0];
                con.Close();

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select S_PRN , S_Name , S_Dep , S_Sem , S_Cont , S_Email ,B_Name ,Book_Issued_Date from IRBook ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dv1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void btnrefr_Click(object sender, EventArgs e)
        {
            t1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t2.Clear();

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {
            if (t2.Text != " ")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from IRBook where S_PRN LIKE '" + t2.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dv2.DataSource = ds.Tables[0];
                con.Close();

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select S_PRN , S_Name , S_Dep , S_Sem , S_Cont , S_Email ,B_Name ,Book_Return_Date from IRBook ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dv2.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void caan_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
