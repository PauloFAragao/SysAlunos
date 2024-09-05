using System;
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

        private void InserirAluno()
        {
            string nome = this.Txt_nome_adiconar.Text;
            int numero = int.Parse(this.Txt_numero_adiconar.Text);

            if(nome != null && numero != 0)
            {
                Lbl_retorno.Text = dados.Inserir(nome, numero);
            }
        }

        //Ocultar as colunas
        private void OcultarColunas()
        {
            // Torna a coluna 0 invisível
            this.dataLista.Columns[0].Visible = false;
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
    }
}
