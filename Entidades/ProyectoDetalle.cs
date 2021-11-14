using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_CarlosLopez_20190720.Entidades
{
    class ProyectoDetalle
    {
        [Key]
        public int ProyectoDetalleId { get; set; }
        public int ProyectoId { get; set; }
        public int TipoId { get; set; }

        [ForeignKey("TipoId")]
        public TiposTareas TiposTareas { get; set; }
        public Proyectos Proyectos { get; set; }

    }
}
