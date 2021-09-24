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
    public partial class Frm_Stock_Report : Form
    {
        public Frm_Stock_Report()
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

        private void Frm_Stock_Report_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT * from Product_Weight_And_Price_Details", Con);
            DataSet Dst = new DataSet();
            sda.Fill(Dst, "Product_Weight_And_Price_Details");

            cryrpt.Load(@"E:\Yogesh Sawant\Project.C#\Jewellery_Shop_Management_System\Jewellery_Shop_Management_System\Crystal_Report\Stock_Report.rpt");

            cryrpt.SetDataSource(Dst);
            Crv_Stock_Report.ReportSource = cryrpt;
        }
    }
}
