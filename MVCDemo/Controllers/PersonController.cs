using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MVCDemo.Controllers
{
    public class PersonController : PersonModel
    {
        /// <summary>
        /// ASSUMING RESULT TAKEN FROM DATABASE AND STORED ON A DATATABLE
        /// return Person details
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public PersonController PersonDetails(PersonController data)
        {
            DataTable dt = new DataTable();

            if (dt != null)
            {
                data.FirstName = dt.Rows[0]["FirstName"].ToString();
                data.MiddleName = dt.Rows[0]["MiddleName"].ToString();
                data.LastName = dt.Rows[0]["LastName"].ToString();
                data.Suffix = dt.Rows[0]["Suffix"].ToString();
                data.Age = Convert.ToInt32(dt.Rows[0]["Age"]);
                data.BirthDate = (DateTime)dt.Rows[0]["FirstName"];
            }
            return data;
        }

        public List<PersonController> GeneratePersonList()
        {
            List<PersonController> list = new List<PersonController>
            {
                new PersonController    {FirstName = "Person 1", MiddleName = "Middle 2",Age = 15 },
                new PersonController    {FirstName = "Person 2", MiddleName = "Middle 3",Age = 33 },
                new PersonController    {FirstName = "Person 3", MiddleName = "Middle 4",Age = 40 }
            };

            return list;
        }

        public DataTable GeneratePersonDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            for (int i = 1; i < 4; i++)
            {
                dt.Rows.Add("Person " + i, "Middle " + i, Utils.Utils.RandomNumber(i, 85));
            }

            return dt;
        }

    }
}
