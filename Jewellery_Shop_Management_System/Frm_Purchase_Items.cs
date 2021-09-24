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
    public partial class Frm_Purchase_Items : Form
    {
        public Frm_Purchase_Items()
        {
            InitializeComponent();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Frm_Bill_Receipt obj = new Frm_Bill_Receipt();
            //obj.MdiParent=this;
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.ControlBox = false;
            obj.Show();
        }

        private void btn_X_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Next_Click_1(object sender, EventArgs e)
        {
            Frm_Bill_Receipt obj = new Frm_Bill_Receipt();
            this.Hide();
            obj.Show();
        }
    }
}
