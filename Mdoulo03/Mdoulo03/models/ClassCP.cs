using Modulo03.estrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo03.models
{
    internal class ClassCP : ClassConta
    {

        public ClassCP() 
        {
        }
        public override decimal Sacar(decimal valor)
        {
            return base.Sacar(valor);
        }
        //
        public override string ToString() { return base.ToString(); }
    }
}
