using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Al_Aman_Bakery_System.DAL
{
   
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        public string Erorr="";
        public DataAccessLayer()
        {

            SET_ONLINE();
            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL")
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ",1433; Database=" +
                                                  Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" +
                                                  Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password + "");

            
            }
            else
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ",1433; Database=" + Properties.Settings.Default.Database + "; Integrated Security=true");

               // //المششكلة يرى الداتا لكن المشكلة في صلاحيات المستخدم
                // تم الحل
                //sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; AttachDbFilename = " + Properties.Settings.Default.Database + "; Integrated Security = True;User Instance=True");

            }
        }
        //اتصال "Attach"

        //try
        //               {
        //                   String ConnectionString = @"Data Source=DESKTOP-EAM5195\SQLEXPTHINKER,1433;AttachDbFilename=|DataDirectory|\img\StoreManagementProject_DB.mdf;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;User Instance=True";
        //       sqlconnection = new SqlConnection(ConnectionString);
        //       sqlconnection.Open();
        //                   MessageBox.Show("Connection is opened.!!");
        //                   sqlconnection.Close();
        //               }
        //               catch (Exception ex)
        //               {
        //                   MessageBox.Show(ex.Message);
        //               }
        public void SET_ONLINE()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=master; Integrated Security=True");
                SqlCommand cmd2;
                string strQuery = "ALTER Database " + Properties.Settings.Default.Database + " SET ONLINE  WITH ROLLBACK IMMEDIATE ";
                cmd2 = new SqlCommand(strQuery, con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd2.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                //for (int i = 0; i < 3000; i++)
                //{

                //}
            }
            catch 
            {

            }
        }
        public bool test_Open()
        {
            try
            {
                StreamWriter test_open = new StreamWriter("test_open.txt");
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //Method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Method To Read Data From Database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                Erorr = "";
            }
            catch (Exception ex)
            {

                  MessageBox.Show(ex.Message + "","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
                //Erorr = "يوجد مشكلة في الاتصال بقاعدة البيانات /n اتصل بمسؤل الشبكة";

            }
            return dt;
        }
        //public string Erorr;
        // 
        public DataTable SelectData(string stored_procedure )
        {
            SqlDataAdapter da = new SqlDataAdapter(stored_procedure, sqlconnection);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        //Method to Insert, Update, and Delete Data From Database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 
