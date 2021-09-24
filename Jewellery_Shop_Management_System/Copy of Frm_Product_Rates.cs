using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Jewellery_Shop_Management_System
{
    public partial class Frm_Product_Rates : Form
    {
        public Frm_Product_Rates()
        {
            InitializeComponent();
        }
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_20Ct_SalesPrice.Text != "" && tb_22Ct_SalesPrice.Text != "" && tb_24Ct_SalesPrice.Text != "" && tb_Siver_Sales_Price.Text != "")
            {

                SqlCommand Cmd1 = new SqlCommand("Update Product_Rate_Details Set Sales_Rate = " + tb_24Ct_SalesPrice.Text + " Where ID = 5001 ", Con);
                Cmd1.ExecuteNonQuery();
                Cmd1.Dispose();

                SqlCommand Cmd2 = new SqlCommand("Update Product_Rate_Details Set Sales_Rate = " + tb_22Ct_SalesPrice.Text + " Where ID = 5002 ", Con);
                Cmd2.ExecuteNonQuery();
                Cmd2.Dispose();

                SqlCommand Cmd3 = new SqlCommand("Update Product_Rate_Details Set Sales_Rate = " + tb_20Ct_SalesPrice.Text + " Where ID = 5003 ", Con);
                Cmd3.ExecuteNonQuery();
                Cmd3.Dispose();

                SqlCommand Cmd4 = new SqlCommand("Update Product_Rate_Details Set Sales_Rate = " + tb_Siver_Sales_Price.Text + " Where ID = 5004 ", Con);
                Cmd4.ExecuteNonQuery();
                Cmd4.Dispose();

                MessageBox.Show("Price Updated Succefully !!!!", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_20Ct_SalesPrice.Clear();
                tb_22Ct_SalesPrice.Clear();
                tb_24Ct_SalesPrice.Clear();
                tb_Siver_Sales_Price.Clear();
            }
            else
            {
                MessageBox.Show("First Fill All New Prices ???", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_20Ct_SalesPrice.Clear();
            tb_22Ct_SalesPrice.Clear();
            tb_24Ct_SalesPrice.Clear();
            tb_Siver_Sales_Price.Clear();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
