using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect3.ViewModel
{
    public class MedicPacientViewModel
    {
        public Medic Medic { get; set; }
        public List<Pacient> Pacients { get; set; }
    }
}
