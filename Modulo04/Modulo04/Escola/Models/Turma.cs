using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo04.Escola.Models
{
    public class Turma: BaseModel
    {
        //A composicao desta esta ligada a regra de negocio do sistema
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Materia> Materias { get; set; }
    }
}
