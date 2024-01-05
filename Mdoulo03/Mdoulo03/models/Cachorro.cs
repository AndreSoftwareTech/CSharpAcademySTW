using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.models
{
    internal class Cachorro : Animal
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public Cachorro() 
        { 
        }
        public Cachorro( string especie) : base(especie)
        {
           

        }
        public override void Comer()
        {
            Console.WriteLine($"O Cachorro {this.Nome} da raca {this.Raca} esta comendo");
           
        }
        public override string ToString()
        {
           return base.ToString() + $"{Nome} {Raca}";
        }
    }
}
