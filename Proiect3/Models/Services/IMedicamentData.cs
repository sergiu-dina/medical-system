using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public interface IMedicamentData
    {
        IEnumerable<Medicament> GetAll();
        Medicament Get(int id);
        void Add(Medicament medicament);
        void Update(Medicament medicament);
        void Delete(int id);
    }
}
