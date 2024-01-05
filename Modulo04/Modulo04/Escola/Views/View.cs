using Modulo04.Escola.Models;
using Modulo04.Escola.Services.AlunoServices;
using Modulo04.Escola.Services.MateriaServices;
using Modulo04.Escola.Services.ProfessorService;
using Modulo04.Escola.Services.TurmaServices;
using System;


namespace Modulo04.Escola.Views
{
    public class View
    {
        public void Main()
        {
            string continuar;
            do
            {
                Console.WriteLine("Digite um valor: 1 - Aluno");
                Console.WriteLine("Digite um valor: 2 - Professor");
                Console.WriteLine("Digite um valor: 3 - Matéria");
                Console.WriteLine("Digite um valor: 4 - Turma");

                string var = Console.ReadLine();

                switch (var)
                {
                    case "1":
                        CrudAluno crudAluno = new CrudAluno();
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Você escolheu Aluno.");
                        Console.Write("O que deseja fazer?\n1 - Criar\n2 - Carregar\n3 - Alterar\n4 - Deletar\n");
                        string cond1 = Console.ReadLine();

                        if (cond1 == "1")
                        {
                            crudAluno.Create(aluno);
                            Console.WriteLine(aluno);
                        }
                        else if (cond1 == "2")
                        {
                            crudAluno.Read();
                        }
                        else if (cond1 == "3")
                        {
                            crudAluno.Update(aluno);
                        }
                        else if (cond1 == "4")
                        {
                            crudAluno.Delete(1);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }


                        break;
                    case "2":
                        CrudProfessor crudProfessor = new CrudProfessor();
                        Professor professor = new Professor();
                        Console.WriteLine("Você escolheu Professor.");
                        Console.Write("O que deseja fazer?\n1 - Criar\n2 - Carregar\n3 - Alterar\n4 - Deletar\n");
                        string cond2 = Console.ReadLine();

                        if (cond2 == "1")
                        {
                            crudProfessor.Create(professor);
                        }
                        else if (cond2 == "2")
                        {
                            crudProfessor.Read();
                        }
                        else if (cond2 == "3")
                        {
                            crudProfessor.Update(professor);
                        }
                        else if (cond2 == "4")
                        {
                            crudProfessor.Delete(1);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }

                        break;
                    case "3":
                        CrudMateria crudMateria = new CrudMateria();
                        Materia materia = new Materia();
                        Console.WriteLine("Você escolheu Matéria.");
                        Console.Write("O que deseja fazer?\n1 - Criar\n2 - Carregar\n3 - Alterar\n4 - Deletar\n");
                        string cond3 = Console.ReadLine();

                        if (cond3 == "1")
                        {
                            crudMateria.Create(materia);
                        }
                        else if (cond3 == "2")
                        {
                            crudMateria.Read();
                        }
                        else if (cond3 == "3")
                        {
                            crudMateria.Update(materia);
                        }
                        else if (cond3 == "4")
                        {
                            crudMateria.Delete(1);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }

                        break;
                    case "4":
                        CrudTurma crudTurma = new CrudTurma();
                        Turma turma = new Turma();
                        Console.WriteLine("Você escolheu Turma.");
                        Console.Write("O que deseja fazer?\n1 - Criar\n2 - Carregar\n3 - Alterar\n4 - Deletar\n");

                        string cond4 = Console.ReadLine();

                        if (cond4 == "1")
                        {
                            crudTurma.Create(turma);
                        }
                        else if (cond4 == "2")
                        {
                            crudTurma.Read();
                        }
                        else if (cond4 == "3")
                        {
                            crudTurma.Update(turma);
                        }
                        else if (cond4 == "4")
                        {
                            crudTurma.Delete(1);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }

                        break;
                    default:
                        Console.WriteLine("Valor não reconhecido.");
                        break;
                }

                Console.Write("Deseja Continuar (Sim/Não): ");
                continuar = Console.ReadLine();

            } while (continuar.ToLower() == "sim");
        }
    }
}
