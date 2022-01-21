using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Andreas Lentini 1141007
 * Comp 1098
 * Assignment 2
 * */
namespace Assinment_2_Dollar_Computers
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            DB db = new DB();
            db.openConnection();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Andreas Lentini\nv1.4\nContact:1-800-136-5527","About", MessageBoxButtons.OKCancel);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            ProductInfoForm product = new ProductInfoForm();
            db.getProductInfo(Convert.ToInt16(product.sendValues()));
            txtCondition.Text = db.condition;
            txtPrice.Text = db.cost;
            int price = (int)(Int32.Parse(db.cost));
            int total = ((int)(Int32.Parse(db.cost) * 1.13));
            int salesTax = total - price;
            txtSalesTax.Text = salesTax.ToString();
            txtTotal.Text = total.ToString();            
            txtManufacturer.Text = db.manufacturer;
            txtPlatform.Text = db.platform;
            txtModel.Text = db.model;

            listBox1.Text = db.lcdScreen;
            listBox1.Text = db.memory;
            listBox1.Text = db.cpuBrand;
            listBox1.Text = db.cpuNumber;
            listBox1.Text = db.cpuSpeed;
            listBox1.Text = db.cpuType;
            listBox1.Text = db.hdd;
            listBox1.Text = db.gpu;
            listBox1.Text = db.webCam;
            listBox1.Text = db.os;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            ProductInfoForm product = new ProductInfoForm();
            product.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thank you for ordering\n\nYour order is being processed and will be shipped in \n7-10 buisness days","thank you", MessageBoxButtons.OKCancel);
            if (this.DialogResult == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("printing", "print");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            this.Close();
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            ProductInfoForm product = new ProductInfoForm();
            product.Show();
            this.Hide();
        }
    }
}
