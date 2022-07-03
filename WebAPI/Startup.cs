﻿using Autofac;
using Interfaces.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.OpenApi.Models;
using Services.Services;

namespace WebAPI
{
    public class Startup
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
                ConnectionString = @"Server=.;Initial Catalog=ExamenFinalPrograX;Trusted_Connection=true;TrustServerCertificate=True"
            };
            conn.Open();

            services.AddSingleton<ICalculoImpuestos, CalculoImpuestosServices>();
            services.AddSingleton<ICiudad, CiudadServices>();
            services.AddSingleton<ICliente, ClienteServices>();
            services.AddSingleton<IContinente, ContinenteServices>();
            services.AddSingleton<IPais, PaisServices>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DIModule());
            #region AutoFac Modulo
            builder.RegisterModule(new DIModule());
            #endregion
            #region AutoFac Direct Registration
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
    }
}
