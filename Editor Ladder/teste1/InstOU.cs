using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class InstOU : Instrucao
    {
        String nome;
        String tipo;

        public InstOU(String _nome)
        {
            nome = _nome;
            tipo = "OU";
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
