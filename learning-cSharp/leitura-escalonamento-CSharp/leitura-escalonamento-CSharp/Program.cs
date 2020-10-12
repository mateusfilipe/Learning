using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace leitura_escalonamento_CSharp
{
    class Program
    {
        void swap(int xp, int yp) {
            int temp = xp;
            xp = yp;
            yp = temp;
        }
        void bubbleSort(int[] arr, int[] arr1, int[] arr2, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr[j], arr[j + 1]);
                        swap(arr1[j], arr1[j + 1]);
                        swap(arr2[j], arr2[j + 1]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\T-Gamer\source\repos\leitura-escalonamento-CSharp\leitura-escalonamento-CSharp\teste.txt");
            string headerLine = sr.ReadLine();

            int n = 0;
            n = int.Parse(headerLine);

            Console.WriteLine();

            List<string> text = new List<string>();
            string[] textSplitted = new string[n*3];

            for(int i = 0; i < n; i++)
            {
                text.Add(sr.ReadLine());
            }
            int a = 0;
            foreach (string t in text) 
            {
                textSplitted[a] = t.Split(" ");
                Console.WriteLine(t);
                a++;
            }

            int[] vectPrioridade = new int[n];
            int[] vectChegada = new int[n];
            int[] vectDuracao = new int[n];


            for(int i = 0; i < n; i++)
            {
            }



        }

        void calcFifo(int[] vectChegada, int[] vectDuracao, int[] vectPrioridade, int n)
        {
            float fifoME = 0; //Tempo médio de espera do FIFO
            float fifoMR = 0; //Tempo médio de resposta do FIFO
            float tempoEspera = 0; //Tempo de espera total
            float tempoDuracao = 0; //Tempo de duração total
            //Ordenando os vetores pelo tempo de chegada e acompanhados de sua duração e prioridade
            bubbleSort(vectChegada, vectDuracao, vectPrioridade, n);
            //Calculando o Tempo médio de Espera do escalonamento FIFO
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    tempoEspera = 0;
                    tempoDuracao = vectChegada[i] + vectDuracao[i];
                }
                else
                {
                    tempoEspera += tempoDuracao - vectChegada[i];
                    tempoDuracao += vectDuracao[i];
                }
            }
            fifoME = tempoEspera / n;
            fifoMR = fifoME;

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"C:\Users\T-Gamer\source\repos\leitura-escalonamento-CSharp\leitura-escalonamento-CSharp\saida.txt", true))
            {
                writer.WriteLine("FIFO "+fifoME+" "+fifoMR);
            }
        }
    }
}
