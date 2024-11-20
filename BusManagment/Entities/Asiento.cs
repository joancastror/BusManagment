using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagment.Entities
{
    public class Asiento
    {
        public int AsientoId { get; set; }
        public int BusID { get; set; }
        public int NumeroPiso {  get; set; }
        public int NumeroAsiento { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
