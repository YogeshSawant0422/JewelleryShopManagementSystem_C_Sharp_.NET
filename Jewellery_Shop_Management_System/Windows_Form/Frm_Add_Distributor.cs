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
    public partial class Frm_Add_Distributor : Form
    {
        public Frm_Add_Distributor()
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

        #region KeyPress

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '-') || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Adhar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
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

        private void tb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Shop_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Reg_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mob_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Auto_Incr() Function

        int Auto_Incr()
        {
            int cnt = 0;
            Connection_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Distributor_ID) from Distributor_Details", Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select MAX(Distributor_ID) from Distributor_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = 12001;
            }

            Connection_Close();
            return cnt;
        }

        #endregion Auto_Incr()

        void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_PAN_No.Clear();
            tb_Mob_No.Text = "";
            tb_Adhar_No.Text = "";
            tb_Reg_No.Text = "";
            tb_Address.Clear();
            tb_Shop_Name.Text = "";
        }


        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();
            if (tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_Date.Text != "" && tb_Adhar_No.Text != "" && tb_PAN_No.Text != "" && tb_Address.Text != "" && tb_Shop_Name.Text != "" && tb_Reg_No.Text != "" )
            {

                SqlCommand Cmd = new SqlCommand("insert into Distributor_Details (Distributor_ID,Date,Name,Mobile_No,Adhar_No,PAN_No,Address,Shop_Name,Reg_No)values(@Distributor_ID,@Date,@Name,@Mobile_No,@Adhar_No,@PAN_No,@Address,@Shop_Name,@Reg_No)", Con);

                Cmd.Parameters.Add("@Distributor_ID", SqlDbType.Int).Value = tb_Distributor_ID.Text;
                Cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("@Mobile_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("@Adhar_No", SqlDbType.Decimal).Value = tb_Adhar_No.Text;
                Cmd.Parameters.Add("@PAN_No", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("@Shop_Name", SqlDbType.NVarChar).Value = tb_Shop_Name.Text;
                Cmd.Parameters.Add("@Reg_No", SqlDbType.NVarChar).Value = tb_Reg_No.Text;


                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Succefully !!!");

                tb_Distributor_ID.Text = Convert.ToString((Auto_Incr()));

                Clear_Controls();
            }
            else
            {
                MessageBox.Show(" Please Fill All The Records !!!");
            }
            Connection_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Frm_Add_Distributor_Load(object sender, EventArgs e)
        {
            tb_Distributor_ID.Text = Convert.ToString((Auto_Incr()));
        }
    }
}
