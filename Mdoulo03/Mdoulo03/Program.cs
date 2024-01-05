using Modulo03.models;

Console.WriteLine("Olá, Bem vindos a Software Tech!");

Funcionario funcionario = new Funcionario();

funcionario.Nome = "Andre";
funcionario.Cpf = "123456";
funcionario.Salario = 2000.0m;
Console.WriteLine(funcionario.Comissao());

Progamador diretor = new Progamador();
diretor.Nome = "Marcelino";
diretor.Cpf = "123456";
diretor.Salario = 20000.0m;

Gerenciador gerenciador = new Gerenciador();
gerenciador.Registrar(funcionario);
gerenciador.Registrar(diretor);
Console.WriteLine($"Total de bonificacao {gerenciador.TotalComissao}");