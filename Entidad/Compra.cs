using System;

namespace Entidad
{
    public class Compra
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public double Descuento { get; set; }

        public override string ToString()
        {
            return $"{Id};{Numero};{Usuario};{FechaCompra};{Total};{SubTotal};{Descuento}";
        }

    }
}
