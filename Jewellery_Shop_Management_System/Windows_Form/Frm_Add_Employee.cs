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
    public partial class Frm_Add_Employee : Form
    {
        public Frm_Add_Employee()
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

        private void tb_Mobile_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Account_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Adhar_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Qualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Experience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (Char)Keys.Back) || (e.KeyChar == (Char)Keys.Space) || e.KeyChar == '.'))
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

        private void tb_Salary_KeyPress(object sender, KeyPressEventArgs e)
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

            SqlCommand Cmd = new SqlCommand("Select Count(Employee_ID) from Employee_Details", Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select MAX(Employee_ID) from Employee_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = 11001;
            }

            Connection_Close();
            return cnt;
        }

        #endregion Auto_Incr()

        void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_Mobile_Number.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            tb_Account_Number.Text = "";
            tb_Adhar_Number.Text = "";
            tb_Salary.Text = "";
            tb_Address.Clear();
            tb_Experience.Clear();
            tb_Qualification.Text = "";
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Add_Employee_Load(object sender, EventArgs e)
        {
            tb_Employee_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender = "";
            string Status = "Working";
            string Leave = "Still Working";
            if (rb_Male.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            Connection_Open();

            try
            {
                if (tb_Name.Text != "" && tb_Mobile_Number.Text != "" && tb_Account_Number.Text != "" && tb_Adhar_Number.Text != ""  && tb_Qualification.Text != "" && tb_Salary.Text != "" && tb_Address.Text != "" && tb_Experience.Text != "")
                {

                    SqlCommand Cmd = new SqlCommand("insert into Employee_Details (Employee_ID,Join_Date,Name,Mobile_No,DOB,Gender,Account_No,Adhar_No,Qualification,Experiance,Address,Salary,Status,Leave_Date)values(@Employee_ID,@Join_Date,@Name,@Mobile_No,@DOB,@Gender,@Account_No,@Adhar_No,@Qualification,@Experiance,@Address,@Salary,@Status,@Leave_Date)", Con);

                    Cmd.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                    Cmd.Parameters.Add("@Join_Date", SqlDbType.Date).Value = dtp_Date.Text;
                    Cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                    Cmd.Parameters.Add("@Mobile_No", SqlDbType.Decimal).Value = tb_Mobile_Number.Text;
                    Cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                    Cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = Gender;
                    Cmd.Parameters.Add("@Account_No", SqlDbType.Decimal).Value = tb_Account_Number.Text;
                    Cmd.Parameters.Add("@Adhar_No", SqlDbType.Decimal).Value = tb_Adhar_Number.Text;
                    Cmd.Parameters.Add("@Qualification", SqlDbType.NVarChar).Value = tb_Qualification.Text;
                    Cmd.Parameters.Add("@Experiance", SqlDbType.NVarChar).Value = tb_Experience.Text;                   
                    Cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                    Cmd.Parameters.Add("@Salary", SqlDbType.Money).Value = tb_Salary.Text;
                    Cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
                    Cmd.Parameters.Add("@Leave_Date", SqlDbType.NVarChar).Value = Leave;
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Save Succefully !!!");

                    tb_Employee_ID.Text = Convert.ToString(Auto_Incr());

                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("First Fill All Records !!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check Further And Fill Details Correctly !!!!");
            }

            Connection_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        
    }
}