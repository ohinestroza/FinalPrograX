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
    public class PaisServices : IPais
    {
        public void DeletePais(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaisModel> EditPais(IDbConnection dbConnection, int idPais)
        {
            throw new NotImplementedException();
        }

        public PaisModel GetPais()
        {
            throw new NotImplementedException();
        }

        public List<PaisModel> GetPaisByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<PaisModel> GetPaises(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetPais(PaisModel pais)
        {
            throw new NotImplementedException();
        }
    }
}
