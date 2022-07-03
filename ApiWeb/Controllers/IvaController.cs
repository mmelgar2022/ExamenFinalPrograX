using Interfaces.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ApiWeb.Controllers
{
    public class IvaController : Controller
    {
        private readonly Iiva _service;
        private readonly IDbConnection _dbConnection;

        [HttpPost("CalculoIva")]
        public List<Iiva> PostIva(int id_cliente)
        {
            return _service.calcularIVA(_dbConnection, id_cliente);
        }
    }

}
