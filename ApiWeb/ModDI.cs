using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ApiWeb
{
    public class ModDI : Autofac.Module

    {
        string connectionString = @"Server=.;Initial Catalog=DbFinalPrograX;Trusted_Connection=true;TrustServerCertificate=True";


        protected override void Load(ContainerBuilder builder)
        {
            SqlConnection conn;
            #region Iva
            builder.RegisterType<Ivaservicios>().As<Iiva>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Isr
            builder.RegisterType<Isrservicios>().As<Iisr>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #region Cliente
            builder.RegisterType<Clientesservicios>().As<Iclientes>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #region Cliente
            builder.RegisterType<Calculosservicios>().As<Icalculos>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
        }
    } }
}