//=====================================================================================================//

// Función Where.

//int[] numeros = Enumerable.Range(1, 20).ToArray();

//var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

//Console.WriteLine("Los Numeros Impares son:");

//foreach (var numero in numerosImpares)
//{
//    Console.WriteLine($"{numero}");
//}

//var numerosImparesMayorQue10 = numeros.Where(n => n %2 == 1 && n > 10).ToList();

//Console.WriteLine("Los Numeros Impares mayor a 10 son:");

//foreach (var numero in numerosImparesMayorQue10) 
//{
//    Console.WriteLine($"{numero}");
//}


//=====================================================================================================//

// Where con Objetos.

using Modulo2;
using System.Collections.Generic;

var personas = new List<Persona>() {
        new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
        new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
        new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
        new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
        new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};


//var personasMenoresA25 = personas.Where(p => p.Edad <= 25).ToList();

//Console.WriteLine("Las personas menores a 25 son:");

//foreach (var persona in personasMenoresA25)
//{
//    Console.WriteLine($"{persona.Nombre} tiene: {persona.Edad} años.");
//}


//var personasSolteras = personas.Where(p => p.Soltero).ToList();
//var personasSolteras = personas.Where(p => p.Soltero && p.Edad < 25 ).ToList();

//foreach (var persona in personasSolteras)
//{
//    Console.WriteLine($"{persona.Nombre} es soltero/a");
//}

//var personasConMenosDe3MesesEnLaEmpresa = personas.Where(p => p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();

//foreach (var persona in personasConMenosDe3MesesEnLaEmpresa)
//{
//    Console.WriteLine($"{persona.Nombre} ingreso hace menos de tres meses y su fecha fue {persona.FechaIngresoALaEmpresa} ");
//}

//=====================================================================================================//

// First y FirstOrDefault.

//var primeraPersona = personas.First();
//var primeraPersona1 = personas.FirstOrDefault();

//var paises = new List<string>();

//try
//{
//    var primerPais1 = paises.First();
//}
//catch (Exception ex)
//{

//	throw ex;
//}

//var primerPais2 = paises.FirstOrDefault(); // Null o lo que tenga la List o Array.

//var primeraPersonaSoltera = personas.FirstOrDefault(p => p.Soltero); 

//=====================================================================================================//

// Last y LastOrDefault

//var ultimaPersona = personas.Last();
//var ultimaPersona2 = personas.LastOrDefault();
//var ultimaPersonaSoltera = personas.Last(p => p.Soltero);

//var a = 1;

//=====================================================================================================//

// ElementAt y ElementAtOrDefault.

//var personaPorIndice = personas.ElementAt(0);

//var personaPorIncice2 = personas.ElementAtOrDefault(1);

//var a = 1;

//=====================================================================================================//

// Single y SingleOrDefault.

//var personasMayorDe60 = personas.Single(p => p.Edad > 60);

//try
//{
//    //var personaMenorDe22 = personas.Single(p => p.Edad < 22);
//    //Console.WriteLine($"{personaMenorDe22.Nombre}");
//    // var personaMayorA100 = personas.SingleOrDefault(p => p.Edad > 100); // No entra al Catch.

//}
//catch (Exception ex)
//{
//    Console.WriteLine("Hubo un error, arreglo vacío");
//}

//try
//{
//    var personaMayor5 = personas.SingleOrDefault(p => p.Edad > 5); // Más de un elemento.
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Hubo otro error, arreglo con mas de un elemento");
//}


//=====================================================================================================//

// OfType.

//var listado = new List<object>() { "Felipe", 1, 2, "Claudia", true };

//var strings = listado.OfType<string>();
//var numeros = listado.OfType<int>();

//var a = 1;

var listadoAnimales = new List<Animal>(){ new Perro(){Nombre = "Firulais"}, new Gato(){Nombre = "Félix"}};

var perros = listadoAnimales.OfType<Perro>();
var gatos = listadoAnimales.OfType<Gato>();

var a = 1;

public abstract class Animal
{
    public abstract string? Nombre { get; set; }
}

public class Perro : Animal
{
    public override string? Nombre { get; set; }
}

public class Gato : Animal
{
    public override string? Nombre { get; set; }
}

