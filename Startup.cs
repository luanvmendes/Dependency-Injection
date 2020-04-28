using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DI
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
            services.AddControllers();

            //Define que cada vez que a interface IFormaPagamentoService for chamada, 
            //será recebida uma nova instância de FormaPagamentoService
            //o ciclo de vida de uma DI é definido por
            //Singleton: Uma instância única durante todo o ciclo de vida da aplicação,
            //           criada uma vez e cada solicitação utiliza essa mesma instância.
            //Scoped: Criado a cada request (exemplo: Cada cliente terá uma instância diferente)
            //Transient: Uso único, criado toda vez que forem solicidtados
            services.AddTransient<IFormaPagamentoService, FormaPagamentoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
