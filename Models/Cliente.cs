using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Inscripciones = new HashSet<Inscripcione>();
            Rutinas = new HashSet<Rutina>();
        }

        public string Ci { get; set; } = null!;
        public string Codcliente { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string? Apellidopaterno { get; set; }
        public string? Apellidomaterno { get; set; }
        public DateOnly? FechaNacimiento { get; set; }
        public string? Telefono { get; set; }
        public int? Estado { get; set; }

        public virtual Estado? EstadoNavigation { get; set; }
        public virtual ICollection<Inscripcione> Inscripciones { get; set; }
        public virtual ICollection<Rutina> Rutinas { get; set; }
    }
}
