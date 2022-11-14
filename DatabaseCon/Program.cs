using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseCon
{
    internal class Program
    {
        static void Main(String[] args)
        {
            using (SqlConnection conn = new SqlConnection("data source = NDI-LAP-122; initial catalog = Office ; integrated security = true "))
            {
                // Insert the data in the table 

                /*Console.WriteLine("Enter employee id :");
                int _id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the employee name :");
                string _name = Console.ReadLine();

                Console.WriteLine("Enter the employee age :");
                int _age = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                cmd.CommandText = "insert into Employee(e_id , e_name , age) values (@e_id , @e_name , @age)";
                cmd.Parameters.AddWithValue("@e_id", _id);
                cmd.Parameters.AddWithValue("@e_name", _name);
                cmd.Parameters.AddWithValue("@age", _age);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    Console.WriteLine("Data inserted successfully");
                }
                else
                {
                    Console.WriteLine("Query Failed");
                }*/


                // Update the data in the table 

                /*Console.WriteLine("Enter employee id :");
                int _id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the new employee name :");
                string _name = Console.ReadLine();

                Console.WriteLine("Enter the new employee age :");
                int _age = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                cmd.CommandText = "update employee set e_name = @e_name , age = @age where e_id = @e_id ";
                cmd.Parameters.AddWithValue("@e_id", _id);
                cmd.Parameters.AddWithValue("@e_name", _name);
                cmd.Parameters.AddWithValue("@age", _age);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    Console.WriteLine($"{rows} Row(s) updated successfully");
                }
                else
                {
                    Console.WriteLine("Query Failed");
                }*/


                // Delete the date from the table 

                Console.WriteLine("Enter employee id :");
                int _id = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                cmd.CommandText = "delete from employee where e_id = @e_id ";
                cmd.Parameters.AddWithValue("@e_id", _id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    Console.WriteLine($"{rows} Row(s) deleted successfully");
                }
                else
                {
                    Console.WriteLine("Query Failed / Invalid E_id");
                }


                // select the data from the table 


                /*SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                cmd.CommandText = "select * from employee ";


                // connected approach
                *//*conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]}");
                }

                conn.Close();*//*

                //diconnected approach

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Console.WriteLine($"{dr[0]} {dr[1]} {dr[2]}");
                    }
                }*/
            }

            // depatment  - d_id , d_name 

            // salary - id , e_id , salary, bonus

            // employee deaprtment - id ,  e_id , d_id 

            // get the nth highest salary of the employee
        }
    }
}
