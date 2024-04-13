using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase___13_04_2024.ClaseBase
{
    internal class CCConsola
    {
        public string Marca { get; set; }
        public int aniolanzamiento { get; set; }

        public void MostrarDetalles()
        {
            Console.WriteLine($"1. Marca: {Marca}\n2. Año lanzamiento: {aniolanzamiento}");
        }
    }
}
