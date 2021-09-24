using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Jewellery_Shop_Management_System
{
    public partial class Frm_Single_Product_Report : Form
    {
        public Frm_Single_Product_Report()
        {
            InitializeComponent();
        }

        #region Connections

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Jewellery_Shop_Management_System_DB;Integrated Security=True");

        void Connection_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Connection_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        #endregion

        ReportDocument cryrpt = new ReportDocument();

        SqlDataAdapter sda;
    

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            Connection_Open();

            if (tb_Product_ID.Text != "")
            {
                sda = new SqlDataAdapter("SELECT Product_Details.Product_ID, Product_Details.Category, Product_Details.Sub_Category,Product_Details.Product_Name,Product_Weight_And_Price_Details.Net_Wt,Product_Weight_And_Price_Details.Unit, Product_Weight_And_Price_Details.Purity, Product_Weight_And_Price_Details.Price, Product_Weight_And_Price_Details.Current_Stock FROM Product_Details INNER JOIN Product_Weight_And_Price_Details ON Product_Details.Product_ID = Product_Weight_And_Price_Details.Product_ID Where Product_Details.Product_ID = " + tb_Product_ID.Text + "", Con);
                DataSet Dst = new DataSet();
                sda.Fill(Dst,"Product_Details");
                sda.Fill(Dst,"Product_Weight_And_Price_Details");
                
                cryrpt.Load(@"E:\Yogesh Sawant\Project.C#\Jewellery_Shop_Management_System\Jewellery_Shop_Management_System\Crystal_Report\Single_Product_Report1.rpt");

                cryrpt.SetDataSource(Dst);
                Crv_Single_Product_Report.ReportSource = cryrpt;
            }
            else
            {
                MessageBox.Show("Please Enter Correct ID !!!");
            }

            Connection_Close();
        }
    }
}
