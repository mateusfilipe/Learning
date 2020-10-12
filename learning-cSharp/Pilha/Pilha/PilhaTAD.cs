using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha
{
    interface PilhaTAD
    {
        public abstract void Empilhar(int elemento);

        public abstract int Desempilhar();

        public void Esvaziar();

        public void Imprimir();

    }
}
