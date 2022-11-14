
using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace ConnectingToSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=swapnaVM\mssqlserver02;Initial Catalog=master;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Please Enter customer Id : ");
            int cumId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease Enter customer First Name : ");
            String cumFName = Console.ReadLine();
            Console.WriteLine("\nPlease Enter customer Last Name  : ");
            String cumLname = Console.ReadLine();
            Console.WriteLine("\n please Enter customer City : ");
            String cumCity = Console.ReadLine();
            Console.WriteLine("\nplease Enter customer Country:");
            String cumCountry = Console.ReadLine();
            Console.WriteLine("\nplease Enter customer Phone:");
            String cumPhone = Console.ReadLine();

           
      
            string insertQuery = "insert into customer values('" + cumId + "','" + cumFName + "','" + cumLname + "','"+cumCity+"','"+cumCountry+"','"+cumPhone+"')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
           int rows= insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlConnection.Close();
        }
    }
}

