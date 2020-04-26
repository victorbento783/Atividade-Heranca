using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herença
{
    class Adm: Colaborador
    {
        private double ajudadeCusto;

        public Adm(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {
        }
        public double AjudadeCusto
        {
            get { return ajudadeCusto; }
            set { ajudadeCusto = value; }
        }
        public override double Salario()
        {
            return base.Salario() + AjudadeCusto;
        }
    }
}
