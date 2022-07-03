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
    public class CalculoImpuestosServices : ICalculoImpuestos
    {
        private readonly IDbConnection _dbConnection;
        public CalculoImpuestosServices(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<AsignacionClienteModel> calcularColchonAhorro(IDbConnection dbConnection, int id_cliente)
        {
            throw new NotImplementedException();
        }

        public List<AsignacionClienteModel> calcularISR(IDbConnection dbConnection, int id_cliente)
        {
            var cliente = dbConnection.Query<ClienteModel>("SELECT * FROM [Vista_ImpuestoCliente] WHERE id_cliente = " + id_cliente);
            double ISR;

            foreach (var item in cliente)
            {
                var montoDonacion = item.MontoDonacion;

                if (montoDonacion <= 30000.00)
                {
                    ISR = montoDonacion * 0.05;
                }
                else
                {
                    ISR = montoDonacion * 0.07;
                }

                dbConnection.Query<AsignacionClienteModel>("INSERT INTO tbl_CalculoImpuesto (id_calculo, monto_donacion, monto_impuesto, descripcion, monto_total, id_cliente) VALUES ("
                                                    + item.id_cliente + "," + item.id_calculo + "," + "'ISR'" + "," + "Cálculo de ISR:" + ISR + ")");
            }

            return (List<AsignacionClienteModel>)dbConnection.Query<AsignacionClienteModel>("SELECT * FROM  tbl_CalculoImpuesto WHERE id_cliente = " + id_cliente);
        }

        public List<AsignacionClienteModel> calcularIVA(IDbConnection dbConnection, int id_cliente)
        {
            var cliente = dbConnection.Query<ClienteModel>("SELECT * FROM [Vista_ImpuestoCliente] WHERE id_cliente = " + id_cliente);
            double IVA;

            foreach (var item in cliente)
            {
                var montoDonacion = item.MontoDonacion;

                IVA = montoDonacion * 0.12;

                dbConnection.Query<AsignacionClienteModel>("INSERT INTO tbl_CalculoImpuesto (id_cliente, id_rubro, Impuesto, Descripcion, Total) VALUES ("
                                                    + item.id_cliente + "," + item.id_rubro + "," + "'IVA'" + "," + "'Calculo de IVA'" + "," + IVA + ")");
            }

            return (List<AsignacionClienteModel>)dbConnection.Query<AsignacionClienteModel>("SELECT * FROM  tbl_CalculoImpuesto WHERE id_cliente = " + id_cliente);
        }
    }
}
