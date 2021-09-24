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
    public partial class Frm_Login_Form : Form
    {
        public Frm_Login_Form()
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

        private void tb_Username_Enter(object sender, EventArgs e)
        {
            tb_Username.Text = "";
        }

        private void tb_Password_Enter(object sender, EventArgs e)
        {
            tb_Password.Text = "";
        }

        private void tb_Username_Leave(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                tb_Username.Text = "Username";
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (tb_Password.Text == "")
            {
                tb_Password.Text = "Password";
            }
        }
        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Please Enter Your Username And Password.";
            tb_Username.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Connection_Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from User_Details Where Username ='" + tb_Username.Text + "' And Password ='" + tb_Password.Text + "' ", Con);

            int cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                MessageBox.Show(" Login Succesfull !!!", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Global_Vars.Username = "Welcome " + tb_Username.Text;

                if (tb_Username.Text == "Admin")
                {
                    Global_Vars.U_Roll = 1;
                }
                else if (tb_Username.Text == "Employee")
                {
                    Global_Vars.U_Roll = 2;
                }

                Frm_Home_MDI obj = new Frm_Home_MDI();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Details !!! Please enter your Valid Details";
                lbl_Note.ForeColor = Color.Red;

                tb_Username.Clear();
                tb_Password.Clear();

                tb_Username.Focus();
            }
            Connection_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_Password.PasswordChar = '*';
        }
    }
}
