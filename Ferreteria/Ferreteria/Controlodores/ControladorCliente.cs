using System;
using System.Collections.Generic;
using System.IO;
using Ferreteria.Modelos;
using System.Linq;

namespace Ferreteria.Controladores
{
    public class ControladorCliente
    {
        private List<Cliente> clientes;

        public ControladorCliente()
        {
            clientes = new List<Cliente>();
            CargarClientesDesdeCsv();
        }

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            GuardarClientesEnCsv();
        }

        public void ActualizarCliente(Cliente clienteActualizado)
        {
            var cliente = clientes.FirstOrDefault(c => c.ClienteID == clienteActualizado.ClienteID);
            if (cliente != null)
            {
                cliente.Nombre = clienteActualizado.Nombre;
                cliente.Apellido1 = clienteActualizado.Apellido1;
                cliente.Apellido2 = clienteActualizado.Apellido2;
                cliente.Telefono = clienteActualizado.Telefono;
                cliente.CorreoElectronico = clienteActualizado.CorreoElectronico;
                GuardarClientesEnCsv();
            }
        }

        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        private void GuardarClientesEnCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("ClienteID,Nombre,Apellido1,Apellido2,Telefono,CorreoElectronico");
                foreach (var cliente in clientes)
                {
                    writer.WriteLine($"{cliente.ClienteID},{cliente.Nombre},{cliente.Apellido1},{cliente.Apellido2},{cliente.Telefono},{cliente.CorreoElectronico}");
                }
            }
        }

        private void CargarClientesDesdeCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    bool isFirstLine = true;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            isFirstLine = false;
                            continue;
                        }
                        var values = line.Split(',');
                        var cliente = new Cliente
                        {
                            ClienteID = values[0],
                            Nombre = values[1],
                            Apellido1 = values[2],
                            Apellido2 = values[3],
                            Telefono = values[4],
                            CorreoElectronico = values[5]
                        };
                        clientes.Add(cliente);
                    }
                }
            }
        }
    }
}
