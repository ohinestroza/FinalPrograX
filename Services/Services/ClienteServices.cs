using Interfaces.Interfaces;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ClienteServices : ICliente
    {
        public void DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public List<ClienteModel> EditCliente(IDbConnection dbConnection, int idCliente)
        {
            throw new NotImplementedException();
        }

        public ClienteModel GetCliente()
        {
            throw new NotImplementedException();
        }

        public List<ClienteModel> GetClienteByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<ClienteModel> GetClientes(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetCliente(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }
    }
}
