using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace MVCDemo.Controllers
{
    public class SQLQueries
    {
        public static DataTable SqlExecReaderWithParams(SqlCommand sqlCmd)
        {
            try
            {
                DataTable dtResult = new DataTable();
                sqlCmd.CommandType = CommandType.StoredProcedure;

                using (SqlConnection sqlConn = new SqlConnection((new DBConnectionController().sqlStringBuilder.ConnectionString)))
                {
                    sqlCmd.Connection = sqlConn;
                    sqlConn.Open();
                    using (sqlCmd)
                    {
                        try
                        {
                            dtResult.Load(sqlCmd.ExecuteReader());
                            return dtResult;
                        }

                        catch (Exception ex)
                        {
                            dtResult = new DataTable();                       
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                    sqlConn.Close();
                }

                return dtResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to conenct to the network, Please try again or Contact Administrator.{ 0} " + ex.Message.ToString(), "Network Issue");
                DataTable dt = new DataTable();
                dt.Columns.Add("Error");
                return dt;
            }
        }

        public static bool SqlExecNQInsert(SqlCommand sqlcmd)
        {
            try
            {
                SqlCommand cmd = sqlcmd;
                bool result = false;
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlConnection sqlConn = new SqlConnection((new DBConnectionController().sqlStringBuilder.ConnectionString)))
                {
                    cmd.Connection = sqlConn;
                    sqlConn.Open();

                    try
                    {
                        result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                        //Globals.SQLSuccessMessage = "Success!";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    sqlConn.Close();
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to the network, Please try again or Contact Administrator.{ 0} " + ex.Message.ToString(), "Network Issue");
                return false;
            }

        }



        public static bool SqlExecNQUpdate(SqlCommand sqlcmd)
        {
            try
            {
                SqlCommand cmd = sqlcmd;
                bool result = false;
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlConnection sqlConn = new SqlConnection((new DBConnectionController().sqlStringBuilder.ConnectionString)))
                {
                    cmd.Connection = sqlConn;
                    sqlConn.Open();

                    try
                    {
                        result = Utils.Utils.ToBool(cmd.ExecuteNonQuery());
                       
                    }

                    catch (Exception ex)
                    {
                       
                        MessageBox.Show(ex.Message.ToString());
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to conenct to the network, Please try again or Contact Administrator.{ 0} " + ex.Message.ToString(), "Network Issue");
                return false;
            }
        }

        public static bool SqlExecNQDelete(SqlCommand sqlcmd)
        {
            try
            {
                SqlCommand cmd = sqlcmd;
                bool result = false;
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlConnection sqlConn = new SqlConnection((new DBConnectionController().sqlStringBuilder.ConnectionString)))
                {
                    cmd.Connection = sqlConn;
                    sqlConn.Open();

                    try
                    {
                        result = Convert.ToBoolean(cmd.ExecuteNonQuery());
                        //Globals.SQLSuccessMessage = "Success!";
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    sqlConn.Close();
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to conenct to the network, Please try again or Contact Administrator.{ 0} " + ex.Message.ToString(), "Network Issue");
                return false;
            }

        }
    }
}
