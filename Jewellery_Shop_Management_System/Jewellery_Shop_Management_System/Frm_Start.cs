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
    public partial class Frm_Start : Form
    {
        public Frm_Start()
        {
            InitializeComponent();
        }

        private void btn_Login_Here_Click(object sender, EventArgs e)
        {
            Frm_Login_Form obj = new Frm_Login_Form();
            obj.ShowDialog();
            btn_Login_Here.Visible = false;
            this.Visible = false;
        }

        private void Frm_Start_Load(object sender, EventArgs e)
        {

        }
    }
}
