using Microsoft.EntityFrameworkCore;
using Proiect3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public class SqlMedicData : IMedicData
    {
        private readonly AppDbContext db;

        public SqlMedicData(AppDbContext db)
        {
            this.db = db;
        }

        public void Add(Medic medic)
        {
            db.Medics.Add(medic);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var medic=db.Medics.Find(id);
            db.Medics.Remove(medic);
            db.SaveChanges();
        }

        public Medic Get(int id)
        {
            var medic = db.Medics.FirstOrDefault(m => m.Id == id);
            return medic;
        }

        public IEnumerable<Medic> GetAll()
        {
            return db.Medics;
        }

        public void Update(Medic medic)
        {
            var entry = db.Entry(medic);
            entry.State = EntityState.Modified;
            db.Entry(medic).Property(m => m.Id).IsModified = false;
            db.SaveChanges();
        }
    }
}
