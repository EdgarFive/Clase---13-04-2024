using Clase___13_04_2024.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase___13_04_2024.ClaseHijo
{
    internal class XboxClass : CCConsola
    {
        public bool LectordeDisco { get; set; }

        public string MostrardetellesXbox()
        {
            MostrarDetalles();
            return $"Lector de disco: {LectordeDisco}";
        }
    }
}
