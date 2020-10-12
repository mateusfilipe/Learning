using System;

namespace leitura_de_arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Método 1, fazendo a leitura e salvando numa string
                                                    //Repositório completo do arquivo
            string text = System.IO.File.ReadAllText(@"\teste.txt");
            Console.WriteLine("Conteúdo do arquivo: {0}", text);

            //Método 2, fazendo a leitra e salvando em um vetor de string
                                                    //Repositório completo do arquivo
            string[] lines = System.IO.File.ReadAllLines(@"\teste.txt");
            //Impirmindo o vetor de strings por um foreach
            foreach (string line in lines) {
                Console.WriteLine("\t" + line);
            }
        }
    }
}
