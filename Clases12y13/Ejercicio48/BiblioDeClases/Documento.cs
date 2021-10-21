using System;

namespace BiblioDeClases
{
    public class Documento
    {
        private int numero;

        public Documento(int numero)
        {
            this.numero = numero;
        }

        public int Numero { get => numero; }
    }
}
