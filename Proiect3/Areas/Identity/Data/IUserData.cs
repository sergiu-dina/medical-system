using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Areas.Identity.Data
{
    public interface IUserData
    {
        IEnumerable<ApplicationUser> GetAll();
        ApplicationUser Get(string email);
    }
}
