using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios
{
    public class Calculos : ICalculos

    {
        private readonly IDbConnection _dbConnection;
        public Calculos(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
