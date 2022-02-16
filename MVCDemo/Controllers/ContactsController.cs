using MVCDemo.Models;
using MVCDemo.Views.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;

namespace MVCDemo.Controllers
{
    public class ContactsController:ContactsModel
    {
        static SqlCommand cmd = new SqlCommand();

        public DataTable GetContacts(string keyword)
        {
            keyword = string.IsNullOrWhiteSpace(keyword) == false ? keyword : "";
            cmd = new SqlCommand("usp_SearchContacts");
            cmd.Parameters.AddWithValue("@Keyword",keyword);
            DataTable dt = SQLQueries.SqlExecReaderWithParams(cmd);
            return dt;
        }
        public bool Save(ContactsController data)
        {
            bool complete = Check(data);
            if (complete == true)
            {
                cmd = new SqlCommand("usp_SaveContact");
                cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", data.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", data.LastName);
                cmd.Parameters.AddWithValue("@Mobile", data.Mobile);
                cmd.Parameters.AddWithValue("@Gender", data.Gender);
                MessageBox.Show("Successfully Saved!!!!!!!!");
                shouldClose = true;
            }
            else
            {
                MessageBox.Show("Check you inputs!");
                shouldClose = false;
            }

            return SQLQueries.SqlExecNQInsert(cmd);
            //you can add prompt here or insinde SQLExecNQInsert
        }

        public bool Edit(ContactsController data)
        {
            bool complete = Check(data);
            if (complete == true)
            {
                cmd = new SqlCommand("usp_EditContact");
                cmd.Parameters.AddWithValue("@UserId", data.UserId);
                cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", data.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", data.LastName);
                cmd.Parameters.AddWithValue("@Mobile", data.Mobile);
                cmd.Parameters.AddWithValue("@Gender", data.Gender);
                MessageBox.Show("Successfully Saved!!!!!!");
                shouldClose = true;
            }
            else
            {
                MessageBox.Show("Check you inputs!");
                shouldClose=false;
            }

            return SQLQueries.SqlExecNQUpdate(cmd);

            //you can add prompt here or insinde SqlExecNQUpdate
        }

        public bool Delete(ContactsController data)
        {
            cmd = new SqlCommand("usp_DeleteContact");
            cmd.Parameters.AddWithValue("@UserId", data.UserId);
            return SQLQueries.SqlExecNQDelete(cmd);
            //you can add prompt here or insinde SqlExecNQDelete
        }

        public bool Check(ContactsController data)
        {
            string[] datalist = { data.FirstName, data.MiddleName, data.LastName, data.Mobile };
            bool res = true;
            
            foreach (string d in datalist)
            {
                if (String.IsNullOrEmpty(d))
                {
                    res = false;
                }
                
            }
            return res;
        }

        private bool shouldClose;

        //for the dialogbox
        public bool closeD { get { return shouldClose; } set { shouldClose = value; } }
       
    }
}
