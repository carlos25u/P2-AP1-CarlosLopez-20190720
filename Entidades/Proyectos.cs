using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_CarlosLopez_20190720.Entidades
{
    class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public String Descripcion { get; set; }

        [ForeignKey("ProyectoId")]
        public List<ProyectoDetalle> Detalle { get; set; } = new List<ProyectoDetalle>();
    }
}
