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
            cmd = new SqlCommand("usp_read_list");
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
                cmd.Parameters.AddWithValue("@User_ID", data.User_ID);
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
            cmd.Parameters.AddWithValue("@User_ID", data.User_ID);
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

        public DataTable InitializeDTContact()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Mobile", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            return dt;
        }

        public DataTable AddToContactsDT(DataTable dtContacts, ContactsController data)
        {
            dtContacts.Rows.Add(
                data.FirstName,
                data.MiddleName,
                data.LastName,
                data.Mobile,
                data.Gender
                );
            return dtContacts;
        }

        public bool BulkSave(ContactsController data)
        {
            cmd = new SqlCommand("usp_BulkSaveContact");
            cmd.Parameters.AddWithValue("@dtContactsForSaving", data.dtContactsForSaving);
            return SQLQueries.SqlExecNQInsert(cmd);
            //you can add prompt here or insinde SQLExecNQInsert
        }

        public bool BulkDelete(ContactsController data)
        {
            cmd = new SqlCommand("usp_BulkDeleteContact");
            cmd.Parameters.AddWithValue("@dtContactsForDelete", data.dtContactsForDelete);
            return SQLQueries.SqlExecNQDelete(cmd);
        }

    }
}
