using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public interface IConsultatieData
    {
        IEnumerable<Consultatie> GetAll();
    }
}
