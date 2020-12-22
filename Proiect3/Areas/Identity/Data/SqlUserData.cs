using Proiect3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Areas.Identity.Data
{
    public class SqlUserData : IUserData
    {
        private readonly AppDbContext db;

        public SqlUserData(AppDbContext db)
        {
            this.db = db;
        }

        public ApplicationUser Get(string email)
        {
            return db.Users.FirstOrDefault(u => u.Email == email);
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return db.Users.OrderBy(r => r.FirstName);
        }
    }
}
