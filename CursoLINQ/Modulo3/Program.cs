//=====================================================================================================//

// OrderBy y OrderByDescending.

using Modulo3;

var personas = new List<Persona>() {
        new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
        new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
        new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
        new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
        new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

//var ordenarPorEdad = personas.OrderBy(p => p.Edad);
//var ordenarPorEdad1 = personas.OrderByDescending(p => p.Edad);

//foreach (var persona in ordenarPorEdad)
//{
//    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad}");
//}

//foreach(var persona in ordenarPorEdad1)
//{
//    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad}");
//}

//int[] numeros = { 1, 5, 12, 2, 3, 111, 6 };

//foreach (var numero in numeros.OrderBy(x => x))
//{
//    Console.WriteLine(numero);
//}

//=====================================================================================================//

// ThenBy y ThenByDescending.

//var ordenarPorEdad = personas.OrderBy(p => p.Edad).ThenBy(p => p.Nombre);
//var ordenarPorEdad = personas.OrderBy(p => p.Edad).ThenByDescending(p => p.Nombre);

//foreach (var persona in ordenarPorEdad)
//{
//    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad}");
//}

//=====================================================================================================//

// Reverse.

//var numeros = Enumerable.Range(1, 20).Reverse();

//personas.Reverse();

//var personasInvertido = personas.AsEnumerable().Reverse().ToList();



