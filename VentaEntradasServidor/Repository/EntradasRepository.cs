using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VentaEntradasServidor.Excepciones;
using VentaEntradasServidor.Models;

namespace VentaEntradasServidor.Repository {
    public class EntradasRepository : IEntradasRepository {

        public Entrada Create(Entrada entrada) {
            return ApplicationDbContext.applicationDbContext.Entradas.Add(entrada);
        }

        public Entrada Delete(long id) {
            Entrada entrada = ApplicationDbContext.applicationDbContext.Entradas.Find(id);
            if (entrada == null) {
                throw new NoEncontradoException("No se ha encontrado la entidad.");
            }
            ApplicationDbContext.applicationDbContext.Entradas.Remove(entrada);
            return entrada;
        }

        public Entrada Read(long id) {
            return ApplicationDbContext.applicationDbContext.Entradas.Find(id);
        }

        public IQueryable<Entrada> ReadAll() {
            IList<Entrada> entradas = new List<Entrada>(ApplicationDbContext.applicationDbContext.Entradas);
            return entradas.AsQueryable();
        }

        public void Update(long id, Entrada entrada) {
            if (ApplicationDbContext.applicationDbContext.Entradas.Count(e => e.Id == entrada.Id) == 0) {
                throw new NoEncontradoException("No se ha encontrado la entidad.");
            }
            ApplicationDbContext.applicationDbContext.Entry(entrada).State = EntityState.Modified;
        }
    }
}