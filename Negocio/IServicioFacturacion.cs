using System.Collections.Generic;

namespace Negocio
{
    public interface IServicioFacturacion<T>
    {
        bool Agregar(T objeto);
        bool Eliminar(T objeto);
        bool Actualizar(T objeto);
        List<T> Listar();
    }
}
