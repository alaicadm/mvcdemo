﻿using MVCDemo.Models;
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

        public ContactsController()
        {
            this.CreatedBy = "Gian";
        }

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
                cmd.Parameters.AddWithValue("@UserId", data.UserId);
                cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", data.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", data.LastName);
                cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                cmd.Parameters.AddWithValue("@Gender", data.Gender);
                MessageBox.Show("Successfully Saved!");
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
                cmd = new SqlCommand("usp_update_list");
                cmd.Parameters.AddWithValue("@UserId", data.UserId);
                cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", data.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", data.LastName);
                cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                cmd.Parameters.AddWithValue("@Gender", data.Gender);
                MessageBox.Show("Successfully Saved!");
                shouldClose = true;
            }
            else
            {
                MessageBox.Show("Check you inputs!");
                shouldClose=false;
            }

            return SQLQueries.SqlExecNQUpdate(cmd);

           
        }

        public bool Delete(ContactsController data)
        {
            cmd = new SqlCommand("usp_DeleteContact");
            cmd.Parameters.AddWithValue("@UserId", data.UserId);
            return SQLQueries.SqlExecNQDelete(cmd);
           
        }

        public bool Check(ContactsController data)
        {
            string[] datalist = { data.FirstName, data.MiddleName, data.LastName, data.PhoneNumber };
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

        public bool closeD { get { return shouldClose; } set { shouldClose = value; } }

        public DataTable InitializeDTContact()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserId", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            return dt;
        }


        public DataTable InitializeDTContactWithID()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserId", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            return dt;
        }


        public DataTable InitializeDTContactWithCheckbox()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserId", typeof(int));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            return dt;
        }

        public DataTable InitializeDTContactUserID()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("UserId", typeof(int));
            return dt;
        }



        public DataTable AddToContactsDT(DataTable dtContacts, ContactsController data)
        {
            dtContacts.Rows.Add(
                data.UserId,
                data.FirstName,
                data.MiddleName,
                data.LastName,
                data.PhoneNumber,
                data.Gender
                );
            return dtContacts;
        }

        public bool BulkSave(ContactsController data)
        {
            cmd = new SqlCommand("usp_BulkSaveContact");
            cmd.Parameters.AddWithValue("@dtContactsForSaving", data.dtContactsForSaving);
            cmd.Parameters.AddWithValue("@CreatedBy", data.CreatedBy);
            return SQLQueries.SqlExecNQInsert(cmd);
        }

        public bool BulkDelete(ContactsController data)
        {
            cmd = new SqlCommand("usp_BulkDeleteContact");
            cmd.Parameters.AddWithValue("@dtContactsForDeleting", data.dtContactsForDeleting);
            //cmd.Parameters.AddWithValue("@VoidedBy", data.CreatedBy);
            return SQLQueries.SqlExecNQDelete(cmd);
        }

        public bool BulkUpdate(ContactsController data)
        {
            cmd = new SqlCommand("usp_BulkUpdateContact");
            cmd.Parameters.AddWithValue("@UserName", Properties.Settings.Default.DBConnUsername);
            cmd.Parameters.AddWithValue("@dtContactsForUpdating", data.dtContactsForUpdating);
            return SQLQueries.SqlExecNQUpdate(cmd);
        }



    }
}
