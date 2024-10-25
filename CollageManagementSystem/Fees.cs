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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID = " + txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            if (DS.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "insert into fees (NAID, fees) values (" + txtRegNumber.Text + ", " + txtFees.Text + ")";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("Fees Submition Successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegNumber.Text = "";
                    txtFees.Text = "";
                    fnameLabel.Text = "________";
                    mnameLabel.Text = "________";
                    durationLabel.Text = "________";
                }

            }
            else
            {
                MessageBox.Show("Fees is Already Submitted...!");
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "________";
                mnameLabel.Text = "________";
                durationLabel.Text = "________";
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



            if (txtRegNumber.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =HARSHAL\\SQLEXPRESS; database =college; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname, mname, duration from New_Admission where NAID = " + txtRegNumber.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    fnameLabel.Text = DS.Tables[0].Rows[0][0].ToString();
                    mnameLabel.Text = DS.Tables[0].Rows[0][1].ToString();
                    durationLabel.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    fnameLabel.Text = "________";
                    mnameLabel.Text = "________";
                    durationLabel.Text = "________";
                }
            }
            else
            {
                txtRegNumber.Text = "";
                txtRegNumber.Text = "";
                fnameLabel.Text = "________";
                mnameLabel.Text = "________";
                durationLabel.Text = "________";
            }

        }
    }
}
