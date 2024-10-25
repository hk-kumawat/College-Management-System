using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using System.Text.RegularExpressions;


namespace CollageManagementSystem
{
    public partial class Add_Teacher : Form
    {
        public Add_Teacher()
        {
            InitializeComponent();
        }

        private void txtProgramming_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool ischecked = radioButtonMale1.Checked;

            if(ischecked)
            {
                gender = radioButtonMale1.Text;
            }
            else
            {
                gender = radioButtonFemale1.Text;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,yer,adr) values ('" + txtFName.Text + "','" + gender + "','" + dateTimePicker_1DOB.Text + "'," + txtMobile.Text + ",'" + txtemail.Text + "','" + txtsemester.Text + "','" + txtProgram.Text + "','" + txtduration.Text + "','" + txtAdd.Text + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dateTimePicker_1DOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
