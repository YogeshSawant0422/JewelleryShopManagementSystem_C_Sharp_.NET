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
    public partial class Frm_Add_New_Customer : Form
    {
        Global_Functions Gobj = new Global_Functions();
  
        public Frm_Add_New_Customer()
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

        #region Clear_Controls
        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Mobile_Number.Text = "";
            tb_Address.Clear();
            tb_PAN_No.Clear();

            cmb_Category.Text = "";
            cmb_Sub_Category.Text = "";
            cmb_Product_Name.Text = "";
            cmb_Purity.Text = "";
            cmb_Unit.Text = "";
            tb_Net_Wt.Text = "";
            tb_Quantity.Text = "";
            tb_Amount.Text = "";
            
        }
        #endregion

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

        #region Keypress
        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
        private void tb_Mobile_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back)))
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
        private void tb_PAN_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Net_Wt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void tb_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Refresh this window ";
            string title = "WARNING";
            MessageBoxIcon Warning = MessageBoxIcon.Warning;
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, Buttons,Warning);

            if (result == DialogResult.Yes)
            {               
              Clear_Controls();
              dgv_Purchase_Items.Rows.Clear();
              
            }
            else
            {

            }   
        }

        private void Frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            tb_ID.Focus();
            tb_Total_Amount.Text = "0";
            tb_ID.Text = Gobj.Auto_Incr("Select Count(*) from Customer_Details ", "Select Max(Customer_ID) from Customer_Details", 101).ToString();

            Connection_Open();
            SqlCommand Cmd = new SqlCommand("Select Distinct(Category_Name) from Category_Details", Con);
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }
            obj.Dispose();

            Connection_Close();

            Connection_Open();

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_Number.Text != "" && tb_Address.Text != "" && tb_PAN_No.Text != "")
            {
                int Count = 0;
                if (dgv_Purchase_Items.Rows.Count > Count)
                {
                    SqlCommand Cmd = new SqlCommand("insert into Customer_Details (Customer_ID,Name ,Mobile_No,Address,Date,PAN_No)values(@Customer_ID ,@Name ,@Mobile_No,@Address,@Date,@PAN_No)", Con);

                    Cmd.Parameters.Add("@Customer_ID", SqlDbType.Int).Value = tb_ID.Text;
                    Cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                    Cmd.Parameters.Add("@Mobile_No", SqlDbType.Decimal).Value = tb_Mobile_Number.Text;
                    Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                    Cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Text;
                    Cmd.Parameters.Add("@PAN_No", SqlDbType.NVarChar).Value = tb_PAN_No.Text;

                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();


                    Cmd.Connection = Con;
                    Cmd.CommandText = "Select Max(Customer_ID) From Customer_Details";
                    int Customer_ID = Convert.ToInt32(Cmd.ExecuteScalar());

                    Cmd.Dispose();
                    try
                    {
                        foreach (DataGridViewRow Row in dgv_Purchase_Items.Rows)
                        {
                            Cmd.Connection = Con;

                            Cmd.CommandText = "Insert into Purchase_Details(Customer_ID,Category,Sub_Category,Product_Name,Purity,Net_Wt,Unit,Quantity,Amount) values(" + Customer_ID + ",'" + Row.Cells[0].Value + "','" + Row.Cells[1].Value + "','" + Row.Cells[2].Value + "','" + Row.Cells[3].Value + "'," + Row.Cells[4].Value + ",'" + Row.Cells[5].Value + "'," + Row.Cells[6].Value + "," + Row.Cells[7].Value + ")";
                            Cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Purchased Items Added Successfully !!!");
                    }

                    Global_Vars.Customer_ID = Convert.ToInt32(tb_ID.Text);
                    Global_Vars.Total_Amount = Convert.ToDouble(tb_Total_Amount.Text);

                    MessageBox.Show("Customer Added Successfully !!!", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Controls();
                    dgv_Purchase_Items.Rows.Clear();
                    tb_ID.Text = Gobj.Auto_Incr("Select Count(*) from Customer_Details ", "Select Max(Customer_ID) from Customer_Details", 101).ToString();

                    Cmd.Dispose();

                    this.Hide();

                    Frm_Bill_Receipt obj = new Frm_Bill_Receipt();
                    obj.WindowState = FormWindowState.Maximized;
                    obj.MdiParent = this.MdiParent;
                    obj.Show();
                }
                else
                {
                    MessageBox.Show(" First Fill Purchased Items  !!!");
                }
            }
            else
            {
                 MessageBox.Show("Please Fill All Customer Information !!!!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
            Connection_Close();
        }
  
        private void btn_Add_Click(object sender, EventArgs e)
        {
           
            if (cmb_Category.Text != "" && cmb_Sub_Category.Text != "" && cmb_Product_Name.Text != "" && cmb_Purity.Text != "" && tb_Net_Wt.Text != "" && cmb_Unit.Text != "" && tb_Quantity.Text != "" && tb_Amount.Text != "")
            {               
                dgv_Purchase_Items.Rows.Add(cmb_Category.Text, cmb_Sub_Category.Text, cmb_Product_Name.Text, cmb_Purity.Text, tb_Net_Wt.Text, cmb_Unit.Text, tb_Quantity.Text, tb_Amount.Text);
                double Total_Amount = Convert.ToDouble(tb_Total_Amount.Text) + Convert.ToDouble(tb_Amount.Text);
                tb_Total_Amount.Text = Convert.ToString(Total_Amount);

                cmb_Category.Text = "";
                cmb_Sub_Category.Text = "";
                cmb_Product_Name.Text = "";
                cmb_Purity.Text = "";
                tb_Net_Wt.Text = "";
                cmb_Unit.Text = "";
                tb_Quantity.Text = "";
                tb_Amount.Text = "";

                tb_Quantity.Text = "0";
                tb_Amount.Text = "0";

                cmb_Category.Items.Clear();
                cmb_Product_Name.Items.Clear();
                cmb_Purity.Items.Clear();
                cmb_Sub_Category.Items.Clear();

                Category_Refresh();
                Purity_Refresh();
                cmb_Category_SelectedIndexChanged(sender,e);
                cmb_Sub_Category_SelectedIndexChanged(sender, e);

                cmb_Category.Focus();
            }
            else
            {
                MessageBox.Show("First Fill All Purchashe Details ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Distinct(SubCategory_Name) from SubCategory_Details where Category_Name = '" + cmb_Category.Text + "'", Con);
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
                cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
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
                    double Amount = Convert.ToDouble(Net_Wt) * Gold_Price / 10 * Quantity;

                    tb_Amount.Text = Convert.ToString(Amount);
                }
                else if (cmb_Category.Text == "Silver")
                {
                    double Amount = Convert.ToDouble(Net_Wt) * Silver_Price / 1000 * Quantity;

                    tb_Amount.Text = Convert.ToString(Amount);
                }
                else
                {
                    MessageBox.Show("This Category Is Not Available In The Stock");

                    cmb_Category.Text = "";
                    cmb_Sub_Category.Text = "";
                    cmb_Product_Name.Text = "";
                    cmb_Purity.Text = "";
                    tb_Net_Wt.Text = "";
                    cmb_Unit.Text = "";
                    tb_Quantity.Text = "";
                    tb_Amount.Text = "";
                    cmb_Category.Focus();
                }
            }
            else
            {
                if (cmb_Category.Text != "")
                {
                    tb_Quantity.Focus();
                }
                else
                {
                    cmb_Category.Focus();
                }
            }

        }
    }
}
