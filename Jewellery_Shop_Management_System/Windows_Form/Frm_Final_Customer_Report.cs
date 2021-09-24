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
        SqlDataAdapter sda;

        public Frm_Final_Customer_Report()
        {
            InitializeComponent();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window ";
            string title = "Close Form";
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, Buttons);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                Frm_Add_New_Customer obj = new Frm_Add_New_Customer();
                obj.WindowState = FormWindowState.Maximized;
                obj.MdiParent = this.MdiParent;
                obj.Show();
            }
            else
            {

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_Customer_ID.Text != "")
            {

                sda = new SqlDataAdapter("SELECT Customer_Details.Customer_ID, Customer_Details.Name, Customer_Details.Mobile_No, Customer_Details.Address, Customer_Details.Date, Purchase_Details.Category, Purchase_Details.Product_Name, Purchase_Details.Purity, Purchase_Details.Net_Wt,Purchase_Details.Unit ,Bill_Reciept_Details.GST, Bill_Reciept_Details.Other_Amount, Bill_Reciept_Details.Total_Amount  FROM Customer_Details INNER JOIN  Purchase_Details ON Customer_Details.Customer_ID = Purchase_Details.Customer_ID INNER JOIN Bill_Reciept_Details ON Customer_Details.Customer_ID = Bill_Reciept_Details.Customer_ID where Customer_Details.Customer_ID = " + tb_Customer_ID.Text + "", Con);

                DataSet Dst = new DataSet();
                sda.Fill(Dst,"Customer_Details");
                sda.Fill(Dst, "Purchase_Details");
                sda.Fill(Dst, "Bill_Reciept_Details");

                cryrpt.Load(@"E:\Yogesh Sawant\Project.C#\Jewellery_Shop_Management_System\Jewellery_Shop_Management_System\Crystal_Report\Customer_Report1.rpt");

                cryrpt.SetDataSource(Dst);
                crystalReportViewer1.ReportSource = cryrpt;
            }
            else
            {
                MessageBox.Show("Please Enter Correct ID !!!");
            }
            Connection_Close();
        }

        private void Frm_Final_Customer_Report_Load(object sender, EventArgs e)
        {
            Connection_Open();

            tb_Customer_ID.Text = Convert.ToString(Global_Vars.Customer_ID);

            Connection_Close();
        }
    }
}
