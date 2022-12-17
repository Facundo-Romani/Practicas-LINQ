//=====================================================================================================//

// InnerJoin.

using Modulo4;
using Modulo9;

var personas = new List<Persona>()
{
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Alejandro", EmpresaId = 3 },
                            new Persona { Nombre = "Valentina",  EmpresaId = 2 },
                            new Persona { Nombre = "Roberto",  EmpresaId = 3 },
                            new Persona { Nombre = "Eugenia"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
};


var empresas = new List<Empresa>()
{
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"},
                new Empresa{Id = 4, Nombre = "Ferreteria Lorenzo"}
};


//var personaConEmpresa = personas.Join(empresas, p => p.EmpresaId, e => e.Id, (personas, empresas) => new
//{
//    Persona = personas,
//    Empresa = empresas
//});

//foreach (var i in personaConEmpresa)
//{
//    Console.WriteLine($"{i.Persona.Nombre} pertenece a {i.Empresa.Nombre}");
//}

//=====================================================================================================//

// GroupJoin.

var empresasYSusEmpleados = empresas.GroupJoin(personas, e => e.Id, p => p.EmpresaId,
                (empresa, personas) => new { Empresa = empresa, Personas = personas });


foreach (var item in empresasYSusEmpleados)
{
    Console.WriteLine($"Las siguientes personas trabajan en {item.Empresa.Nombre}");

    foreach (var persona in item.Personas)
    {
        Console.WriteLine($"-{persona.Nombre}");
    }
}

