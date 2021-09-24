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
    public partial class Frm_Add_Stock : Form
    {
        public Frm_Add_Stock()
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

        void Clear_Controls()
        {
            tb_Product_ID.Text = "";
            tb_Product_Name.Clear();
            tb_Category.Text = "";
            tb_Sub_Category.Text = "";
            tb_Current_Stock.Clear();
            tb_Add_Quantity.Text = "";
            cmb_Net_Wt.Text = "";
            tb_Current_Stock.Text = "0";
            tb_Product_ID.Focus();
            tb_Add_Quantity.Text = "0";
        }
        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_Product_ID.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Select * From Product_Details Where Product_ID = " + tb_Product_ID.Text + " ", Con);

                var obj = Cmd.ExecuteReader();

                if (obj.Read())
                {
                    tb_Category.Text = obj.GetString(obj.GetOrdinal("Category"));
                    tb_Sub_Category.Text = obj.GetString(obj.GetOrdinal("Sub_category"));
                    tb_Product_Name.Text = obj.GetString(obj.GetOrdinal("Product_Name"));
                }
                else
                {
                    MessageBox.Show("Invalid Product ID!!!", "Whats Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    tb_Product_ID.Clear();
                    tb_Product_ID.Focus();
                }

                Cmd.Dispose();
            }
            else
            {
                MessageBox.Show("First Fill Product ID For Searching !!!!");
            }

            Connection_Close();
        }

        private void tb_Product_ID_Leave(object sender, EventArgs e)
        {
            if (tb_Product_ID.Text != "")
            {
                Connection_Open();

                SqlCommand Cmd = new SqlCommand("Select Distinct(Net_Wt) from Product_Weight_And_Price_Details where Product_ID = " + tb_Product_ID.Text + "", Con);
                var obj = Cmd.ExecuteReader();

                while (obj.Read())
                {
                    cmb_Net_Wt.Items.Add(obj["Net_Wt"]);
                }
                obj.Dispose();

                Connection_Close();
            }
            else
            {
                MessageBox.Show("Please Do Not Leave Product ID With Null !!!");
            }
        }  

        private void cmb_Net_Wt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Unit from Product_Weight_And_Price_Details where Net_Wt = " + cmb_Net_Wt.Text + "", Con);
            var obj = Cmd.ExecuteReader();
            while (obj.Read())
            {
                lbl_Unit.Text = (obj["Unit"].ToString());
            }
            obj.Dispose();
            
            SqlCommand Cmd2 = new SqlCommand("Select Current_Stock From Product_Weight_And_Price_Details where Net_Wt = " + cmb_Net_Wt.Text + " And Product_ID = " + tb_Product_ID.Text + "",Con);
            tb_Current_Stock.Text = Convert.ToString(Cmd2.ExecuteScalar());

            Connection_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();          

            if (tb_Product_ID.Text != "" && cmb_Net_Wt.Text != "" && tb_Add_Quantity.Text != "")
            {
                int Current_Stock = Convert.ToInt32(tb_Current_Stock.Text);
                int Add_Quantity = Convert.ToInt32(tb_Add_Quantity.Text);
                Current_Stock = Current_Stock + Add_Quantity;
                tb_Current_Stock.Text = Convert.ToString(Current_Stock);

                SqlCommand Cmd = new SqlCommand("Update Product_Weight_And_Price_Details Set Current_Stock = " + tb_Current_Stock.Text + " where Net_Wt = " + cmb_Net_Wt.Text + " And Product_ID = " + tb_Product_ID.Text + "", Con);
                Cmd.ExecuteNonQuery();

                MessageBox.Show(" Stock Added Successfully !!!!");
                Clear_Controls();
                cmb_Net_Wt.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill The Details Correctly ????");
            }

            Connection_Close();
        }

  
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
