using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class Isr : Iisr

    {
        public List<Isr> calcularISR(IDbConnection dbConnection, int id_cliente)
        {
            var cliente = dbConnection.Query<Clientes>("SELECT * FROM [Vista_Impuesto] WHERE id_cliente = " + id_cliente);
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

                dbConnection.Query<Isr>("INSERT INTO Calculo_Cliente (id_isr , id_cliente, monto) VALUES ("
                                                    + item.id_cliente + "," + item.id_isr + "," + "'ISR'" + "," + "'Calculo de ISR'" + "," + ISR + ")");
            }

            return (List<Isr>)dbConnection.Query<Isr>("SELECT * FROM  tbl_Calculo WHERE id_cliente = " + id_cliente);
        }

        public double calcularISR(Modelos.Modelos.Clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}

