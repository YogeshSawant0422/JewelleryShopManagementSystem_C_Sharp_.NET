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
    public partial class Frm_Datewise_Customer_Report : Form
    {
        public Frm_Datewise_Customer_Report()
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

        private void Frm_Datewise_Customer_Report_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();
            DataSet Dst = new DataSet();
            SqlCommand cmd = new SqlCommand("Select * from Customer_Details Where Date  >= @From_date AND Date <= @ToDate", Con);
            cmd.Parameters.Add("@From_date", SqlDbType.Date).Value = dtp_From.Text;
            cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = dtp_To.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
  
            sda.Fill(Dst,"Customer_Details");

            cryrpt.Load(@"E:\Yogesh Sawant\Project.C#\Jewellery_Shop_Management_System\Jewellery_Shop_Management_System\Crystal_Report\Datewise_Customer_Report.rpt");

            cryrpt.SetDataSource(Dst);
            crystalReportViewer1.ReportSource = cryrpt;

            Connection_Close();
        }
    }
}
