using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class InstE : Instrucao
    {
        String nome;
        String tipo;

        public InstE(String _nome)
        {
            nome = _nome;
            tipo = "E";
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
