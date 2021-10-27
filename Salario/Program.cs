using System;
using System.Collections.Generic;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazendo a lista
            List<Funcionario> funcionarios = new List<Funcionario>();
            //Entrada pro usuario de Funcionarios a serem registrados
            Console.WriteLine("Digite um número de Funcionarios a serem Registrados");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //vai mostrar a ordem de chegada dos hospedes
                Console.WriteLine($"Funcionario #{i}");
                //entrada pro usuario Digitar o ID do funcionario
                Console.WriteLine("Digite o Id Do funcionario: ");
                int id = int.Parse(Console.ReadLine());
                //entra pro usuario colocar o nome do funcionario
                Console.WriteLine("Digite o nome do funcionario: ");
                string nome = Console.ReadLine();
                //entrada pro usuario colocar o salario
                Console.WriteLine("Digite o salário do funcionario: ");
                double salario = double.Parse(Console.ReadLine());
                //adicionando elementos na lista 
                funcionarios.Add(new Funcionario { ID = id, Nome = nome, Salario = salario });
                Console.WriteLine("==============================");
            }
            //ID do funcionario para receber o aumento
            Console.WriteLine("Digite o id do funcionário que tera Aumento no salario: ");
            int IDFuncionario = int.Parse(Console.ReadLine());
            //procurando ID do funcionario
            var A = funcionarios.Find(x => x.ID == IDFuncionario);

            if (A != null)
            {
                //entrada pro usuario add a porcentagem que sera acrescentada no salario
                Console.WriteLine("Digite a porcentagem que sera acrescentada no salario: ");
                double B = double.Parse(Console.ReadLine());
                //Incrementando a porcentagem no salario
                A.Salarioincrementado(B);
            }
            else
            {
                //id de funcionario nao existe 
                Console.WriteLine("Id de funcionario não Encontrado!");
            }
            //lista atualizada
            Console.WriteLine("Atualização da lista:");
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Salario);
                Console.WriteLine("");
            }
        }
    }
}



