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
    public partial class Frm_Product_Details : Form
    {
        public Frm_Product_Details()
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

        #endregion Connections

        #region Auto_Incr() Function 

        int Auto_Incr()
        {
            int cnt = 0;
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Product_ID) from Product_Details", Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select MAX(Product_ID) from Product_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = 6001;
            }

            Connection_Close();
            return cnt;
        }

        #endregion Auto_Incr()


        #region KeyPress_Events

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_Product_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Product_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '-') || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Net_Wt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '-') || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
        private void tb_Purity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        #endregion KeyPress

        #region Clear_Controls

        void Clear_Controls()
        {
            cmb_Category.Text = "";
            cmb_Sub_Category.Text = "";
            tb_Product_Name.Text = "";
            tb_Net_Wt.Text = "";
            cmb_Unit.Text = "";
            cmb_Purity.Text = "";
            tb_Price.Text = "";
            dgv_Product.Rows.Clear();
     
        }

        #endregion clear_Controls

        #region Form_Load_Event

        private void Frm_Product_Details_Load(object sender, EventArgs e)
        {
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Category_Name) from Category_Details", Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }
            obj.Dispose();
            Cmd.Dispose();

            tb_Product_ID.Text = Convert.ToString(Auto_Incr());

            Connection_Open();

            SqlCommand Cmd1 = new SqlCommand("Select Sales_Rate from Product_Rate_Details where ID = 5002", Con);
            tb_Gold_Price.Text = Convert.ToString(Cmd1.ExecuteScalar());

            Cmd1.Dispose();

            SqlCommand Cmd2 = new SqlCommand("Select Sales_Rate from Product_Rate_Details where ID = 5004", Con);
            tb_Silver_Price.Text = Convert.ToString(Cmd2.ExecuteScalar());

            Connection_Close();

            Connection_Close();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select SubCategory_Name from SubCategory_Details where Category_Name = '" + cmb_Category.Text + "'", Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Sub_Category.Items.Add(obj.GetString(obj.GetOrdinal("SubCategory_Name")));
            }

            Connection_Close();
        }

        #endregion Form_Load_Event

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Refresh this window ";
            string title = "WARNING";
            MessageBoxIcon Warning = MessageBoxIcon.Warning;
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, Buttons, Warning);

            if (result == DialogResult.Yes)
            {
                Clear_Controls();
             
            }
            else
            {

            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Net_Wt.Text != "" && cmb_Unit.Text != "" && cmb_Purity.Text != "" && tb_Price.Text != "")
            {
                dgv_Product.Rows.Add(tb_Net_Wt.Text, cmb_Unit.Text, cmb_Purity.Text, tb_Price.Text);

                tb_Net_Wt.Text = "";
                cmb_Unit.Text = "";
                cmb_Purity.Text = "";
                tb_Price.Text = "";

                tb_Net_Wt.Text = "0";
                tb_Price.Text = "0";
            }
            else
            {
                MessageBox.Show("Please Fill Product Weight And Price Details!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_Product_ID.Text != "" && cmb_Category.Text != "" && cmb_Sub_Category.Text != "" && tb_Product_Name.Text != "")
            {
                if (dgv_Product.Rows.Count > 0)
                {
                    SqlCommand Cmd = new SqlCommand("insert into Product_Details (Product_ID ,Category,Sub_Category,Product_Name)values(@Product_ID,@Category,@Sub_Category,@Product_Name)", Con);

                    Cmd.Parameters.Add("@Product_ID", SqlDbType.Int).Value = tb_Product_ID.Text;
                    Cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = cmb_Category.Text;
                    Cmd.Parameters.Add("@Sub_Category", SqlDbType.NVarChar).Value = cmb_Sub_Category.Text;
                    Cmd.Parameters.Add("@Product_Name", SqlDbType.NVarChar).Value = tb_Product_Name.Text;

                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();

                    Cmd.Connection = Con;
                    Cmd.CommandText = "Select Max(Product_ID) From Product_Details";
                    int ID = Convert.ToInt32(Cmd.ExecuteScalar());

                    Cmd.Dispose();

                    foreach (DataGridViewRow Row in dgv_Product.Rows)
                    {
                        Cmd.Connection = Con;

                        Cmd.CommandText = "insert into Product_Weight_And_Price_Details(Product_ID, Net_Wt ,Unit , Purity ,Price,Current_Stock) values(" + ID + "," + Row.Cells[0].Value + ",'" + Row.Cells[1].Value + "','" + Row.Cells[2].Value + "'," + Row.Cells[3].Value + ",0)";
                        Cmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Product Added Successfully !!!", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tb_Net_Wt.Text = "0";
                    tb_Price.Text = "0";

                    Clear_Controls();
                    dgv_Product.Rows.Clear();

                    tb_Product_ID.Text = Convert.ToString(Auto_Incr());
                }
                else
                {
                    MessageBox.Show("First Fill Product Weight And Price Information ");
                }
            }
            else
            {
                MessageBox.Show("First Fill All The Info Of Product !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connection_Close();
        }

        private void cmb_Purity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Net_Wt = Convert.ToString(tb_Net_Wt.Text);
            double Gold_Price = Convert.ToDouble(tb_Gold_Price.Text);
            double Silver_Price = Convert.ToDouble(tb_Silver_Price.Text);
           // double Price = Convert.ToDouble(tb_Price.Text);

            if (cmb_Category.Text == "Gold")
            {
              double  Price = Convert.ToDouble(Net_Wt) * Gold_Price / 10;

                tb_Price.Text = Convert.ToString(Price);
            }
            else if (cmb_Category.Text == "Silver")
            {
                double Price = Convert.ToDouble(Net_Wt) * Silver_Price / 1000;

                tb_Price.Text = Convert.ToString(Price);
            }
            else
            {
                MessageBox.Show("This Tyape Of Category Are Not In Stock !!! ");
                cmb_Category.Text = "";
                cmb_Sub_Category.Text = "";
                tb_Product_Name.Text = "";
                tb_Net_Wt.Text = "0";
                cmb_Category.Focus();
                cmb_Unit.Text = ""; cmb_Unit.Text = "";
                cmb_Purity.Text = "";
                cmb_Purity.Text = "";
            }
        }
    }
}
