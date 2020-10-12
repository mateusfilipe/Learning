using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha
{
    public class Bloco
    {
        public int valor;
        public Bloco prox;

        public Bloco(int valorInicial) {
            this.valor = valorInicial;
            this.prox = null;
        }
    }
}
