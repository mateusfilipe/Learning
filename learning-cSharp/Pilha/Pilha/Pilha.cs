using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha
{
    class Pilha : PilhaTAD
    {
        public Bloco topo;
        private int quantidade;

        public Pilha() {
            topo = null;
            quantidade = 0;
        }

        public void Empilhar(int elemento) {
            Bloco novo;
            novo = new Bloco(elemento);
            novo.prox = topo;
            topo = novo;
            quantidade++;
        }

        public int Desempilhar() {
            int valorDesempilhado = 0;
            try
            {
                if (quantidade != 0)
                {
                    Bloco aux = topo;
                    topo = topo.prox;
                    valorDesempilhado = aux.valor;
                    quantidade--;
                }
                else
                    Console.WriteLine("Não é possível desempilhar uma pilha vazia.");
            }
            catch (Exception e)
            {
                throw e;
            }

            return valorDesempilhado;
        }

        public void Esvaziar() {
            while (topo != null)
                Desempilhar();
        }

        public void Imprimir() {
            Bloco aux = topo;
            while (aux != null)
            {
                Console.WriteLine(aux.valor);
                aux = aux.prox;
            }

        }
    }
}
