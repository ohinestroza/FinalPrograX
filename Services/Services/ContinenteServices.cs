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
    public class ContinenteServices : IContinente
    {
        public void DeleteContinente(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContinenteModel> EditCliente(IDbConnection dbConnection, int idContinente)
        {
            throw new NotImplementedException();
        }

        public List<ContinenteModel> EditContinente(IDbConnection dbConnection, int idContinente)
        {
            throw new NotImplementedException();
        }

        public ContinenteModel GetContinente()
        {
            throw new NotImplementedException();
        }

        public List<ContinenteModel> GetContinenteByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<ContinenteModel> GetContinentes(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetContinente(ContinenteModel continente)
        {
            throw new NotImplementedException();
        }
    }
}
