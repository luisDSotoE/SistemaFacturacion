namespace Entidad
{
    public class Cliente : Persona
    {
        public string TipoCliente { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{TipoCliente}";
        }

    }
}
