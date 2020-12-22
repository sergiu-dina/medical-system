using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Pacient
    {
        public int PacientId { get; set; }
        public string CNP { get; set; }

        [Display(Name = "Last Name")]
        public string NumePacient { get; set; }

        [Display(Name = "First Name")]
        public string PrenumePacient { get; set; }

        [Display(Name = "Adress")]
        public string Adresa { get; set; }

        [Display(Name = "Insurance")]
        public string Asigurare { get; set; }
        public IList<MedicPacient> MedicPacients { get; set; }
        public IList<Consultatie> Consultatii { get; set; }

    }
}
