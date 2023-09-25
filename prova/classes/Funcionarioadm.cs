using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova.classes
{
    internal class Funcionarioadm: Funcionario
    {
        public string Funcao { get; set; }

        public Funcionarioadm(string funcao, string nome, string cpf, int matricula, DateTime datanasc, string sexo, double salario)
            :base (nome, cpf, matricula, datanasc, sexo, salario)
        {
            this.Funcao = funcao;
        }

        public Funcionarioadm()
        {
        }

        public void Valetrasn (double salario)
        {
            double valetrasn = 150;
            valetrasn += salario;
        }

        public void Valealim (double salario)
        {
            double alimentacao = salario + (salario / 100 * 15);
        }
    }
}
