using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jewellery_Shop_Management_System
{
    public partial class Frm_Login_Form : Form
    {
        public Frm_Login_Form()
        {
            InitializeComponent();
        }

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
            if (tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successfull !!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Home_MDI obj = new Frm_Home_MDI();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Please enter your valid username and password ..";
                //lbl_Note.ForeColor = Color.Red;
                tb_Username.Text = "";
                tb_Password.Text = "";
                tb_Username.Focus();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Frm_Start obj = new Frm_Start();
            obj.Show();
            this.Hide();
        }
    }
}
