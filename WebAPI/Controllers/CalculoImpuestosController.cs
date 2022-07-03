using Interfaces.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.Data;

namespace WebAPI.Controllers
{
    public class CalculoImpuestosController : Controller
    {
        private readonly ICalculoImpuestos _service;
        private readonly IDbConnection _dbConnection;
        public CalculoImpuestosController(ICalculoImpuestos calculos, IDbConnection dbConnection)
        {
            this._service = calculos;
            this._dbConnection = dbConnection;
        }
        // GET: api/<CalculoImpuestosController>
        [HttpPost("CalculoISR")]
        public List<ClienteModel> PostISR(int id_cliente)
        {
            return _service.calcularISR(_dbConnection, id_cliente);
        }

        [HttpPost("CalculoIva")]
        public List<ClienteModel> PostIVA(int id_cliente)
        {
            return _service.calcularIVA(_dbConnection, id_cliente);
        }
    }
}
