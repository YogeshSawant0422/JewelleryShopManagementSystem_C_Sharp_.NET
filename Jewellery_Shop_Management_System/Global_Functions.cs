using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Jewellery_Shop_Management_System
{ 
    class Global_Functions
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Jewellery_Shop_Management_System_DB;Integrated Security=True");

        public void Connection_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        public void Connection_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        #region Auto_Increment
        public int Auto_Incr(string Str1 , String Str2 ,int ID)
        {
            int cnt = 0;
            Connection_Open();

            SqlCommand Cmd = new SqlCommand(Str1, Con);

            cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = Str2;

                cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                cnt = cnt + 1;
            }
            else
            {
                cnt = ID;
            }

            Connection_Close();
            return cnt;
        }
        #endregion Auto_Increment();

        #region Data_Insert_Query
        public void Data_Insert(string Str1)
        {
            Connection_Open();

            SqlCommand cmd = new SqlCommand(Str1,Con);
            cmd.ExecuteNonQuery();

            Connection_Close();
        }
        #endregion Data_Insert_Query

        public void Retrive_Data(String Str1)
        {
            Connection_Open();

            SqlCommand cmd = new SqlCommand(Str1,Con);
            var obj = cmd.ExecuteReader();
 
            while(obj.Read())
            {
                
            }
            Connection_Close();
        }
    }
}
