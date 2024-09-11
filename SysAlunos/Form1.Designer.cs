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
            this.Txt_nome_adiconar = new System.Windows.Forms.TextBox();
            this.Txt_numero_adiconar = new System.Windows.Forms.TextBox();
            this.Btn_inserir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnDeletar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_id_deletar = new System.Windows.Forms.TextBox();
            this.Btn_deletar = new System.Windows.Forms.Button();
            this.Cbx_status = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_id_status = new System.Windows.Forms.TextBox();
            this.Btn_editar_status = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_id_editar_ = new System.Windows.Forms.TextBox();
            this.Btn_editar_notas = new System.Windows.Forms.Button();
            this.Txt_notaqt = new System.Windows.Forms.TextBox();
            this.Txt_notatt = new System.Windows.Forms.TextBox();
            this.Txt_notast = new System.Windows.Forms.TextBox();
            this.Txt_notapt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Txt_id_editar = new System.Windows.Forms.TextBox();
            this.Txt_numero_editar = new System.Windows.Forms.TextBox();
            this.Txt_nome_editar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_retorno = new System.Windows.Forms.Label();
            this.ErrorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.CbxStatus = new System.Windows.Forms.ComboBox();
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
            // Txt_nome_adiconar
            // 
            this.Txt_nome_adiconar.Location = new System.Drawing.Point(724, 19);
            this.Txt_nome_adiconar.Name = "Txt_nome_adiconar";
            this.Txt_nome_adiconar.Size = new System.Drawing.Size(145, 20);
            this.Txt_nome_adiconar.TabIndex = 3;
            // 
            // Txt_numero_adiconar
            // 
            this.Txt_numero_adiconar.Location = new System.Drawing.Point(733, 57);
            this.Txt_numero_adiconar.Name = "Txt_numero_adiconar";
            this.Txt_numero_adiconar.Size = new System.Drawing.Size(136, 20);
            this.Txt_numero_adiconar.TabIndex = 4;
            // 
            // Btn_inserir
            // 
            this.Btn_inserir.Location = new System.Drawing.Point(890, 34);
            this.Btn_inserir.Name = "Btn_inserir";
            this.Btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.Btn_inserir.TabIndex = 5;
            this.Btn_inserir.Text = "Inserir";
            this.Btn_inserir.UseVisualStyleBackColor = true;
            this.Btn_inserir.Click += new System.EventHandler(this.Btn_inserir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 517);
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
            this.tabPage1.Size = new System.Drawing.Size(1081, 491);
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
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(548, 6);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 4;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.Txt_id_deletar);
            this.tabPage2.Controls.Add(this.Btn_deletar);
            this.tabPage2.Controls.Add(this.Cbx_status);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.Txt_id_status);
            this.tabPage2.Controls.Add(this.Btn_editar_status);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Txt_id_editar_);
            this.tabPage2.Controls.Add(this.Btn_editar_notas);
            this.tabPage2.Controls.Add(this.Txt_notaqt);
            this.tabPage2.Controls.Add(this.Txt_notatt);
            this.tabPage2.Controls.Add(this.Txt_notast);
            this.tabPage2.Controls.Add(this.Txt_notapt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btn_editar);
            this.tabPage2.Controls.Add(this.Txt_id_editar);
            this.tabPage2.Controls.Add(this.Txt_numero_editar);
            this.tabPage2.Controls.Add(this.Txt_nome_editar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Txt_nome_adiconar);
            this.tabPage2.Controls.Add(this.Btn_inserir);
            this.tabPage2.Controls.Add(this.Txt_numero_adiconar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(901, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "ID";
            // 
            // Txt_id_deletar
            // 
            this.Txt_id_deletar.Location = new System.Drawing.Point(925, 125);
            this.Txt_id_deletar.Name = "Txt_id_deletar";
            this.Txt_id_deletar.Size = new System.Drawing.Size(145, 20);
            this.Txt_id_deletar.TabIndex = 32;
            // 
            // Btn_deletar
            // 
            this.Btn_deletar.Location = new System.Drawing.Point(961, 153);
            this.Btn_deletar.Name = "Btn_deletar";
            this.Btn_deletar.Size = new System.Drawing.Size(75, 23);
            this.Btn_deletar.TabIndex = 31;
            this.Btn_deletar.Text = "Deletar";
            this.Btn_deletar.UseVisualStyleBackColor = true;
            this.Btn_deletar.Click += new System.EventHandler(this.Btn_deletar_Click);
            // 
            // Cbx_status
            // 
            this.Cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_status.FormattingEnabled = true;
            this.Cbx_status.Items.AddRange(new object[] {
            "Aprovado",
            "Reprovado"});
            this.Cbx_status.Location = new System.Drawing.Point(667, 392);
            this.Cbx_status.Name = "Cbx_status";
            this.Cbx_status.Size = new System.Drawing.Size(145, 21);
            this.Cbx_status.TabIndex = 30;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Temprario - Editar  Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(643, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "ID";
            // 
            // Txt_id_status
            // 
            this.Txt_id_status.Location = new System.Drawing.Point(667, 366);
            this.Txt_id_status.Name = "Txt_id_status";
            this.Txt_id_status.Size = new System.Drawing.Size(145, 20);
            this.Txt_id_status.TabIndex = 26;
            // 
            // Btn_editar_status
            // 
            this.Btn_editar_status.Location = new System.Drawing.Point(714, 419);
            this.Btn_editar_status.Name = "Btn_editar_status";
            this.Btn_editar_status.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar_status.TabIndex = 25;
            this.Btn_editar_status.Text = "Editar";
            this.Btn_editar_status.UseVisualStyleBackColor = true;
            this.Btn_editar_status.Click += new System.EventHandler(this.Btn_editar_status_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Temprario - Editar Notas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID";
            // 
            // Txt_id_editar_
            // 
            this.Txt_id_editar_.Location = new System.Drawing.Point(666, 241);
            this.Txt_id_editar_.Name = "Txt_id_editar_";
            this.Txt_id_editar_.Size = new System.Drawing.Size(145, 20);
            this.Txt_id_editar_.TabIndex = 21;
            // 
            // Btn_editar_notas
            // 
            this.Btn_editar_notas.Location = new System.Drawing.Point(698, 293);
            this.Btn_editar_notas.Name = "Btn_editar_notas";
            this.Btn_editar_notas.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar_notas.TabIndex = 20;
            this.Btn_editar_notas.Text = "Editar";
            this.Btn_editar_notas.UseVisualStyleBackColor = true;
            this.Btn_editar_notas.Click += new System.EventHandler(this.Btn_editar_notas_Click);
            // 
            // Txt_notaqt
            // 
            this.Txt_notaqt.Location = new System.Drawing.Point(816, 267);
            this.Txt_notaqt.Name = "Txt_notaqt";
            this.Txt_notaqt.Size = new System.Drawing.Size(70, 20);
            this.Txt_notaqt.TabIndex = 19;
            // 
            // Txt_notatt
            // 
            this.Txt_notatt.Location = new System.Drawing.Point(740, 267);
            this.Txt_notatt.Name = "Txt_notatt";
            this.Txt_notatt.Size = new System.Drawing.Size(70, 20);
            this.Txt_notatt.TabIndex = 18;
            // 
            // Txt_notast
            // 
            this.Txt_notast.Location = new System.Drawing.Point(664, 267);
            this.Txt_notast.Name = "Txt_notast";
            this.Txt_notast.Size = new System.Drawing.Size(70, 20);
            this.Txt_notast.TabIndex = 17;
            // 
            // Txt_notapt
            // 
            this.Txt_notapt.Location = new System.Drawing.Point(588, 267);
            this.Txt_notapt.Name = "Txt_notapt";
            this.Txt_notapt.Size = new System.Drawing.Size(70, 20);
            this.Txt_notapt.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Temprario - Editar Aluno";
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(820, 153);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar.TabIndex = 11;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Txt_id_editar
            // 
            this.Txt_id_editar.Location = new System.Drawing.Point(657, 125);
            this.Txt_id_editar.Name = "Txt_id_editar";
            this.Txt_id_editar.Size = new System.Drawing.Size(103, 20);
            this.Txt_id_editar.TabIndex = 10;
            // 
            // Txt_numero_editar
            // 
            this.Txt_numero_editar.Location = new System.Drawing.Point(659, 177);
            this.Txt_numero_editar.Name = "Txt_numero_editar";
            this.Txt_numero_editar.Size = new System.Drawing.Size(145, 20);
            this.Txt_numero_editar.TabIndex = 9;
            // 
            // Txt_nome_editar
            // 
            this.Txt_nome_editar.Location = new System.Drawing.Point(659, 151);
            this.Txt_nome_editar.Name = "Txt_nome_editar";
            this.Txt_nome_editar.Size = new System.Drawing.Size(145, 20);
            this.Txt_nome_editar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
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
        private System.Windows.Forms.TextBox Txt_nome_adiconar;
        private System.Windows.Forms.TextBox Txt_numero_adiconar;
        private System.Windows.Forms.Button Btn_inserir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_retorno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox Txt_id_editar;
        private System.Windows.Forms.TextBox Txt_numero_editar;
        private System.Windows.Forms.TextBox Txt_nome_editar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_id_editar_;
        private System.Windows.Forms.Button Btn_editar_notas;
        private System.Windows.Forms.TextBox Txt_notaqt;
        private System.Windows.Forms.TextBox Txt_notatt;
        private System.Windows.Forms.TextBox Txt_notast;
        private System.Windows.Forms.TextBox Txt_notapt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_id_status;
        private System.Windows.Forms.Button Btn_editar_status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Cbx_status;
        private System.Windows.Forms.ErrorProvider ErrorIcone;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.TextBox Txt_id_deletar;
        private System.Windows.Forms.Button Btn_deletar;
        private System.Windows.Forms.Button BtnDeletar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label label12;
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

