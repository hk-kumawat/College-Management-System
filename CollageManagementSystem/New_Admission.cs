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
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            string name = txtFullName.Text;
            string mname = txtMotherName.Text;
            string gender = radioButtonMale.Checked ? radioButtonMale.Text : radioButtonFemale.Text;
            string dob = dateTimePickerDOB.Text;
            long mobile = long.Parse(txtMobileNo.Text);
            string email = txtEmail.Text;
            string semester = txtSemester.Text;
            string program = txtProgramming.Text;
            string sname = txtSchoolName.Text;
            string duration = txtDuration.Text;
            string add = txtAddress.Text;

            string connectionString = "data source=HARSHAL\\SQLEXPRESS; database=college; integrated security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string insertQuery = "INSERT INTO New_Admission (fname, mname, gender, dob, mobile, email, semester, prog, sname, duration, addres) " +
                                     "VALUES (@fname, @mname, @gender, @dob, @mobile, @email, @semester, @prog, @sname, @duration, @add)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@fname", name);
                    cmd.Parameters.AddWithValue("@mname", mname);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@semester", semester);
                    cmd.Parameters.AddWithValue("@prog", program);
                    cmd.Parameters.AddWithValue("@sname", sname);
                    cmd.Parameters.AddWithValue("@duration", duration);
                    cmd.Parameters.AddWithValue("@add", add);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();
        }

    }
}
