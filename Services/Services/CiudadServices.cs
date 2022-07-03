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
    public class CiudadServices : ICiudad
    {
        public void DeleteCiudad(int id)
        {
            throw new NotImplementedException();
        }

        public List<CiudadModel> EditCiudad(IDbConnection dbConnection, int idCiudad)
        {
            throw new NotImplementedException();
        }

        public CiudadModel GetCiudad()
        {
            throw new NotImplementedException();
        }

        public List<CiudadModel> GetCiudadByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<CiudadModel> GetCiudades(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public void SetCiudad(CiudadModel ciudad)
        {
            throw new NotImplementedException();
        }
    }
}
