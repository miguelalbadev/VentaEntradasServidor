using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaEntradasServidor.Models;

namespace VentaEntradasServidor.Repository {
    public interface IPeliculasRepository {

        Pelicula Create(Pelicula pelicula);
        Pelicula Read(long Id);
        IQueryable<Pelicula> ReadAll();
        void Update(long id, Pelicula pelicula);
        Pelicula Delete(long id);
    }
}
