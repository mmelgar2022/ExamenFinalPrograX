using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Servicios.DB
{
    private readonly SqlConnection conn = new SqlConnection();
    public SqlConnection GetConnection()
    {
        try
        {
            conn.ConnectionString = @"Server=localhost;Initial Catalog=DbFinalPrograX;Trusted_Connection=true";
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
    }
}

