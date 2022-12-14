// Ejecución Diferida.

//int[] numeros = { 1, 2, 3, 4 };

int[] numeros2 = Enumerable.Range(1, 5).ToArray();

// Sitaxis 1 de methods.
var numerosPares = numeros2.Where(n => { Console.WriteLine($"Evaluando si {n} es par"); return n % 2 == 0; }).ToList();

var numerosPares2 = numeros2.Where(n => { Console.WriteLine($"Evaluando si {n} es par"); return n % 2 == 0; });

// Con .ToList();
foreach (var numero in numerosPares)
{
    Console.WriteLine($" si {numero} es par");
}

// Sin .ToList();
foreach (var numero in numerosPares2)
{
    Console.WriteLine($" si {numero} es par");
}

// Sitaxis 2 de querys.
//var numerosPares2 = (from n in numeros
//                     where n % 2 == 0
//                     select n).ToList();
