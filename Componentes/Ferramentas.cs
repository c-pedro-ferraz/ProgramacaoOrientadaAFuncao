using System;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este método só pode ser acessado dentro desse assembly de componenentes";
        }
        internal string MetodoParaTodosQueUtilizarOAssembly()
        {
            return "Este método é para todos";
        }

        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
