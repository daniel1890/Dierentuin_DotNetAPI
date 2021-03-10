using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dierentuin_DotNetAPI.Models
{
    public class Dier
    {
        public int Id { get; set; } = 0;
        public static int IdCounter { get; set; }
        public string Naam { get; set; } = "Jackie";
        public int Ledematen { get; set; } = 4;
        public DierSoort Soort { get; set; } = DierSoort.Tijger;

        public Dier()
        {
            IdCounter++;
            Id = IdCounter;
        }
    }
}