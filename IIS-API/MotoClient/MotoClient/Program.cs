using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace MotoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:5000/api/Motorcycles");
            request.Accept = "application/xml";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream data = response.GetResponseStream();

            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Motorcycle>));
            List<Motorcycle> motorcycles = (List<Motorcycle>)serializer.ReadObject(data);

            foreach (Motorcycle m in motorcycles)
            {
                Console.WriteLine("Make: " + m.Make);
                Console.WriteLine("Name: " + m.Name);
                Console.WriteLine("Type: " + m.Type);
                Console.WriteLine("Power: " + m.Power);
                Console.WriteLine("Weight: " + m.Weight);
                Console.WriteLine();
            }
        }
    }
}
