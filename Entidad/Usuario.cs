namespace Entidad
{
    public class Usuario : Persona
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{NombreUsuario}";
        }

    }
}
