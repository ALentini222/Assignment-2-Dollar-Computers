using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
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
    public partial class ProductInfoForm : Form
    {
        public String productID;

        public ProductInfoForm()
        {
            InitializeComponent(); 
        }
        private OpenFileDialog openFileDialog;

        public void OpenPrevious()
        {
            openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog.FileName;
                    using (Stream str = openFileDialog.OpenFile())
                    {
                        productID = System.IO.File.ReadAllText(filePath);
                    }

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            DB db = new DB();
            db.openConnection();
            db.getProductInfo(Convert.ToInt16(productID));
            txtCondition.Text = db.condition;
            txtCost.Text = db.cost;
            txtCPUBrand.Text = db.cpuBrand;
            txtCPUNumber.Text = db.cpuNumber;
            txtCPUSpeed.Text = db.cpuSpeed;
            txtCPUType.Text = db.cpuType;
            txtGPUType.Text = db.gpu;
            txtHDD.Text = db.hdd;
            txtLCDSize.Text = db.lcdScreen;
            txtManufacturer.Text = db.manufacturer;
            txtMemory.Text = db.memory;
            txtModel.Text = db.model;
            txtOS.Text = db.os;
            txtPlatform.Text = db.platform;
            txtProductID.Text = db.id;
            txtWebCam.Text = db.webCam;
        }
        private void saveToFile()
        {
            string id;
            id = productID.ToString();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), id);
        }
        public String sendValues()
        {
            DB db = new DB();
            return db.id;
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
            DB db = new DB();
            db.closeConnection();
            OrderForm order = new OrderForm();
            order.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            SelectForm select = new SelectForm();
            select.Show();
            this.Hide();    
            DB db = new DB();
            db.closeConnection();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenPrevious();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            this.Close();
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.closeConnection();
            SelectForm select = new SelectForm();
            select.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToFile();
        }
    }
}
