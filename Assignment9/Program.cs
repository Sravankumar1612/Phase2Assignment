using System;
using System.Data;
using System.Data.SqlClient;

namespace Assignment9
{
    internal class Program
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static string conStr = "server = DESKTOP-C057B7R; database = OrderDB; trusted_connection = true;";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(conStr);
                con.Open();

                cmd = new SqlCommand()
                {
                    CommandText = "PlaceOrder",
                    CommandType = CommandType.StoredProcedure,
                    Connection = con
                };

                Console.Write("Enter Customer ID : ");
                cmd.Parameters.AddWithValue("@customerId", int.Parse(Console.ReadLine()));
                Console.Write("Enter Total Amount : ");
                cmd.Parameters.AddWithValue("@totalAmount", double.Parse(Console.ReadLine()));

                int output = (int)cmd.ExecuteScalar();

                if (output >= 1)
                {
                    Console.WriteLine("Order Placed Successfully!");
                }
                else
                {
                    Console.WriteLine("Order Placing Failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}