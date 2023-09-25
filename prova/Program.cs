using prova.classes;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        

        Console.WriteLine("escolha uma opçao: \n  "+" 1 Funcionario" +
            "2: Medico \n" + " 3: Funcionarioadm ");

        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 0)
        {
            Funcionario f = new();
            f.Nome = Console.ReadLine();
            Console.WriteLine("digitr seu nome: " ); 
            f.Cpf = Console.ReadLine();
            Console.WriteLine("Digite seu Cpf: ");
            f.Matricula= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua matricula: ");
            f.Datanasc = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite seu Aniversario: ");
            f.Sexo = Console.ReadLine();
            Console.WriteLine("digite seu sexo: ");
            f.Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite seu salario: ");

            list.Add(opcao);
            foreach (var o in list)
            {
                Console.WriteLine(o);
            }

        }
         if (opcao == 1)
        {
            Medico medico  = new ();
            medico.Nome = Console.ReadLine();
            Console.WriteLine("digitr seu nome: ");
            medico.Cpf = Console.ReadLine();
            Console.WriteLine("Digite seu Cpf: ");
            medico.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua matricula: ");
            medico.Datanasc = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite seu Aniversario: ");
            medico.Sexo = Console.ReadLine();
            Console.WriteLine("digite seu sexo: ");
            medico.Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite seu salario: " + Auxilioperi);
            medico.Valorextra= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("seu extra é; ");

            
            list.Add(opcao);
            foreach (var o in list)
            {
                Console.WriteLine(o);
            }
            
        }

         if(opcao == 2)
        {
            Funcionarioadm funadm = new();
            funadm.Nome = Console.ReadLine();
            Console.WriteLine("digitr seu nome: ");
            funadm.Cpf = Console.ReadLine();
            Console.WriteLine("Digite seu Cpf: ");
            funadm.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua matricula: ");
            funadm.Datanasc = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite seu Aniversario: ");
            funadm.Sexo = Console.ReadLine();
            Console.WriteLine("digite seu sexo: ");
            funadm.Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite seu salario: " );
            funadm.Funcao = Console.ReadLine();
            Console.WriteLine("digite sua funcao: " );

            list.Add(opcao);
            foreach (var o in list)
            {
                Console.WriteLine(o);
            }

        }

    }
}
