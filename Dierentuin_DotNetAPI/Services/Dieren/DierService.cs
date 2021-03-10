using Dierentuin_DotNetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dierentuin_DotNetAPI.Services.Dieren
{
    public class DierService : IDierService
    {
        private static List<Dier> _dieren = new List<Dier>
        {
            new Dier(),
            new Dier() {Soort = DierSoort.Olifant, Naam = "Harry"},
            new Dier {Soort = DierSoort.Aap, Naam = "Piet"}
        };

        public List<Dier> GetAllDieren()
        {
            return _dieren.Select(x => x).ToList();
        }

        public Dier GetDierById(int id)
        {
            return _dieren.FirstOrDefault(x => x.Id == id);
        }

        public List<Dier> AddDier(Dier newDier)
        {
            _dieren.Add(newDier);
            return _dieren.Select(x => x).ToList();
        }

        public Dier UpdateDier(Dier updatedDier)
        {
            Dier dier = _dieren.FirstOrDefault(x => x.Id == updatedDier.Id);
            dier.Ledematen = updatedDier.Ledematen;
            dier.Naam = updatedDier.Naam;
            dier.Soort = updatedDier.Soort;
            return updatedDier;
        }
    }
}