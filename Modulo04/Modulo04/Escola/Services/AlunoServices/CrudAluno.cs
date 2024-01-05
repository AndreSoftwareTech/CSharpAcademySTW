using Modulo04.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Modulo04.Escola.Services.AlunoServices
{
    internal class CrudAluno : ICrudAluno
    {
        private static List<Aluno> alunos = new List<Aluno>();
        private static int ProximoId = 1; // Inicialize o ID corretamente

        public void Create(Aluno model)
        {
            model.Id = ProximoId++;
            alunos.Add(model);
        }

        public void Delete(int id)
        {
            // Procurar o aluno com o ID fornecido e removê-lo da lista
            Aluno alunoParaExcluir = alunos.FirstOrDefault(a => a.Id == id);

            if (alunoParaExcluir != null)
            {
                alunos.Remove(alunoParaExcluir);
            }
        }

        public List<Aluno> Read()
        {
            // Retornar a lista de todos os alunos
            return alunos;
        }

        public void Update(Aluno model)
        {
            // Procurar o aluno com o ID fornecido
            Aluno alunoExistente = alunos.FirstOrDefault(a => a.Id == model.Id);
            if (alunoExistente != null)
            {
                // Atualizar as informações do aluno existente
                alunoExistente.Nome = model.Nome;
                alunoExistente.Sobrenome = model.Sobrenome;
                alunoExistente.Matricula = model.Matricula;
            }
            else
            {
                // Lidar com o caso em que o aluno não foi encontrado
                throw new ArgumentException("Aluno não encontrado");
            }
        }
    }
}
