using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herença
{
    class Colaborador : Pessoa
    {
        private int id_setor;
        private double salario_base;
        private int impostos;

        public Colaborador(string Nome, string End, string Tel) : base(Nome, End, Tel)
        { }
        public int ID_Setor
        {
            get { return id_setor; }
            set { id_setor = value; }
        }
        public double Salario_Base
        {
            get { return salario_base; }
            set { salario_base = value; }
        }
        public int Impostos
        {
            get { return impostos; }
            set { impostos = value; }
        }
        public virtual double Salario()
        {
            return Salario_Base - (Salario_Base * ((double)Impostos / 100));
        }
    }
}