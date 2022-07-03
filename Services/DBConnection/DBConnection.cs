using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DBConnection
{
    public class DBConnection
    {
        private readonly SqlConnection conn = new SqlConnection();
        public SqlConnection GetConnection()
        {
            try
            {
                conn.ConnectionString = @"Server=localhost;Initial Catalog=ExamenFinalPrograX;Trusted_Connection=true";
                conn.Open();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }
    }
}
