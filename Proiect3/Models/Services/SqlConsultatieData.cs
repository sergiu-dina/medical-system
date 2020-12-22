using Proiect3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public class SqlConsultatieData : IConsultatieData
    {
        private readonly AppDbContext db;

        public SqlConsultatieData(AppDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Consultatie> GetAll()
        {
            return db.Consultatii;
        }
    }
}
