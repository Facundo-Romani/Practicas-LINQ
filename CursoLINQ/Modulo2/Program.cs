// Función Where.

int[] numeros = Enumerable.Range(1, 20).ToArray();

//var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

//Console.WriteLine("Los Numeros Impares son:");

//foreach (var numero in numerosImpares)
//{
//    Console.WriteLine($"{numero}");
//}

var numerosImparesMayorQue10 = numeros.Where(n => n %2 == 1 && n > 10).ToList();

Console.WriteLine("Los Numeros Impares mayor a 10 son:");

foreach (var numero in numerosImparesMayorQue10) 
{
    Console.WriteLine($"{numero}");
}


