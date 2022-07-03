using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface ICiudad
    {
        CiudadModel GetCiudad();
        List<CiudadModel> GetCiudades(System.Data.IDbConnection dbConnection);
        List<CiudadModel> GetCiudadByFirstLetter(char FirstLetter);
        void SetCiudad(CiudadModel ciudad);
        void DeleteCiudad(int id);
        List<CiudadModel> EditCiudad(System.Data.IDbConnection dbConnection, int idCiudad);
    }
}
