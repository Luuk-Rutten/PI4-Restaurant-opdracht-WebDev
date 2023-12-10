using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI4_Restaurant_opdracht_WebDev
{
    public class Medewerker
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Medewerker(string id, string name) 
        {
             Id = id;
             Name = name;
        }


    }
}
