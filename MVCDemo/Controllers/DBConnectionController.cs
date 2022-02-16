using MVCDemo.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MVCDemo.Controllers
{
    public class DBConnectionController : IDisposable
    {
        public SqlConnectionStringBuilder sqlStringBuilder = new SqlConnectionStringBuilder();
        private string sqlConnStr;

        private string server;
        private string username;
        private string password;
        private string database;
        private bool integratedsecurity;
        private bool encrypt;
        private bool trustservercertificate;
        public string Server { get { return this.server; } set { this.server = value; sqlStringBuilder["Server"] = this.server; sqlConnStr = sqlStringBuilder.ConnectionString; } }
        public string UserName { get { return this.username; } set { this.username = value; sqlStringBuilder["User ID"] = this.username; sqlConnStr = sqlStringBuilder.ConnectionString; } }
        public string PassWord { get { return this.password; } set { this.password = value; sqlStringBuilder["Password"] = this.password; sqlConnStr = sqlStringBuilder.ConnectionString; } }
        public string DataBase { get { return this.database; } set { this.database = value; sqlStringBuilder["Database"] = this.database; sqlConnStr = sqlStringBuilder.ConnectionString; } }

        public bool Integratedsecurity { get { return this.integratedsecurity; } set { this.integratedsecurity = value; sqlStringBuilder["integrated security"] = this.integratedsecurity; sqlConnStr = sqlStringBuilder.ConnectionString; } }
        public bool Encrypt { get { return this.encrypt; } set { this.encrypt = value; sqlStringBuilder["encrypt"] = this.encrypt; sqlConnStr = sqlStringBuilder.ConnectionString; } }
        public bool Trustservercertificate { get { return this.trustservercertificate; } set { this.trustservercertificate = value; sqlStringBuilder["trustServerCertificate"] = this.trustservercertificate; sqlConnStr = sqlStringBuilder.ConnectionString; } }

        public bool ConnectToDB(DBConnectionController data)
        {
            bool connectionResult = IsConnectedToServer();

            if (!connectionResult)
            {
                //this.Dispatcher.Invoke(() => {
                //    dialogHost.IsOpen = true;
                //    biBar.IsBusy = false;
                //});
            }
            else
            {

                Properties.Settings.Default.DBConnServer = data.Server;
                Properties.Settings.Default.DBConnUsername = data.UserName;
                Properties.Settings.Default.DBConnPassword = data.PassWord;
                Properties.Settings.Default.DBConnDatabase = data.DataBase;

                Properties.Settings.Default.DBIntegratedSecurity = data.Integratedsecurity;
                Properties.Settings.Default.DBEncrypt = data.Encrypt;
                Properties.Settings.Default.DBTrustServerCertificate = data.Trustservercertificate;
                Properties.Settings.Default.Save();
            }
            return connectionResult;
        }
       
        public DBConnectionController()
        {
            sqlStringBuilder.Clear();

            Server = string.IsNullOrWhiteSpace(Server) ? Properties.Settings.Default.DBConnServer.ToString() : Server;
            UserName = string.IsNullOrWhiteSpace(UserName) ? Properties.Settings.Default.DBConnUsername.ToString() : UserName;
            PassWord = string.IsNullOrWhiteSpace(PassWord) ? Properties.Settings.Default.DBConnPassword.ToString() : PassWord;
            DataBase = string.IsNullOrWhiteSpace(DataBase) ? Properties.Settings.Default.DBConnDatabase.ToString() : DataBase;

            Integratedsecurity = Properties.Settings.Default.DBIntegratedSecurity;
            Encrypt = Properties.Settings.Default.DBEncrypt;
            Trustservercertificate = Properties.Settings.Default.DBTrustServerCertificate;


        }
        public bool IsConnectedToServer()
        {
            using (SqlConnection connection = new SqlConnection(this.sqlStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();

                    Properties.Settings.Default.DBConnServer = sqlStringBuilder["Server"].ToString();
                    Properties.Settings.Default.DBConnUsername = sqlStringBuilder["User ID"].ToString();
                    Properties.Settings.Default.DBConnPassword = sqlStringBuilder["Password"].ToString();
                    Properties.Settings.Default.DBConnDatabase = sqlStringBuilder["Database"].ToString();
                    Properties.Settings.Default.DBIntegratedSecurity = Convert.ToBoolean(sqlStringBuilder["integrated security"]);
                    Properties.Settings.Default.DBEncrypt = Convert.ToBoolean(sqlStringBuilder["encrypt"]);
                    Properties.Settings.Default.DBTrustServerCertificate = Convert.ToBoolean(sqlStringBuilder["trustServerCertificate"]);
                    Properties.Settings.Default.Save();

                    Globals.ServerName = sqlStringBuilder["Server"].ToString();

                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
