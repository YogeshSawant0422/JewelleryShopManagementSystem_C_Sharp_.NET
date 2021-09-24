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
    public partial class Frm_Manage_Customer : Form
    {
        public Frm_Manage_Customer()
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

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_X_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Manage_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jewellery_Shop_Management_System_DBDataSet4.Purchase_Details' table. You can move, or remove it, as needed.
            this.purchase_DetailsTableAdapter1.Fill(this.jewellery_Shop_Management_System_DBDataSet4.Purchase_Details);
            // TODO: This line of code loads data into the 'jewellery_Shop_Management_System_DBDataSet3.Bill_Reciept_Details' table. You can move, or remove it, as needed.
            this.bill_Reciept_DetailsTableAdapter.Fill(this.jewellery_Shop_Management_System_DBDataSet3.Bill_Reciept_Details);
            // TODO: This line of code loads data into the 'jewellery_Shop_Management_System_DBDataSet2.Purchase_Details' table. You can move, or remove it, as needed.
            this.purchase_DetailsTableAdapter.Fill(this.jewellery_Shop_Management_System_DBDataSet2.Purchase_Details);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_ID.Text != "")
            {

                SqlCommand Cmd = new SqlCommand("Select Name from Customer_Details where Customer_ID = " + tb_ID.Text + "", Con);
                var obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Name.Text = (obj["Name"].ToString());
                }
                Cmd.Dispose();
                obj.Dispose();

                SqlCommand Cmd2 = new SqlCommand("Select Mobile_No from Customer_Details where Customer_ID = " + tb_ID.Text + "", Con);
                tb_Mobile_Number.Text = Convert.ToString(Cmd2.ExecuteScalar());

                Cmd2.Dispose();

                SqlCommand Cmd3 = new SqlCommand("Select Date from Customer_Details where Customer_ID = " + tb_ID.Text + "", Con);
                tb_Date.Text = Convert.ToString(Cmd3.ExecuteScalar());

                Cmd3.Dispose();


                if (tb_ID.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select * from Purchase_Details Where Customer_ID = " + tb_ID.Text + "", Con);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);
                    dgv_View_Customer_Details.DataSource = dt;

                    SqlDataAdapter sda2 = new SqlDataAdapter("Select * from Bill_Reciept_Details Where Customer_ID = " + tb_ID.Text + "", Con);

                    DataTable dt2 = new DataTable();

                    sda2.Fill(dt2);
                    dgv_Bill_Details.DataSource = dt2;

                }
                else
                {
                    MessageBox.Show("Invalid Customer Id !!!");
                    tb_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid Customer Id !!!");
                tb_ID.Focus();
            }
            Connection_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Connection_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Purchase_Details", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgv_View_Customer_Details.DataSource = dt;

            SqlDataAdapter sda2 = new SqlDataAdapter("Select * from Bill_Reciept_Details ", Con);

            DataTable dt2 = new DataTable();

            sda2.Fill(dt2);
            dgv_Bill_Details.DataSource = dt2;

            tb_ID.Clear();
            tb_Mobile_Number.Clear();
            tb_Date.Clear();
            tb_Name.Clear();

            Connection_Close();
        }
    }
}
