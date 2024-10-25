using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollageManagementSystem
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

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upgrade_Semester us = new Upgrade_Semester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student ss = new Search_Student();
            ss.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Individual_Detail sid = new Student_Individual_Detail();
            sid.Show();
        }

        private void addTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Teacher at = new Add_Teacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Teacher st = new Search_Teacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Student rs = new Remove_Student();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure ? This will Delete Your UNSAVED Data...!", "Confirmation Dailog!",MessageBoxButtons.OKCancel,MessageBoxIcon
                .Warning)==DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
