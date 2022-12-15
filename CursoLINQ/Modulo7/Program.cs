//=====================================================================================================//

// Take y TakeLast.

var numeros = Enumerable.Range(1, 100);

//var primeros10Numeros = numeros.Take(10).ToList();

//var ultimos10Numeros = numeros.TakeLast(10).ToList();

//=====================================================================================================//

// Skip y SkipLast.

//var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

//var penultimoLoteDe10 = numeros.SkipLast(10).TakeLast(10).ToList();

//var a = 4;

//=====================================================================================================//

// Paginación.

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Página {i}");
    var paginado = numeros.Paginar(i, 10);
    foreach (var item in paginado)
    {
        Console.WriteLine(item);
    }
}

public static class IEnumerableExTensions
{
    public static IEnumerable<T> Paginar<T>(this IEnumerable<T> coleccion, int pagina, int tamañoLote)
    {
        return coleccion.Skip((pagina - 1) * tamañoLote).Take(tamañoLote);
    }
}
