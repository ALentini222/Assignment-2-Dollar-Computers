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
    public partial class SelectForm : Form
    {
        public string displayValue;
        public int productId;
        public string id, condition, cost, platform, manufacturer, os, model, memory, lcdScreen, hdd, gpu, cpuBrand, cpuNumber, cpuSpeed, cpuType, webCam;

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'computer_ProductsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.computer_ProductsDataSet.Products);
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductInfoForm product = new ProductInfoForm();
            product.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
        public int sendValue()
        {
            int productID = productId;
            return productID;
        }
        private int selectedRow = -1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            DataGridViewRow selectedRows = dataGridView1.Rows[selectedRow];
            productId = (int)selectedRows.Cells[0].Value;
            displayValue = selectedRows.Cells[2].Value.ToString();
            displayValue += selectedRows.Cells[3].Value.ToString();
            displayValue += "Valued at:";
            displayValue += selectedRows.Cells[1].Value.ToString();
            textBox1.Text = displayValue;

            id = selectedRows.Cells[0].Value.ToString();
            condition = selectedRows.Cells[10].Value.ToString();
            cost = selectedRows.Cells[1].Value.ToString();
            platform = selectedRows.Cells[11].Value.ToString();
            manufacturer = selectedRows.Cells[2].Value.ToString();
            os = selectedRows.Cells[12].Value.ToString();
            model = selectedRows.Cells[3].Value.ToString();
            memory = selectedRows.Cells[4].Value.ToString();
            lcdScreen = selectedRows.Cells[5].Value.ToString();
            hdd = selectedRows.Cells[13].Value.ToString();
            gpu = selectedRows.Cells[14].Value.ToString();
            cpuBrand = selectedRows.Cells[6].Value.ToString();
            cpuNumber = selectedRows.Cells[7].Value.ToString();
            cpuSpeed = selectedRows.Cells[8].Value.ToString();
            cpuType = selectedRows.Cells[9].Value.ToString();
            webCam = selectedRows.Cells[15].Value.ToString();
            if (selectedRow != -1)
            {
                button1.Enabled = true;
            }
        }
    }
}
