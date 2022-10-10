using System;
using System.Collections.Generic;

namespace SistemaGimnasio.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Categoria = new HashSet<Categorium>();
            Clientes = new HashSet<Cliente>();
            Detallerutinas = new HashSet<Detallerutina>();
            Ejercicios = new HashSet<Ejercicio>();
            Equipos = new HashSet<Equipo>();
            Inscripciones = new HashSet<Inscripcione>();
            Publicaciones = new HashSet<Publicacione>();
            Rutinas = new HashSet<Rutina>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Idestado { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Categorium> Categoria { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Detallerutina> Detallerutinas { get; set; }
        public virtual ICollection<Ejercicio> Ejercicios { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
        public virtual ICollection<Inscripcione> Inscripciones { get; set; }
        public virtual ICollection<Publicacione> Publicaciones { get; set; }
        public virtual ICollection<Rutina> Rutinas { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
