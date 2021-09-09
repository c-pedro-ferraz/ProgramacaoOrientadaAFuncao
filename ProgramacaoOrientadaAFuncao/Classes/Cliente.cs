using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        
        /// <summary>
        /// Construtor com 3 parametrso
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        /*
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome">Para preencher o nome do objeto</param>
        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        */
        

        /// <summary>
        /// Construtor com parametro telefone inteiro
        /// </summary>
        /// <param name="telefone">telefone inteiro</param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }

        /// <summary>
        /// Construtor sem Parametro
        /// </summary>
        public Cliente() { }     

        public static string Teste;

        public string Nome;
        public string Telefone;
        public string CPF;

        private string sobrenome = "Santos";

        public void Gravar()
        {
            
        
        }

        private void Olhar()
        {
            Console.WriteLine("O cliente " + this.Nome + " " + this.sobrenome + " está olhando para mim");
        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        private static string caminhoBaseUsuarios()
        {
            return ConfigurationManager.AppSettings["BaseDeUsuarios"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;

                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]);                      

                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }

        public static List<Usuario> LerUsuarios()
        {
            var usuarios = new List<Usuario>();

            if (File.Exists(caminhoBaseUsuarios()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseUsuarios()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;

                        var usuarioArquivo = linha.Split(';');

                        var usuario = new Usuario(usuarioArquivo[0], usuarioArquivo[1], usuarioArquivo[2]);

                        usuarios.Add(usuario);
                    }
                }
            }

            return usuarios;
        }
    }
}
