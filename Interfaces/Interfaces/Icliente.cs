using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Interfaces.Interfaces
{
   public interface ICliente
    {
        Clientes GetCliente();
        List<Clientes> GetClientes(System.Data.IDbConnection dbConnection);
        List<Clientes> GetClienteByFirstLetter(char FirstLetter);
        void SetCliente(Clientes cliente);
        void DeleteCliente(int id);
        List<Clientes> EditCliente(System.Data.IDbConnection dbConnection, int idCliente);




    }
}
