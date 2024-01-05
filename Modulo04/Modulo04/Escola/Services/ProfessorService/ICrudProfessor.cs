using Modulo04.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo04.Escola.Services.ProfessorService
{
    internal interface ICrudProfessor
    {
        void Create(Professor model);
        List<Professor> Read();
        void Update(Professor model);
        void Delete(int id);
    }
}
