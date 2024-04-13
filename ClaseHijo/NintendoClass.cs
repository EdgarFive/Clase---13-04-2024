using Clase___13_04_2024.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase___13_04_2024.ClaseHijo
{
    internal class NintendoClass : CCConsola
    {
        public bool Esportatil { get; set; }

        public string MostrarDetallesNintendo()
        {
            MostrarDetalles();
            return $"Es portátil: {Esportatil}";
        }
    }
}
