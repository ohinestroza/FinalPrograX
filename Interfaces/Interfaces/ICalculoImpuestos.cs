using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ICalculoImpuestos : IIVA, IISR, IColchonAhorro
    {
        List<ClienteModel> GetClientes(IDbConnection dbConnection);
        List<ClienteModel> GetClienteImpuesto(IDbConnection dbConnection, ClienteModel clienteImpuesto);
    }
    public interface IIVA
    {
        List<AsignacionClienteModel> calcularIVA(IDbConnection dbConnection, int id_cliente);
    }

    public interface IISR
    {
        List<AsignacionClienteModel> calcularISR(IDbConnection dbConnection, int id_cliente);
    }


    public interface IColchonAhorro
    {
        List<AsignacionClienteModel> calcularColchonAhorro(IDbConnection dbConnection, int id_cliente);
    }
}
