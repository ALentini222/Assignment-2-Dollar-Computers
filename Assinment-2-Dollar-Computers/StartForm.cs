using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
/*
 * Andreas Lentini 1141007
 * Comp 1098
 * Assignment 2
 * */
namespace Assinment_2_Dollar_Computers
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();              
        }
        private void StartForm_Load(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.Show();
            this.Hide();
        }        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            ProductInfoForm info = new ProductInfoForm();
            info.OpenPrevious();
            info.Show();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }


    }
}
