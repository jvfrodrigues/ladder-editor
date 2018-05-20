using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class InstSEL : Instrucao
    {
        String nome;
        String tipo;

        public InstSEL(String _nome)
        {
            nome = _nome;
            tipo = "SEL";
        }

        public override String obterNome()
        {
            return this.nome;
        }

        public override String obterTipo()
        {
            return this.tipo;
        }
    }
}
