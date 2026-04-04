using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseExemplo
{
    internal class Classe
    {
        public string Equipamento;
        public double Valor;
        public int Taxas;

        public Classe(string equipamento, double valor, int taxas)
        {
            Equipamento = equipamento;
            Valor = valor;
            Taxas = taxas;
        }

        public override string ToString()
        {
            return Equipamento + " " + Valor + " " + Taxas;
        }

    }
}
