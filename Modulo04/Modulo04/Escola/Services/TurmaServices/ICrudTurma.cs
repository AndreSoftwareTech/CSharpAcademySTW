using Modulo04.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo04.Escola.Services.TurmaServices
{
    internal interface ICrudTurma
    {
        void Create(Turma model);
        List<Turma> Read();
        void Update(Turma model);
        void Delete(int id);
    }
}
