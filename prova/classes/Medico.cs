using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova.classes
{
    internal class Medico: Funcionario
    {
        public string CRM { get; set; }
        public double Valorextra { get; set; }
        public string Especi { get; set; }

        public Medico(string cRM, double valorextra, string especi, string nome, string cpf, int matricula, DateTime datanasc, string sexo, double salario)
            :base(nome, cpf, matricula, datanasc, sexo, salario)
        {
            this.CRM = cRM;
            this.Valorextra = valorextra;
            this.Especi = especi;
        }

        public Medico()
        {
        }

        public void Auxilioperi(double salario)
        {
            double Auxilio = salario + (salario / 100 * 20);
        }
    }
}
