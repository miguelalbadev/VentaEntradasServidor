using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VentaEntradasServidor.Models {
    public class Entrada {
        [Key]
        public long Id { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Codigo { get; set; }
        public float Precio { get; set; }
        public string Pelicula { get; set; }
    }
}