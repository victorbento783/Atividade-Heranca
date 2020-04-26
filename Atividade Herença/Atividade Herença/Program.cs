using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Herença
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f = new Fornecedor("Marlon Comandante da PM", "Monsenhor Paulo", "(35) 3264-1111");
            f.Valor_Credito = 1000.00;
            f.Valor_Divida = 316.00;
            Console.WriteLine("Fornecedor: " + f.Nome + "\nTelefone: " + f.Telefone + "\nEndereço: " + f.Endereco + "\nsaldo de: R$ " + f.Saldo());

            Colaborador c = new Colaborador("Diogo Defante", "Rio de Janeiro", "(21) 3200-9000");
            c.ID_Setor = 30;
            c.Salario_Base = 1500.00;
            c.Impostos = 2;
            Console.WriteLine("\nColaborador: " + c.Nome + "\nTelefone: " + c.Telefone + "\nEndereço: " + c.Endereco + "\nsaldo de: R$ " + c.Salario());

            Adm a = new Adm("Yudi do Playstation", " São Paulo - Bomdia&Cia", "(35) 4002-8922");
            a.ID_Setor = 30;
            a.Salario_Base = 152000.00;
            a.Impostos = 2;
            a.AjudadeCusto = 314.00;
            Console.WriteLine("\nAdm: " + a.Nome + "\nTelefone: " + a.Telefone + "\nEndereço: " + a.Endereco + "\nsaldo de: JP¥ " + a.Salario());

            Operario o = new Operario("Mateus Canella", " São Paulo", "(35) 3263-8772");
            o.ID_Setor = 30;
            o.Salario_Base = 818.00;
            o.Impostos = 2;
            o.ValorProducao = 117.00;
            o.Comissao = 3;
            Console.WriteLine("\nOperario: " + o.Nome + "\nTelefone: " + o.Telefone + "\nEndereço: " + o.Endereco + "\nsaldo de: R$ " + o.Salario());

            Vendedor v = new Vendedor("Sasha Grey", "California", "(1) 55584-7942");
            v.ID_Setor = 30;
            v.Salario_Base = 2500.00;
            v.Impostos = 2;
            v.ValorVendas = 1028.00;
            v.Comissao = 5;
            Console.WriteLine("\nVendedor: " + v.Nome + "\nTelefone: " + v.Telefone + "\nEndereço: " + v.Endereco + "\nsaldo de: $ " + v.Salario());
            Console.ReadKey();
        }
    }
}
