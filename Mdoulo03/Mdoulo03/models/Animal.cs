using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.models
{
    internal class Animal
    {
        private static int _id;
        public int ID { get; private set; }
        public string Especie { get; set; }
        public Animal() 
        {
            this.ID = ++_id;
        }
        public Animal(string especie)
        {
            Especie = especie;
            this.ID = ++_id;
        }
        public virtual void Comer()
        {
            Console.WriteLine("O Animal esta comendo");
        }
        public override string ToString() {
            return $"{this.ID}\n {this.Especie}";
        }
    }
}
