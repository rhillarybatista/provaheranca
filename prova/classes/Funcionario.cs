using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova.classes
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Matricula { get; set; }
        public DateTime Datanasc { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }



        public Funcionario(string nome, string cpf, int matricula, DateTime datanasc, string sexo, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Matricula = matricula;
            this.Datanasc = datanasc;
            this.Sexo = sexo;
            this.Salario = salario;
        }

        public Funcionario()
        {
        }
    }
}
