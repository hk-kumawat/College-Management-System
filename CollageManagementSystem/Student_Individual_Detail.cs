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
    public partial class Student_Individual_Detail : Form
    {
        public Student_Individual_Detail()
        {
            InitializeComponent();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            // Modify the SQL query to retrieve individual student details based on the given input (textBox1.Text)
            cmd.CommandText = "SELECT * FROM New_Admission WHERE NAID = @NAID";
            cmd.Parameters.AddWithValue("@NAID", textBox1.Text);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count != 0)
            {
                // Update the labels with the retrieved student details
                labelFullName.Text = DS.Tables[0].Rows[0]["fname"].ToString();
                labelMotherName.Text = DS.Tables[0].Rows[0]["mname"].ToString();
                labelGender.Text = DS.Tables[0].Rows[0]["gender"].ToString();
                labelDOB.Text = DS.Tables[0].Rows[0]["dob"].ToString();
                labelMobile.Text = DS.Tables[0].Rows[0]["mobile"].ToString();
                labelEmail.Text = DS.Tables[0].Rows[0]["email"].ToString();
                labelStd.Text = DS.Tables[0].Rows[0]["semester"].ToString();
                labelMedium.Text = DS.Tables[0].Rows[0]["prog"].ToString();
                labelSchoolName.Text = DS.Tables[0].Rows[0]["sname"].ToString();
                labelYear.Text = DS.Tables[0].Rows[0]["duration"].ToString();
                labelAddress.Text = DS.Tables[0].Rows[0]["addres"].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelFullName.Text = "________";
                labelMotherName.Text = "________";
                labelGender.Text = "________";
                labelDOB.Text = "________";
                labelMobile.Text = "________";
                labelEmail.Text = "________";
                labelStd.Text = "________";
                labelMedium.Text = "________";
                labelSchoolName.Text = "________";
                labelYear.Text = "________";
                labelAddress.Text = "________";
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "________";
            labelMotherName.Text = "________";
            labelGender.Text = "________";
            labelDOB.Text = "________";
            labelMobile.Text = "________";
            labelEmail.Text = "________";
            labelStd.Text = "________";
            labelMedium.Text = "________";
            labelSchoolName.Text = "________";
            labelYear.Text = "________";
            labelAddress.Text = "________";

            textBox1.Text = "";
        }
    }
}
