namespace Entidad
{
    public class Administrador : Persona
    {
        public string UsuarioAdministrador { get; set; }
        public string contraseña { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{UsuarioAdministrador}";
        }

    }
}
