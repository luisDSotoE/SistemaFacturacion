using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteImpl : IServicioFacturacion<Cliente>
    {
        List<Cliente> clientes;
        RepositorioCliente reposClientes;

        public ClienteImpl()
        {
            reposClientes = new RepositorioCliente("clientes.txt");
            clientes = reposClientes.GetClientes();
        }

        public bool Actualizar(Cliente cliente)
        {
            try
            {
                foreach (var item in clientes)
                {
                    if (item.Equals(cliente.Nombres))
                    {
                        item.Id = cliente.Id;
                        item.Nombres = cliente.Nombres;
                        item.Apellidos = cliente.Apellidos;
                        item.Documento = cliente.Documento;
                        item.Direccion = cliente.Direccion;
                        item.TipoCliente = cliente.TipoCliente;
                        break;
                    }
                }
                reposClientes.Update(clientes, true);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Agregar(Cliente cliente)
        {
            try
            {
                reposClientes.GuardarDatos(cliente);
                clientes = reposClientes.GetClientes();
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public bool Eliminar(Cliente cliente)
        {
            try
            {
                clientes.Remove(cliente);
                reposClientes.Update(clientes, false);
                return true;
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Cliente> Listar() { return clientes; }
    }
}
