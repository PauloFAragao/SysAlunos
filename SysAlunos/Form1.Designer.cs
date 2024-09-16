namespace SysAlunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.BtnInserirAluno = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.ChkEditarStatus = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ChkEditarNotas = new System.Windows.Forms.CheckBox();
            this.TxtNQT = new System.Windows.Forms.TextBox();
            this.TxtNTT = new System.Windows.Forms.TextBox();
            this.TxtNST = new System.Windows.Forms.TextBox();
            this.TxtNPT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Lbl_retorno = new System.Windows.Forms.Label();
            this.ErrorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(6, 6);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(145, 20);
            this.Txt_nome.TabIndex = 0;
            this.Txt_nome.TextChanged += new System.EventHandler(this.Txt_nome_TextChanged);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(157, 4);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar.TabIndex = 1;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(6, 33);
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.Size = new System.Drawing.Size(1069, 452);
            this.dataLista.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1111, 565);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnDeletar);
            this.tabPage1.Controls.Add(this.BtnEditar);
            this.tabPage1.Controls.Add(this.BtnInserir);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_nome);
            this.tabPage1.Controls.Add(this.dataLista);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1103, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnDeletar
            // 
            this.BtnDeletar.Location = new System.Drawing.Point(629, 6);
            this.BtnDeletar.Name = "BtnDeletar";
            this.BtnDeletar.Size = new System.Drawing.Size(75, 23);
            this.BtnDeletar.TabIndex = 5;
            this.BtnDeletar.Text = "Deletar";
            this.BtnDeletar.UseVisualStyleBackColor = true;
            this.BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(548, 6);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(467, 6);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 23);
            this.BtnInserir.TabIndex = 3;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CbxStatus);
            this.tabPage2.Controls.Add(this.BtnInserirAluno);
            this.tabPage2.Controls.Add(this.BtnCancelar);
            this.tabPage2.Controls.Add(this.BtnSalvar);
            this.tabPage2.Controls.Add(this.ChkEditarStatus);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.ChkEditarNotas);
            this.tabPage2.Controls.Add(this.TxtNQT);
            this.tabPage2.Controls.Add(this.TxtNTT);
            this.tabPage2.Controls.Add(this.TxtNST);
            this.tabPage2.Controls.Add(this.TxtNPT);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.TxtId);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.TxtNome);
            this.tabPage2.Controls.Add(this.TxtNumero);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CbxStatus
            // 
            this.CbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatus.Enabled = false;
            this.CbxStatus.FormattingEnabled = true;
            this.CbxStatus.Items.AddRange(new object[] {
            "Aprovado",
            "Reprovado"});
            this.CbxStatus.Location = new System.Drawing.Point(75, 324);
            this.CbxStatus.Name = "CbxStatus";
            this.CbxStatus.Size = new System.Drawing.Size(145, 21);
            this.CbxStatus.TabIndex = 53;
            // 
            // BtnInserirAluno
            // 
            this.BtnInserirAluno.Location = new System.Drawing.Point(237, 361);
            this.BtnInserirAluno.Name = "BtnInserirAluno";
            this.BtnInserirAluno.Size = new System.Drawing.Size(75, 23);
            this.BtnInserirAluno.TabIndex = 52;
            this.BtnInserirAluno.Text = "Inserir";
            this.BtnInserirAluno.UseVisualStyleBackColor = true;
            this.BtnInserirAluno.Click += new System.EventHandler(this.BtnInserirAluno_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Enabled = false;
            this.BtnCancelar.Location = new System.Drawing.Point(128, 361);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 51;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.Location = new System.Drawing.Point(37, 361);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 50;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // ChkEditarStatus
            // 
            this.ChkEditarStatus.AutoSize = true;
            this.ChkEditarStatus.Enabled = false;
            this.ChkEditarStatus.Location = new System.Drawing.Point(75, 299);
            this.ChkEditarStatus.Name = "ChkEditarStatus";
            this.ChkEditarStatus.Size = new System.Drawing.Size(86, 17);
            this.ChkEditarStatus.TabIndex = 49;
            this.ChkEditarStatus.Text = "Editar Status";
            this.ChkEditarStatus.UseVisualStyleBackColor = true;
            this.ChkEditarStatus.CheckedChanged += new System.EventHandler(this.ChkEditarStatus_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 254);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Quarto Trimestre:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "Terceiro Trimestre:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "Segundo Trimestre:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Primeiro Trimestre:";
            // 
            // ChkEditarNotas
            // 
            this.ChkEditarNotas.AutoSize = true;
            this.ChkEditarNotas.Enabled = false;
            this.ChkEditarNotas.Location = new System.Drawing.Point(77, 109);
            this.ChkEditarNotas.Name = "ChkEditarNotas";
            this.ChkEditarNotas.Size = new System.Drawing.Size(84, 17);
            this.ChkEditarNotas.TabIndex = 44;
            this.ChkEditarNotas.Text = "Editar Notas";
            this.ChkEditarNotas.UseVisualStyleBackColor = true;
            this.ChkEditarNotas.CheckedChanged += new System.EventHandler(this.ChkEditarNotas_CheckedChanged);
            // 
            // TxtNQT
            // 
            this.TxtNQT.Enabled = false;
            this.TxtNQT.Location = new System.Drawing.Point(77, 270);
            this.TxtNQT.Name = "TxtNQT";
            this.TxtNQT.Size = new System.Drawing.Size(70, 20);
            this.TxtNQT.TabIndex = 43;
            // 
            // TxtNTT
            // 
            this.TxtNTT.Enabled = false;
            this.TxtNTT.Location = new System.Drawing.Point(77, 228);
            this.TxtNTT.Name = "TxtNTT";
            this.TxtNTT.Size = new System.Drawing.Size(70, 20);
            this.TxtNTT.TabIndex = 42;
            // 
            // TxtNST
            // 
            this.TxtNST.Enabled = false;
            this.TxtNST.Location = new System.Drawing.Point(77, 186);
            this.TxtNST.Name = "TxtNST";
            this.TxtNST.Size = new System.Drawing.Size(70, 20);
            this.TxtNST.TabIndex = 41;
            // 
            // TxtNPT
            // 
            this.TxtNPT.Enabled = false;
            this.TxtNPT.Location = new System.Drawing.Point(77, 146);
            this.TxtNPT.Name = "TxtNPT";
            this.TxtNPT.Size = new System.Drawing.Size(70, 20);
            this.TxtNPT.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(53, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "ID";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(77, 31);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(70, 20);
            this.TxtId.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Número:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(77, 57);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(238, 20);
            this.TxtNome.TabIndex = 34;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Enabled = false;
            this.TxtNumero.Location = new System.Drawing.Point(77, 83);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(70, 20);
            this.TxtNumero.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Status";
            // 
            // Lbl_retorno
            // 
            this.Lbl_retorno.AutoSize = true;
            this.Lbl_retorno.Location = new System.Drawing.Point(277, 9);
            this.Lbl_retorno.Name = "Lbl_retorno";
            this.Lbl_retorno.Size = new System.Drawing.Size(22, 13);
            this.Lbl_retorno.TabIndex = 7;
            this.Lbl_retorno.Text = "- - -";
            // 
            // ErrorIcone
            // 
            this.ErrorIcone.ContainerControl = this;
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 565);
            this.Controls.Add(this.Lbl_retorno);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Lbl_retorno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider ErrorIcone;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox ChkEditarNotas;
        private System.Windows.Forms.TextBox TxtNQT;
        private System.Windows.Forms.TextBox TxtNTT;
        private System.Windows.Forms.TextBox TxtNST;
        private System.Windows.Forms.TextBox TxtNPT;
        private System.Windows.Forms.CheckBox ChkEditarStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnInserirAluno;
        private System.Windows.Forms.ComboBox CbxStatus;
    }
}

