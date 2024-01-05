using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo05.Escola.Models
{
    public class Pessoa: BaseModel
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            return $"{this.Id}; {this.Matricula}; {this.Nome}; {this.Sobrenome}";
        }
    }

}
