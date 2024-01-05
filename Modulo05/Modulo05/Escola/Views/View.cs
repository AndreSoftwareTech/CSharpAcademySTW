using Modulo05.Escola.Models;
using Modulo05.Escola.Services;
using System;


namespace Modulo05.Escola.Views
{
    public class View
    {
        public  void Main()
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
                            Console.Write("Digite Sua matricula: ");
                            aluno.Matricula = Console.ReadLine();
                            Console.Write("Digite Seu Nome: ");
                            aluno.Nome = Console.ReadLine();
                            Console.Write("Digite Seu SobreNome: ");
                            aluno.Sobrenome = Console.ReadLine();
                            crudAluno.Create(aluno);
                            Console.WriteLine("Aluno criado com sucesso.");
                        }
                        else if (cond1 == "2")
                        {
                            crudAluno.Read();
                        }
                        else if (cond1 == "3")
                        {
                            Console.Write("Digite o ID do aluno que deseja atualizar: ");
                            int idParaAtualizar = int.Parse(Console.ReadLine());

                            // Localiza o aluno que será atualizado
                            Aluno alunoParaAtualizar = crudAluno.Read().FirstOrDefault(a => a.Id == idParaAtualizar);

                            if (alunoParaAtualizar != null)
                            {
                                Console.Write("Digite Sua nova matricula: ");
                                alunoParaAtualizar.Matricula = Console.ReadLine();
                                Console.Write("Digite Seu outro Nome: ");
                                alunoParaAtualizar.Nome = Console.ReadLine();
                                Console.Write("Digite Seu outro SobreNome: ");
                                alunoParaAtualizar.Sobrenome = Console.ReadLine();

                                crudAluno.Update(alunoParaAtualizar);
                            }
                            else
                            {
                                Console.WriteLine("Aluno não encontrado para atualização.");
                            }
                        }
                        else if (cond1 == "4")
                        {
                            Console.WriteLine("Lista de alunos cadastrados:");
                            var alunosCadastrados = crudAluno.Read();
                            if (alunosCadastrados.Any())
                            {
                                Console.WriteLine("Estes são os alunos cadastrados:");
                                foreach (var a in alunosCadastrados)
                                {
                                    Console.WriteLine($"ID: {a.Id}, Nome: {a.Nome}");
                                }
                                Console.Write("Digite o ID do aluno que deseja deletar: ");
                                int idParaDeletar = int.Parse(Console.ReadLine());
                                crudAluno.Delete(idParaDeletar);
                            }
                            else
                            {
                                Console.WriteLine("Não há alunos cadastrados para deletar.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }
                        break;


                    case "2":

                        CrudBase crudProfessor = new CrudBase();
                        Professor professor = new Professor();
                        Console.WriteLine("Você escolheu Professor.");
                        Console.Write("O que deseja fazer?\n1 - Criar\n2 - Carregar\n3 - Alterar\n4 - Deletar\n");
                        string cond2 = Console.ReadLine();

                        if (cond2 == "1")
                        {
                            Console.Write("Digite o nome do professor: ");
                            professor.Nome = Console.ReadLine();
                            Console.Write("Digite a especialização do professor: ");
                            professor.Especializacao = Console.ReadLine();
                            crudProfessor.Create(professor);
                            Console.WriteLine("Professor cadastrado com sucesso.");
                        }
                        else if (cond2 == "2")
                        {
                            Console.WriteLine("Lista de Professores:");
                            var professoresCadastrados = crudProfessor.Read();
                            if (professoresCadastrados.Any())
                            {
                                Console.WriteLine("Estes são os professores cadastrados:");
                                foreach (var p in professoresCadastrados)
                                {
                                    Console.WriteLine($"ID: {p.Id}, Nome: {p.Nome}");
                                }
                                // Operação de leitura específica de um professor
                            }
                            else
                            {
                                Console.WriteLine("Não há professores cadastrados.");
                            }
                        }
                        else if (cond2 == "3")
                        {
                            Console.Write("Digite o ID do professor que deseja atualizar: ");
                            int idParaAtualizar = int.Parse(Console.ReadLine());

                            Professor professorParaAtualizar = crudProfessor.Read().FirstOrDefault(p => p.Id == idParaAtualizar);

                            if (professorParaAtualizar != null)
                            {
                                Console.Write("Digite o novo nome do professor: ");
                                professorParaAtualizar.Nome = Console.ReadLine();
                                Console.Write("Digite a nova especialização do professor: ");
                                professorParaAtualizar.Especializacao = Console.ReadLine();

                                crudProfessor.Update(professorParaAtualizar);
                                Console.WriteLine("Professor atualizado com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Professor não encontrado para atualização.");
                            }
                        }
                        else if (cond2 == "4")
                        {
                            Console.WriteLine("Lista de professores cadastrados:");
                            var professoresCadastrados = crudProfessor.Read();
                            if (professoresCadastrados.Any())
                            {
                                Console.WriteLine("Estes são os professores cadastrados:");
                                foreach (var p in professoresCadastrados)
                                {
                                    Console.WriteLine($"ID: {p.Id}, Nome: {p.Nome}");
                                }
                                Console.Write("Digite o ID do professor que deseja deletar: ");
                                int idParaDeletar = int.Parse(Console.ReadLine());
                                crudProfessor.Delete(idParaDeletar);
                                Console.WriteLine("Professor deletado com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Não há professores cadastrados para deletar.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }

                        break;

                    // O código para os cases 3 (Matéria) e 4 (Turma) seguirá a mesma lógica, adaptando às suas respectivas classes e operações CRUD.

                    case "3":
                        CrudBase crudMateria = new CrudBase();
                        Console.WriteLine("Você escolheu Matéria.");
                        Console.Write("O que deseja fazer?\n1 - Criar\n2 - Carregar\n3 - Alterar\n4 - Deletar\n");
                        string cond3 = Console.ReadLine();

                        if (cond3 == "1")
                        {
                            Materia materia = new Materia();
                            Console.WriteLine("Digite o nome da matéria:");
                            materia.Nome = Console.ReadLine();
                            Console.WriteLine("Digite a descrição da matéria:");
                            materia.Descricao = Console.ReadLine();
                            crudMateria.Create(materia);
                        }
                        else if (cond3 == "2")
                        {
                            crudMateria.Read();
                        }
                        else if (cond3 == "3")
                        {
                            Console.WriteLine("Você escolheu Alterar Matéria.");
                            Console.WriteLine("Lista de matérias cadastradas:");
                            var materias = crudMateria.Read();

                            if (materias.Count > 0)
                            {
                                Console.WriteLine("Escolha o número da matéria que deseja alterar:");
                                for (int i = 0; i < materias.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {materias[i].Nome}");
                                }

                                int opcao = int.Parse(Console.ReadLine());
                                if (opcao > 0 && opcao <= materias.Count)
                                {
                                    Materia materiaParaAtualizar = materias[opcao - 1];

                                    Console.WriteLine("Digite o novo nome da matéria:");
                                    materiaParaAtualizar.Nome = Console.ReadLine();
                                    Console.WriteLine("Digite a nova descrição da matéria:");
                                    materiaParaAtualizar.Descricao = Console.ReadLine();

                                    crudMateria.Update(materiaParaAtualizar);
                                }
                                else
                                {
                                    Console.WriteLine("Opção inválida");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não há matérias cadastradas para alterar.");
                            }
                        }
                        else if (cond3 == "4")
                        {
                            Console.WriteLine("Você escolheu Deletar Matéria.");
                            Console.WriteLine("Lista de matérias cadastradas:");
                            var materias = crudMateria.Read();

                            if (materias.Count > 0)
                            {
                                Console.WriteLine("Escolha o número da matéria que deseja deletar:");
                                for (int i = 0; i < materias.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {materias[i].Nome}");
                                }

                                int opcao = int.Parse(Console.ReadLine());
                                if (opcao > 0 && opcao <= materias.Count)
                                {
                                    Materia materiaParaDeletar = materias[opcao - 1];
                                    crudMateria.Delete(materiaParaDeletar.Id);
                                }
                                else
                                {
                                    Console.WriteLine("Opção inválida");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não há matérias cadastradas para deletar.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida");
                        }
                        break;

                    case "4":
                        CrudBase crudTurma = new CrudBase();  
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
