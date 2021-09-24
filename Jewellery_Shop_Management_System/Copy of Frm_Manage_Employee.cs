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
    public partial class Frm_Manage_Employee : Form
    {
        public Frm_Manage_Employee()
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

        private void Frm_Manage_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jewellery_Shop_Management_System_DBDataSet5.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.jewellery_Shop_Management_System_DBDataSet5.Employee_Details);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_Employee_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select Join_Date from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + "", Con);
                var obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Join_Date.Text = (obj["Join_Date"].ToString());
                }
                Cmd.Dispose();
                obj.Dispose();

                SqlCommand Cmd2 = new SqlCommand("Select Status from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + "", Con);
                var obj2 = Cmd2.ExecuteReader();

                if (obj2.Read())
                {
                    tb_Status.Text = (obj2["Status"].ToString());
                }
                Cmd.Dispose();
                obj2.Dispose();

                Cmd2.Dispose();

                SqlCommand Cmd3 = new SqlCommand("Select Leave_Date from Employee_Details where Employee_ID = " + tb_Employee_ID.Text + "", Con);

                var obj3 = Cmd3.ExecuteReader();

                if (obj3.Read())
                {
                    tb_Leave_Date.Text = (obj3["Leave_Date"].ToString());
                }
                Cmd3.Dispose();
                obj3.Dispose();


                Cmd3.Dispose();

            }
            else
            {
                MessageBox.Show("Please Insert Employee ID First !!!");
            }

            Connection_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_Employee_ID.Text != "" && tb_Join_Date.Text != "" && tb_Leave_Date.Text != "" && tb_Status.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Update Employee_Details Set Status = '" + tb_Status.Text + "',Leave_Date = '" + tb_Leave_Date.Text + "' where Employee_ID = " + tb_Employee_ID.Text + "",Con);
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Employee updated!!!");

                tb_Employee_ID.Text = "";
                tb_Join_Date.Text = "";
                tb_Leave_Date.Text = "";
                tb_Status.Text = "";


                SqlDataAdapter sda = new SqlDataAdapter("Select * from Employee_Details ",Con);

                DataTable dt = new DataTable();

                sda.Fill(dt);
                dgv_Manage_Employee.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Please Fill All The Details for update!!!");
            }

            Connection_Open();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

            tb_Employee_ID.Text = "";
            tb_Join_Date.Text = "";
            tb_Leave_Date.Text = "";
            tb_Status.Text = "";


            SqlDataAdapter sda = new SqlDataAdapter("Select * from Employee_Details ", Con);

            DataTable dt = new DataTable();

            sda.Fill(dt);
            dgv_Manage_Employee.DataSource = dt;

        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
