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
    public partial class Frm_Bill_Receipt : Form
    {
        public Frm_Bill_Receipt()
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window ";
            string title = "Close Form";
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message,title,Buttons);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                Frm_Add_New_Customer obj = new Frm_Add_New_Customer();
                obj.WindowState = FormWindowState.Maximized;
                obj.MdiParent = this.MdiParent;
                obj.Show();
            }
            else
            {
                
            }
        }

        private void Frm_Bill_Receipt_Load(object sender, EventArgs e)
        {
            Connection_Open();

            tb_Customer_ID.Text = Convert.ToString(Global_Vars.Customer_ID);
            tb_Total_Amount.Text = Convert.ToString(Global_Vars.Total_Amount);

            Connection_Close();
        }

        private void tb_Other_Amount_Leave(object sender, EventArgs e)
        {
            if (tb_Other_Amount.Text != "")
            {
                double Main_Amount = Convert.ToDouble(tb_Total_Amount.Text) + Convert.ToDouble(tb_Other_Amount.Text);
                double Final_Bill = Main_Amount + (Convert.ToDouble(tb_Total_Amount.Text) * (Convert.ToDouble(tb_GST.Text) / 100));

                tb_Total_Amount.Text = Convert.ToString(Final_Bill);
            }
            else
            {
                MessageBox.Show("Please Do Not Leave without Null !!!");
                tb_Other_Amount.Focus();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();

            string Payment_Mode = "";

            if (rb_Card.Checked == true)
            {
                Payment_Mode = "Card";
            }
            else if (rb_Cash.Checked == true)
            {
                Payment_Mode = "Cash";
            }
            else
            {
                Payment_Mode = "Online";
            }

            if (tb_Other_Amount.Text != "" && rb_Card.Text != "" || rb_Cash.Text != "" || rb_Online.Text != "")
            {
               
                SqlCommand Cmd = new SqlCommand("Insert into Bill_Reciept_Details values(" + tb_Customer_ID.Text + "," + tb_GST.Text + "," + tb_Other_Amount.Text + "," + tb_Total_Amount.Text + ",'" + Payment_Mode + "')",Con);
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Bill Uploaded !!!!!");

                tb_Customer_ID.Text = "";
                tb_Other_Amount.Text = "";
                tb_Total_Amount.Text = "";
                rb_Card.Checked = false;
                rb_Cash.Checked = false;
                rb_Online.Checked = false;

                Frm_Final_Customer_Report FCR = new Frm_Final_Customer_Report();
                FCR.WindowState = FormWindowState.Maximized;
                FCR.MdiParent = this.MdiParent;
                FCR.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fill Recored Correctly ????");
            }
            Connection_Close();
        }
    }
}
