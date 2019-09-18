using System;
using Classe_Escola.Classe_2;
using Classe_Escola.ObjEscola;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Escola
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();

            Estado estado = new Estado();

            Cidade cidade = new Cidade();

            Pais pais = new Pais();

            Casa casa = new Casa();

            Biarro bairro = new Biarro();

            casa.bairro = bairro;

            estado.cidade = cidade;

            Console.WriteLine("Informações da pessoa");
            pessoa.nome = "Lucas";
            pessoa.dataDeNascimento = new DateTime(1996, 5, 9);
            Console.WriteLine(pessoa);

            Console.WriteLine("Casa");
            casa.bairro.Nome = "Santa Paula";
            casa.NomeDaRua = "José Amador";
            casa.numeroCasa = "12333";
            Console.WriteLine(casa);

            Console.WriteLine("Cidade/Estado");
            estado.cidade.Nome = "São Paulo";
            estado.Nome = "São Paulo";
            Console.WriteLine(estado);
            Console.WriteLine(estado.cidade);

            Console.WriteLine("PAIS");
            pais.Nome = "Brasil";
            Console.WriteLine(pais);

            Aluno_Classe aluno_Classe = new Aluno_Classe();

            Turma_Classe turma_Classe = new Turma_Classe();

            Funcionario_Classe funcionario_Classe = new Funcionario_Classe();

            professor Professor = new professor();

            aluno_Classe.nome = "Lucas";
            aluno_Classe.matricula = "123564";
            Console.WriteLine(aluno_Classe);
            turma_Classe.serie = "3º";
            Console.WriteLine(turma_Classe);
            funcionario_Classe.nome = "Jorge";
            funcionario_Classe.RG = "123654";
            Console.WriteLine(funcionario_Classe);
            Professor.nome = "Mateus";
            Professor.Materia = "Português";
            Console.WriteLine(Professor);

            Console.ReadLine();
        }
    }
}
