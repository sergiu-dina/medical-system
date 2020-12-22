using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class MedicPacient
    {
        public int MedicId { get; set; }
        public Medic Medic { get; set; }
        public int PacientId { get; set; }
        public Pacient Pacient { get; set; }

    }
}
