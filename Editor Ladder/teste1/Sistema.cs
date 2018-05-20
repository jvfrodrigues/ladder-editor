using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste1
{
    public partial class FormPrincipal : Form
    {
        ArrayList logicas;
        List<Panel> panelsAdded;
        List<Button> buttonsAdded;
        Button btnAtual;
        int upIni, leftIni, upAtual, leftAtual;
        int logica;
        int pos;
        public FormPrincipal()
        {
            InitializeComponent();
            logicas = new ArrayList();
            buttonsAdded = new List<Button>();
            panelsAdded = new List<Panel>();
            upIni = 65;
            leftIni = 20;
            upAtual = upIni;
            leftAtual = leftIni;
            logica = -1;
            pos = 0;
            panelAlterar.Visible = false;
        }

        #region Funcoes
        private void btnLadder(Button btn, Panel pnl)
        {
            panelAlterar.Visible = false;
            upAtual = btn.Location.Y;
            leftAtual = btn.Location.X;
            pos = (int)btn.Tag;
            logica = (int)pnl.Tag;
            btn.BackColor = Color.LightBlue;
            changeColor(btn);
            btnAtual = btn;
        }

        private void changeColor(Button btn)
        {
            for (int i = 0; i < buttonsAdded.Count; i++)
            {
                if (buttonsAdded[i] != btn)
                {
                    buttonsAdded[i].BackColor = Color.White;
                }
            }
        }

        public void alterarInstrucao(String tipo, String novoNome)
        {
            Logica logicaAux = (Logica)logicas[logica];
            logicaAux.alterarInstrucao(tipo, novoNome, pos);
        }

        private void limpaTela()
        {
            while (buttonsAdded.Count > 0)
            {
                Button buttonToRemove = buttonsAdded[0];
                buttonsAdded.Remove(buttonToRemove);
                this.Controls.Remove(buttonToRemove);
            }
            while (panelsAdded.Count > 0)
            {
                Panel panelToRemove = panelsAdded[0];
                panelsAdded.Remove(panelToRemove);
                this.Controls.Remove(panelToRemove);
            }
        }

        private void colarML(String logicaML)
        {
            String inst = "";
            String nome = "";
            bool instFlag = false;
            bool firstFlag = true;
            for (int i = 0; i < logicaML.Length; i++)
            {
                char chAux = logicaML[i];
                if (!instFlag)
                {
                    if ((chAux > 0x40 && chAux < 0x5B) || (chAux > 0x60 && chAux < 0x7B))
                    {
                        inst += chAux;
                    }
                    else
                    {
                        if (chAux == '(')
                        {
                            instFlag = true;
                        }
                    }
                }
                else
                {
                    if ((chAux > 0x40 && chAux < 0x5B) || (chAux > 0x60 && chAux < 0x7B))
                    {
                        nome += chAux;
                    }
                    else
                    {
                        if (chAux == ')')
                        {
                            instFlag = false;
                            if (nome.Length > 50)
                            {
                                MessageBox.Show("TAMANHO MAXIMO DE NOME É 50 CARACTERES");
                            }
                            else
                            {
                                #region switchInst
                                switch (inst)
                                {
                                    case "SEL":
                                        insereSEL(nome);
                                        firstFlag = false;
                                        break;
                                    case "SED":
                                        insereSED(nome);
                                        firstFlag = false;
                                        break;
                                    case "E":
                                        if (!firstFlag)
                                            insereE(nome);
                                        break;
                                    case "EN":
                                        if (!firstFlag)
                                            insereEN(nome);
                                        break;
                                    case "OU":
                                        if (!firstFlag)
                                            insereOU(nome);
                                        break;
                                    case "OUN":
                                        if (!firstFlag)
                                            insereOUN(nome);
                                        break;
                                    case "MEMO":
                                        if (!firstFlag)
                                            insereMEMO(nome);
                                        break;
                                    default: break;
                                }
                                #endregion
                            }
                            inst = "";
                            nome = "";
                        }
                    }
                }
            }
            if(firstFlag == true)
            {
                MessageBox.Show("A lógica deve iniciar com SEL ou SED");
            }
        }

        private void redraw()
        {
            int index = 0;
            upAtual = upIni;
            leftAtual = leftIni;
            List<String> logicaML = new List<String>();
            limpaTela();
            while(logicas.Count != 0)
            {
                Logica logicaAux = (Logica)logicas[0];
                ArrayList instrucoes = logicaAux.obterArrayList();
                logicaML.Add("");
                for(int j=0; j < instrucoes.Count; j++)
                {
                    Instrucao instAux = (Instrucao)instrucoes[j];
                    logicaML[index] += instAux.obterTipo();
                    logicaML[index] += "(";
                    logicaML[index] += instAux.obterNome();
                    logicaML[index] += ")";
                    logicaML[index] += System.Environment.NewLine;
                }
                logicas.Remove(logicas[0]);
                logica--;
                index++;
            }
            for(int i = 0; i < index; i++)
            {
                pos = 0;
                colarML(logicaML[i]);
            }
            for(int i = 0; i < buttonsAdded.Count; i++)
            {
                buttonsAdded[i].BackColor = Color.White;
            }
        }
        #endregion

        #region Instrucoes
        private void btnSEL_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (nome == "")
                MessageBox.Show("Dé um nome para a instrução");
            else
            {
                insereSEL(nome);
                redraw();
            }
        }
        private void btnSED_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (nome == "")
                MessageBox.Show("Dé um nome para a instrução");
            else
            {
                insereSED(nome);
                redraw();
            }
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (nome == "")
                MessageBox.Show("Dé um nome para a instrução");
            else
            {
                if (btnAtual.BackColor != Color.White)
                {
                    if (btnAtual.AccessibleDescription != null)
                    {
                        MessageBox.Show("Novas instruções não podem ser adicionadas depois do MEMO");
                    }
                    else
                    {
                        insereE(nome);
                        redraw();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione aonde a instrução será inserida");
                }
            }
        }
        private void btnEN_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (nome == "")
                MessageBox.Show("Dé um nome para a instrução");
            else
            {
                if (btnAtual.BackColor != Color.White)
                {
                    if (btnAtual.AccessibleDescription != null)
                    {
                        MessageBox.Show("Novas instruções não podem ser adicionadas depois do MEMO");
                    }
                    else
                    {
                        insereEN(nome);
                        redraw();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione aonde a instrução será inserida");
                }
            }
        }
        private void btnOU_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (nome == "")
                MessageBox.Show("Dé um nome para a instrução");
            else
            {
                if (btnAtual.BackColor != Color.White)
                {
                    if (btnAtual.AccessibleDescription != null)
                    {
                        MessageBox.Show("Novas instruções não podem ser adicionadas depois do MEMO");
                    }
                    else
                    {
                        insereOU(nome);
                        redraw();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione aonde a instrução será inserida");
                }
            }
        }
        private void btnOUN_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (nome == "")
                MessageBox.Show("Dé um nome para a instrução");
            else
            {
                if (btnAtual.BackColor != Color.White)
                {
                    if (btnAtual.AccessibleDescription != null)
                    {
                        MessageBox.Show("Novas instruções não podem ser adicionadas depois do MEMO");
                    }
                    else
                    {
                        insereOUN(nome);
                        redraw();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione aonde a instrução será inserida");
                }
            }
        }
        private void btnMEMO_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            if (nome == "")
                MessageBox.Show("Dé um nome para a instrução");
            else
            {
                if (btnAtual.BackColor != Color.White)
                {
                    if (btnAtual.AccessibleDescription != null)
                    {
                        MessageBox.Show("Novas instruções não podem ser adicionadas depois do MEMO");
                    }
                    else
                    {
                        insereMEMO(nome);
                        redraw();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione aonde a instrução será inserida");
                }
            }
        }

        private void insereSEL(String nome)
        {
            panelAlterar.Visible = false;
            logica = logicas.Count - 1;
            logica++;
            logicas.Add(new Logica());
            Logica aux = (Logica)logicas[logica];
            Panel pnl = new Panel();
            pnl.AutoSize = true;
            pnl.Tag = logica;
            panelsAdded.Add(pnl);
            #region peçaSEL
            if (logica == 0)
            {
                Button btn = new Button();
                btn.Location = new Point(leftAtual, upAtual);
                btn.Height = 120;
                btn.Width = 150;
                btn.Text = nome;
                btn.Image = imageList1.Images[0];
                btn.TextImageRelation = TextImageRelation.TextAboveImage;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = pos;
                btn.Click += delegate { btnLadder(btn, pnl); };
                pnl.Controls.Add(btn);
                buttonsAdded.Add(btn);
                aux.insereSEL(nome, pos);
                pnl.Location = new Point(leftAtual, upAtual);
                btnLadder(btn, pnl);
            }
            else
            {
                Panel pnlAux = panelsAdded[logica - 1];
                upAtual = upIni;
                leftAtual = leftIni;
                pos = 0;
                Button btn = new Button();
                btn.Location = new Point(leftAtual, upAtual);
                btn.Height = 120;
                btn.Width = 150;
                btn.Text = nome;
                btn.Image = imageList1.Images[0];
                btn.TextImageRelation = TextImageRelation.TextAboveImage;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.LightBlue;
                btn.Tag = pos;
                btn.Click += delegate { btnLadder(btn, pnl); };
                pnl.Controls.Add(btn);
                buttonsAdded.Add(btn);
                aux.insereSEL(nome, pos);
                int upAux = pnlAux.Bottom;
                pnl.Location = new Point(leftIni, upAux);
                changeColor(btn);
            }
            Controls.Add(pnl);
            #endregion
            txtNome.Text = "";
        }
        private void insereSED(String nome)
        {
            panelAlterar.Visible = false;
            logica = logicas.Count - 1;
            logica++;
            logicas.Add(new Logica());
            Logica aux = (Logica)logicas[logica];
            Panel pnl = new Panel();
            pnl.AutoSize = true;
            pnl.Tag = logica;
            panelsAdded.Add(pnl);
            #region peçaSED
            if (logica == 0)
            {
                Button btn = new Button();
                btn.Location = new Point(leftAtual, upAtual);
                btn.Height = 120;
                btn.Width = 150;
                btn.Text = nome;
                btn.Image = imageList1.Images[1];
                btn.TextImageRelation = TextImageRelation.TextAboveImage;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = pos;
                btn.Click += delegate { btnLadder(btn, pnl); };
                pnl.Controls.Add(btn);
                buttonsAdded.Add(btn);
                aux.insereSED(nome, pos);
                pnl.Location = new Point(leftAtual, upAtual);
                btnLadder(btn, pnl);
            }
            else
            {
                Panel pnlAux = panelsAdded[logica - 1];
                upAtual = upIni;
                leftAtual = leftIni;
                pos = 0;
                Button btn = new Button();
                btn.Location = new Point(leftAtual, upAtual);
                btn.Height = 120;
                btn.Width = 150;
                btn.Text = nome;
                btn.Image = imageList1.Images[1];
                btn.TextImageRelation = TextImageRelation.TextAboveImage;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.LightBlue;
                btn.Tag = pos;
                btn.Click += delegate { btnLadder(btn, pnl); };
                pnl.Controls.Add(btn);
                buttonsAdded.Add(btn);
                aux.insereSED(nome, pos);
                int upAux = pnlAux.Bottom;
                pnl.Location = new Point(leftIni, upAux);
                changeColor(btn);
            }
            Controls.Add(pnl);
            #endregion
            txtNome.Text = "";
        }
        private void insereE(String nome)
        {
            panelAlterar.Visible = false;
            pos++;
            try
            {
                leftAtual += 150;
                Button btnAux = buttonsAdded[0];
                upAtual = btnAux.Location.Y;
                Logica aux = (Logica)logicas[logica];
                aux.insereE(nome, pos);
                Panel pnl = panelsAdded[logica];
                #region peçaE
                Button btn = new Button();
                btn.Location = new Point(leftAtual, upAtual);
                btn.Height = 120;
                btn.Width = 150;
                btn.Text = nome;
                btn.Image = imageList1.Images[2];
                btn.TextImageRelation = TextImageRelation.TextAboveImage;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = pos;
                btn.Click += delegate { btnLadder(btn, pnl); };
                pnl.Controls.Add(btn);
                buttonsAdded.Add(btn);
                btnLadder(btn, pnl);
                #endregion
                txtNome.Text = "";
            }
            catch
            {
                MessageBox.Show("Deve se iniciar com SEL ou SED");
            }
        }
        private void insereEN(String nome)
        {
            panelAlterar.Visible = false;
            pos++;
            try
            {
                leftAtual += 150;
                Button btnAux = buttonsAdded[0];
                upAtual = btnAux.Location.Y;
                Logica aux = (Logica)logicas[logica];
                aux.insereEN(nome, pos); Panel pnl = panelsAdded[logica];
                #region peçaEN
                Button btn = new Button();
                btn.Location = new Point(leftAtual, upAtual);
                btn.Height = 120;
                btn.Width = 150;
                btn.Text = nome;
                btn.Image = imageList1.Images[3];
                btn.TextImageRelation = TextImageRelation.TextAboveImage;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = pos;
                btn.Click += delegate { btnLadder(btn, pnl); };
                pnl.Controls.Add(btn);
                buttonsAdded.Add(btn);
                btnLadder(btn, pnl);
                #endregion
                txtNome.Text = "";
            }
            catch
            {
                MessageBox.Show("Deve se iniciar com SEL ou SED");
            }
        }
        private void insereOU(String nome)
        {
            panelAlterar.Visible = false;
            pos++;
            try
            {
                Logica aux = (Logica)logicas[logica];
                aux.insereOU(nome, pos);
                Panel pnl = panelsAdded[logica];
                if (leftAtual == 20)
                {
                    #region peçaOUs
                    Button btn = new Button();
                    btn.Location = new Point(leftAtual, upAtual + 120);
                    btn.Height = 120;
                    btn.Width = 150;
                    btn.Text = nome;
                    btn.Image = imageList1.Images[4];
                    btn.TextImageRelation = TextImageRelation.TextAboveImage;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Tag = pos;
                    btn.Click += delegate { btnLadder(btn, pnl); };
                    pnl.Controls.Add(btn);
                    buttonsAdded.Add(btn);
                    btnLadder(btn, pnl);
                    #endregion
                }
                else
                {
                    #region peçaOUm
                    Button btn = new Button();
                    btn.Location = new Point(leftAtual, upAtual + 120);
                    btn.Height = 120;
                    btn.Width = 150;
                    btn.Text = nome;
                    btn.Image = imageList1.Images[5];
                    btn.TextImageRelation = TextImageRelation.TextAboveImage;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.LightBlue;
                    btn.Tag = pos;
                    btn.AutoSize = true;
                    btn.Click += delegate { btnLadder(btn, pnl); };
                    pnl.Controls.Add(btn);
                    buttonsAdded.Add(btn);
                    btnLadder(btn, pnl);
                    #endregion
                    #region linhasDeContinuidadeOU
                    int leftAux = leftAtual;
                    while (leftAux >= 20)
                    {
                        leftAux -= 150;
                        if (leftAux == 20)
                        {
                            Button btn1 = new Button();
                            btn1.Location = new Point(leftAux, upAtual);
                            btn1.Height = 120;
                            btn1.Width = 150;
                            btn1.Text = " ";
                            btn1.Image = imageList1.Images[9];
                            btn1.TextImageRelation = TextImageRelation.TextAboveImage;
                            btn1.FlatStyle = FlatStyle.Flat;
                            btn1.BackColor = Color.White;
                            btn1.Tag = pos;
                            btn1.AutoSize = true;
                            pnl.Controls.Add(btn1);
                            buttonsAdded.Add(btn1);
                        }
                        else
                        {
                            if (leftAux > 20)
                            {
                                Button btn1 = new Button();
                                btn1.Location = new Point(leftAux, upAtual);
                                btn1.Height = 120;
                                btn1.Width = 150;
                                btn1.Text = " ";
                                btn1.Image = imageList1.Images[10];
                                btn1.TextImageRelation = TextImageRelation.TextAboveImage;
                                btn1.FlatStyle = FlatStyle.Flat;
                                btn1.BackColor = Color.White;
                                btn1.Tag = pos;
                                btn1.AutoSize = true;
                                pnl.Controls.Add(btn1);
                                buttonsAdded.Add(btn1);
                            }
                        }
                        #endregion
                    }
                }
                txtNome.Text = "";
            }
            catch
            {
                MessageBox.Show("Deve se iniciar com SEL ou SED");
            }
        }
        private void insereOUN(String nome)
        {
            panelAlterar.Visible = false;
            pos++;
            try
            {
                Logica aux = (Logica)logicas[logica];
                aux.insereOUN(nome, pos);
                Panel pnl = panelsAdded[logica];
                if (leftAtual == 20)
                {
                    #region peçaOUNs
                    Button btn = new Button();
                    btn.Location = new Point(leftAtual, upAtual + 120);
                    btn.Height = 120;
                    btn.Width = 150;
                    btn.Text = nome;
                    btn.Image = imageList1.Images[6];
                    btn.TextImageRelation = TextImageRelation.TextAboveImage;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Tag = pos;
                    btn.Click += delegate { btnLadder(btn, pnl); };
                    pnl.Controls.Add(btn);
                    buttonsAdded.Add(btn);
                    btnLadder(btn, pnl);
                    #endregion
                }
                else
                {
                    #region peçaOUNm
                    Button btn = new Button();
                    btn.Location = new Point(leftAtual, upAtual + 120);
                    btn.Height = 120;
                    btn.Width = 150;
                    btn.Text = nome;
                    btn.Image = imageList1.Images[7];
                    btn.TextImageRelation = TextImageRelation.TextAboveImage;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Tag = pos;
                    btn.AutoSize = true;
                    btn.Click += delegate { btnLadder(btn, pnl); };
                    pnl.Controls.Add(btn);
                    buttonsAdded.Add(btn);
                    btnLadder(btn, pnl);
                    #endregion
                    #region linhasDeContinuidadeOUN
                    int leftAux = leftAtual;
                    while (leftAux >= 20)
                    {
                        leftAux -= 150;
                        if (leftAux == 20)
                        {
                            Button btn1 = new Button();
                            btn1.Location = new Point(leftAux, upAtual);
                            btn1.Height = 120;
                            btn1.Width = 150;
                            btn1.Text = " ";
                            btn1.Image = imageList1.Images[9];
                            btn1.TextImageRelation = TextImageRelation.TextAboveImage;
                            btn1.FlatStyle = FlatStyle.Flat;
                            btn1.BackColor = Color.White;
                            btn1.Tag = pos;
                            btn1.AutoSize = true;
                            pnl.Controls.Add(btn1);
                            buttonsAdded.Add(btn1);
                        }
                        else
                        {
                            if (leftAux > 20)
                            {
                                Button btn1 = new Button();
                                btn1.Location = new Point(leftAux, upAtual);
                                btn1.Height = 120;
                                btn1.Width = 150;
                                btn1.Text = " ";
                                btn1.Image = imageList1.Images[10];
                                btn1.TextImageRelation = TextImageRelation.TextAboveImage;
                                btn1.FlatStyle = FlatStyle.Flat;
                                btn1.BackColor = Color.White;
                                btn1.Tag = pos;
                                btn1.AutoSize = true;
                                pnl.Controls.Add(btn1);
                                buttonsAdded.Add(btn1);
                            }
                        }
                        #endregion
                    }
                }
                txtNome.Text = "";
            }
            catch
            {
                MessageBox.Show("Deve se iniciar com SEL ou SED");
            }
        }
        private void insereMEMO(String nome)
        {
            panelAlterar.Visible = false;
            try
            {
                leftAtual += 150;
                Button btnAux = buttonsAdded[0];
                upAtual = btnAux.Location.Y;
                Logica aux = (Logica)logicas[logica];
                ArrayList instrucoes = aux.obterArrayList();
                pos = instrucoes.Count;
                aux.insereMEMO(nome, pos);
                Panel pnl = panelsAdded[logica];
                #region peçaMEMO
                Button btn = new Button();
                btn.Location = new Point(leftAtual, upAtual);
                btn.Height = 120;
                btn.Width = 150;
                btn.Text = nome;
                btn.Image = imageList1.Images[8];
                btn.TextImageRelation = TextImageRelation.TextAboveImage;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = pos;
                btn.Click += delegate { btnLadder(btn, pnl); };
                pnl.Controls.Add(btn);
                buttonsAdded.Add(btn);
                btnLadder(btn, pnl);
                #endregion
                txtNome.Text = "";
                btn.AccessibleDescription = "Full";
            }
            catch
            {
                MessageBox.Show("Deve se iniciar com SEL ou SED");
            }
        }
        #endregion

        #region Comandos
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Logica logicaAux = (Logica)logicas[logica];
                ArrayList instAux = logicaAux.obterArrayList();
                Instrucao inst = (Instrucao)instAux[pos];
                txtNovoNome.Text = inst.obterNome();
                txtNovoNome.SelectedText = null;
                rbn1.Visible = true;
                rbn2.Visible = true;
                label2.Visible = true;
                switch (inst.obterTipo())
                {
                    case "SEL": rbn1.Text = "SEL";
                        rbn2.Text = "SED";
                        rbn1.Select();
                        break;
                    case "SED": rbn1.Text = "SEL";
                        rbn2.Text = "SED";
                        rbn2.Select();
                        break;
                    case "E": rbn1.Text = "E";
                        rbn2.Text = "EN";
                        rbn1.Select();
                        break;
                    case "EN": rbn1.Text = "E";
                        rbn2.Text = "EN";
                        rbn2.Select();
                        break;
                    case "OU": rbn1.Text = "OU";
                        rbn2.Text = "OUN";
                        rbn1.Select();
                        break;
                    case "OUN": rbn1.Text = "OU";
                        rbn2.Text = "OUN";
                        rbn2.Select();
                        break;
                    case "MEMO":
                        rbn1.Text = "MEMO";
                        rbn1.Visible = false;
                        rbn2.Visible = false;
                        label2.Visible = false;
                        break;
                    default: break;
                }
                panelAlterar.Visible = true;
            }
            catch
            {
                MessageBox.Show("Nada para alterar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool flagLog = true;
            try
            {
                panelAlterar.Visible = false;
                Panel pnlAux = panelsAdded[logica];
                Logica aux = (Logica)logicas[logica];
                flagLog = aux.removerInstrucao(pos);
            }
            catch
            {
                MessageBox.Show("Nada para remover");
            }
            if (!flagLog)
                logicas.Remove(logicas[logica]);
            redraw();
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            String novoNome = txtNovoNome.Text;
            if (rbn1.Text == "SEL")
            {
                if (rbn1.Checked)
                    alterarInstrucao("SEL", novoNome);
                else
                    alterarInstrucao("SED", novoNome);
            }
            if (rbn1.Text == "E")
            {
                if (rbn1.Checked)
                    alterarInstrucao("E", novoNome);
                else
                    alterarInstrucao("EN", novoNome);
            }
            if (rbn1.Text == "OU")
            {
                if (rbn1.Checked)
                    alterarInstrucao("OU", novoNome);
                else
                    alterarInstrucao("OUN", novoNome);
            }
            if (rbn1.Text == "MEMO")
            {
                alterarInstrucao("MEMO", novoNome);
            }
            redraw();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                panelAlterar.Visible = false;
                String lg = "";
                Logica aux = (Logica)logicas[logica];
                lg = aux.obterML();
                Clipboard.SetText(lg);
            }
            catch
            {
                MessageBox.Show("Nada para exportar");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            #region limpaEspaço
            logica = logicas.Count - 1;
            limpaTela();
            while (logicas.Count > 0)
            {
                Logica aux = (Logica)logicas[logica];
                logicas.Remove(aux);
                logica--;
            }
            upAtual = upIni;
            leftAtual = leftIni;
            logica = -1;
            pos = 0;
            panelAlterar.Visible = false;
            #endregion
        }
        
        private void btnColar_Click(object sender, EventArgs e)
        {
            String logicaML = Clipboard.GetText();
            colarML(logicaML);
        }

        private void btnCancelaAlteracao_Click(object sender, EventArgs e)
        {
            panelAlterar.Visible = false;
        }
        #endregion
    }
}