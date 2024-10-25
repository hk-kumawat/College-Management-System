using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;

namespace CollageManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public async void DataFromCloud()
        {
            Cursor.Current = Cursors.WaitCursor;
            var fb = new FirebaseClient(FBConfig.url);
            RegisterData obj = new RegisterData();

            obj.Username = txtUsername.Text;
            obj.Password = txtPassword.Text;
            var fbdata = await fb.Child("RegisterInfo").OnceAsync<RegisterData>();
            int id = 0;
            foreach (var data in fbdata)
            {
                RegisterData rd = new RegisterData();
                rd.Username = data.Object.Username;
                rd.Password = data.Object.Password;

                if (rd.Username == txtUsername.Text && rd.Password == txtPassword.Text)
                {
                    id = 1;
                    MessageBox.Show("Login Done Successfully");
                    Dashboard form = new Dashboard();
                    form.Show();
                    this.Hide();
                    return;
                }
            }
            if (id == 0)
            {
                MessageBox.Show("Invalid User");
            }
        }


        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

      

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username can't be Empty");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can't be Empty");
                return;
            }
            else
            {
                DataFromCloud();
               
            }
           
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Register gh = new Register();
            gh.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
