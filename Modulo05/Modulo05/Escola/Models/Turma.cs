using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo05.Escola.Models
{
    public class Turma:BaseModel
    {

        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Materia> Materias { get; set; }
    }
}
