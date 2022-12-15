//=====================================================================================================//

// All.

var personas = new List<Persona>() 
{
                    new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                    new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
};


//var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);

//var sonTodosSolteros = personas.All(p => p.Soltero);

//=====================================================================================================//

// Any.

//var existeMenor = personas.Any(p => p.Edad < 18);

//var existePersonaMayorDe20 = personas.Any(p => p.Edad > 20);

//var n = 3;

//=====================================================================================================//

// Contains.

var numeros = Enumerable.Range(1, 5);

var estaElNumero3 = numeros.Contains(3);

var estaElNumero20 = numeros.Contains(20);

var n = 3;