using System;
using Cadastro_Alunos_POO.classes;

namespace Cadastro_Alunos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();//instância da classe - criando um objeto "aluno" 
           
               Console.Write("Digite o nome do aluno: ");
               aluno.nome = Console.ReadLine();

               Console.Write("Digite o curso: ");
               aluno.curso = Console.ReadLine();

               Console.Write("Digite a idade do aluno: ");
               aluno.idade = int.Parse(Console.ReadLine());

               Console.Write("Digite o RG do aluno: ");
               aluno.rg = Console.ReadLine();

               Console.Write("Digite a média final: ");
               aluno.mediaFinal = float.Parse(Console.ReadLine());

               Console.Write("Digite o valor bruto da mensalidade: R$ ");
               aluno.valorMensalidade = float.Parse(Console.ReadLine());

               Console.Write("O aluno tem direito a bolsa de estudo? (s/n): ");
               string resposta = Console.ReadLine();

               if(resposta == "s")
               {
                   aluno.bolsista = true;
               }
               else
               {
                   aluno.bolsista = false;
               }


               //menu de opções
                int opcao = 0;
               do
               {
                   Console.WriteLine("------Menu-----------");
                   Console.WriteLine("Selecione uma opção:");
                   Console.WriteLine("[1] - Média do aluno");
                   Console.WriteLine("[2] - Valor da mensalidade");
                   Console.WriteLine("[0] - Sair");
                   opcao = int.Parse(Console.ReadLine());

                   switch (opcao)
                   {
                        case 1:
                            Console.WriteLine($"A média do aluno {aluno.nome} é : {aluno.VerMediaAluno()}");
                           break;

                        case 2:
                            Console.WriteLine($"O valor do mensalidade é de : R$ {aluno.VerMensalidade()}");
                            break;

                        case 0:
                            Console.WriteLine("---fim---");
                        break;

                        default:
                            Console.WriteLine("Opção inválida - tente novamente !");
                        break;
                   }
                   
                   
               } while (opcao != 0);

                          
        }
    }
}
