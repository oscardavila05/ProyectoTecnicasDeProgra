using System.Collections.Generic;
using System.IO;
using Ferreteria_Proyecto_Tecnicas_de_Progra;

namespace FerreteriaControlador
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
            string filePath = "cajeros.csv";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{cajero.CajeroID},{cajero.Nombre},{cajero.Apellido1},{cajero.Apellido2}");
            }
        }
    }
}