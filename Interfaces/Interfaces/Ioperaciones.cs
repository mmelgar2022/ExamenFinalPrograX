using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
   public interface Ioperacion
    {
        public interface IAhorro
        {
            double calAhorro(Clientes cliente);
        }
        interface ICalcISR
        {
            double calcularISR(Clientes cliente);
        }

        interface ICalcIVA
        {
            double calcIVA(Clientes cliente);
        }


    }
}
