using Clase___13_04_2024.ClaseBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase___13_04_2024.ClaseHijo
{
    internal class PlaystationClass : CCConsola
    {
        public string Modelocontrolador { get; set; }

        public string MostrarDetallesPlaystation()
        {
            MostrarDetalles();
            return $"Modelo de controlador : {Modelocontrolador}";
        }
    }
}
