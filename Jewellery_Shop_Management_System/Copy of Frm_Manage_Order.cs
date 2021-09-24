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
    public partial class Frm_Manage_Order : Form
    {
        public Frm_Manage_Order()
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

        private void Frm_Manage_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jewellery_Shop_Management_System_DBDataSet.Purchased_Order_Details' table. You can move, or remove it, as needed.
            this.purchased_Order_DetailsTableAdapter.Fill(this.jewellery_Shop_Management_System_DBDataSet.Purchased_Order_Details);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_ID.Text != "")
            {

                SqlCommand Cmd = new SqlCommand("Select Name from Order_Details where Order_ID = " + tb_ID.Text + "", Con);
                var obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Name.Text = (obj["Name"].ToString());
                }

                Cmd.Dispose();
                obj.Dispose();

                SqlCommand Cmd2 = new SqlCommand("Select Total_Amount from Order_Amount where Order_ID = " + tb_ID.Text + "", Con);
                tb_Total_Amount.Text = Convert.ToString(Cmd2.ExecuteScalar());

                Cmd2.Dispose();

                SqlCommand Cmd3 = new SqlCommand("Select Remaining_Amount from Order_Amount where Order_ID = " + tb_ID.Text + " ", Con);
                tb_Remaining_Amount.Text = Convert.ToString(Cmd3.ExecuteScalar());

                Cmd3.Dispose();


                    SqlDataAdapter sda = new SqlDataAdapter("Select * from Purchased_Order_Details Where Order_ID = " + tb_ID.Text + "", Con);

                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    dgv_View_Orders.DataSource = dt;

            }
            else
            {
                MessageBox.Show("First Fill All Correct Order ID  !!!");
            }
            Connection_Close();
        }

        private void btn_Refresh_Grid_Click(object sender, EventArgs e)
        {
            Connection_Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select * from Purchased_Order_Details", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv_View_Orders.DataSource = dt;

            Connection_Close();

            tb_ID.Text = "";
            tb_Name.Text = "";
            tb_Remaining_Amount.Text = "";
            tb_Total_Amount.Text = "";
                
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (rb_Total_Paid_Yes.Checked == false && rb_Total_Paid_No.Checked == false || rb_Yes.Checked == false && rb_No.Checked == false)
            {
                MessageBox.Show("First Fill All Order Details !!!");
            }
            else
            {
                Connection_Open();

                string Total_Paid = "";
                string Order_Placed = "" ;

                if(rb_Total_Paid_Yes.Checked == true)
                {
                    Total_Paid = "Yes";
                }
                else
                {
                    Total_Paid = "No";
                }

                if(rb_Yes.Checked == true)
                {
                    Order_Placed = "Yes";
                }
                else
	            {
                    Order_Placed = "No";
	            }

                SqlCommand Cmd = new SqlCommand("Update Purchased_Order_Details set Order_Placed = '" + Order_Placed + "' Where Order_ID = " + tb_ID.Text + "",Con);
                Cmd.ExecuteNonQuery();

                Cmd.Dispose();

                SqlCommand Cmd2 = new SqlCommand("Update Order_Amount set Total_Amount_Paid_OR_Not = '" + Total_Paid + "' Where Order_ID = " + tb_ID.Text + "", Con);
                Cmd2.ExecuteNonQuery();

                Cmd2.Dispose();

                MessageBox.Show("Record Updated Successfully !!!!");

                tb_ID.Text = "";
                tb_Name.Text = "";
                tb_Remaining_Amount.Text = "";
                tb_Total_Amount.Text = "";

                rb_No.Checked = false;
                rb_Yes.Checked = false;
                rb_Total_Paid_Yes.Checked = false;
                rb_Total_Paid_No.Checked = false;

                SqlDataAdapter sda = new SqlDataAdapter("Select * from Purchased_Order_Details", Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                dgv_View_Orders.DataSource = dt;

                Connection_Close();
            }
            Connection_Close();
        }
    }
}
