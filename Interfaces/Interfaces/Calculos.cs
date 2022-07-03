using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ICalculos
    {
        List<Clientes> GetClientes(IDbConnection dbConnection);
        List<Clientes> GetClienteImpuesto(IDbConnection dbConnection, Clientes clienteImpuesto);

    }
}
