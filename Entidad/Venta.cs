using System;

namespace Entidad
{
    public class Venta
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }

        public override string ToString()
        {
            return $"{Id};{Numero};{Cliente};{Usuario};{FechaVenta};{Total};{SubTotal};{Descuento}";
        }

    }
}
