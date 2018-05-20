using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class InstEN : Instrucao
    {
        String nome;
        String tipo;

        public InstEN(String _nome)
        {
            nome = _nome;
            tipo = "EN";
        }

        public override String obterNome()
        {
            return nome;
        }

        public override String obterTipo()
        {
            return tipo;
        }
    }
}
