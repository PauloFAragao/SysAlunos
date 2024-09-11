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
            this.ttMensagem.SetToolTip(Txt_nome, "Nome do Aluno que deve ser buscado");
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
                Lbl_retorno.Text = Dados.Inserir(nome, numero, 0, 0, 0, 0, "nulo");
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
                Lbl_retorno.Text = Dados.EditarAluno(id, nome, numero);
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
                Lbl_retorno.Text = Dados.EditarNotas(id, notaPt, notaSt, notaTt, notaQt);
            }
        }

        //editar status
        private void EditarStatus()
        {
            int id = 0;
            string status = "";

            //capturando o valor do campo id
            if (!String.IsNullOrWhiteSpace(this.Txt_id_status.Text))
            {
                if (int.TryParse(this.Txt_id_status.Text, out int parsedId))
                {
                    id = parsedId;
                }
                else { Debug.WriteLine("O valor inserido no campo id não pode ser convertido para inteiro!"); }
            }
            else { Debug.WriteLine("Campo id não preenchido"); }

            //capturado o status selecionado no combo box
            status = Cbx_status.Text;

            //verificando para mandar os dados para o método que vai escrever no banco de dados
            if (id > 0)
            {
                Lbl_retorno.Text = Dados.EditarStatus(id, status);
            }

        }

        //deletar um aluno
        private void DeletarAluno()
        {
            int id = 0;

            //capturando o valor do campo id
            if (!String.IsNullOrWhiteSpace(this.Txt_id_deletar.Text))
            {
                if (int.TryParse(this.Txt_id_deletar.Text, out int parsedId))
                {
                    id = parsedId;
                }
                else { Debug.WriteLine("O valor inserido no campo id não pode ser convertido para inteiro!"); }
            }
            else { Debug.WriteLine("Campo id não preenchido"); }

            //verificando para deletar o aluno
            if (id > 0)
            {
                Lbl_retorno.Text = Dados.DeletarAluno(id);
            }
        }

        //habilita a edição das notas
        private void HabilitarEditarNotas(bool status)
        {
            this.TxtNPT.Enabled = status;
            this.TxtNST.Enabled = status;
            this.TxtNTT.Enabled = status;
            this.TxtNQT.Enabled = status;
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

        private void HabilitarInserir()
        {
            ModoInserir = true;

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
            int id;
            string nome = "";
            int numero = 0;
            decimal notaPT = 0;
            decimal notaST = 0;
            decimal notaTT = 0;
            decimal notaQT = 0;
            string status = "";

            //capturando o valor do campo nome
            if (!String.IsNullOrWhiteSpace(this.TxtNome.Text))
            {
                nome = this.TxtNome.Text;
            }
            else { Debug.WriteLine("Campo nome não preenchido"); }

            //capturando o valor do campo numero
            if (!String.IsNullOrWhiteSpace(this.TxtNumero.Text))
            {
                if (int.TryParse(this.TxtNumero.Text, out int parsedNumero))
                {
                    numero = parsedNumero;
                }
                else { Debug.WriteLine("O valor inserido no campo id não pode ser convertido para inteiro!"); }
            }
            else { Debug.WriteLine("Campo numero não preenchido"); }

            if (ChkEditarNotas.Checked)
            {
                //capturando o valor do campo da nota do primeiro trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNPT.Text))
                {
                    if (decimal.TryParse(this.TxtNPT.Text, out decimal value))
                    {
                        notaPT = value;
                    }
                    else { Debug.WriteLine("O valor inserido no campo da nota do primeiro trimestre não pode ser convertido para decimal!"); }
                }
                else { Debug.WriteLine("Campo da nota do primeiro trimestre não preenchido"); }

                //capturando o valor do campo da nota do segundo trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNST.Text))
                {
                    if (decimal.TryParse(this.TxtNST.Text, out decimal value))
                    {
                        notaST = value;
                    }
                    else { Debug.WriteLine("O valor inserido no campo da nota do segundo trimestre não pode ser convertido para decimal!"); }
                }
                else { Debug.WriteLine("Campo da nota do segundo trimestre não preenchido"); }

                //capturando o valor do campo da nota do terceiro trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNTT.Text))
                {
                    if (decimal.TryParse(this.TxtNTT.Text, out decimal value))
                    {
                        notaTT = value;
                    }
                    else { Debug.WriteLine("O valor inserido no campo da nota do terceiro trimestre não pode ser convertido para decimal!"); }
                }
                else { Debug.WriteLine("Campo da nota do terceiro trimestre não preenchido"); }

                //capturando o valor do campo da nota do quarto trimestre
                if (!String.IsNullOrWhiteSpace(this.TxtNQT.Text))
                {
                    if (decimal.TryParse(this.TxtNQT.Text, out decimal value))
                    {
                        notaQT = value;
                    }
                    else { Debug.WriteLine("O valor inserido no campo da nota do quarto trimestre não pode ser convertido para decimal!"); }
                }
                else { Debug.WriteLine("Campo da nota do quarto trimestre não preenchido"); }
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

            Debug.WriteLine("Salvar");
            if (ModoInserir)
            {
                Debug.WriteLine("Inserir");
                Lbl_retorno.Text = Dados.Inserir(nome, numero, notaPT, notaST, notaTT, notaQT, status);
            }
            
            else if(ModoEditar)
            {
                //aqui vai chamar o metodo Dados.EditarAluno
                if (ChkEditarNotas.Checked)
                {
                    //aqui vai chamar o metodo Dados.EditarNotas
                }
                if (ChkEditarStatus.Checked)
                {
                    //aqui vai chamar o metodo Dados.EditarStatus
                }
            }

            //resetando tudo
            LimparCampos();
            DesabilitarTudo();
            ResetarVariaveis();
            this.BtnInserirAluno.Enabled = true;

            //atualizando o DataGridView
            Mostrar();

        }

        //////////////////////// métodos gerados pelo Visual Studio
        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
            OcultarColunas();
            MudarNomeDasColunas();

            //Setando para o combo box já estar com o status Aprovado selecionado
            this.Cbx_status.SelectedIndex = 0;
            this.CbxStatus.SelectedIndex = 0;
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
            Mostrar();
        }

        private void Btn_editar_notas_Click(object sender, EventArgs e)
        {
            EditarNotas();
            Mostrar();
        }

        private void Btn_editar_status_Click(object sender, EventArgs e)
        {
            EditarStatus();
            Mostrar();
        }

        private void Btn_deletar_Click(object sender, EventArgs e)
        {
            DeletarAluno();
            Mostrar();
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
            HabilitarInserir();
        }
        
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            HabilitarInserir();
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
    }
}
