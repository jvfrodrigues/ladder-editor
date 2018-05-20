using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class Instrucao
    {
        String nome;
        String tipo;

        public Instrucao()
        {
        }

        public virtual String obterNome()
        {
            return nome;
        }

        public virtual String obterTipo()
        {
            return tipo;
        }
    }
}
