using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Main.Models
{
    [DataContract]
    class Motorcycle
    {
        [DataMember(Order = 0)]
        public string Make { get; set; }

        [DataMember(Order = 1)]
        public string Name { get; set; }

        [DataMember(Order = 2)]
        public string Type { get; set; }

        [DataMember(Order = 3)]
        public int Power { get; set; }

        [DataMember(Order = 4)]
        public double Weight { get; set; }

        public Motorcycle(string make, string name, string type, int power, double weight)
        {
            Make = make;
            Name = name;
            Type = type;
            Power = power;
            Weight = weight;
        }

        public override string ToString() 
            => $"Make: {Make}\r\n Name: {Name}\r\n Type: {Type}\r\n Power: {Power}\r\n Weight: {Weight}";
    }
}
