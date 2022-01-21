using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    class DB
    {
        public String id, condition, cost, platform, manufacturer, os, model, memory, lcdScreen, hdd, gpu, cpuBrand, cpuNumber, cpuSpeed, cpuType, webCam;
        public static SqlConnection connection = new SqlConnection("Data Source=ANDY-LENTINI;Initial Catalog=Computer Products;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand("", connection);
        public static BindingSource bindSrc;
        public static string sql;
        public void openConnection()
        {
            try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        break;
                    case 1045:
                        break;
                }
            }
        }

        public void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException e)
            {
                String message = e.Message;
            }
        }
        public void getProductInfo(int productId)
        {
                SqlDataReader dataReader;
                sql = "SELECT * FROM dbo.Products WHERE ID = @productId";
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add(new SqlParameter("@productId", SqlDbType.Int));
                cmd.Parameters["@productId"].Value = productId;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    id = (String)dataReader.GetValue(0);
                    condition = (String)dataReader.GetValue(10);
                    cost = (String)dataReader.GetValue(1);
                    platform = (String)dataReader.GetValue(11);
                    manufacturer = (String)dataReader.GetValue(2);
                    os = (String)dataReader.GetValue(12);
                    model = (String)dataReader.GetValue(3);
                    memory = (String)dataReader.GetValue(4);
                    lcdScreen = (String)dataReader.GetValue(5);
                    hdd = (String)dataReader.GetValue(13);
                    gpu = (String)dataReader.GetValue(14);
                    cpuBrand = (String)dataReader.GetValue(6);
                    cpuNumber = (String)dataReader.GetValue(7);
                    cpuSpeed = (String)dataReader.GetValue(8);
                    cpuType = (String)dataReader.GetValue(9);
                    webCam = (String)dataReader.GetValue(15);
            }
        }
    }
}

