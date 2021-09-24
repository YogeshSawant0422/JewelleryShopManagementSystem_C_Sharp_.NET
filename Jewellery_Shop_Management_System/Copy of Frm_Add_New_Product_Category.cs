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
        Global_Functions Gobj = new Global_Functions();

        public Frm_Add_New_Product_Category()
        {
            InitializeComponent();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Add_New_Product_Category_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterParent;
            tb_Category_ID.Focus();
            tb_Category_ID.Text = Gobj.Auto_Incr("Select Count(Category_ID) from Category_Details", "Select Max(Category_ID) from Category_Details", 1).ToString();
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
            if (tb_Category_Name.Text != "")
            {
                Gobj.Data_Insert("insert into Category_Details values(" + tb_Category_ID.Text + ",'" + tb_Category_Name.Text + "')");
                
                MessageBox.Show("Category Added Successfully !!!", "ADD SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Category_Name.Clear();
                tb_Category_ID.Text = Gobj.Auto_Incr("Select Count(Category_ID) from Category_Details", "Select Max(Category_ID) from Category_Details", 1).ToString();
            }
            else
            {
                MessageBox.Show("First Fill Category Name !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Category_Name.Clear();
        }
    }
}

