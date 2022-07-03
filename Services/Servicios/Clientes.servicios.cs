using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    internal class Clientes : ICliente
    {
        public void DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public List<Modelos.Modelos.Clientes> EditCliente(IDbConnection dbConnection, int idCliente)
        {
            throw new NotImplementedException();
        }

        public Modelos.Modelos.Clientes GetCliente()
        {
            throw new NotImplementedException();
        }

        public List<Modelos.Modelos.Clientes> GetClienteByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<Modelos.Modelos.Clientes> GetClientes(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetCliente(Modelos.Modelos.Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
