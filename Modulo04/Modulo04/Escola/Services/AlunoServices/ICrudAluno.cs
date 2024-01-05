using Modulo04.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo04.Escola.Services.AlunoServices
{
    internal interface ICrudAluno
    {
        void Create(Aluno model);
        List<Aluno> Read();
        void Update(Aluno model);
        void Delete(int id);
    }
}
