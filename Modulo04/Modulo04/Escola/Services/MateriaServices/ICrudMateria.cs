using Modulo04.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo04.Escola.Services.MateriaServices
{
    internal interface ICrudMateria
    {
        void Create(Materia model);
        List<Materia> Read();
        void Update(Materia model);
        void Delete(int id);
    }
}
