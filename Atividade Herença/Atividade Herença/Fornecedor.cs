using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herença
{
    class Fornecedor : Pessoa
    {
        private double valor_credito;
        private double valor_divida;

        public Fornecedor(string Nome, string End, string Tel) : base(Nome, End, Tel)
        { }
        public double Valor_Credito
        {
            get { return valor_credito; }
            set { valor_credito = value; }
        }
        public double Valor_Divida
        {
            get { return valor_divida; }
            set { valor_divida = value; }
        }
        public double Saldo()
        {
            if ((Valor_Credito - Valor_Divida) >= 0)
            {
                return Valor_Credito - Valor_Divida;
            }
            else
            {
                return Valor_Divida - Valor_Credito;
            }
        }
    }
}