using Autofac;
using Interfaces.Interfaces;
using Microsoft.Data.SqlClient;
using Services.Services;
using System.Data;

namespace WebAPI
{
    public class DIModule : Autofac.Module
    {
        string connectionString = @"Server=.;Initial Catalog=ExamenFinalPrograX;Trusted_Connection=true;TrustServerCertificate=True";

        protected override void Load(ContainerBuilder builder)
        {
            SqlConnection conn;
            #region Cálculo Impuestos
            builder.RegisterType<CalculoImpuestosServices>().As<ICalculoImpuestos>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Ciudades
            builder.RegisterType<CiudadServices>().As<ICiudad>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Clientes
            builder.RegisterType<ClienteServices>().As<ICliente>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Continentes
            builder.RegisterType<ContinenteServices>().As<IContinente>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Países
            builder.RegisterType<PaisServices>().As<IPais>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
        }
    }
}
