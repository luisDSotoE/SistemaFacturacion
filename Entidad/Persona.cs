namespace Entidad
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombres};{Apellidos};{Documento};{Direccion};";
        }
    }
}
