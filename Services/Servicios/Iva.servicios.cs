using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class Iva : Iiva

    {
        public List<Iva> calcularIVA(IDbConnection dbConnection, int id_cliente)
        {
            var cliente = dbConnection.Query<Clientes>("SELECT * FROM [Vista_Impuesto] WHERE id_cliente = " + id_cliente);
            double IVA;

            foreach (var item in cliente)
            {
                var salario = item.Salario;

                IVA = salario * 0.12;

                dbConnection.Query<Iva>("INSERT INTO Calculo_Cliente (id_cliente, id_iva, mpnto) VALUES ("
                                                    + item.id_cliente + "," + item.id_iva + "," + "'IVA'" + "," + "'Calculo de IVA'" + "," + IVA + ")");
            }

            return (List<Iva>)dbConnection.Query<Iva>("SELECT * FROM  tbl_Calculos WHERE id_cliente = " + id_cliente);
        }
    }
}
