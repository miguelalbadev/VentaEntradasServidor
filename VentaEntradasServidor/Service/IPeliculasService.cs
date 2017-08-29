using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaEntradasServidor.Models;

namespace VentaEntradasServidor.Service {
    public interface IPeliculasService {

        Pelicula Create(Pelicula pelicula);
        Pelicula Read(long id);
        IQueryable<Pelicula> ReadAll();
        void Update(long id, Pelicula pelicula);
        Pelicula Delete(long id);
    }
}
