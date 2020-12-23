using Microsoft.EntityFrameworkCore;
using Proiect3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models.Services
{
    public class SqlPacientData : IPacientData
    {
        private readonly AppDbContext db;

        public SqlPacientData(AppDbContext db)
        {
            this.db = db;
        }

        public void Add(Pacient pacient)
        {
            db.Pacients.Add(pacient);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var pacient = db.Pacients.Find(id);
            db.Pacients.Remove(pacient);
            db.SaveChanges();
        }

        public Pacient Get(int id)
        {
            var pacient = db.Pacients.FirstOrDefault(p => p.Id == id);
            return pacient;
        }

        public IEnumerable<Pacient> GetAll()
        {
            return db.Pacients;
        }

        public void Update(Pacient pacient)
        {
            var entry = db.Entry(pacient);
            entry.State = EntityState.Modified;
            db.Entry(pacient).Property(p => p.Id).IsModified = false;
            db.SaveChanges();
        }
    }
}
