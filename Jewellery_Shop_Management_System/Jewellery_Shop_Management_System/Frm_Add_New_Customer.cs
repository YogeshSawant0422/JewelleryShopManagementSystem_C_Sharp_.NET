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
        public Frm_Add_New_Customer()
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
        int Auto_Incr()
        {
            int cnt = 0;
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Customer_ID) from Customer_Details", Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select MAX(Customer_ID) from Customer_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = 101;
            }

            Connection_Close();
            return cnt;
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            tb_ID.Focus();
            tb_ID.Text= Convert.ToString(Auto_Incr());
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsDigit(e.KeyChar))|| (e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!((char.IsLetter(e.KeyChar)) ||(e.KeyChar==(char)Keys.Back)||(e.KeyChar==(char)Keys.Space)))
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_Number.Text != "" && tb_Address.Text != "" && tb_PAN_No.Text != "")
            {

                SqlCommand cmd = new SqlCommand("insert into Customer_Details values(" + tb_ID.Text + ",'" + tb_Name.Text + "'," + tb_Mobile_Number.Text + ",'" + tb_Address.Text + "','" + dtp_Date.Text + "','" + tb_PAN_No.Text + "')", Con);
                cmd.ExecuteNonQuery();

               // var Result = MessageBox.Show("Customer Added Successfully !!!", "SAVE SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string message = "Customer Added Successfully !!!";
                string title = "SAVE SUCCESS";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message , title ,buttons);

                if (result == DialogResult.OK)
                {
                    DialogResult output = MessageBox.Show("Customer Wants To Purchase The Items !!!", "PURCHASE OR NOT ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (output == DialogResult.Yes)
                    {
                        this.Hide();
                        Frm_Purchase_Items obj = new Frm_Purchase_Items();
                        obj.WindowState = FormWindowState.Maximized;
                        obj.MdiParent = Frm_Purchase_Items.ActiveForm;
                        obj.StartPosition = FormStartPosition.CenterParent;
                        obj.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Customer Only Saved !!!!","SAVED",MessageBoxButtons.OK);
                    }
                }

                tb_ID.Text = Convert.ToString(Auto_Incr());
                tb_Name.Clear();
                tb_Mobile_Number.Text = "";
                tb_Address.Clear();
                tb_PAN_No.Clear();
            }
            else
            {
                MessageBox.Show("First Fill All Records !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Connection_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Mobile_Number.Text = "";
            tb_Address.Clear();
            tb_PAN_No.Clear();
        }

        public IFormatProvider OK { get; set; }
    }
}
