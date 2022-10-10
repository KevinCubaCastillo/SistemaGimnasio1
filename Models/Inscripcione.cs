using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Inscripcione
    {
        public int Codinscripcion { get; set; }
        public string Cicliente { get; set; } = null!;
        public string Ciusuario { get; set; } = null!;
        public DateOnly Fechainicio { get; set; }
        public DateOnly Fechafin { get; set; }
        public string? Tipoinscripcion { get; set; }
        public string? Tipopago { get; set; }
        public string? Observaciones { get; set; }
        public int? Estado { get; set; }

        public virtual Cliente CiclienteNavigation { get; set; } = null!;
        public virtual Usuario CiusuarioNavigation { get; set; } = null!;
        public virtual Estado? EstadoNavigation { get; set; }
    }
}
