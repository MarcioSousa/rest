using System;

namespace Model
{
    public class Caixa
    {
        private double valor;
        private DateTime datacaixa;

        public Caixa(double valor, DateTime datacaixa)
        {
            this.Valor = valor;
            this.Datacaixa = datacaixa;
        }

        public double Valor { get => valor; set => valor = value; }
        public DateTime Datacaixa { get => datacaixa; set => datacaixa = value; }
    }
}
