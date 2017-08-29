using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VentaEntradasServidor.Excepciones {
    public class NoEncontradoException : Exception{

        public NoEncontradoException() {

        }

        public NoEncontradoException(string message) : base(message) {

        }

        public NoEncontradoException(string message, Exception inner) : base(message, inner) {

        }
    }
}