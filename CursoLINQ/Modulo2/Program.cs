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

var personas = new List<Persona>() {
        new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
        new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
        new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
        new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
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

var personasConMenosDe3MesesEnLaEmpresa = personas.Where(p => p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();

foreach (var persona in personasConMenosDe3MesesEnLaEmpresa)
{
    Console.WriteLine($"{persona.Nombre} ingreso hace menos de tres meses y su fecha fue {persona.FechaIngresoALaEmpresa}");
}