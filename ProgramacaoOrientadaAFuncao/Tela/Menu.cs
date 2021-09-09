using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        /*constante*/

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Salve user, POF" +
                    "\nDigite uma das opções abaixo: " +
                    "\n0 - Sair do programa" +
                    "\n1 - Para ler arquivos" +
                    "\n2 - Para executar a tabuada" +
                    "\n3 - Calcular media" +
                    "\n4 - Cadastrar cliente";
                     

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do programa");

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("----------------arquivos---------");
                    Arquivo.Ler(1);
                    Console.WriteLine("-----------------------------");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("----------------tabuada------");
                    Console.WriteLine("Digite um numero pra tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("-----------------------------");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("-----------------------------");
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("-----------------------------");
                }
                else
                {
                    Console.WriteLine("opcao invalida");
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}
