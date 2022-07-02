using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Interfaces.Interfaces
{
   public interface Icliente
    {
        interface ICrearCliente
        {
            void crear(Clientes cliente);
        }
        interface IEditarCliente
        {
            void editar(Clientes cliente);
        }
        interface IEliminarCliente
        {
            void eliminar(Clientes cliente);
        }





    }
}
