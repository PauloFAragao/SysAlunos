using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SysAlunos
{
    public class Dados
    {
        public Dados() { }

        //método mostrar
        public static DataTable Mostrar()
        {
            // Objeto do tipo DataTable
            DataTable DtResultado = new DataTable("alunos");

            // Objeto da conexão com o banco de dados
            using (SqlConnection SqlCon = new SqlConnection(Conexao.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    SqlCon.Open();

                    // Comando SQL - que está no banco de dados
                    using (SqlCommand SqlCmd = new SqlCommand("spmostrar_aluno", SqlCon))
                    {
                        //Define o tipo de comando como StoredProcedure, 
                        //o que indica que estamos chamando um procedimento armazenado no banco de dados.
                        SqlCmd.CommandType = CommandType.StoredProcedure;

                        // Objeto que vai guardar informações da tabela
                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd))
                        {
                            // Preenchendo o DataTable
                            sqlDat.Fill(DtResultado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    DtResultado = null;
                    Debug.WriteLine("Exception: " + ex);
                }
            }

            return DtResultado;
        }

        //método buscar
        public static DataTable BuscarNome(string nome)
        {
            // Objeto do tipo DataTable
            DataTable DtResultado = new DataTable("alunos");

            // Objeto da conexão com o banco de dados
            using (SqlConnection SqlCon = new SqlConnection(Conexao.Cn))
            {
                try
                {
                    // Abrindo a conexão ao banco de dados
                    SqlCon.Open();

                    // Configurando o comando SQL
                    using (SqlCommand SqlCmd = new SqlCommand("spbuscar_nome", SqlCon))
                    {
                        SqlCmd.CommandType = CommandType.StoredProcedure;

                        // Adicionando o parâmetro ao comando SQL
                        SqlParameter ParTextoBuscar = new SqlParameter
                        {
                            ParameterName = "@nome", //Nome do parâmetro no procedimento armazenado. nome da variavel no sql
                            SqlDbType = SqlDbType.VarChar, //Define o tipo de dados como VARCHAR no banco de dados.
                            Size = 100, //Define o tamanho do VARCHAR (50 caracteres).
                            Value = (object)nome ?? DBNull.Value // Usando DBNull.Value para valores nulos
                            //O valor do parâmetro, que pode ser o texto a ser buscado. Usa DBNull.Value para valores nulos
                        };
                        SqlCmd.Parameters.Add(ParTextoBuscar);

                        // Criando o DataAdapter
                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd))
                        {
                            // Preenchendo o DataTable
                            sqlDat.Fill(DtResultado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log ou tratamento da exceção pode ser adicionado aqui
                    // Exemplo: Console.WriteLine(ex.Message);
                    DtResultado = null;
                }
            }
            return DtResultado;
        }

        //método inserir
        public static string Inserir(string nome, int numero)
        {
            string resposta = "";

            // Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Conexao.Cn))
            {
                try
                {
                    // Abrindo conexão
                    sqlCon.Open();

                    // Cria um comando SQL que vai chamar uma stored procedure
                    using (SqlCommand sqlCmd = new SqlCommand("spinserir_aluno", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro para o nome do aluno
                        SqlParameter parNome = new SqlParameter
                        {
                            ParameterName = "@nome",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 100,
                            Value = string.IsNullOrEmpty(nome) ? (object)DBNull.Value : nome
                        };
                        sqlCmd.Parameters.Add(parNome);

                        // Parâmetro para o número do aluno
                        SqlParameter parNumero = new SqlParameter
                        {
                            ParameterName = "@numero",
                            SqlDbType = SqlDbType.Int,
                            Value = numero
                        };
                        sqlCmd.Parameters.Add(parNumero);

                        // Parâmetro para a noda do primeiro trimestre
                        SqlParameter parNotaPt = new SqlParameter
                        {
                            ParameterName = "@notapt",
                            SqlDbType = SqlDbType.Decimal,
                            Value = 0
                        };
                        sqlCmd.Parameters.Add(parNotaPt);

                        // Parâmetro para a noda do segundo trimestre
                        SqlParameter parNotaSt = new SqlParameter
                        {
                            ParameterName = "@notast",
                            SqlDbType = SqlDbType.Decimal,
                            Value = 0
                        };
                        sqlCmd.Parameters.Add(parNotaSt);

                        // Parâmetro para a noda do terceiro trimestre
                        SqlParameter parNotaTt = new SqlParameter
                        {
                            ParameterName = "@notatt",
                            SqlDbType = SqlDbType.Decimal,
                            Value = 0
                        };
                        sqlCmd.Parameters.Add(parNotaTt);

                        // Parâmetro para a noda do quarto trimestre
                        SqlParameter parNotaQt = new SqlParameter
                        {
                            ParameterName = "@notaqt",
                            SqlDbType = SqlDbType.Decimal,
                            Value = 0
                        };
                        sqlCmd.Parameters.Add(parNotaQt);

                        // Parâmetro para a média
                        SqlParameter parMedia = new SqlParameter
                        {
                            ParameterName = "@media",
                            SqlDbType = SqlDbType.Decimal,
                            Value = 0
                        };
                        sqlCmd.Parameters.Add(parMedia);

                        // Parâmetro para o status do aluno
                        SqlParameter parStatus = new SqlParameter
                        {
                            ParameterName = "@status",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = "nulo"
                        };
                        sqlCmd.Parameters.Add(parStatus);

                        // Executa o comando e verifica se a inserção foi bem-sucedida
                        int linhasAfetadas = sqlCmd.ExecuteNonQuery();
                        if (linhasAfetadas == 1)
                        {
                            resposta = "Registro inserido com sucesso.";
                        }
                        else
                        {
                            resposta = "Registro não inserido.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    resposta = $"Erro: {ex.Message}";
                }
            }

            return resposta;
        }

        //método editar aluno
        public static string EditarAluno(int idAluno, string nome, int numero)
        {
            string resposta = "";
            
            //Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Conexao.Cn))
            {
                try
                {
                    //abrindo conexão
                    sqlCon.Open();

                    //cria um comando sql que vai chamar uma função que foi escrita no sql (stored procedure)
                    using (SqlCommand sqlCmd = new SqlCommand("speditar_aluno", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro de saída para o ID da nome
                        SqlParameter parIdAluno = new SqlParameter
                        {
                            ParameterName = "@idaluno",
                            SqlDbType = SqlDbType.Int,
                            //Direction = ParameterDirection.Output,
                            Value = idAluno
                        };
                        sqlCmd.Parameters.Add(parIdAluno);

                        // Parâmetro para o nome do aluno
                        SqlParameter parNome = new SqlParameter
                        {
                            ParameterName = "@nome",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 100,
                            Value = string.IsNullOrEmpty(nome) ? (object)DBNull.Value : nome
                        };
                        sqlCmd.Parameters.Add(parNome);

                        // Parâmetro para o número do aluno
                        SqlParameter parNumero = new SqlParameter
                        {
                            ParameterName = "@numero",
                            SqlDbType = SqlDbType.Int,
                            Value = numero
                        };
                        sqlCmd.Parameters.Add(parNumero);

                        // Executa o comando e verifica se a inserção foi bem-sucedida
                        int linhasAfetadas = sqlCmd.ExecuteNonQuery();
                        if (linhasAfetadas == 1)
                        {
                            int id_Aluno = Convert.ToInt32(parIdAluno.Value);
                            resposta = $"OK. ID da nova aluno: {id_Aluno}";
                        }
                        else
                        {
                            resposta = "Registro não inserido";
                        }
                    }
                }
                catch (Exception ex)
                {
                    resposta = $"Erro: {ex.Message}";
                    Debug.WriteLine("ERRO: " + resposta);
                }
            }

            return resposta;
        }


        //método editar notas
        public static string EditarNotas(int idAluno, decimal npt, decimal nst, decimal ntt, decimal nqt)
        {
            string resposta = "";

            //Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Conexao.Cn))
            {
                try
                {
                    //abrindo conexão
                    sqlCon.Open();

                    //cria um comando sql que vai chamar uma função que foi escrita no sql (stored procedure)
                    using (SqlCommand sqlCmd = new SqlCommand("speditar_notas", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro de saída para o ID da nome
                        SqlParameter parIdAluno = new SqlParameter
                        {
                            ParameterName = "@idaluno",
                            SqlDbType = SqlDbType.Int,
                            //Direction = ParameterDirection.Output,
                            Value = idAluno
                        };
                        sqlCmd.Parameters.Add(parIdAluno);

                        // Parâmetro para a noda do primeiro trimestre
                        SqlParameter parNotaPt = new SqlParameter
                        {
                            ParameterName = "@notapt",
                            SqlDbType=SqlDbType.Decimal,
                            Precision = 5,   // Total de dígitos, o número pode ter até 5 dígitos no total, incluindo os dígitos após o ponto decimal.
                            Scale = 2,       // Dígitos após o ponto decimal
                            Value = npt
                        };
                        sqlCmd.Parameters.Add(parNotaPt);

                        // Parâmetro para a noda do segundo trimestre
                        SqlParameter parNotaSt = new SqlParameter
                        {
                            ParameterName = "@notast",
                            SqlDbType = SqlDbType.Decimal,
                            Value = nst
                        };
                        sqlCmd.Parameters.Add(parNotaSt);

                        // Parâmetro para a noda do terceiro trimestre
                        SqlParameter parNotaTt = new SqlParameter
                        {
                            ParameterName = "@notatt",
                            SqlDbType = SqlDbType.Decimal,
                            Value = ntt
                        };
                        sqlCmd.Parameters.Add(parNotaTt);

                        // Parâmetro para a noda do quarto trimestre
                        SqlParameter parNotaQt = new SqlParameter
                        {
                            ParameterName = "@notaqt",
                            SqlDbType = SqlDbType.Decimal,
                            Value = nqt
                        };
                        sqlCmd.Parameters.Add(parNotaQt);

                        // Parâmetro para a média
                        SqlParameter parMedia = new SqlParameter
                        {
                            ParameterName = "@media",
                            SqlDbType = SqlDbType.Decimal,
                            Value = (npt + nst + ntt + nqt) / 4
                        };
                        sqlCmd.Parameters.Add(parMedia);

                        // Executa o comando e verifica se a inserção foi bem-sucedida
                        int linhasAfetadas = sqlCmd.ExecuteNonQuery();
                        if (linhasAfetadas == 1)
                        {
                            int id_Aluno = Convert.ToInt32(parIdAluno.Value);
                            resposta = $"OK. ID da nova aluno: {id_Aluno}";
                        }
                        else
                        {
                            resposta = "Registro não inserido";
                        }
                    }
                }
                catch (Exception ex)
                {
                    resposta = $"Erro: {ex.Message}";
                    Debug.WriteLine("ERRO: " + resposta);
                }
            }

            return resposta;
        }

        //método editar status
        public static string EditarStatus(int idAluno, string status)
        {
            string resposta = "";

            //Cria uma conexão com o banco de dados e garante que ela será fechada e liberada corretamente após o uso.
            using (SqlConnection sqlCon = new SqlConnection(Conexao.Cn))
            {
                try
                {
                    //abrindo conexão
                    sqlCon.Open();

                    //cria um comando sql que vai chamar uma função que foi escrita no sql (stored procedure)
                    using (SqlCommand sqlCmd = new SqlCommand("speditar_status", sqlCon))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        // Parâmetro de saída para o ID da nome
                        SqlParameter parIdAluno = new SqlParameter
                        {
                            ParameterName = "@idaluno",
                            SqlDbType = SqlDbType.Int,
                            //Direction = ParameterDirection.Output,
                            Value = idAluno
                        };
                        sqlCmd.Parameters.Add(parIdAluno);

                        // Parâmetro para o status do aluno
                        SqlParameter parStatus = new SqlParameter
                        {
                            ParameterName = "@status",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 20,
                            Value = status
                        };
                        sqlCmd.Parameters.Add(parStatus);

                        // Executa o comando e verifica se a inserção foi bem-sucedida
                        int linhasAfetadas = sqlCmd.ExecuteNonQuery();
                        if (linhasAfetadas == 1)
                        {
                            int id_Aluno = Convert.ToInt32(parIdAluno.Value);
                            resposta = $"OK. ID da nova aluno: {id_Aluno}";
                        }
                        else
                        {
                            resposta = "Registro não inserido";
                        }
                    }
                }
                catch (Exception ex)
                {
                    resposta = $"Erro: {ex.Message}";
                    Debug.WriteLine("ERRO: " + resposta);
                }
            }

            return resposta;
        }
    }
}
