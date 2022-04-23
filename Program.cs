using System;
using System.Collections.Generic;

namespace ExercicioHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<FuncionarioTerceirizado> funcionarioTerceirizados = new List<FuncionarioTerceirizado>();

            Console.WriteLine("Digite a quantidade de funcionários que gostaria de cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Este funcionário é terceirizado? (s/n):");
                char resp = char.Parse(Console.ReadLine());

                if(resp == 's' || resp == 'S')
                {
                    Console.WriteLine("Digite o nome do funcionário terceirizado: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a quantidade de horas trabalhadas: ");
                    double horas = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da hora trabalhada: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.Write("Digite a despesa adicional: ");
                    double desp = double.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("");



                    funcionarioTerceirizados.Add(new FuncionarioTerceirizado(nome, horas, valor , desp));


                }

                if ( resp == 'n' || resp == 'N')
                {
                    Console.WriteLine("Digite o nome do funcionário :");
                    string nome = Console.ReadLine();
                    Console.Write("Digite a quantidade de horas trabalhadas: ");
                    double horas = double.Parse(Console.ReadLine());
                    Console.Write("Digite o valor da hora trabalhada: ");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine("");
                   


                    funcionarios.Add(new Funcionario(nome, horas, valor));

                }


            }

            foreach ( Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj.ToString());  
            }

            foreach (FuncionarioTerceirizado obj in funcionarioTerceirizados)
            {
                Console.WriteLine(obj.ToString());
            }



        }
    }
}
