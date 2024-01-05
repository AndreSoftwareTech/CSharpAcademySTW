using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo05.Escola.Models
{
    public class Professor: Pessoa
    {
        //Composicao
        public string Especializacao { get; set; }
        public List<Materia> Materias { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{this.Materias};ss {this.Especializacao}";
        }
    }
}
