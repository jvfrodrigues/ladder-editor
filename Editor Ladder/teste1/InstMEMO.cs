using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class InstMEMO : Instrucao
    {
        String nome;
        String tipo;

        public InstMEMO(String _nome)
        {
            nome = _nome;
            tipo = "MEMO";
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
