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
    public partial class Remove_Student : Form
    {
        public Remove_Student()
        {
            InitializeComponent();
        }

        private void Remove_Student_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from New_Admission";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewDelStudent.DataSource = DS.Tables[0];

        }

        private void btnDelStudent_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will DELETE Your Data...!","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from New_Admission where NAID =" + txtRegID.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBox.Show("Deletion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
