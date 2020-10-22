using System;
using System.Collections.Generic;
using System.Text;

namespace MateusFilipe_Roteiro_02_CSharp
{
    class Questoes
    {
        public static float Questao01() {
            Console.WriteLine("Insira 3 números:\nPara confirmar cada número use ENTER.");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            line = Console.ReadLine();
            int b = int.Parse(line);
            line = Console.ReadLine();
            int c = int.Parse(line);

            int soma = a + b + c;
            float media = soma / 3f;
            Console.WriteLine("Média: ");
            return media;
        }

        public static float Questao02() {
            Console.WriteLine("Insira 3 números:\nPara confirmar cada número use ENTER.");
            string line = Console.ReadLine();
            float a = float.Parse(line);
            line = Console.ReadLine();
            float b = float.Parse(line);
            line = Console.ReadLine();
            float c = float.Parse(line);
            if (c == 0)
            {
                Console.WriteLine("Divisão inválida.");
                return 0;
            }
            Console.WriteLine();
            return (a * b) / c;
        }

        public static float Questao03(){
            Console.WriteLine("Insira a nota e em seguida seu peso:\nPara confirmar cada número use ENTER.");
            string line = Console.ReadLine();
            float notaA = float.Parse(line);
            line = Console.ReadLine();
            float pesoA = float.Parse(line);

            line = Console.ReadLine();
            float notaB = float.Parse(line);
            line = Console.ReadLine();
            float pesoB = float.Parse(line);

            line = Console.ReadLine();
            float notaC = float.Parse(line);
            line = Console.ReadLine();
            float pesoC = float.Parse(line);

            float somatorio = (notaA * pesoA) + (notaB * pesoB) + (notaC * pesoC);
            float media = somatorio / 3f;

            return media;
        }

        public static float Questao04()
        {
            Console.WriteLine("Digite o salário:\nPara confirmar cada número use ENTER.");
            string line = Console.ReadLine();
            
            float salario = float.Parse(line);
            
            salario += (salario * 0.1f);
            salario -= (salario * 0.05f);

            return salario;
        }

        public static float Questao05()
        {
            Console.WriteLine("Digite o salário fixo:\nPara confirmar cada número use ENTER.");
            string line = Console.ReadLine();
            float salarioFixo = float.Parse(line);
            Console.WriteLine("Digite o valor total das vendas:\nPara confirmar cada número use ENTER.");
            line = Console.ReadLine();
            float vendas = float.Parse(line);
            
            Console.Write("Salário com benefício: ");
            return salarioFixo + (vendas * 0.04f) ;
        }

        public static Tuple <float,float> Questao23()
        {
            Console.WriteLine("Insira 3 números:\nPara confirmar cada número use ENTER.");
            string line = Console.ReadLine();
            float a = float.Parse(line);
            line = Console.ReadLine();
            float b = float.Parse(line);
            line = Console.ReadLine();
            float c = float.Parse(line);

            float delta = MathF.Pow(b, 2);

            float x1 = 0, x2 = 0;

            x1 = (-b - MathF.Sqrt(delta)) / (2 * a);
            x2 = (-b + MathF.Sqrt(delta)) / (2 * a);
            if (delta < 0)
            {
                Console.WriteLine("Não existe raíz real.");
                Tuple.Create(0,0);
            }
            else if (delta == 0) 
            {
                Console.Write("Raízes iguais: ");
                return Tuple.Create(x1,x2);
            }
            return Tuple.Create(x1, x2);
        }
    }
}
