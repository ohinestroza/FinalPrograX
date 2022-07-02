using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class ClienteModel
    {
        public int id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string apellido_cliente { get; set; }
        public string descripcion { get; set; }
        public double sueldo_mensual { get; set; }
        public double monto_donacion { get; set; }
        public int codigo_postal { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public int id_ciudad { get; set; }
        public double pib { get; set; }
        public int id_categoria { get; set; }
    }
}
