using Orientacao.Models;
using System;

namespace Orientacao.Controller
{
    public class AlunoController
    {
        public void BuscaAluno(){
           Aluno aluno = new Aluno();
           Console.WriteLine("Digite o nome do aluno");
           aluno.nome = Console.ReadLine();
           Console.WriteLine("Digite o CPF do aluno");
           aluno.cpf = Console.ReadLine();
           Console.WriteLine("Digite o Endereço do aluno");
           aluno.endereco = Console.ReadLine();
           Console.WriteLine("Digite a data de nascimento do aluno");
           aluno.data_nascimento = Console.ReadLine();
        }

        public double NotaAluno(){
            Nota nota = new Nota();
            Aluno aluno = new Aluno();
            double soma;
            Console.WriteLine("Digite a nota do primeiro bimestre: ");
            nota.nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre: ");
            nota.nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro bimestre: ");
            nota.nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do quarto bimestre: ");
            nota.nota4 = double.Parse(Console.ReadLine());

            soma = nota.nota1 + nota.nota2 + nota.nota3 + nota.nota4;
            soma = soma / 4;;
            Console.WriteLine($"A nota do {aluno.nome} foi de {soma}");
            return soma;
        }
    }
}
