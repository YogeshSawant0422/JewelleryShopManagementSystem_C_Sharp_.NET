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
    public partial class Frm_Add_New_Product_Category : Form
    {
        public Frm_Add_New_Product_Category()
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

        #region Category_ID Auto_Increment

        int Auto_Incr()
        {
            int cnt = 0;
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Category_ID) from Category_Details", Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select MAX(Category_ID) from Category_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = 1;
            }

            Connection_Close();
            return cnt;
        }
        #endregion Auto_Increment

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Add_New_Product_Category_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterParent;
            tb_Category_ID.Focus();
            tb_Category_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_X_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_Category_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Category_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_Category_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into Category_Details values(" + tb_Category_ID.Text + ",'" + tb_Category_Name.Text + "')", Con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Category Added Successfully !!!", "ADD SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Category_Name.Clear();
                tb_Category_ID.Text = Convert.ToString(Auto_Incr());
            }
            else
            {
                MessageBox.Show("First Fill Category Name !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Connection_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Category_Name.Clear();
        }
    }
}

