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
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select New_Admission.NAID as Student_ID,New_Admission.fname as Full_name,New_Admission.mname as Mother_name,New_Admission.gender as Gender,New_Admission.dob as Date_Of_Birth,New_Admission.mobile as Mobile,New_Admission.email as Email_ID,New_Admission.semester,New_Admission.prog as Programming_Language,New_Admission.sname as School_Name,New_Admission.duration as Course_Duration,New_Admission.addres as Address,fees.fees as Fees from New_Admission inner join fees on New_Admission.NAID=fees.NAID";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from New_Admission where NAID="+textBox1.Text+"";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
