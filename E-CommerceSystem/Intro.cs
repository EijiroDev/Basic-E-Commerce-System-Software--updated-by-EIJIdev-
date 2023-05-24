using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace E_CommerceSystem
{
    public partial class Intro : KryptonForm
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
                Opacity += .2;
               
                if (timer1.Interval == 500 && Opacity == 100)
                {
                    Login login = new Login();
                    timer1.Stop();
                    login.Show();
                }
            
        }
    }
}
