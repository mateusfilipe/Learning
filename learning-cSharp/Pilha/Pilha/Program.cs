using System;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilha1 = new Pilha();
            for(int i = 0; i < 10; i++)
            {
                pilha1.Empilhar(i);
            }

            Console.WriteLine("Antes de desempilhar: ");

            pilha1.Imprimir();
           
            pilha1.Desempilhar();

            Console.WriteLine("Depois de desempilhar: ");

            pilha1.Imprimir();

        }
    }
}
