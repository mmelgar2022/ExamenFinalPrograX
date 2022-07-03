using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
   public  class Ahorro : IAhorro

    {
        public List<Ahorro> calcularAHORRO(IDbConnection dbConnection, int id_cliente)
        {
            throw new NotImplementedException();
        }
    }
}
