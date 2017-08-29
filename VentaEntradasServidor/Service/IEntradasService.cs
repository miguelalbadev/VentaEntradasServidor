using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaEntradasServidor.Models;

namespace VentaEntradasServidor.Service {
    public interface IEntradasService {
        Entrada Create(Entrada entrada);
        Entrada Read(long Id);
        IQueryable<Entrada> ReadAll();
        void Update(long id, Entrada entrada);
        Entrada Delete(long id);
    }
}
