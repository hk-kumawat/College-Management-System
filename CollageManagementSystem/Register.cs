using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Firebase.Database;
using Firebase.Database.Query;


namespace CollageManagementSystem
{
    public partial class Register : Form
    {
        String password_pattern = "(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        public Register()
        {
            InitializeComponent();
        }

        public async void RegisterData()
        {
            Cursor.Current = Cursors.WaitCursor;
            FirebaseClient fb = new FirebaseClient(FBConfig.url);
            RegisterData obj = new RegisterData();
            obj.Username = txtUsername.Text;
            obj.Password = txtPassword.Text;

            try
            {
                await fb.Child("RegisterInfo").PostAsync(obj);
                MessageBox.Show("Registration Done Successfully");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            Cursor.Current = Cursors.Default;

        }



        private void btnRegister_Click_1(object sender, EventArgs e)
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
            Regex reg = new Regex(password_pattern);
            if (!reg.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Enter Strong Password");
                return;
            }
            else
            {
                MessageBox.Show("Sign Up successful");

            }

            Form1 lg = new Form1();
            lg.Show();
            Hide();
            RegisterData();
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

        private void txtPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }



        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 lg = new Form1();
            lg.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }


        private void btnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
