﻿using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("=========== Cadastro de Cliente ============\n");

            while (true)
            {

                string mensagem = "\nDigite uma das opções abaixo: " +
                    "\n0 - Sair do cadastro" +
                    "\n1 - Para cadastrar clientes" +
                    "\n2 - Para listar clientes";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());              

                if (valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("Digite o nome do cliente");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do cliente");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do cliente");
                    cliente.CPF = Console.ReadLine();
                    cliente.Gravar();

                }
                else
                {
                    var clientes = Cliente.LerClientes();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.CPF);

                        Console.WriteLine("--------------");

                    }
                }

                Cliente.Teste = "sss";                
            }
        }
    }
}
