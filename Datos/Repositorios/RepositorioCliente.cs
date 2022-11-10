using Entidad;
using System.Collections.Generic;
using System.IO;
using System;

namespace Datos
{
    public class RepositorioCliente : ArchivoCliente
    {
        public RepositorioCliente() : base()
        {
        }

        public RepositorioCliente(string ruta) : base(ruta)
        {
        }

        public List<Cliente> GetClientes()
        {
            try
            {
                StreamReader sr = new StreamReader(ruta);
                List<Cliente> clientes = new List<Cliente>();
                while (!sr.EndOfStream)
                {
                    clientes.Add(Mappear(sr.ReadLine()));
                }
                sr.Close();
                return clientes;
            }
            catch (Exception e) { throw e; }
        }

        public Cliente Mappear(string cadena)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Id = int.Parse(cadena.Split(';')[0]);
                cliente.Nombres = cadena.Split(';')[1];
                cliente.Apellidos = cadena.Split(';')[2];
                cliente.Documento = cadena.Split(';')[3];
                cliente.Direccion = cadena.Split(';')[4];
                cliente.TipoCliente = cadena.Split(';')[5];
                return cliente;
            }
            catch (Exception e) { throw e; }
        }

        public bool Update(List<Cliente> clientes, bool modo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta, modo);
                foreach (var item in clientes) { sw.WriteLine(item.ToString()); }
                sw.Close();
                return true;
            }
            catch (Exception e) { throw e; }

        }
    }
}
