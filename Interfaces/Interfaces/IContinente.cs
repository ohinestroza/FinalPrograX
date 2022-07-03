using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IContinente
    {
        ContinenteModel GetContinente();
        List<ContinenteModel> GetContinentes(System.Data.IDbConnection dbConnection);
        List<ContinenteModel> GetContinenteByFirstLetter(char FirstLetter);
        void SetContinente(ContinenteModel continente);
        void DeleteContinente(int id);
        List<ContinenteModel> EditContinente(System.Data.IDbConnection dbConnection, int idContinente);
    }
}