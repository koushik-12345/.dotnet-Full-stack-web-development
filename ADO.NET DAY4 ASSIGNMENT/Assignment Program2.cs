using System.Data.SqlClient;
using System;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient; 

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr = "Server=USHYDKKANAGALA1; Database=Employee; Integrated Security=true";

            SqlConnection conn = new SqlConnection(connStr);
            // conn.ConnectionString = connStr;

            string cmdText = string.Format("INSERT INTO PRODUCTS VALUES({0},'{1}',{2},{3},'{4}')",120,"apple",1800,20,"mobile");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            conn.Open();
            Console.WriteLine("Connected to Database successfully");

            int n = cmd.ExecuteNonQuery();  // For DML:  Insert, update, delete

            Console.WriteLine("No. of rows affected :" + n);
            conn.Close();

            Console.ReadLine();
        }
    }
}