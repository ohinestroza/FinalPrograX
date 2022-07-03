using System;
using Models.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ICliente
    {
        ClienteModel GetCliente();
        List<ClienteModel> GetClientes(System.Data.IDbConnection dbConnection);
        List<ClienteModel> GetClienteByFirstLetter(char FirstLetter);
        void SetCliente(ClienteModel cliente);
        void DeleteCliente(int id);
        List<ClienteModel> EditCliente(System.Data.IDbConnection dbConnection, int idCliente);
    }
}
