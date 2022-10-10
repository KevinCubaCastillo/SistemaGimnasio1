using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Detallerutina
    {
        public int Coddetallerutina { get; set; }
        public int Codrutina { get; set; }
        public int Codejercicio { get; set; }
        public string? Descripcion { get; set; }
        public int? Cantidadreps { get; set; }
        public int? Estado { get; set; }

        public virtual Ejercicio CodejercicioNavigation { get; set; } = null!;
        public virtual Rutina CodrutinaNavigation { get; set; } = null!;
        public virtual Estado? EstadoNavigation { get; set; }
    }
}
