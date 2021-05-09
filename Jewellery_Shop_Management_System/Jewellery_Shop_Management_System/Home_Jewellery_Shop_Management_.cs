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
    public partial class Home_Jewellery_Shop_Management_ : Form
    {
       // private panel panelSub_Panel;
       // private panel Sub_Panel;
        public Home_Jewellery_Shop_Management_()
        {
            InitializeComponent();
            Customize_Sub_Panels();
        }

          private void  Customize_Sub_Panels()
        {
            pnl_Customer_Sub_Panel.Visible = false;
            pnl_Product_Sub_Panel.Visible = false;
            pnl_Order_Sub_Panel.Visible = false;
            pnl_Stock_Sub_Panel.Visible = false;
        }

          private void Hide_Sub_Panels()
          {
              if(pnl_Customer_Sub_Panel.Visible == true)
              {
                  pnl_Product_Sub_Panel.Visible = false;
                  pnl_Order_Sub_Panel.Visible = false;
                  pnl_Stock_Sub_Panel.Visible = false;
              }
              if (pnl_Product_Sub_Panel.Visible == true)
              {
                  pnl_Customer_Sub_Panel.Visible = false;
                  pnl_Order_Sub_Panel.Visible = false;
                  pnl_Stock_Sub_Panel.Visible = false;
              }
              if (pnl_Order_Sub_Panel.Visible == true)
              {
                  pnl_Product_Sub_Panel.Visible = false;
                  pnl_Stock_Sub_Panel.Visible = false;
                  pnl_Customer_Sub_Panel.Visible = false;
              }
              if (pnl_Stock_Sub_Panel.Visible == true)
              {
                  pnl_Product_Sub_Panel.Visible = false;
                  pnl_Customer_Sub_Panel.Visible = false;
                  pnl_Order_Sub_Panel.Visible = false;
              }
          }

          private void Show_Panel_Sub_Panel(Panel panel_Sub_Panel)
          {
              if (panel_Sub_Panel.Visible == false)
              {
                  Hide_Sub_Panels();
                  panel_Sub_Panel.Visible = true;
              }
              else
              {
                  panel_Sub_Panel.Visible = false;
              }
          }
        /*
          private void Show_Panel_Product_Sub_Panel(panel Show_Product_Panel_)
          {
              if (panel_Product_Sub_Panel.Visible == false)
              {
                  Hide_Sub_Panels();
                  panel_Product_Sub_Panel.Visible = true;
              }
              else
              {
                  panel_Product_Sub_Panel.Visible = false;
              }
          }*/
        private void btn_Add_New_Customer_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Customer obj = new Frm_Add_New_Customer();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.ControlBox = false;
            obj.Show();

            Hide_Sub_Panels();
        }
        private void btn_Purchase_Items_Click(object sender, EventArgs e)
        {
            Frm_Purchase_Items obj = new Frm_Purchase_Items();
            obj.MdiParent = this;
           // obj.WindowState = FormWindowState.Maximized;
            obj.ControlBox = false;
            obj.Show();

            Hide_Sub_Panels();
        }

        private void btn_Customer_Details_Click(object sender, EventArgs e)
        {
           
            Show_Panel_Sub_Panel(pnl_Customer_Sub_Panel);
            pnl_Product_Sub_Panel.Visible = false;
            pnl_Order_Sub_Panel.Visible = false;
            pnl_Stock_Sub_Panel.Visible = false;
        }

        private void btn_Add_New_Category_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Product_Category obj = new Frm_Add_New_Product_Category();
            obj.MdiParent = this;
            //obj.StartPosition = FormStartPosition.CenterParent;
            obj.ControlBox = false;
            obj.Show();
        }

        private void btn_Add_New_Sub_Category_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Product_Sub_Category obj = new Frm_Add_New_Product_Sub_Category();
            obj.MdiParent = this;
            //obj.StartPosition = FormStartPosition.CenterParent;
            obj.ControlBox = false;
            obj.Show();
        }

        private void btn_Product_Details_Click(object sender, EventArgs e)
        {
            Show_Panel_Sub_Panel(pnl_Product_Sub_Panel);
            pnl_Customer_Sub_Panel.Visible = false;
            pnl_Order_Sub_Panel.Visible = false;
            pnl_Stock_Sub_Panel.Visible = false;
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Frm_Product_Details obj = new Frm_Product_Details();
            obj.MdiParent = this;
           // obj.StartPosition = FormStartPosition.CenterParent;
            obj.ControlBox = false;
            obj.Show();
        }

        private void btn_Search_Customer_Click(object sender, EventArgs e)
        {
            btn_View_All_Customer.Visible = true;
            btn_Search_Single_Customer.Visible = true;
        }

        private void btn_Search_Single_Customer_Click(object sender, EventArgs e)
        {
            Frm_Search_Customer obj = new Frm_Search_Customer();
            obj.MdiParent = this;
           // obj.StartPosition = FormStartPosition.CenterParent;
            obj.ControlBox = false;
            obj.Show();
        }

        private void btn_Order_Details_Click(object sender, EventArgs e)
        {
            Show_Panel_Sub_Panel(pnl_Order_Sub_Panel);
            pnl_Customer_Sub_Panel.Visible = false;
            pnl_Product_Sub_Panel.Visible = false;
            pnl_Stock_Sub_Panel.Visible = false;
        }

        private void btn_Stock_Details_Click(object sender, EventArgs e)
        {
            Show_Panel_Sub_Panel(pnl_Stock_Sub_Panel);
            pnl_Customer_Sub_Panel.Visible = false;
            pnl_Order_Sub_Panel.Visible = false;
            pnl_Product_Sub_Panel.Visible = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_View_All_Customer_Click(object sender, EventArgs e)
        {
            Frm_View_All_Customer obj = new Frm_View_All_Customer();
            obj.MdiParent = this;
           // obj.StartPosition = FormStartPosition.CenterParent;
            obj.ControlBox = false;
            obj.Show();
        }

        private void Dashboard_Jewellery_Shop_Management__Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Image_Click(object sender, EventArgs e)
        {

        }
    }
}
