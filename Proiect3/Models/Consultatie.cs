using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.Models
{
    public class Consultatie
    {
        public int PacientId { get; set; }
        public Pacient Pacient { get; set; }
        public int MedicamentId { get; set; }
        public Medicament Medicament { get; set; }
        public string Data { get; set; }
        public string Diagnostic { get; set; }
        public int DozaMedicament { get; set; }
    }
}
