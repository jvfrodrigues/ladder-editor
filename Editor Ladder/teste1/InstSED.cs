using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class InstSED : Instrucao
    {
        String nome;
        String tipo;

        public InstSED(String _nome)
        {
            nome = _nome;
            tipo = "SED";
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
