using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Medicament
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Denumire { get; set; }
        public IList<Consultatie> Consultatii { get; set; }

    }
}
