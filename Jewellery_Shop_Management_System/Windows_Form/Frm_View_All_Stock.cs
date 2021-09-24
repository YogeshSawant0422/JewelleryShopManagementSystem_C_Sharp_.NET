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
    public partial class Frm_View_All_Stock : Form
    {
        public Frm_View_All_Stock()
        {
            InitializeComponent();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void Frm_View_All_Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jewellery_Shop_Management_System_DBDataSet1.Product_Weight_And_Price_Details' table. You can move, or remove it, as needed.
            this.product_Weight_And_Price_DetailsTableAdapter.Fill(this.jewellery_Shop_Management_System_DBDataSet1.Product_Weight_And_Price_Details);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Product_Name from Product_Details where Product_ID = " + tb_Product_ID.Text + "", Con);
            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Product_Name.Text = (obj["Product_Name"].ToString());
            }

            Cmd.Dispose();
            obj.Dispose();

            if (tb_Product_ID.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Product_Weight_And_Price_Details Where Product_ID = " + tb_Product_ID.Text + "", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgv_Stock_View.DataSource = dt;
                
            }
            else
            {
                MessageBox.Show("Invalid Product Id !!!");
                tb_Product_ID.Focus();
            }
            Connection_Close();
        }

        private void btn_Refresh_Grid_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_Product_ID.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Product_Weight_And_Price_Details", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgv_Stock_View.DataSource = dt;
            }

            tb_Product_ID.Text = "";
            tb_Product_Name.Text = "";

            tb_Product_ID.Focus();

            Connection_Close();
        }
    }
}
