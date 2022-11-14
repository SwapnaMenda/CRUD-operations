using System;
using System.Data.SqlClient;


namespace delete
{
    class Deletion
    {
        static void Main()
            
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=swapnaVM\mssqlserver02;Initial Catalog=master;Integrated Security=True";
             sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            try
            {
                Console.WriteLine("enter the id value that you want to delete");
                int Id = int.Parse(Console.ReadLine());

                string deletequery = "delete from customer where Id=" + Id;
                SqlCommand deleteCommand = new SqlCommand(deletequery, sqlConnection);

                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("deleted data successfully");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            }
        }
    }
