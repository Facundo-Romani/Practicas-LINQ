//=====================================================================================================//

// Count y LongCount.

using Modulo4;

//var personas = new List<Persona>()
//{
//                new Persona { Nombre = "Eduardo", Soltero = true },
//                new Persona { Nombre = "Nidia", Soltero = true },
//                new Persona { Nombre = "Alejandro", Soltero = true },
//                new Persona { Nombre = "Valentina", Soltero = false }
// };

//Console.WriteLine($"La cantidad de personas es {personas.Count()}");

//Console.WriteLine($"La cantidad de personas solteras es {personas.Count(p => p.Soltero)}");

//Console.WriteLine($"int max {int.MaxValue.ToString("N")}"); // Maximo de valor en int.

//personas.LongCount();

//=====================================================================================================//

// Suma , Max y Min.

var personas = new List<Persona>() {
                                new Persona { Nombre = "Eduardo", Edad = 19, },
                                new Persona { Nombre = "Nidia", Edad = 25 },
                                new Persona { Nombre = "Alejandro", Edad = 30 },
                                new Persona { Nombre = "Valentina", Edad = 22 }
                                };

//var numeros = Enumerable.Range(1, 5);

//Console.WriteLine($"La suma es : {numeros.Sum()}");

//Console.WriteLine($"La suma de las edades es: {personas.Sum(p => p.Edad)}");

//Console.WriteLine($"La edad MAXIMA de las personas es {personas.Max(p => p.Edad)}");

//Console.WriteLine($"La edad MAXIMA de las personas es {personas.Min(p => p.Edad)}");

//=====================================================================================================//

// MixBy Maxby.

//var personasDeMayorEdad = personas.MaxBy(p => p.Edad);

//var personasDeMenorEdad = personas.MinBy(p => p.Edad);

//var a = 3;

//=====================================================================================================//

// Promedio.

//Console.WriteLine($"El promedio de las edades de las personas es { personas.Average(p => p.Edad)}");

//=====================================================================================================//

// Agregado.

var numeros = Enumerable.Range(1, 5);

var resultado = numeros.Aggregate((a , b) => a * b); //1x2x3x4x5.

Console.WriteLine(resultado);

var resultadoConValorInicial = numeros.Aggregate(10, (a, b) => a * b);

Console.WriteLine("El resultado con el valor seed es: " + resultadoConValorInicial);