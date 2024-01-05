using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo02.GerenciamentoMemoria;

internal class TiposAnonimos
{
    public void Executar()
    {
        var person = new { FirstName = "John", LastName = "Doe", year = 26 };
        Console.WriteLine(person.FirstName + " " + person.LastName);
    }
}
