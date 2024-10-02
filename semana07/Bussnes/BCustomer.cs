using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business

{ // ES PARA MANEJAR LA LOGICA DE NEGOCIO Y UTILIZA LA CAPA DATA PARA OBTENER LOS DATOS
    public class BCustomer
    {
        public List<Customer> Get(string? name = null)


        { // ESTA FUNCION ES PARA OBTENER LOS DATOS DE LA CAPA DATA 
            DCustomer dCustomer = new DCustomer();
            var customers = dCustomer.Get();

            if (name == null)
            {
                return customers;
            }
            else
            {

                return customers
                     .Where(x => x.Name == name)
                     .ToList();
            }

        }
    }
}
