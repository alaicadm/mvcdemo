using MVCDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MVCDemo.Utils
{
    /// <summary>
    /// USE THIS CLASS FOR USER DEFINED FUNCTIONS, CALCULATIONS, ETC...
    /// THIS IS A STATIC CLASS NO NEED TO INSTANTIATE 
    /// </summary>
    public static class Utils
    {
        public static bool ToBool(object var)
        {
            return Convert.ToBoolean(var);
        }
        public static int ToInt(object var)
        {
            return Convert.ToInt32(ToDecimal(var));
        }

        public static decimal ToDecimal(object var)
        {
            if (var == null || var.ToString() == "")
                var = 0;
            return Convert.ToDecimal(var);
        }

        /// <summary>
        /// THIS METHOD USES LINQ
        /// 
        /// </summary>
        /// <param name="dt" expects a datatable arguement></param>
        /// <param name="col" column to aggregate></param>
        /// <returns></returns>
        public static int GetDTColumnSumINT(DataTable dt, string col)
        {
            try
            {
                return dt.AsEnumerable().Sum(x => x.Field<int>(col));
               
            }
            catch (Exception err)
            {
                return 0;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        //public static int GetDTColumnSumINT<T>(List<string> list, string col)
        //{
        //    try
        //    {
        //        //return list.Sum(x => col(x));
        //    }
        //    catch (Exception err)
        //    {
        //        return 0;
        //    }
        //}

        // Generates a random number within a range.      
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
