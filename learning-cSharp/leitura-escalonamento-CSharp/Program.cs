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

        public static float fifoME = 0; //Tempo médio de espera do FIFO
        public static float fifoMR = 0; //Tempo médio de resposta do FIFO

        public static float prioME = 0; //Tempo médio de espera do PRIO
        public static float prioMR = 0; //Tempo médio de resposta do PRIO

        public static float srt_ME = 0; //Tempo médio de espera do SRT
        public static float srt_MR = 0; //Tempo médio de resposta do SRT

        public static float rrq5ME = 0; //Tempo médio de espera do RRQ5
        public static float rrq5MR = 0; //Tempo médio de resposta do RRQ5

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
            //calcPrio(vectChegada, vectDuracao, vectPrioridade, n);
            //calcSRT_(vectChegada, vectDuracao, vectPrioridade, n);
            calcRRQ5(vectChegada, vectDuracao, vectPrioridade, n);

            using (StreamWriter writer = new StreamWriter("saida.txt"))
            {
                writer.WriteLine("FIFO " + Math.Round(fifoME, 2) + " " + Math.Round(fifoMR, 2));
                writer.WriteLine("PRIO " + Math.Round(prioME, 2) + " " + Math.Round(prioMR, 2));
                writer.WriteLine("SRT_ " + Math.Round(srt_ME, 2) + " " + Math.Round(srt_MR, 2));
                writer.WriteLine("RRQ5 " + Math.Round(rrq5ME, 2) + " " + Math.Round(rrq5MR, 2));

            }


        }

        static void calcFifo(int[] vectChegada, int[] vectDuracao, int[] vectPrioridade, int n)
        {

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
        }

        static void calcPrio(int[] vectChegada, int[] vectDuracao, int[] vectPrioridade, int n)
        {
            float tempoEspera = 0;
            float auxDuracao = 0;
            float difChegada = 0;
            //Ordenando os vetores pelo tempo de chegada e acompanhados de sua duração e prioridade
            bubbleSort(vectPrioridade, vectChegada, vectDuracao, n);
            //Calculando o Tempo médio de Espera do escalonamento Prioridade
            for (int a = 0; a < n; a++)
            {
                auxDuracao += vectDuracao[a]; //Auxiliar do somatório de todas as Durações
            }
            int i = n - 1;
            int j = n - 2;

            for (int x = n - 1, y = n - 2; x >= 0; x--, y--)
            {
                auxDuracao -= vectDuracao[x]; // Subtraindo a duração após "rodar" um dos processos
                
                if (y != -1 && (vectChegada[y] - vectChegada[x]) < 0)
                {
                    difChegada += vectChegada[x] - vectChegada[y]; // Somando a diferença para subtrair da espera total
                }

                tempoEspera += auxDuracao; // Somando a espera total
            }
            tempoEspera -= difChegada; // Tirando a diferença da espera

            float somaPrioridade = 0;
            float somaResposta = 0;
            //Calculando o Tempo médio de Resposta do escalonamento Prioridade
            for (int ii = 0, jj = 1; ii < n ; ii++, jj++)
            {
                if (vectPrioridade[jj] > vectPrioridade[ii] && vectChegada[jj] != vectChegada[ii])
                {
                    somaPrioridade += 0;
                }
                if (vectPrioridade[jj] >= vectPrioridade[ii] && vectChegada[jj] == vectChegada[ii])
                {
                    somaPrioridade += vectDuracao[ii];
                    somaResposta += somaPrioridade;
                }
                if (vectPrioridade[jj] == vectPrioridade[ii] && vectChegada[jj] > vectChegada[ii])
                {
                    somaPrioridade += (vectDuracao[jj] + vectChegada[jj]) - vectChegada[ii];
                    somaResposta += somaPrioridade;
                }
            }

            prioME = tempoEspera / n;
            prioMR = somaResposta / n;
        }


        static void calcSRT_(int[] vectChegada, int[] vectDuracao, int[] vectPrioridade, int n)
        {
            bubbleSort(vectPrioridade, vectChegada, vectDuracao, n);

            //Calculando o Tempo médio de Espera do escalonamento SRT_
            int[] auxDuracao = new int[n]; //Vetor auxiliar para tempo de Espera;
            float tempoFinal;
            int menorIndex;
            float restante = 0, time, esperaTotal = 0;
            float respDiferente = 0, aux = 0, respIgual = 0;

            bool bo = true;

            for (int i = 0; i < n; i++)
            {
                auxDuracao[i] = vectDuracao[i];
            }
            auxDuracao[n-1] = 9999;
            for (time = 0; restante != n; time++)
            {
                menorIndex = 9;
                for (int i = 0; i < n; i++)
                {
                    if (vectChegada[i] <= time && auxDuracao[i] < auxDuracao[menorIndex] && auxDuracao[i] > 0)
                    {
                        menorIndex = i;
                    }
                }
                auxDuracao[menorIndex]--;
                if (auxDuracao[menorIndex] == 0)
                {
                    restante++;
                    tempoFinal = time + 1;
                    esperaTotal += tempoFinal - vectDuracao[menorIndex] - vectChegada[menorIndex];
                    if (bo)
                    {
                        respDiferente += esperaTotal - aux; // Diferentes
                        respIgual = esperaTotal - aux; // Iguais
                        bo = false;
                    }
                    if (respDiferente == esperaTotal)
                    {
                        bo = true;
                        aux = esperaTotal;
                    }
                }
            }

            float totalTempo = vectChegada[0];
            for (int i = 0; i < n; i++)
            {
                totalTempo += vectDuracao[i];
            }

            //Calculando o Tempo médio de Resposta do escalonamento SRT_
            bool complete = false;
            int cont = 0;
            int aux2 = 0;
            for (int i = 0, j = 1; i < n; i++, j++)
            {
                while (complete == false)
                {
                    aux2 += 1;
                    if (aux2 == vectChegada[j])
                    {
                        if (vectDuracao[i] - aux2 > vectDuracao[j])
                        {
                            cont++;
                        }
                    }
                    if (aux2 == totalTempo)
                        complete = true;
                }
            }
            if (cont > 0)
            {
                srt_MR = respIgual / n;
            }
            else
            {
                srt_MR = respDiferente / n;
            }

            srt_ME = esperaTotal / n;
        }


        static void calcRRQ5(int[] vectChegada, int[] vectDuracao, int[] vectPrioridade, int n)
        {
            bubbleSort(vectChegada, vectPrioridade, vectDuracao, n);
            //Cálculo do tempo médio de Espera
            int i;
            float total = 0, x, counter = 0;
            float wait_time = 0;
            int[] copyDuracao = new int[n];
            int b = 0;
            x = n;
            for (i = 0; i < n; i++)
            {
                copyDuracao[i] = vectDuracao[i];
            }

            for (total = 0, i = 0; x != 0;)
            {
                if (copyDuracao[i] <= 5 && copyDuracao[i] > 0)
                {
                    total = total + copyDuracao[i];
                    copyDuracao[i] = 0;
                    counter = 1;
                }
                else if (copyDuracao[i] > 0)
                {
                    copyDuracao[i] = copyDuracao[i] - 5;
                    total = total + 5;
                }
                if (copyDuracao[i] == 0 && counter == 1)
                {
                    x--;
                    wait_time += total - vectChegada[i] - vectDuracao[i];
                    counter = 0;
                }
                if (i == n - 1)
                {
                    i = 0;
                }
                else if (vectChegada[i + 1] <= total)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }
            rrq5ME = wait_time / n;

            //Cálculo do tempo médio de Resposta
            float diferencaResposta = 0;
            float somaResposta = 0;
            float primeiraChegada = vectChegada[0];
            for (int ii = 0, j = 1; ii < n; ii++, j++)
            {
                if (j != n)
                {
                    while (vectChegada[j] >= primeiraChegada)
                    {
                        primeiraChegada += 5;
                    }
                    if (ii > 0)
                    {
                        diferencaResposta = (primeiraChegada + 5) - vectChegada[j];
                    }
                    else
                    {
                        diferencaResposta = primeiraChegada - vectChegada[j];
                    }
                    somaResposta += diferencaResposta;
                }
            }
            rrq5MR = somaResposta / n;
        }

    }
}
