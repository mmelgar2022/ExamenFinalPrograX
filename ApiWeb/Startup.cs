using Autofac;
using Interfaces.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.OpenApi.Models;

namespace ApiWeb
{
    public class Startup : Controller
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            SqlConnection conn = new SqlConnection
            {
                ConnectionString = @"Server=.;Initial Catalog=DbFinalPrograX;Trusted_Connection=true;TrustServerCertificate=True"
            };
            conn.Open();
            //builder.RegisterInstance<IDbConnection>(conn);
            //this.ApplicationContainer = builder.Build();

            services.AddSingleton<Iiva, Ivaservicios>();
            services.AddSingleton<Iisr,Isrservicios>();
            services.AddSingleton<ICliente,ClienteServicios>();
            services.AddSingleton<IAhorro, Ahorroservicios>();
            services.AddSingleton<ICalculos, Calculosservicios>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiWeb", Version = "v1" });
            });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModDI());
            #region AutoFac Modulo
            builder.RegisterModule(new ModDI());
            #endregion
            #region AutoFac Direct REgistration
            //builder.RegisterType<AlumnoService>().As<IAlumno>();
            #endregion


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WepApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseSentryTracing();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=ClientesImpuestosController}");
            //});

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
