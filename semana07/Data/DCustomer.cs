using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    // LA CAPA DATA ES PARA MANEJAR EL ACCESO A LA BD 
    public class DCustomer
    {
        private string cadena = "Server=LAB1507-06\\SQLEXPRESS03; Database=lab07;User ID=Alee;Password=123456;MultipleActiveResultSets=True";

        public List<Customer> Get()
        {

            List<Customer> ListarCustomer = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("USP_listarCustomers", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        CustomerId = Convert.ToInt32(reader["customer_id"]),
                        Name = reader["name"] != DBNull.Value ? reader["name"].ToString() : string.Empty,
                        Address = reader["address"] != DBNull.Value ? reader["address"].ToString() : string.Empty,
                        Phone = reader["phone"] != DBNull.Value ? reader["phone"].ToString() : string.Empty,
                       
                    };
                    ListarCustomer.Add(customer);

                }
                return ListarCustomer;
            }

        }

    }
}
