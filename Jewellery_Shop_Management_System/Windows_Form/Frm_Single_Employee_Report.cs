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
    public partial class Frm_Single_Employee_Report : Form
    {
        public Frm_Single_Employee_Report()
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

            if (tb_Employee_ID.Text != "")
            {
                sda = new SqlDataAdapter("SELECT Employee_Details.Employee_ID ,Employee_Details.Join_Date,Employee_Details.Name,Employee_Details.Mobile_No,Employee_Details.DOB ,Employee_Details.Gender,Employee_Details.Account_No,Employee_Details.Adhar_No,Employee_Details.Qualification,Employee_Details.Experiance,Employee_Details.Address,Employee_Details.Salary,Employee_Details.Status,Employee_Details.Leave_Date FROM Employee_Details Where Employee_ID = " + tb_Employee_ID.Text + "", Con);
                DataSet Dst = new DataSet();
                sda.Fill(Dst, "Employee_Details");

                cryrpt.Load(@"E:\Yogesh Sawant\Project.C#\Jewellery_Shop_Management_System\Jewellery_Shop_Management_System\Crystal_Report\Single_Employee_Report1.rpt");

                cryrpt.SetDataSource(Dst);
                Crv_Single_Employee_Report.ReportSource = cryrpt;
            }
            else
            {
                MessageBox.Show("Please Enter Correct ID !!!");
            }

            Connection_Close();
        }

        private void Frm_Single_Employee_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
