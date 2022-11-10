using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IServicioFacturacion<T>
    {
        bool Agregar(T Object);
        bool Eliminar(T Object);
        bool Actualizar(T Object);
        List<T> Listar();    
    }
}
