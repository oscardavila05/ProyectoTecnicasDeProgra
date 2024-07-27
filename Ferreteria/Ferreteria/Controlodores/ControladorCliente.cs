// Ferreteria/Controladores/ControladorCliente.cs
using System;
using System.Collections.Generic;
using System.IO;
using Ferreteria.Modelos;
using System.Windows.Forms;

namespace Ferreteria.Controladores
{
    public class ControladorCliente
    {
        private List<Cliente> clientes;

        public ControladorCliente()
        {
            clientes = new List<Cliente>();
        }

        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            SaveToCsv(cliente);
        }

        private void SaveToCsv(Cliente cliente)
        {
            // Usa la ruta predeterminada de .NET (directorio de salida de la aplicación)
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.csv");

            // Verifica si el archivo existe y crea si es necesario
            bool fileExists = File.Exists(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                if (!fileExists)
                {
                    writer.WriteLine("ClienteID,Nombre,Apellido1,Apellido2,Telefono,CorreoElectronico");
                }
                writer.WriteLine($"{cliente.ClienteID},{cliente.Nombre},{cliente.Apellido1},{cliente.Apellido2},{cliente.Telefono},{cliente.CorreoElectronico}");
            }

            MessageBox.Show("El archivo CSV se ha creado/actualizado correctamente.");
        }
    }
}
