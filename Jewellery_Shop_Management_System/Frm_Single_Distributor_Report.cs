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

namespace Jewellery_Shop_Management_System.Windows_Form
{
    public partial class Frm_Single_Distributor_Report : Form
    {
        public Frm_Single_Distributor_Report()
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

            if (tb_Distributor_ID.Text != "")
            {
                sda = new SqlDataAdapter("SELECT Distributor_Details.Distributor_ID, Distributor_Details.Date,Distributor_Details.Name,Distributor_Details.Mobile_No, Distributor_Details.Adhar_No, Distributor_Details.PAN_No, Distributor_Details.Address, Distributor_Details.Shop_Name, Distributor_Details.Reg_No,Stock_Added_By_Distributor.Stock_Added_Date,Stock_Added_By_Distributor.Category,Stock_Added_By_Distributor.Sub_Category,Stock_Added_By_Distributor.Product_Name,Stock_Added_By_Distributor.Add_Stock FROM Distributor_Details INNER JOIN Stock_Added_By_Distributor ON Distributor_Details.Distributor_ID = Stock_Added_By_Distributor.Distributor_ID where Distributor_Details.Distributor_ID = " + tb_Distributor_ID.Text + "", Con);
                DataSet Dst = new DataSet();
                sda.Fill(Dst, "Distributor_Details");
                sda.Fill(Dst, "Stock_Added_By_Distributor");

                cryrpt.Load(@"E:\Yogesh Sawant\Project.C#\Jewellery_Shop_Management_System\Jewellery_Shop_Management_System\Crystal_Report\Single_Distributor_Report1.rpt");

                cryrpt.SetDataSource(Dst);
                Crv_Single_Distributor_Report.ReportSource = cryrpt;
            }
            else
            {
                MessageBox.Show("Please Enter Correct ID !!!");
            }

            Connection_Close();
        }
    }
}
