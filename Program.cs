

using Clase___13_04_2024.ClaseBase;
using Clase___13_04_2024.ClaseHijo;

NintendoClass ccnintendo = new NintendoClass();

ccnintendo.Esportatil = true;
ccnintendo.Marca = "Nintendo";
ccnintendo.aniolanzamiento = 2017;

string resultado = ccnintendo.MostrarDetallesNintendo();
Console.WriteLine(resultado);

Console.WriteLine("");




PlaystationClass ccplay = new PlaystationClass();
ccplay.Modelocontrolador = "Soy Batman";
ccplay.Marca = "PlayStation";
ccplay.aniolanzamiento = 2017;

resultado = ccplay.MostrarDetallesPlaystation();
Console.WriteLine(resultado);

Console.WriteLine("");




XboxClass ccxbox = new XboxClass();

ccxbox.Marca = "Xbox";
ccxbox.aniolanzamiento = 2015;
ccxbox.LectordeDisco = true;

resultado = ccxbox.MostrardetellesXbox();
Console.WriteLine(resultado);



/*
CCConsola ccconsola1 = new CCConsola();

ccconsola1.Marca = "Toyota";
ccconsola1.aniolanzamiento = 2023;

ccconsola1.MostrarDetalles();
*/






