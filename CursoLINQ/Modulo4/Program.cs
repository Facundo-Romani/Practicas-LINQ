//=====================================================================================================//

// Select.

//using Modulo4;

//var personas = new List<Persona>() {
//        new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//        new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//        new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//        new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
//        new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
//};


//var nombres = personas.Select(p => p.Nombre).ToList();

//var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad }).ToList();  // Mapear a Obj Anónimo.

//var nombresYEdadesDTO = personas.Select(p => new PersonaDTO { Nombre = p.Nombre, Edad = p.Edad }).ToList(); // Mapear hacia clase.

//var numeros = Enumerable.Range(1, 5).ToList();

//var numerosx2 = numeros.Select(n => n * 2).ToList();

//var personasConIndice = personas.Select((p, indice) => new { Persona = p, Indice = indice + 1 }).ToList();

//foreach (var item in personasConIndice)
//{
//    Console.WriteLine($"{item.Indice} = {item.Persona.Nombre}");
//}

//var a = 3;

//=====================================================================================================//

// SelectMany.

using Modulo4;
using System.Reflection;

var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
                            new Persona { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
                            new Persona { Nombre = "Alejandro", Telefonos = { "712-132" } },
                            new Persona { Nombre = "Valentina" }
    };


//var telefonos = personas.SelectMany(p => p.Telefonos).ToList();

//int[] numeros = { 1, 2, 3 };

//var personasYNumeros = personas.SelectMany(p => numeros, (personas, numeros) => new
//{
//    Persona = personas,
//    Numeros = numeros
//});

//foreach (var item in personasYNumeros)
//{
//    Console.WriteLine($"{item.Persona} - {item.Numeros}");
//}

var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (persona, telefono) => new
{
    Personas = persona,
    Telefonos = telefono
});

foreach (var item in personasYTelefonos)
{
    Console.WriteLine($"{item.Personas.Nombre} y su telefono es {item.Telefonos}");
}

//var a = 3;
