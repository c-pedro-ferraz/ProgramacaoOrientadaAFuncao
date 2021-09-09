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
            Menu.Criar();

            Console.WriteLine("=========== Cadastro de Cliente ==========");
            Cliente c = new Cliente();
            c.Nome = "teste";
            c.Telefone = "teste1";
            c.CPF = "teste2";

            c.Gravar();

            foreach (Cliente c1 in Cliente.LerClientes())
            {
                Console.WriteLine(c1.Nome);
                Console.WriteLine(c1.Telefone);
                Console.WriteLine(c1.CPF);
                Console.WriteLine("=======================");
            }

            Console.WriteLine("=========== Cadastro de Usuario ==========");

            Usuario u = new Usuario();
            u.Nome = "teste";
            u.Telefone = "teste1";
            u.CPF = "teste2";

            u.Gravar();
            
            foreach(Usuario us in Usuario.LerUsuarios())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("=======================");
            }
        }
    }
}
