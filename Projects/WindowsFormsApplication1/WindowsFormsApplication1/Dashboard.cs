using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library;

namespace WindowsFormsApplication1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                this.Close();
            }
            
        }

       

        private void addNewBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddBook b = new AddBook();
            b.Show();
        }

        private void viewBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewB b = new ViewB();
            b.Show();
        }

        private void addStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddStudent b = new AddStudent();
            b.Show();
        }

        private void newStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewStudent s = new viewStudent();
            s.Show();
        }

        private void issuedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssuedBook i = new IssuedBook();
            i.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetunB rb = new RetunB();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBD cb = new CompleteBD();
            cb.Show();
        }
    }
}
