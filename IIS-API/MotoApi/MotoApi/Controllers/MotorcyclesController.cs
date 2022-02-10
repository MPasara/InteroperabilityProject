using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotoApi.Models;
using RabbitMQ.Client;

namespace MotoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorcyclesController : ControllerBase
    {
        [HttpGet]
        public List<Motorcycle> Get() => Startup.ListaMotora;

        [HttpPost]
        public bool Post(Motorcycle[] arrayOfMotorcycle)
        {
            bool ok = false;
            Console.WriteLine("Request accepted");
            try
            {
                if (arrayOfMotorcycle != null)
                {
                    foreach (Motorcycle newMotorcycle in arrayOfMotorcycle)
                    {
                        Startup.ListaMotora.Add(newMotorcycle);
                        ok = true;

                        string message = "New motorcycle added: " + newMotorcycle.ToString();
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        Startup.channel.BasicPublish("", "Motorcycles", null, data);
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ok = false;
            }

            return ok;
        }
    }
}