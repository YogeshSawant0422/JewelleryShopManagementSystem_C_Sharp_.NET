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
    public partial class Frm_Home_MDI : Form
    {
        public Frm_Home_MDI()
        {
            InitializeComponent();
            CustomizeDesign();
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

        private void btn_Purchase_Items_Click(object sender, EventArgs e)
        {
            Frm_Purchase_Items obj = new Frm_Purchase_Items();
            obj.WindowState = FormWindowState.Maximized;
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterParent;
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
    }
}
