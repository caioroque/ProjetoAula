using System;
using Orientacao.Controller;
using Orientacao.Models;

namespace Orientacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();
            AlunoController aluno = new AlunoController();

            aluno.BuscaAluno();
            Console.Clear();
            Console.WriteLine(aluno1.nome);
            //aluno.NotaAluno();

        }
    }
}
