using Modulo04.Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo04.Escola.Services.ProfessorService
{
    internal class CrudProfessor : ICrudProfessor
    {
        public void Create(Professor model)
        {
            string linha;
            try
            {
                StreamWriter sw = new StreamWriter("Professor.txt", true);
                sw.WriteLine(model);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Professor> Read()
        {
            List<Professor> lista = new List<Professor>();
            string linha;
            try
            {

                StreamReader sr = new StreamReader("Professor.txt");
                linha = sr.ReadLine();
                while (linha != null)
                {
                    var professor = linha.Split(';');
                    Professor model = new Professor { Id = Convert.ToInt32(professor[0]), Matricula = professor[1], Nome = professor[2], Sobrenome = professor[3] };
                    lista.Add(model);
                    linha = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return lista;
        }

        public void Update(Professor model)
        {
            throw new NotImplementedException();
        }
    }
}
