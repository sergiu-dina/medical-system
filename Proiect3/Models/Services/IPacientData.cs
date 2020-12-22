using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public interface IPacientData
    {
        IEnumerable<Pacient> GetAll();
        Pacient Get(int id);
        void Add(Pacient pacient);
        void Update(Pacient pacient);
        void Delete(int id);
    }
}
