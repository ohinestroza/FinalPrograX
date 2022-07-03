using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class AsignacionClienteModel
    {
        public int id_calculo { get; set; }
        public double monto_donacion { get; set; }
        public string monto_impuesto { get; set; }
        public string descripcion { get; set; }
        public double monto_total { get; set; }
        public int id_cliente { get; set; }
    }
}
