using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public interface IMedicData
    {
        IEnumerable<Medic> GetAll();
        Medic Get(int id);
        void Add(Medic medic);
        void Update(Medic medic);
        void Delete(int id);
    }
}
