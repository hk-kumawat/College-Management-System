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
    public partial class SplashScreen : Form
    {
        int ticks;
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            ticks++;
            if (ticks == 2)
            {
                Form1 obj = new Form1();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }

    }
}


