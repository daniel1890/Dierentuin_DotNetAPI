using Dierentuin_DotNetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dierentuin_DotNetAPI.Services.Dieren
{
    public interface IDierService
    {
        List<Dier> GetAllDieren();

        Dier GetDierById(int id);

        List<Dier> AddDier(Dier newDier);

        Dier UpdateDier(Dier updatedDier);
    }
}