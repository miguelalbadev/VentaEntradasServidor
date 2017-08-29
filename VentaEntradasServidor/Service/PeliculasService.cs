using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaEntradasServidor.Models;
using VentaEntradasServidor.Repository;

namespace VentaEntradasServidor.Service {
    public class PeliculasService : IPeliculasService {

        private IPeliculasRepository peliculasRepository;
        public PeliculasService (IPeliculasRepository peliculasRepository) {
            this.peliculasRepository = peliculasRepository;
        }
        public Pelicula Create(Pelicula pelicula) {
            return peliculasRepository.Create(pelicula);
        }

        public Pelicula Delete(long id) {
            return peliculasRepository.Delete(id);
        }

        public Pelicula Read(long id) {
            return peliculasRepository.Read(id);
        }

        public IQueryable<Pelicula> ReadAll() {
            IQueryable<Pelicula>peliculas;
            peliculas = peliculasRepository.ReadAll();
            return peliculas;
        }

        public void Update(long id, Pelicula pelicula) {
            peliculasRepository.Update(id, pelicula);
        }
    }
}