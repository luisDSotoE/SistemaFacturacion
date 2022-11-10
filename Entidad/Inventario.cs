using System;

namespace Entidad
{
    public class Inventario
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int Almacen { get; set; }
        public int Tipo { get; set; }
        public DateTime FechaInventario { get; set; }

        public override string ToString()
        {
            return $"{Id};{Producto};{Cantidad};{Almacen};{Tipo};{FechaInventario}";
        }
    }
}
