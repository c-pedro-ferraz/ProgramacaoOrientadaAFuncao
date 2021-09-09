using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Usuario : Cliente
    {
        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Usuario()
        {
        
        }

        public void Gravar()
        {
            
            
                var usuario = Usuario.LerUsuarios();
                Usuario u = new Usuario(this.Nome, this.Telefone, this.CPF);
                usuario.Add(u);

                if (File.Exists(caminhoBaseUsuarios()))
                {
                    StreamWriter r = new StreamWriter(caminhoBaseUsuarios());
                    r.WriteLine("nome;telefone;cpf;");
                    foreach (Usuario c in usuario)
                    {
                        var linha = c.Nome + ";" + c.Telefone + ";" + c.CPF + ";";
                        r.WriteLine(linha);
                    }

                    r.Close();
                
            }
        }
    }
}
