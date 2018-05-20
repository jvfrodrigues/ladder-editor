namespace teste1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbn2 = new System.Windows.Forms.RadioButton();
            this.rbn1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.panelAlterar = new System.Windows.Forms.Panel();
            this.btnCancelaAlteracao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMEMO = new System.Windows.Forms.Button();
            this.btnOUN = new System.Windows.Forms.Button();
            this.btnOU = new System.Windows.Forms.Button();
            this.btnEN = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnSED = new System.Windows.Forms.Button();
            this.btnSEL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelAlterar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "SEL.jpg");
            this.imageList1.Images.SetKeyName(1, "SED.jpg");
            this.imageList1.Images.SetKeyName(2, "E.jpg");
            this.imageList1.Images.SetKeyName(3, "EN.jpg");
            this.imageList1.Images.SetKeyName(4, "OUs.jpg");
            this.imageList1.Images.SetKeyName(5, "OUm.jpg");
            this.imageList1.Images.SetKeyName(6, "OUNs.jpg");
            this.imageList1.Images.SetKeyName(7, "OUNm.jpg");
            this.imageList1.Images.SetKeyName(8, "MEMO.jpg");
            this.imageList1.Images.SetKeyName(9, "fim.jpg");
            this.imageList1.Images.SetKeyName(10, "med.jpg");
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(43, 123);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(81, 34);
            this.btnConfirmaAlteracao.TabIndex = 21;
            this.btnConfirmaAlteracao.Text = "Ok";
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo";
            // 
            // rbn2
            // 
            this.rbn2.AutoSize = true;
            this.rbn2.Location = new System.Drawing.Point(198, 73);
            this.rbn2.Name = "rbn2";
            this.rbn2.Size = new System.Drawing.Size(40, 17);
            this.rbn2.TabIndex = 19;
            this.rbn2.TabStop = true;
            this.rbn2.Text = "EN";
            this.rbn2.UseVisualStyleBackColor = true;
            // 
            // rbn1
            // 
            this.rbn1.AutoSize = true;
            this.rbn1.Location = new System.Drawing.Point(198, 50);
            this.rbn1.Name = "rbn1";
            this.rbn1.Size = new System.Drawing.Size(32, 17);
            this.rbn1.TabIndex = 18;
            this.rbn1.TabStop = true;
            this.rbn1.Text = "E";
            this.rbn1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome";
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Location = new System.Drawing.Point(24, 50);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(100, 20);
            this.txtNovoNome.TabIndex = 16;
            // 
            // panelAlterar
            // 
            this.panelAlterar.Controls.Add(this.btnCancelaAlteracao);
            this.panelAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.panelAlterar.Controls.Add(this.txtNovoNome);
            this.panelAlterar.Controls.Add(this.label2);
            this.panelAlterar.Controls.Add(this.label3);
            this.panelAlterar.Controls.Add(this.rbn2);
            this.panelAlterar.Controls.Add(this.rbn1);
            this.panelAlterar.Location = new System.Drawing.Point(340, 137);
            this.panelAlterar.Name = "panelAlterar";
            this.panelAlterar.Size = new System.Drawing.Size(278, 191);
            this.panelAlterar.TabIndex = 22;
            // 
            // btnCancelaAlteracao
            // 
            this.btnCancelaAlteracao.Location = new System.Drawing.Point(142, 123);
            this.btnCancelaAlteracao.Name = "btnCancelaAlteracao";
            this.btnCancelaAlteracao.Size = new System.Drawing.Size(81, 34);
            this.btnCancelaAlteracao.TabIndex = 22;
            this.btnCancelaAlteracao.Text = "Cancelar";
            this.btnCancelaAlteracao.UseVisualStyleBackColor = true;
            this.btnCancelaAlteracao.Click += new System.EventHandler(this.btnCancelaAlteracao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMEMO);
            this.groupBox1.Controls.Add(this.btnOUN);
            this.groupBox1.Controls.Add(this.btnOU);
            this.groupBox1.Controls.Add(this.btnEN);
            this.groupBox1.Controls.Add(this.btnE);
            this.groupBox1.Controls.Add(this.btnSED);
            this.groupBox1.Controls.Add(this.btnSEL);
            this.groupBox1.Location = new System.Drawing.Point(138, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 63);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instrucões";
            // 
            // btnMEMO
            // 
            this.btnMEMO.Location = new System.Drawing.Point(498, 26);
            this.btnMEMO.Name = "btnMEMO";
            this.btnMEMO.Size = new System.Drawing.Size(75, 23);
            this.btnMEMO.TabIndex = 14;
            this.btnMEMO.Text = "MEMO";
            this.btnMEMO.UseVisualStyleBackColor = true;
            this.btnMEMO.Click += new System.EventHandler(this.btnMEMO_Click);
            // 
            // btnOUN
            // 
            this.btnOUN.Location = new System.Drawing.Point(417, 26);
            this.btnOUN.Name = "btnOUN";
            this.btnOUN.Size = new System.Drawing.Size(75, 23);
            this.btnOUN.TabIndex = 13;
            this.btnOUN.Text = "OUN";
            this.btnOUN.UseVisualStyleBackColor = true;
            this.btnOUN.Click += new System.EventHandler(this.btnOUN_Click);
            // 
            // btnOU
            // 
            this.btnOU.Location = new System.Drawing.Point(336, 25);
            this.btnOU.Name = "btnOU";
            this.btnOU.Size = new System.Drawing.Size(75, 23);
            this.btnOU.TabIndex = 12;
            this.btnOU.Text = "OU";
            this.btnOU.UseVisualStyleBackColor = true;
            this.btnOU.Click += new System.EventHandler(this.btnOU_Click);
            // 
            // btnEN
            // 
            this.btnEN.Location = new System.Drawing.Point(255, 25);
            this.btnEN.Name = "btnEN";
            this.btnEN.Size = new System.Drawing.Size(75, 23);
            this.btnEN.TabIndex = 11;
            this.btnEN.Text = "EN";
            this.btnEN.UseVisualStyleBackColor = true;
            this.btnEN.Click += new System.EventHandler(this.btnEN_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(174, 25);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 23);
            this.btnE.TabIndex = 10;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnSED
            // 
            this.btnSED.Location = new System.Drawing.Point(93, 25);
            this.btnSED.Name = "btnSED";
            this.btnSED.Size = new System.Drawing.Size(75, 23);
            this.btnSED.TabIndex = 9;
            this.btnSED.Text = "SED";
            this.btnSED.UseVisualStyleBackColor = true;
            this.btnSED.Click += new System.EventHandler(this.btnSED_Click);
            // 
            // btnSEL
            // 
            this.btnSEL.BackColor = System.Drawing.SystemColors.Control;
            this.btnSEL.Location = new System.Drawing.Point(12, 25);
            this.btnSEL.Name = "btnSEL";
            this.btnSEL.Size = new System.Drawing.Size(75, 23);
            this.btnSEL.TabIndex = 8;
            this.btnSEL.Text = "SEL";
            this.btnSEL.UseVisualStyleBackColor = false;
            this.btnSEL.Click += new System.EventHandler(this.btnSEL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnCopiar);
            this.groupBox2.Location = new System.Drawing.Point(736, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 115);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comandos";
            // 
            // btnColar
            // 
            this.btnColar.Location = new System.Drawing.Point(143, 48);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(119, 23);
            this.btnColar.TabIndex = 20;
            this.btnColar.Text = "Colar lógicas";
            this.btnColar.UseVisualStyleBackColor = true;
            this.btnColar.Click += new System.EventHandler(this.btnColar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(20, 48);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir instrução";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(20, 19);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar instrução";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(143, 77);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 23);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar espaço";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(143, 19);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(119, 23);
            this.btnCopiar.TabIndex = 16;
            this.btnCopiar.Text = "Copiar lógica atual";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNome);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(116, 49);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nome instrução";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1030, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelAlterar);
            this.Name = "FormPrincipal";
            this.Text = "Editor Ladder";
            this.panelAlterar.ResumeLayout(false);
            this.panelAlterar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbn2;
        private System.Windows.Forms.RadioButton rbn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.Panel panelAlterar;
        private System.Windows.Forms.Button btnCancelaAlteracao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMEMO;
        private System.Windows.Forms.Button btnOUN;
        private System.Windows.Forms.Button btnOU;
        private System.Windows.Forms.Button btnEN;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnSED;
        private System.Windows.Forms.Button btnSEL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

