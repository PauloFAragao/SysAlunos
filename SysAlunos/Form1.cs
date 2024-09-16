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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysAlunos
{
    public partial class Form1 : Form
    {
        //booleanas de controle
        bool ModoInserir = false;
        bool ModoEditar = false;

        public Form1()
        {
            InitializeComponent();

            MensagensDoToolTip();
        }

        private void MensagensDoToolTip()
        {
            this.ttMensagem.SetToolTip(Txt_nome, "Nome do aluno que deve ser buscado");

            this.ttMensagem.SetToolTip(TxtId, "Id interno do aluno");
            this.ttMensagem.SetToolTip(TxtNome, "Insira o nome do aluno");
            this.ttMensagem.SetToolTip(TxtNumero, "Número do aluno na chamada");

            this.ttMensagem.SetToolTip(ChkEditarNotas, "Habilitar para editar as notas");

            this.ttMensagem.SetToolTip(TxtNPT, "Nota do primeiro trimestre");
            this.ttMensagem.SetToolTip(TxtNST, "Nota do segundo trimestre");
            this.ttMensagem.SetToolTip(TxtNTT, "Nota do terceiro trimestre");
            this.ttMensagem.SetToolTip(TxtNQT, "Nota do quarto trimestre");

            this.ttMensagem.SetToolTip(ChkEditarStatus, "Habilitar para editar o statuso do aluno");

            this.ttMensagem.SetToolTip(CbxStatus, "Status do aluno, Aprovado ou Reprovado");
            
        }

        //Mostrar no Data Grid
        private void Mostrar()
        {
            this.dataLista.DataSource = Dados.Mostrar();
        }

        //Buscar pelo Nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = Dados.BuscarNome(this.Txt_nome.Text);
            this.OcultarColunas();
        }

        //Ocultar as colunas
        private void OcultarColunas()
        {
            // Torna a coluna 0 invisível
            this.dataLista.Columns[0].Visible = false;
        }

        //mudar o nome das colunas
        private void MudarNomeDasColunas()
        {
            // Altera o texto do cabeçalho da coluna 1 para "Nome do aluno"
            this.dataLista.Columns[1].HeaderText = "Nome do aluno";
            this.dataLista.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Altera o texto do cabeçalho da coluna 2 para "Número da chamada"
            this.dataLista.Columns[2].HeaderText = "Número da chamada";
            this.dataLista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Altera o texto do cabeçalho da coluna 3 para "Nota do primeiro trimestre"
            this.dataLista.Columns[3].HeaderText = "Nota do primeiro trimestre";
            this.dataLista.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Altera o texto do cabeçalho da coluna 4 para "Nota do segundo trimestre"
            this.dataLista.Columns[4].HeaderText = "Nota do segundo trimestre";
            this.dataLista.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Altera o texto do cabeçalho da coluna 5 para "Nota do terceiro trimestre"
            this.dataLista.Columns[5].HeaderText = "Nota do terceiro trimestre";
            this.dataLista.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Altera o texto do cabeçalho da coluna 6 para "Nota do quarto trimestre"
            this.dataLista.Columns[6].HeaderText = "Nota do quarto trimestre";
            this.dataLista.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Altera o texto do cabeçalho da coluna 7 para "Média"
            this.dataLista.Columns[7].HeaderText = "Média";
            this.dataLista.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Altera o texto do cabeçalho da coluna 8 para "Status"
            this.dataLista.Columns[8].HeaderText = "Status";
            this.dataLista.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //habilita a edição das notas
        private void HabilitarEditarNotas(bool status)
        {
            this.TxtNPT.Enabled = status;
            this.TxtNST.Enabled = status;
            this.TxtNTT.Enabled = status;
            this.TxtNQT.Enabled = status;
        }

        private void TirarErrorProvider()
        {
            ErrorIcone.SetError(TxtNome, string.Empty);
            ErrorIcone.SetError(TxtNumero, string.Empty);

            ErrorIcone.SetError(TxtNPT, string.Empty);
            ErrorIcone.SetError(TxtNST, string.Empty);
            ErrorIcone.SetError(TxtNTT, string.Empty);
            ErrorIcone.SetError(TxtNQT, string.Empty);
        }

        private void LimparCampos()
        {
            this.TxtId.Text = string.Empty;
            this.TxtNome.Text = string.Empty;
            this.TxtNumero.Text = string.Empty;

            this.ChkEditarNotas.Checked = false;

            this.TxtNPT.Text = string.Empty;
            this.TxtNST.Text = string.Empty;
            this.TxtNTT.Text = string.Empty;
            this.TxtNQT.Text = string.Empty;

            this.ChkEditarStatus.Checked = false;

            this.CbxStatus.SelectedIndex = 0;

            TirarErrorProvider();
        }

        private void DesabilitarTudo()
        {
            this.TxtId.Enabled = false;
            this.TxtNome.Enabled = false;
            this.TxtNumero.Enabled = false;

            this.ChkEditarNotas.Enabled = false;

            HabilitarEditarNotas(false);

            this.ChkEditarStatus.Enabled = false;

            this.CbxStatus.Enabled = false;

            this.BtnSalvar.Enabled = false;
            this.BtnCancelar.Enabled = false;
        }

        private void ResetarVariaveis()
        {
            ModoInserir = false;
            ModoEditar = false;
        }

        private void HabilitarCampos()
        {
            //habilitando os campos
            this.TxtNome.Enabled = true;
            this.TxtNumero.Enabled = true;
            this.ChkEditarNotas.Enabled = true;
            this.ChkEditarStatus.Enabled = true;
            this.BtnSalvar.Enabled = true;
            this.BtnCancelar.Enabled = true;
            this.BtnInserirAluno.Enabled = false;
        }

        private void Salvar()
        {
            int id = 0;
            string nome = "";
            int numero = 0;
            decimal notaPT = 0;
            decimal notaST = 0;
            decimal notaTT = 0;
            decimal notaQT = 0;
            string status = "";

            bool podeSalvar = true;

            //capturando o valor do campo nome
            if (!String.IsNullOrWhiteSpace(this.TxtNome.Text))
            {
                nome = this.TxtNome.Text;
            }
            else 
            {
                podeSalvar = false;

                Debug.WriteLine("Campo nome não preenchido");
                ErrorIcone.SetError(this.TxtNome, "Insira o nome");
            }

            //capturando o valor do campo numero
            if (!String.IsNullOrWhiteSpace(this.TxtNumero.Text))
            {
                if (int.TryParse(this.TxtNumero.Text, out int parsedNumero))
                {
                    numero = parsedNumero;
                }
                else 
                {
                    podeSalvar = false;

                    Debug.WriteLine("O valor inserido no campo id não pode ser convertido para inteiro!");
                    ErrorIcone.SetError(this.TxtNome, "Insira um número inteiro");
                }
            }
            else 
            {
                podeSalvar = false;

                Debug.WriteLine("Campo numero não preenchido");
                ErrorIcone.SetError(this.TxtNumero, "Insira o número da chamada");
            }

            if (ChkEditarNotas.Checked)
            {
                //capturando o valor do campo da nota do primeiro trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNPT.Text))
                {
                    if (decimal.TryParse(this.TxtNPT.Text, out decimal value))
                    {
                        notaPT = value;
                    }
                    else 
                    {
                        podeSalvar = false;

                        Debug.WriteLine("O valor inserido no campo da nota do primeiro trimestre não pode ser convertido para decimal!");
                        ErrorIcone.SetError(this.TxtNPT, "Insira um número Decimal");
                    }
                }
                else 
                {
                    podeSalvar = false;

                    Debug.WriteLine("Campo da nota do primeiro trimestre não preenchido");
                    ErrorIcone.SetError(this.TxtNPT, "Insira a nota do primeiro trimestre");
                }

                //capturando o valor do campo da nota do segundo trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNST.Text))
                {
                    if (decimal.TryParse(this.TxtNST.Text, out decimal value))
                    {
                        notaST = value;
                    }
                    else 
                    {
                        podeSalvar = false;

                        Debug.WriteLine("O valor inserido no campo da nota do segundo trimestre não pode ser convertido para decimal!");
                        ErrorIcone.SetError(this.TxtNST, "Insira um número Decimal");
                    }
                }
                else 
                {
                    podeSalvar = false;

                    Debug.WriteLine("Campo da nota do segundo trimestre não preenchido");
                    ErrorIcone.SetError(this.TxtNST, "Insira a nota do segundo trimestre");
                }

                //capturando o valor do campo da nota do terceiro trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNTT.Text))
                {
                    if (decimal.TryParse(this.TxtNTT.Text, out decimal value))
                    {
                        notaTT = value;
                    }
                    else 
                    {
                        podeSalvar = false;

                        Debug.WriteLine("O valor inserido no campo da nota do terceiro trimestre não pode ser convertido para decimal!");
                        ErrorIcone.SetError(this.TxtNTT, "Insira um número Decimal");
                    }
                }
                else 
                {
                    podeSalvar = false;

                    Debug.WriteLine("Campo da nota do terceiro trimestre não preenchido");
                    ErrorIcone.SetError(this.TxtNTT, "Insira a nota do terceiro trimestre");
                }

                //capturando o valor do campo da nota do quarto trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNQT.Text))
                {
                    if (decimal.TryParse(this.TxtNQT.Text, out decimal value))
                    {
                        notaQT = value;
                    }
                    else 
                    {
                        podeSalvar = false;

                        Debug.WriteLine("O valor inserido no campo da nota do quarto trimestre não pode ser convertido para decimal!");
                        ErrorIcone.SetError(this.TxtNQT, "Insira um número Decimal");
                    }
                }
                else 
                {
                    podeSalvar = false;

                    Debug.WriteLine("Campo da nota do quarto trimestre não preenchido");
                    ErrorIcone.SetError(this.TxtNQT, "Insira a nota do quarto trimestre");
                }
            }
            else
            {
                notaPT = 0;
                notaST = 0;
                notaTT = 0;
                notaQT = 0;
            }

            if (ChkEditarStatus.Checked)
            {
                //capturado o status selecionado no combo box
                status = this.CbxStatus.Text;
            }
            else status = "Nulo";

            if (ModoInserir && podeSalvar)
            {
                Lbl_retorno.Text = Dados.Inserir(nome, numero, notaPT, notaST, notaTT, notaQT, status);
            }
            else if (ModoEditar && podeSalvar)
            {
                id = Convert.ToInt32(this.TxtId.Text);

                Lbl_retorno.Text = Dados.EditarAluno(id, nome, numero);

                if (ChkEditarNotas.Checked)
                    Lbl_retorno.Text += "-" + Dados.EditarNotas(id, notaPT, notaST, notaTT, notaQT);

                if (ChkEditarStatus.Checked)
                    Lbl_retorno.Text += "-" + Dados.EditarStatus(id, status);

            }
            
            if(podeSalvar)
            {
                //resetando tudo
                LimparCampos();
                DesabilitarTudo();
                ResetarVariaveis();
                this.BtnInserirAluno.Enabled = true;

                //atualizando o DataGridView
                Mostrar();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Editar()
        {
            ModoEditar = true;

            this.TxtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idaluno"].Value);

            this.TxtNome.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["nome"].Value);
            this.TxtNumero.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["numero"].Value);

            this.TxtNPT.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["notapt"].Value);
            this.TxtNST.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["notast"].Value);
            this.TxtNTT.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["notatt"].Value);
            this.TxtNQT.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["notaqt"].Value);

            this.CbxStatus.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["status"].Value);

            this.tabControl1.SelectedIndex = 1;

            HabilitarCampos();
        }

        private void Deletar()
        {
            int id = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idaluno"].Value);

            if (MessageBox.Show(
                "Realmente Deseja Apagar o Aluno?",
                "Apagar Aluno?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK )
            {  Lbl_retorno.Text = Dados.DeletarAluno(id); }
        }

        //////////////////////// métodos gerados pelo Visual Studio
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
            OcultarColunas();
            MudarNomeDasColunas();

            //Setando para o combo box já estar com o status Aprovado selecionado
            this.CbxStatus.SelectedIndex = 0;
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void ChkEditarNotas_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEditarNotas.Checked)
                HabilitarEditarNotas(true);
            else
                HabilitarEditarNotas(false);
        }

        private void ChkEditarStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkEditarStatus.Checked)
                CbxStatus.Enabled = true;
            else
                CbxStatus.Enabled = false;
        }

        private void BtnInserirAluno_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            ModoInserir = true;
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarCampos();
            ModoInserir = true;
            this.tabControl1.SelectedIndex = 1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarTudo();
            ResetarVariaveis();
            this.BtnInserirAluno.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            Deletar();
            Mostrar();
        }
    }
}
