using Soap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Soap
{
    /// <summary>
    /// Summary description for MotoService1
    /// </summary>
    [WebService(Namespace = "")] 
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MotoService1 : WebService
    {
        private static readonly Motorcycle yamahaMt125 = new Motorcycle("Yamaha", "Mt 125", "Naked bike", 125, 138);
        private static readonly Motorcycle diavel = new Motorcycle("Ducati", "Diavel", "Cruiser", 1260, 234);
        private static readonly Motorcycle harley = new Motorcycle("Harley Davidson", "Street 500", "Cruiser", 500, 206);
        
        readonly List<Motorcycle> motorcycleList = new List<Motorcycle>() { yamahaMt125, diavel, harley };

        [WebMethod]
        public List<Motorcycle> GetAllMotorcycles() => motorcycleList;

        [WebMethod]
        public Motorcycle GetMotorcycleByMake(string make)
        {
            Motorcycle bike = motorcycleList.Find(m => m.Make == make);

            return bike;
        }

    }
}
