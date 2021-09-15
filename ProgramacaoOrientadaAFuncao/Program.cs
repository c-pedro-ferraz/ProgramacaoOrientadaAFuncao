using Calculo;
using Classes;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.IO;
using Tela;

namespace ProgramacaoOrientadaAFuncao
{
    class Program
    {            
        static void Main(string[] args)
        {
            //Menu.Criar();

            /* Console.WriteLine("=========== Cadastro de Cliente ==========");
             Cliente c = new Cliente();
             c.Nome = "Cliente";
             c.Telefone = "Cliente22222";
             c.CPF = "Cliente3333333";

             c.Gravar();

             foreach (Cliente c1 in Cliente.LerClientes())
             {
                 Console.WriteLine(c1.Nome);
                 Console.WriteLine(c1.Telefone);
                 Console.WriteLine(c1.CPF);
                 Console.WriteLine("=======================");
             }*/

            Cliente c = new Cliente();
            c.CalcularUmMaisDois3();

            Console.WriteLine("=========== Cadastro de Usuario ==========");

            Usuario u = new Usuario();
            u.Nome = "Usuario";
            u.Telefone = "Usuario2222222";
            u.CPF = "Usuario33333333";

            u.Olhar();
            
          /*  foreach(Usuario us in Usuario.LerUsuarios())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("=======================");
            }*/
        }
    }
}
