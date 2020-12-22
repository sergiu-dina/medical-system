using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.ViewModel
{
    public class PacientMedicMedicineViewModel
    {
        public Pacient Pacient { get; set; }
        public List<Medic> Medici { get; set; }
        public List<ConsultatieViewModel> Consultatii { get; set; }
    }
}
