using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
     class Funcionario
    {
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }

        public double ValorHora { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, double horasTrabalhadas, double valorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorHora = valorHora;
        }
    
        public double CalcularSalario()
        {
            double salario  =  HorasTrabalhadas * ValorHora;
            return salario;
        }
        public override string ToString()
        {
            return "Nome do Funcionário: " + Nome + "  " + "Salário:"+ CalcularSalario(); 
    }

    }

    

}
