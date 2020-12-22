using Proiect3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public class SqlMedicPacientData : IMedicPacientData
    {
        private readonly AppDbContext db;

        public SqlMedicPacientData(AppDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<MedicPacient> GetAll()
        {
            return db.MedicPacients;
        }
    }
}
