using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{
    class Logica
    {
        ArrayList instrucoes;
        public Logica()
        {
            instrucoes = new ArrayList();
        }

        public void insereE(String nome, int pos)
        {
            instrucoes.Insert(pos, new InstE(nome));
        }
        public void insereEN(String nome, int pos)
        {
            instrucoes.Insert(pos, new InstEN(nome));
        }
        public void insereSED(String nome, int pos)
        {
            instrucoes.Insert(pos, new InstSED(nome));
        }
        public void insereSEL(String nome, int pos)
        {
            instrucoes.Insert(pos, new InstSEL(nome));
        }
        public void insereOU(String nome, int pos)
        {
            instrucoes.Insert(pos, new InstOU(nome));
        }
        public void insereOUN(String nome, int pos)
        {
            instrucoes.Insert(pos, new InstOUN(nome));
        }
        public void insereMEMO(String nome, int pos)
        {
            instrucoes.Insert(pos, new InstMEMO(nome));
        }

        public String obterML()
        {
            String codeML = "";
            for (int i = 0; i < instrucoes.Count; i++)
            {
                Instrucao inst = (Instrucao)instrucoes[i];
                String tipo = inst.obterTipo();
                String nome = inst.obterNome();
                codeML += tipo + "(" + nome + ")" + System.Environment.NewLine;
            }
            return codeML;
        }

        public ArrayList obterArrayList()
        {
            return instrucoes;
        }

        public void alterarInstrucao(String tipo, String novoNome, int pos)
        {
            Instrucao instAux = (Instrucao)instrucoes[pos];
            instrucoes.Remove(instrucoes[pos]);
            switch (tipo)
            {
                case "SEL":
                    insereSEL(novoNome, pos);
                    break;
                case "SED":
                    insereSED(novoNome, pos);
                    break;
                case "E":
                    insereE(novoNome, pos);
                    break;
                case "EN":
                    insereEN(novoNome, pos);
                    break;
                case "OU":
                    insereOU(novoNome, pos);
                    break;
                case "OUN":
                    insereOUN(novoNome, pos);
                    break;
                case "MEMO":
                    insereMEMO(novoNome, pos);
                    break;
                default: break;
            }
        }

        public bool removerInstrucao(int pos)
        {
            instrucoes.Remove(instrucoes[pos]);
            bool flagLog = true;
            if (pos == 0)
            {
                if (instrucoes.Count != 0)
                {
                    Instrucao inst = (Instrucao)instrucoes[pos];
                    String tipoAtual = inst.obterTipo();
                    if (tipoAtual == "E" || tipoAtual == "OU")
                        alterarInstrucao("SEL", inst.obterNome(), pos);
                    if (tipoAtual == "EN" || tipoAtual == "OUN")
                        alterarInstrucao("SED", inst.obterNome(), pos);
                    if (tipoAtual == "MEMO")
                    {
                        instrucoes.Remove(instrucoes[pos]);
                        flagLog = false;
                    }
                }
                else
                {
                    flagLog = false;
                }
            }
            return flagLog;
        }
    }
}
