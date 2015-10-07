using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.DAL
{
    public class PaymentDao : IPaymentDao
    {
        public decimal RetrievePayment(int id)
        {
            var connection = GetConnection();
            decimal payment = 0;

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT Id, Payment FROM Payment;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        payment = reader.GetDecimal(1);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }

            return payment;
        }

        public int SavePayment(decimal payment)
        {
            var connection = GetConnection();
            int id = 0;

            using (connection)
            {
                SqlCommand command = new SqlCommand("Insert into Payment Values(" + payment + ") ;", connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetInt32(0);
                        payment = reader.GetDecimal(1);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }

            return id; 
        }

        private SqlConnection GetConnection()
        {
            var connectionString = "Server=.;Database=VendingMachine;Trusted_Connection=True;";

            return new SqlConnection(connectionString);
        }
    }
}
