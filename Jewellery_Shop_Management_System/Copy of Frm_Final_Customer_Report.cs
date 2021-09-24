using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Jewellery_Shop_Management_System
{
    public partial class Frm_Final_Customer_Report : Form
    {

        ReportDocument cryrpt = new ReportDocument();
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Jewellery_Shop_Management_System_DB;Integrated Security=True");
        SqlDataAdapter sda;
        public Frm_Final_Customer_Report()
        {
            InitializeComponent();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Final_Customer_Report_Load(object sender, EventArgs e)
        {
            Con.Open();

            sda = new SqlDataAdapter("SELECT Customer_Details.Customer_ID AS Expr1, Customer_Details.Name, Customer_Details.Mobile_No, Customer_Details.Address, Customer_Details.Date, Purchase_Details.Category, Purchase_Details.Product_Name, Purchase_Details.Purity, Purchase_Details.Net_Wt, Bill_Reciept_Details.GST, Bill_Reciept_Details.Other_Amount, Bill_Reciept_Details.Total_Amount  FROM Customer_Details INNER JOIN  Purchase_Details ON Customer_Details.Customer_ID = Purchase_Details.Customer_ID INNER JOIN Bill_Reciept_Details ON Customer_Details.Customer_ID = Bill_Reciept_Details.Customer_ID",Con);

            DataSet Dst = new DataSet();
            sda.Fill(Dst, "Customer_Details");
            cryrpt.Load("Customer_Report.rpt");

            cryrpt.SetDataSource(Dst);
            crystalReportViewer1.ReportSource = cryrpt;
        }
    }
}
