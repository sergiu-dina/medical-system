using Microsoft.EntityFrameworkCore;
using Proiect3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public class SqlMedicamentData : IMedicamentData
    {
        private readonly AppDbContext db;

        public SqlMedicamentData(AppDbContext db)
        {
            this.db = db;
        }

        public void Add(Medicament medicament)
        {
            db.Medicamente.Add(medicament);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var medicament = db.Medicamente.Find(id);
            db.Medicamente.Remove(medicament);
            db.SaveChanges();
        }

        public Medicament Get(int id)
        {
            var medicament = db.Medicamente.FirstOrDefault(m => m.Id == id);
            return medicament;
        }

        public IEnumerable<Medicament> GetAll()
        {
            return db.Medicamente;
        }

        public void Update(Medicament medicament)
        {
            var entry = db.Entry(medicament);
            entry.State = EntityState.Modified;
            db.Entry(medicament).Property(u => u.Id).IsModified = false;
            db.SaveChanges();
        }
    }
}
