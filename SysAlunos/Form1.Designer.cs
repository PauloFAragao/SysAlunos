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
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Txt_nome_adiconar = new System.Windows.Forms.TextBox();
            this.Txt_numero_adiconar = new System.Windows.Forms.TextBox();
            this.Btn_inserir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.Txt_notapt = new System.Windows.Forms.TextBox();
            this.Txt_notast = new System.Windows.Forms.TextBox();
            this.Txt_notaqt = new System.Windows.Forms.TextBox();
            this.Txt_notatt = new System.Windows.Forms.TextBox();
            this.Btn_editar_notas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_id_editar_ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.dataLista.Size = new System.Drawing.Size(827, 452);
            this.dataLista.TabIndex = 2;
            // 
            // Txt_nome_adiconar
            // 
            this.Txt_nome_adiconar.Location = new System.Drawing.Point(65, 24);
            this.Txt_nome_adiconar.Name = "Txt_nome_adiconar";
            this.Txt_nome_adiconar.Size = new System.Drawing.Size(145, 20);
            this.Txt_nome_adiconar.TabIndex = 3;
            // 
            // Txt_numero_adiconar
            // 
            this.Txt_numero_adiconar.Location = new System.Drawing.Point(74, 62);
            this.Txt_numero_adiconar.Name = "Txt_numero_adiconar";
            this.Txt_numero_adiconar.Size = new System.Drawing.Size(136, 20);
            this.Txt_numero_adiconar.TabIndex = 4;
            // 
            // Btn_inserir
            // 
            this.Btn_inserir.Location = new System.Drawing.Point(24, 106);
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
            this.tabControl1.Size = new System.Drawing.Size(847, 517);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_nome);
            this.tabPage1.Controls.Add(this.dataLista);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            this.tabPage2.Size = new System.Drawing.Size(839, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Temprario - Editar Aluno";
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(579, 102);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar.TabIndex = 11;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Txt_id_editar
            // 
            this.Txt_id_editar.Location = new System.Drawing.Point(418, 74);
            this.Txt_id_editar.Name = "Txt_id_editar";
            this.Txt_id_editar.Size = new System.Drawing.Size(145, 20);
            this.Txt_id_editar.TabIndex = 10;
            // 
            // Txt_numero_editar
            // 
            this.Txt_numero_editar.Location = new System.Drawing.Point(418, 126);
            this.Txt_numero_editar.Name = "Txt_numero_editar";
            this.Txt_numero_editar.Size = new System.Drawing.Size(145, 20);
            this.Txt_numero_editar.TabIndex = 9;
            // 
            // Txt_nome_editar
            // 
            this.Txt_nome_editar.Location = new System.Drawing.Point(418, 100);
            this.Txt_nome_editar.Name = "Txt_nome_editar";
            this.Txt_nome_editar.Size = new System.Drawing.Size(145, 20);
            this.Txt_nome_editar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // Lbl_retorno
            // 
            this.Lbl_retorno.AutoSize = true;
            this.Lbl_retorno.Location = new System.Drawing.Point(302, 17);
            this.Lbl_retorno.Name = "Lbl_retorno";
            this.Lbl_retorno.Size = new System.Drawing.Size(22, 13);
            this.Lbl_retorno.TabIndex = 7;
            this.Lbl_retorno.Text = "- - -";
            // 
            // Txt_notapt
            // 
            this.Txt_notapt.Location = new System.Drawing.Point(340, 220);
            this.Txt_notapt.Name = "Txt_notapt";
            this.Txt_notapt.Size = new System.Drawing.Size(70, 20);
            this.Txt_notapt.TabIndex = 16;
            // 
            // Txt_notast
            // 
            this.Txt_notast.Location = new System.Drawing.Point(416, 220);
            this.Txt_notast.Name = "Txt_notast";
            this.Txt_notast.Size = new System.Drawing.Size(70, 20);
            this.Txt_notast.TabIndex = 17;
            // 
            // Txt_notaqt
            // 
            this.Txt_notaqt.Location = new System.Drawing.Point(568, 220);
            this.Txt_notaqt.Name = "Txt_notaqt";
            this.Txt_notaqt.Size = new System.Drawing.Size(70, 20);
            this.Txt_notaqt.TabIndex = 19;
            // 
            // Txt_notatt
            // 
            this.Txt_notatt.Location = new System.Drawing.Point(492, 220);
            this.Txt_notatt.Name = "Txt_notatt";
            this.Txt_notatt.Size = new System.Drawing.Size(70, 20);
            this.Txt_notatt.TabIndex = 18;
            // 
            // Btn_editar_notas
            // 
            this.Btn_editar_notas.Location = new System.Drawing.Point(450, 246);
            this.Btn_editar_notas.Name = "Btn_editar_notas";
            this.Btn_editar_notas.Size = new System.Drawing.Size(75, 23);
            this.Btn_editar_notas.TabIndex = 20;
            this.Btn_editar_notas.Text = "Editar";
            this.Btn_editar_notas.UseVisualStyleBackColor = true;
            this.Btn_editar_notas.Click += new System.EventHandler(this.Btn_editar_notas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID";
            // 
            // Txt_id_editar_
            // 
            this.Txt_id_editar_.Location = new System.Drawing.Point(418, 194);
            this.Txt_id_editar_.Name = "Txt_id_editar_";
            this.Txt_id_editar_.Size = new System.Drawing.Size(145, 20);
            this.Txt_id_editar_.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Temprario - Editar Notas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 565);
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
    }
}

