using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaEntradasServidor.Models {
    public class Pelicula {
        [Key]
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Director { get; set; }
        public DateTime FechaEstreno { get; set; }
        
    }
}