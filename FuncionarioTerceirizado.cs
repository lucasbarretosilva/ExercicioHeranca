using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado()
        {
        }

        public FuncionarioTerceirizado(string nome, double horasTrabalhadas, double valorHora, double despesaAdicional) : base(nome, horasTrabalhadas, valorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public double SalarioTerceirizado()
        {
            double bonus = DespesaAdicional * 1.10;
            double salario = HorasTrabalhadas * ValorHora + bonus;
            return salario;
        }

        public override string ToString()
        {
            return "Nome do terceirizado: " + Nome + "  " + "Salário do terceirizado: " + SalarioTerceirizado();
        }


    }
}
