using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace leitura_escalonamento_CSharp
{
    class Program
    {
        static void swap(int xp, int yp) {
            int temp = xp;
            xp = yp;
            yp = temp;
        }
        static void bubbleSort(int[] arr, int[] arr1, int[] arr2, int n)
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

            List<string> text = new List<string>();

            for (int i = 0; i < n; i++)
            {
                text.Add(sr.ReadLine());
            }
            string[] a;

            int []vectAll = new int [3*n];
            int aux = 0;

            foreach (string t in text) 
            {
                a = t.Split(" ");
                foreach (string v in a) 
                {
                    vectAll[aux] = Int32.Parse(v);
                    aux++;
                }
            }

            for (int i = 0; i < n*3; i++) 
            {
                Console.WriteLine(vectAll[i]);
            }

            int[] vectPrioridade = new int[n];
            int[] vectChegada = new int[n];
            int[] vectDuracao = new int[n];

            for(int x = 0, y = 1; x < n; x++, y+=3)
            {
                vectPrioridade[x] = vectAll[y-1];
                vectChegada[x] = vectAll[y];
                vectDuracao[x] = vectAll[y+1];
            }

            calcFifo(vectChegada, vectDuracao, vectPrioridade, n);

        }

        static void calcFifo(int[] vectChegada, int[] vectDuracao, int[] vectPrioridade, int n)
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

            using (StreamWriter writer = new StreamWriter("saida.txt"))
            {
                writer.WriteLine("FIFO " + fifoME + " " + fifoMR);

            }
        }
    }
}
