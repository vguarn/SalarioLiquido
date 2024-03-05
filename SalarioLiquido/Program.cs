using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada 
            Console.WriteLine("Informe qual é o seu salário bruto: ");
             double sb = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor pago por hora extra: ");
             double vhe = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas extras que você trabalhou: ");
             double het = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do vale alimentação: ");
             double va = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor pago por filho: ");
             double vf = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de filhos: ");
             double qf = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do INSS: ");
             double inss = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do IRPF: ");
             double irpf = double.Parse(Console.ReadLine());

            //Processamento
            double tf = vf * qf;
            double the = vhe * het;
            double sl1 = sb + va + the + tf;
            double sl2 = sl1 - inss;
            double sl = sl2 - irpf;

            //saída
            Console.WriteLine("O salário líquido é: " + sl);
            Console.ReadKey();



        }
    }
}
