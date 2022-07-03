using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    internal class Isr : Iisr

    {
        public List<Isr> calcularISR(IDbConnection dbConnection, int id_cliente)
        {
            var cliente = dbConnection.Query<Clientes>("SELECT * FROM [VW_IMPUESTO_CLIENTE] WHERE id_cliente = " + id_cliente);
            double ISR;

            foreach (var item in cliente)
            {
                var salario = item.Salario;

                if (salario <= 30000.00)
                {
                    ISR = salario * 0.05;
                }
                else
                {
                    ISR = salario * 0.07;
                }

                dbConnection.Query<Isr>("INSERT INTO Calculo_Cliente (id_cliente, id_rubro, Impuesto, Descripcion, Total) VALUES ("
                                                    + item.id_cliente + "," + item.id_rubro + "," + "'ISR'" + "," + "'Calculo de ISR'" + "," + ISR + ")");
            }

            return (List<Isr>)dbConnection.Query<Isr>("SELECT * FROM  Calculo_Cliente WHERE id_cliente = " + id_cliente);
        }

    }
}
}
