using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Jewellery_Shop_Management_System.Windows_Form;

namespace Jewellery_Shop_Management_System
{
    public partial class Frm_Home_MDI : Form
    {
        public Frm_Home_MDI()
        {
            InitializeComponent();
            CustomizeDesign();
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

        private void CustomizeDesign()
        {
            pnl_Customer_Sub_Panel.Visible = false;
            pnl_Product_Sub_Panel.Visible = false;
            pnl_Order_Sub_Panel.Visible = false;
            pnl_Stock_Sub_Panel.Visible = false;
            pnl_Distributor_Sub_Panel.Visible = false;
            pnl_Employee_Sub_Panel.Visible = false;
            pnl_User_Sub_Panel.Visible = false;
            pnl_Report_Sub_Panel.Visible = false;
        }

        private void HideSubmenu()
        {
            if (pnl_Customer_Sub_Panel.Visible == true)
            {
                pnl_Customer_Sub_Panel.Visible = false;
               /* pnl_Product_Sub_Panel.Visible = false;
                pnl_Order_Sub_Panel.Visible = false;
                pnl_Stock_Sub_Panel.Visible = false;
                pnl_Distributor_Sub_Panel.Visible = false;
                pnl_Employee_Sub_Panel.Visible = false;
                pnl_User_Sub_Panel.Visible = false;
                pnl_Report_Sub_Panel.Visible = false;*/
            }
            if (pnl_Product_Sub_Panel.Visible == true)
            {
                pnl_Product_Sub_Panel.Visible = false;
                /*pnl_Customer_Sub_Panel.Visible = false;
                pnl_Order_Sub_Panel.Visible = false;
                pnl_Stock_Sub_Panel.Visible = false;
                pnl_Distributor_Sub_Panel.Visible = false;
                pnl_Employee_Sub_Panel.Visible = false;
                pnl_User_Sub_Panel.Visible = false;
                pnl_Report_Sub_Panel.Visible = false;*/
            }
            if (pnl_Order_Sub_Panel.Visible == true)
            {
                pnl_Order_Sub_Panel.Visible = false;
            }
            if(pnl_Stock_Sub_Panel.Visible == true)
            {
                pnl_Stock_Sub_Panel.Visible = false;
            }
            if(pnl_Distributor_Sub_Panel.Visible == true)
            {
                pnl_Distributor_Sub_Panel.Visible = false;
            }
            if(pnl_Employee_Sub_Panel.Visible == true)
            {
                pnl_Employee_Sub_Panel.Visible = false;
            }
            if(pnl_User_Sub_Panel.Visible == true)
            {
                pnl_User_Sub_Panel.Visible = false;
            }
            if (pnl_Report_Sub_Panel.Visible == true)
            {
                pnl_Report_Sub_Panel.Visible = false;
            }
        }
        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Customer_Sub_Panel);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Product_Sub_Panel);
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Order_Sub_Panel);
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Stock_Sub_Panel);
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Distributor_Sub_Panel);
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Employee_Sub_Panel);
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_User_Sub_Panel);
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnl_Report_Sub_Panel);
        }

        private void btn_Add_New_Customer_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Customer obj = new Frm_Add_New_Customer();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
            pnl_Customer_Sub_Panel.Hide();
        }

        private void btn_New_Category_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Product_Category obj = new Frm_Add_New_Product_Category();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Product_Sub_Panel.Hide();
        }

        private void btn_Sub_Category_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Product_Sub_Category obj = new Frm_Add_New_Product_Sub_Category();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Product_Sub_Panel.Hide();
        }

        private void btn_Manage_Product_Click(object sender, EventArgs e)
        {
            Frm_Product_Details obj = new Frm_Product_Details();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Product_Sub_Panel.Hide();
        }

        private void btn_Manage_Customer_Click(object sender, EventArgs e)
        {
            Frm_Manage_Customer obj = new Frm_Manage_Customer();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Customer_Sub_Panel.Hide();
        }

        private void btn_Accept_Order_Click(object sender, EventArgs e)
        {
            Frm_Accept_Order obj = new Frm_Accept_Order();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Order_Sub_Panel.Hide();
        }

        private void btn_Manage_Order_Click(object sender, EventArgs e)
        {
            Frm_Manage_Order obj = new Frm_Manage_Order();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Product_Sub_Panel.Hide();
        }

        private void btn_Add_Stock_Click(object sender, EventArgs e)
        {
            Frm_Add_Stock obj = new Frm_Add_Stock();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Stock_Sub_Panel.Hide();
        }

        private void btn_Add_New_Distributor_Click(object sender, EventArgs e)
        { 
            Frm_Add_Distributor obj = new Frm_Add_Distributor();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Distributor_Sub_Panel.Hide();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            Frm_Add_Employee obj = new Frm_Add_Employee();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
            pnl_Employee_Sub_Panel.Hide();
        }

        private void btn_Update_Price_Click(object sender, EventArgs e)
        {
            Frm_Product_Rates obj = new Frm_Product_Rates();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show(); 
        }

        private void Frm_Home_MDI_Load(object sender, EventArgs e)
        {
            Connection_Open();

            SqlCommand Cmd1 = new SqlCommand("Select Sales_Rate from Product_Rate_Details where ID = 5002", Con);
            tb_Gold_Price.Text = Convert.ToString(Cmd1.ExecuteScalar());

            Cmd1.Dispose();

            SqlCommand Cmd2 = new SqlCommand("Select Sales_Rate from Product_Rate_Details where ID = 5004", Con);
            tb_Silver_Price.Text = Convert.ToString(Cmd2.ExecuteScalar());
                
            Connection_Close();

            lbl_Welcome.Text = Global_Vars.Username;
          
            if (Global_Vars.U_Roll == 2)
            {
                btn_Product.Visible = false;
                btn_Manage_Order.Visible = false;
                btn_Add_Stock.Visible = false;
                btn_Distributor.Visible = false;
                btn_Employee.Visible = false;
                btn_Report.Visible = false;
            }
        }

        private void btn_View_Stock_Click(object sender, EventArgs e)
        {
            Frm_View_All_Stock obj = new Frm_View_All_Stock();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void btn_Manage_Employee_Click(object sender, EventArgs e)
        {
            Frm_Manage_Employee obj = new Frm_Manage_Employee();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }

        private void btn_Manage_Distributor_Click(object sender, EventArgs e)
        {
            Frm_Manage_Distributor obj = new Frm_Manage_Distributor();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.Show();
        }
        private void btn_X_Click(object sender, EventArgs e)
        {

            if (Global_Vars.U_Roll == 2)
            {
                btn_Product.Visible = true;
                btn_Manage_Order.Visible = true;
                btn_Add_Stock.Visible = true;
                btn_Distributor.Visible = true;
                btn_Employee.Visible = true;
                btn_Report.Visible = true;
            }
            Frm_Login_Form obj = new Frm_Login_Form();
            obj.Show();
            this.Hide();           
        }

        private void btn_Single_Product_Report_Click(object sender, EventArgs e)
        {
            Frm_Single_Product_Report obj = new Frm_Single_Product_Report();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void btn_Distributor_Report_Click(object sender, EventArgs e)
        {
            Frm_Single_Distributor_Report obj = new Frm_Single_Distributor_Report();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void btn_Single_Employee_Report_Click(object sender, EventArgs e)
        {
            Frm_Single_Employee_Report obj = new Frm_Single_Employee_Report();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void Stock_Report_Click(object sender, EventArgs e)
        {
            Frm_Stock_Report obj = new Frm_Stock_Report();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Refresh this window ";
            string title = "WARNING";
            MessageBoxIcon Warning = MessageBoxIcon.Warning;
            MessageBoxButtons Buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, Buttons, Warning);

            if (result == DialogResult.Yes)
            {
                Frm_Home_MDI obj = new Frm_Home_MDI();
                obj.Show();
                this.Hide();
            }
            else
            {

            }   
        }

        private void btn_Customer_Added_Report_Click(object sender, EventArgs e)
        {
            Frm_Datewise_Customer_Report obj = new Frm_Datewise_Customer_Report();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
