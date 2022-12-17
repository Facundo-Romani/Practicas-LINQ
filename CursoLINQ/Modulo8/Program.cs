//=====================================================================================================//

// OrderBy.

using Modulo3;

var personas = new List<Persona>() 
{
            new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
            new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
            new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
            new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
            new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
            new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
            new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
};


//var agruparPorSoltero = personas.GroupBy(p => p.Soltero);


//foreach (var item in agruparPorSoltero)
//{
//    Console.WriteLine($"Grupo de personas solteros {item.Key} total {item.Count()}");

//    foreach (var persona in item)
//    {
//        Console.WriteLine($"{persona.Nombre}");
//    }
//}


var agrupamientoPorRangoEdad = personas.GroupBy(p => p.Edad / 5);


foreach (var item in agrupamientoPorRangoEdad)
{
    Console.WriteLine($"Grupo de las personas en el rango de edad {item.Key * 5} - {item.Key * 5 + 5 - 1}");

    foreach (var persona in item)
    {
        Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
    }
}

