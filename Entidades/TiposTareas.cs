using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_CarlosLopez_20190720.Entidades
{
    class TiposTareas
    {
        [Key]
        public int TipoId { get; set; }
        public string TipoTarea { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }
    }
}
