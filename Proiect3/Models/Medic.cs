using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Medic
    {
        public int MedicId { get; set; }

        [Display(Name = "Last Name")]
        public string NumeMedic { get; set; }

        [Display(Name = "First Name")]
        public string PrenumeMedic { get; set; }

        [Display(Name = "Specialization")]
        public string Specializare { get; set; }
        public IList<MedicPacient> MedicPacients { get; set; }
    }
}
