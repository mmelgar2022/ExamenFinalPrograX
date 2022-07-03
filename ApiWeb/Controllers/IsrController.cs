using Interfaces.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ApiWeb.Controllers
{
    public class IsrController : Controller
    {
        private readonly Iisr _service;
        private readonly IDbConnection _dbConnection;

        [HttpPost("CalculoIva")]
        public List<Iisr> PostIva(int id_cliente)
        {
            return _service.calcularISR(_dbConnection, id_cliente);
        }
    }

}
