using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IPais
    {
        PaisModel GetPais();
        List<PaisModel> GetPaises(System.Data.IDbConnection dbConnection);
        List<PaisModel> GetPaisByFirstLetter(char FirstLetter);
        void SetPais(PaisModel pais);
        void DeletePais(int id);
        List<PaisModel> EditPais(System.Data.IDbConnection dbConnection, int idPais);
    }
}
