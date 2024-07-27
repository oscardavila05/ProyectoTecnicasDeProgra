using System;
using System.Collections.Generic;
using System.IO;
using Ferreteria.Modelos;

namespace Ferreteria.Controladores
{
    public class ControladorCajero
    {
        private List<Cajero> cajeros;

        public ControladorCajero()
        {
            cajeros = new List<Cajero>();
        }

        public void AgregarCajero(Cajero cajero)
        {
            cajeros.Add(cajero);
            SaveToCsv(cajero);
        }

        private void SaveToCsv(Cajero cajero)
        {
            // Usa la ruta predeterminada de .NET (directorio de salida de la aplicación)
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cajeros.csv");

            // Verifica si el archivo existe y crea si es necesario
            bool fileExists = File.Exists(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                if (!fileExists)
                {
                    writer.WriteLine("CajeroID,Nombre,Apellido1,Apellido2");
                }
                writer.WriteLine($"{cajero.CajeroID},{cajero.Nombre},{cajero.Apellido1},{cajero.Apellido2}");
            }
        }
    }
}
