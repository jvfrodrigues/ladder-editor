using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class InstOUN : Instrucao
    {
        String nome;
        String tipo;

        public InstOUN(String _nome)
        {
            nome = _nome;
            tipo = "OUN";
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
