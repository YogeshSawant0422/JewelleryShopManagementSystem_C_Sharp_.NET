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
    public partial class Frm_Accept_Order : Form
    {
        public Frm_Accept_Order()
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

        #region Auto_Incr() Function

        int Auto_Incr()
        {
            int cnt = 0;
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Order_ID) from Order_Details", Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select MAX(Order_ID) from Order_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = 9001;
            }

            Connection_Close();
            return cnt;
        }

        #endregion Auto_Incr()

        #region Category_Refresh

        void Category_Refresh()
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
            Connection_Close();
        }

       #endregion 

        #region Purity_Refresh
        void Purity_Refresh()
        {
            Connection_Open();

            SqlCommand Cmd3 = new SqlCommand("select Distinct (Purity) from Product_Weight_And_Price_Details ", Con);

            var obj2 = Cmd3.ExecuteReader();

            while (obj2.Read())
            {
                cmb_Purity.Items.Add(obj2.GetString(obj2.GetOrdinal("Purity")));
            }

            Connection_Close();
        }
        #endregion

        #region Clear_Controls
        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Mobile_Number.Text = "";
            tb_Address.Clear();
      
            cmb_Category.Text = "";
            cmb_Sub_Category.Text = "";
            cmb_Product.Text = "";
            cmb_Purity.Text = "";
            cmb_Unit.Text = "";
            tb_Net_Wt.Text = "";
            tb_Quantity.Text = "";
            tb_Price.Text = "";

            tb_Total_Amount.Clear();
            tb_Remaining_Amount.Clear();
            tb_Paid_Amount.Text = "0";
            tb_Other_Amount.Text = "0";
        }
        #endregion

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Accept_Order_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Convert.ToString(Auto_Incr());


            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Category_Name) from Category_Details", Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }
            obj.Dispose();
            Cmd.Dispose();       

            SqlCommand Cmd1 = new SqlCommand("Select Sales_Rate from Product_Rate_Details where ID = 5002", Con);
            tb_Gold_Price.Text = Convert.ToString(Cmd1.ExecuteScalar());

            Cmd1.Dispose();

            SqlCommand Cmd2 = new SqlCommand("Select Sales_Rate from Product_Rate_Details where ID = 5004", Con);
            tb_Silver_Price.Text = Convert.ToString(Cmd2.ExecuteScalar());


            SqlCommand Cmd3 = new SqlCommand("select Distinct (Purity) from Product_Weight_And_Price_Details ", Con);

            var obj2 = Cmd3.ExecuteReader();

            while (obj2.Read())
            {
                cmb_Purity.Items.Add(obj2.GetString(obj2.GetOrdinal("Purity")));
            }

            Connection_Close();
        }

        #region KeyPress

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '-') || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Mobile_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space) || e.KeyChar == '.'))
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

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
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

        private void tb_Other_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Paid_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        #endregion

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

        private void cmb_Sub_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select * from Product_Details where Sub_Category = '" + cmb_Sub_Category.Text + "'", Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            Connection_Close();
        }

        private void tb_Quantity_Leave(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "")
            {
                var Net_Wt = Convert.ToString(tb_Net_Wt.Text);
                int Quantity = Convert.ToInt32(tb_Quantity.Text);
                double Gold_Price = Convert.ToDouble(tb_Gold_Price.Text);
                double Silver_Price = Convert.ToDouble(tb_Silver_Price.Text);

                if (cmb_Category.Text == "Gold")
                {
                    double Price = Convert.ToDouble(Net_Wt) * Gold_Price / 10 * Quantity;

                    tb_Price.Text = Convert.ToString(Price);
                }
                else if (cmb_Category.Text == "Silver")
                {
                    double Price = Convert.ToDouble(Net_Wt) * Silver_Price / 1000 * Quantity;

                    tb_Price.Text = Convert.ToString(Price);
                }
                else
                {
                    MessageBox.Show("This Category Is Not Available In The Stock");

                    cmb_Category.Text = "";
                    cmb_Sub_Category.Text = "";
                    cmb_Product.Text = "";
                    cmb_Purity.Text = "";
                    tb_Net_Wt.Text = "";
                    cmb_Unit.Text = "";
                    tb_Quantity.Text = "0";
                    tb_Price.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Please Do Not Leave Quantity Without Null !!!!");
                tb_Quantity.Focus();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cmb_Category.Text != "" && cmb_Sub_Category.Text != "" && cmb_Product.Text != "" && cmb_Purity.Text != "" && tb_Net_Wt.Text != "" && cmb_Unit.Text != "" && tb_Quantity.Text != "" && tb_Price.Text != "")
            {
                dgv_Accept_Order.Rows.Add(cmb_Category.Text, cmb_Sub_Category.Text, cmb_Product.Text, cmb_Purity.Text, tb_Net_Wt.Text, cmb_Unit.Text, tb_Quantity.Text, tb_Price.Text);

                double Total_Amount = Convert.ToDouble(tb_Total_Amount.Text) + Convert.ToDouble(tb_Price.Text);
                tb_Total_Amount.Text = Convert.ToString(Total_Amount);

                cmb_Category.Text = "";
                cmb_Sub_Category.Text = "";
                cmb_Product.Text = "";
                cmb_Purity.Text = "";
                tb_Net_Wt.Text = "";
                cmb_Unit.Text = "";
                tb_Quantity.Text = "";
                tb_Price.Text = "";

                tb_Quantity.Text = "0";

                cmb_Category.Items.Clear();
                cmb_Product.Items.Clear();
                cmb_Purity.Items.Clear();
                cmb_Sub_Category.Items.Clear();

                Category_Refresh();
                Purity_Refresh();
                cmb_Category_SelectedIndexChanged(sender, e);
                cmb_Sub_Category_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("First Fill All Purchashe Details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_Number.Text != "" && tb_Address.Text != "" && dtp_Date.Text != "")
            {
                int Count = 0;
                if (dgv_Accept_Order.Rows.Count > Count)
                {
                    SqlCommand Cmd = new SqlCommand("insert into Order_Details (Order_ID,Mob_No,Date,Name,Address)values(@Order_ID ,@Mob_No,@Date,@Name,@Address)", Con);

                    Cmd.Parameters.Add("@Order_ID", SqlDbType.Int).Value = tb_ID.Text;
                    Cmd.Parameters.Add("@Mob_No", SqlDbType.Decimal).Value = tb_Mobile_Number.Text;
                    Cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Text;
                    Cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = tb_Name.Text;                  
                    Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                   
                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();


                    Cmd.Connection = Con;
                    Cmd.CommandText = "Select Max(Order_ID) From Order_Details";
                    int Order_ID = Convert.ToInt32(Cmd.ExecuteScalar());

                    Cmd.Dispose();
                   
                    foreach (DataGridViewRow Row in dgv_Accept_Order.Rows)
                    {
                        Cmd.Connection = Con;
                        string Order_Place = "No";
                        Cmd.CommandText = "Insert into Purchased_Order_Details(Order_ID,Category,Sub_Category,Product,Purity,Net_Wt,Unit,Quantity,Price,Order_Placed) values(" + Order_ID + ",'" + Row.Cells[0].Value + "','" + Row.Cells[1].Value + "','" + Row.Cells[2].Value + "','" + Row.Cells[3].Value + "'," + Row.Cells[4].Value + ",'" + Row.Cells[5].Value + "'," + Row.Cells[6].Value + "," + Row.Cells[7].Value + ",'" + Order_Place + "')";
                        Cmd.ExecuteNonQuery();
                    }

                    Cmd.Dispose();
                    string Message = "No";
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Insert into Order_Amount (Order_ID,Other_Amount,Total_Amount,Paid_Amount,Remaining_Amount,Total_Amount_Paid_OR_Not) values(" + Order_ID + "," + tb_Other_Amount.Text + "," + tb_Total_Amount.Text + "," + tb_Paid_Amount.Text + "," + tb_Remaining_Amount.Text + ",'" + Message + "') ";
                    Cmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Order Added Successfully !!!", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls();
                    
                    dgv_Accept_Order.Rows.Clear();  
                    tb_ID.Text = Convert.ToString(Auto_Incr());
                    
                    Cmd.Dispose();
                }
                else
                {
                    MessageBox.Show(" First Fill Orderd Items  !!!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Customer Information !!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connection_Close();
        }

        private void tb_Other_Amount_Leave(object sender, EventArgs e)
        {
            if (tb_Other_Amount.Text != "")
            {
                double Total_Amount = Convert.ToDouble(tb_Total_Amount.Text) + Convert.ToDouble(tb_Other_Amount.Text);

                tb_Total_Amount.Text = Convert.ToString(Total_Amount);
            }
            else
            {
                MessageBox.Show("Please Do Not leave with Null !!!");
            }
        }

        private void tb_Paid_Amount_Leave(object sender, EventArgs e)
        {
            if (tb_Paid_Amount.Text != "")
            {
                double Paid_Amount = 0.5 * Convert.ToDouble(tb_Total_Amount.Text);
                double P_Amount = Convert.ToDouble(tb_Paid_Amount.Text);

                if (P_Amount > Paid_Amount)
                {                  
                   double Remaining_Amount = Convert.ToDouble(tb_Total_Amount.Text) - Convert.ToDouble(tb_Paid_Amount.Text);

                    if(Remaining_Amount >= 0)
                    {
                        tb_Remaining_Amount.Text = Convert.ToString(Remaining_Amount);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Amount !!!!");
                        tb_Paid_Amount.Text = "0";
                        tb_Remaining_Amount.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Please Paid 50% Amount Of Total Amount .");
                    tb_Paid_Amount.Focus();
                }
            }
            else
            {
                MessageBox.Show("Do Not Leave With Null !!!");
                tb_Paid_Amount.Focus();
                tb_Remaining_Amount.Text = "0";
            }
        }
    }
}
