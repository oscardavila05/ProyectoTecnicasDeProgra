using System;
using System.Collections.Generic;
using System.IO;
using Ferreteria.Modelos;
using System.Linq;

namespace Ferreteria.Controladores
{
    public class ControladorCajero
    {
        private List<Cajero> cajeros;

        public ControladorCajero()
        {
            cajeros = new List<Cajero>();

            //carga la lilsta desde el csv
            CargarCajerosDesdeCsv();
        }

        //metodo para guardar el cajero nuevo en el csv
        public void AgregarCajero(Cajero cajero)
        {
            cajeros.Add(cajero);

            //guarda la lista de cajeros en el csv
            GuardarCajerosEnCsv();
        }

        public void ActualizarCajero(Cajero cajeroActualizado)
        {
            var cajero = cajeros.FirstOrDefault(c => c.CajeroID == cajeroActualizado.CajeroID);
            if (cajero != null)
            {
                cajero.Nombre = cajeroActualizado.Nombre;
                cajero.Apellido1 = cajeroActualizado.Apellido1;
                cajero.Apellido2 = cajeroActualizado.Apellido2;
                cajero.Telefono = cajeroActualizado.Telefono;
                cajero.CorreoElectronico = cajeroActualizado.CorreoElectronico;
                GuardarCajerosEnCsv();
            }
        }


        //metodo para actualizar el cajero en el csv
        public List<Cajero> ObtenerCajeros()
        {
            return cajeros;
        }


        //metodo para guardar los cajeros en el csv
        private void GuardarCajerosEnCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cajeros.csv");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine("CajeroID,Nombre,Apellido1,Apellido2,Telefono,CorreoElectronico");
                foreach (var cajero in cajeros)
                {
                    writer.WriteLine($"{cajero.CajeroID},{cajero.Nombre},{cajero.Apellido1},{cajero.Apellido2},{cajero.Telefono},{cajero.CorreoElectronico}");
                }
            }
        }


        //metodo para cargar la lista de cajeros ene l csv
        private void CargarCajerosDesdeCsv()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cajeros.csv");

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
                        if (values.Length == 6)
                        {
                            var cajero = new Cajero
                            {
                                CajeroID = values[0],
                                Nombre = values[1],
                                Apellido1 = values[2],
                                Apellido2 = values[3],
                                Telefono = values[4],
                                CorreoElectronico = values[5]
                            };
                            cajeros.Add(cajero);
                        }
                        else
                        {
                            // metodo de Log o handle del error del formato del csv
                            Console.WriteLine($"Skipping invalid line: {line}");
                        }
                    }
                }
            }
        }
    }
}
