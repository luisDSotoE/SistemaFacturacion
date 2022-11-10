using Entidad;
using System.Collections.Generic;
using System.IO;
using System;

namespace Datos
{
    public class ArchivoCliente
    {
        protected string ruta = "clientes.txt";

        public ArchivoCliente()
        {
            this.ruta = "clientes.txt";
        }

        public ArchivoCliente(string ruta)
        {
            this.ruta = ruta;
        }

        public bool GuardarDatos(Cliente cliente)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, true);
                sw.WriteLine(cliente.ToString());
                sw.Close();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool update(List<Cliente> cliente)
        {
            try
            {
                StreamWriter sw = new StreamWriter("temporal", true);
                foreach (var item in cliente) { sw.WriteLine(item); }
                sw.Close();
                File.Delete(ruta);
                File.Move("temporal", ruta);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public void vaciar()
        {
            StreamWriter sw = new StreamWriter(ruta, false);
            sw.Write("");
            sw.Close();
        }
    }
}
