using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MotoApi.Models;
using RabbitMQ.Client;

namespace MotoApi
{
    public class Startup
    {
        internal static List<Motorcycle> ListaMotora;
        internal static ConnectionFactory rmqServer;
        internal static IConnection serverConnection;
        internal static IModel channel;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            ListaMotora = new List<Motorcycle>();
            Motorcycle yamahaMt125 = new Motorcycle("Yamaha","Mt 125", "Naked bike", 125, 138);
            Motorcycle diavel = new Motorcycle("Ducati", "Diavel", "Cruiser", 1260, 234);
            Motorcycle r1 = new Motorcycle("Yamaha", "R1", "Racer", 1200, 200);

            ListaMotora.Add(yamahaMt125);
            ListaMotora.Add(diavel);
            ListaMotora.Add(r1);

            rmqServer = new ConnectionFactory();
            serverConnection = rmqServer.CreateConnection();
            channel = serverConnection.CreateModel();
            channel.QueueDeclare(queue: "Motorcycles", exclusive: false);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddXmlDataContractSerializerFormatters();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseAuthorization(); -> deals with first attribure in xml

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
