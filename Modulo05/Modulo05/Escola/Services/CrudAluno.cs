using Modulo05.Escola.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo05.Escola.Services
{
    internal class CrudAluno : ICrud<Aluno>
    {
        public void Create(Aluno model)
        {
            StreamWriter Writer = new StreamWriter("C:\\Banco\\Aluno.txt", true);
            string linha = model.ToString();
            try
            {
                Writer.WriteLine(linha);
                Writer.Close();
            }catch (Exception ex) { }
        }

        public void Delete(int id)
        {
            List<Aluno> lista = Read().ToList();
            Aluno aluno = lista.Find(x => x.Id == id);
            if (aluno != null)
            {
                lista.Remove(aluno);
                StreamWriter Writer = new StreamWriter("C:\\Banco\\Aluno.txt");
                foreach(var aluninho in lista)
                {
                    Writer.WriteLine(aluninho.ToString());
                }
                Writer.Close();

            }
        }

        public IEnumerable<Aluno> Read()
        {
            StreamReader reader = new StreamReader("C:\\Banco\\Aluno.txt");
            List<Aluno> alunos = new List<Aluno>();
            string linha = reader.ReadLine();

            while (linha != null)
            {
                var aluno = linha.Split(';');
                Aluno model = new Aluno { Id = Convert.ToInt32(aluno[0]), Matricula = aluno[1], Nome = aluno[2], Sobrenome = aluno[3] };
                alunos.Add(model);
                linha = reader.ReadLine();  
            }
            reader.Close();
            return alunos;
        }

        public void Update(Aluno model)
        {
            List<Aluno> lista = Read().ToList();
            Aluno aluno = lista.Find(x => x.Id == model.Id);

            if (aluno != null)
            {
                aluno.Matricula = model.Matricula;
                aluno.Nome = model.Nome;
                aluno.Sobrenome = model.Sobrenome;

                StreamWriter Writer = new StreamWriter("C:\\Banco\\Aluno.txt");
                foreach (var aluninho in lista)
                {
                    Writer.WriteLine(aluninho.ToString());
                }
                Writer.Close();

            }
        }
    }
    }

