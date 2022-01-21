using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
/*
 * Andreas Lentini 1141007
 * Comp 1098
 * Assignment 2
 * this assignment is to show db upload and file writing
 * 
 * ive had so many issues with my enviroment and getting things figured out that I just gave up
 * 
 * 
 * */
namespace Assinment_2_Dollar_Computers
{
    public partial class SplashScreen : Form
    {
        System.Timers.Timer timer;
        public SplashScreen()
        {
            InitializeComponent();            
            timer = new System.Timers.Timer(3000);
            timer.Elapsed += timer_Elapsed;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Close();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
