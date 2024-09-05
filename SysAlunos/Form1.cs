﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAlunos
{
    public partial class Form1 : Form
    {
        Dados dados = new Dados();

        public Form1()
        {
            InitializeComponent();
        }

        //Mostrar no Data Grid
        private void Mostrar()
        {
            this.dataLista.DataSource = dados.Mostrar();
            OcultarColunas();
        }

        //Buscar pelo Nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = dados.BuscarNome(this.Txt_nome.Text);
            this.OcultarColunas();
        }

        //Inserção de alunos
        private void InserirAluno()
        {
            string nome = "";
            int numero = 0;

            //capturando o valor do campo nome
            if (!String.IsNullOrWhiteSpace(this.Txt_nome_adiconar.Text))
            {
                nome = this.Txt_nome_adiconar.Text;
            }
            else { Debug.WriteLine("Campo nome não preenchido"); }

            //capturando o valor do campo numero
            if (!String.IsNullOrWhiteSpace(this.Txt_numero_adiconar.Text))
            {
                if (int.TryParse(this.Txt_numero_adiconar.Text, out int parsedNumero))
                {
                    numero = parsedNumero;
                }
                else { Debug.WriteLine("O valor inserido no campo id não pode ser convertido para inteiro!"); }
            }
            else { Debug.WriteLine("Campo numero não preenchido"); }

            //string nome = this.Txt_nome_adiconar.Text;
            //int numero = int.Parse(this.Txt_numero_adiconar.Text);

            if (nome != null && numero > 0)
            {
                Lbl_retorno.Text = dados.Inserir(nome, numero);
            }
        }

        //Edição de alunos
        private void EditarAluno()
        {
            int id = 0;
            string nome = "";
            int numero = 0;

            //capturando o valor do campo id
            if (!String.IsNullOrWhiteSpace(this.Txt_id_editar.Text))
            {
                if (int.TryParse(this.Txt_id_editar.Text, out int parsedId))
                {
                    id = parsedId;
                }
                else { Debug.WriteLine("O valor inserido no campo id não pode ser convertido para inteiro!"); }
            } else { Debug.WriteLine("Campo id não preenchido"); }

            //capturando o valor do campo nome
            if (!String.IsNullOrWhiteSpace(this.Txt_nome_editar.Text))
            {
                nome = this.Txt_nome_editar.Text;
            }
            else { Debug.WriteLine("Campo nome não preenchido"); }

            //capturando o valor do campo numero
            if (!String.IsNullOrWhiteSpace(this.Txt_numero_editar.Text))
            {
                if (int.TryParse(this.Txt_numero_editar.Text, out int parsedNumero))
                {
                    numero = parsedNumero;
                }
                else { Debug.WriteLine("O valor inserido no campo Número não pode ser convertido para inteiro!"); }
            }
            else { Debug.WriteLine("Campo número não preenchido"); }

            //verificando para mandar os dados para o método que vai escrever no banco
            if ( id > 0 && !String.IsNullOrWhiteSpace(nome) && numero > 0) 
            {
                Debug.WriteLine("Chamando o método EditarAluno");
                Lbl_retorno.Text = dados.EditarAluno(id, nome, numero);
            }
        }

        //edição de notas
        private void EditarNotas()
        {   
            int id = 0;
            decimal notaPt = 0m;
            decimal notaSt = 0m;
            decimal notaTt = 0m;
            decimal notaQt = 0m;

            //capturando o valor do campo id
            if (!String.IsNullOrWhiteSpace(this.Txt_id_editar_.Text))
            {
                if (int.TryParse(this.Txt_id_editar_.Text, out int parsedId))
                {
                    id = parsedId;
                }
                else { Debug.WriteLine("O valor inserido no campo id não pode ser convertido para inteiro!"); }
            }
            else { Debug.WriteLine("Campo id não preenchido"); }

            //capturando o valor do campo da nota do primeiro trimestre
            if (!String.IsNullOrWhiteSpace(this.Txt_notapt.Text))
            {
                if (decimal.TryParse(this.Txt_notapt.Text, out decimal parsedNPt))
                {
                    notaPt = parsedNPt;
                }
                else { Debug.WriteLine("O valor inserido no campo da nota do primeiro trimestre não pode ser convertido para float!"); }
            }
            else { Debug.WriteLine("Campo da nota do primeiro trimestre não preenchido"); }

            //capturando o valor do campo da nota do segundo trimestre
            if (!String.IsNullOrWhiteSpace(this.Txt_notast.Text))
            {
                if (decimal.TryParse(this.Txt_notast.Text, out decimal parsedNSt))
                {
                    notaSt = parsedNSt;
                }
                else { Debug.WriteLine("O valor inserido no campo da nota do segundo trimestre não pode ser convertido para float!"); }
            }
            else { Debug.WriteLine("Campo da nota do segundo trimestre não preenchido"); }

            //capturando o valor do campo da nota do terceciro trimestre
            if (!String.IsNullOrWhiteSpace(this.Txt_notatt.Text))
            {
                if (decimal.TryParse(this.Txt_notatt.Text, out decimal parsedNTt))
                {
                    notaTt = parsedNTt;
                }
                else { Debug.WriteLine("O valor inserido no campo da nota do terceciro trimestre não pode ser convertido para float!"); }
            }
            else { Debug.WriteLine("Campo da nota do terceciro trimestre não preenchido"); }

            //capturando o valor do campo da nota do quarto trimestre
            if (!String.IsNullOrWhiteSpace(this.Txt_notaqt.Text))
            {
                if (decimal.TryParse(this.Txt_notaqt.Text, out decimal parsedNQt))
                {
                    notaQt = parsedNQt;
                }
                else { Debug.WriteLine("O valor inserido no campo da nota do quarto trimestre não pode ser convertido para float!"); }
            }
            else { Debug.WriteLine("Campo da nota do quarto trimestre não preenchido"); }

            //verificando para mandar os dados para o método que vai escrever no banco
            if (id > 0 && notaPt > 0 && notaSt > 0 && notaTt > 0 && notaQt > 0)
            {
                Lbl_retorno.Text = dados.EditarNotas(id, notaPt, notaSt, notaTt, notaQt);
            }
        }

        //Ocultar as colunas
        private void OcultarColunas()
        {
            // Torna a coluna 0 invisível
            //this.dataLista.Columns[0].Visible = false;
        }

        private void MudarNomeDasColunas()
        {
            // Altera o texto do cabeçalho da coluna 1 para "Nome do aluno"
            this.dataLista.Columns[1].HeaderText = "Nome do aluno";

            // Altera o texto do cabeçalho da coluna 2 para "Número da chamada"
            this.dataLista.Columns[2].HeaderText = "Número da chamada";

            // Altera o texto do cabeçalho da coluna 3 para "Nota do primeiro trimestre"
            this.dataLista.Columns[3].HeaderText = "Nota do primeiro trimestre";

            // Altera o texto do cabeçalho da coluna 4 para "Nota do segundo trimestre"
            this.dataLista.Columns[4].HeaderText = "Nota do segundo trimestre";

            // Altera o texto do cabeçalho da coluna 5 para "Nota do terceiro trimestre"
            this.dataLista.Columns[5].HeaderText = "Nota do terceiro trimestre";

            // Altera o texto do cabeçalho da coluna 6 para "Nota do quarto trimestre"
            this.dataLista.Columns[6].HeaderText = "Nota do quarto trimestre";

            // Altera o texto do cabeçalho da coluna 7 para "Média"
            this.dataLista.Columns[7].HeaderText = "Média";

            // Altera o texto do cabeçalho da coluna 8 para "Status"
            this.dataLista.Columns[8].HeaderText = "Status";
        }

        //////////////////////// métodos gerados pelo Visual Studio
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
            MudarNomeDasColunas();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarNome();

            //Debug.WriteLine("Valor: " + this.dataLista.TabIndex );
            //Debug.WriteLine("Valor: " + this.dataLista.ToString());
            //Debug.WriteLine("Valor: " + this.dataLista.Rows.Count);
            //Debug.WriteLine("Valor: " + this.dataLista.Columns.Count); 
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Btn_inserir_Click(object sender, EventArgs e)
        {
            InserirAluno();
            Mostrar();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            EditarAluno();
        }

        private void Btn_editar_notas_Click(object sender, EventArgs e)
        {
            EditarNotas();
        }
    }
}
