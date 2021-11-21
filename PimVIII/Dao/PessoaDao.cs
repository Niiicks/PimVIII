using PimVIII.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace PimVIII.Dao
{
    class PessoaDao
    {
        static string dataSource = "Password=sa123456;Persist Security Info=True;User ID=sa;Initial Catalog=CADASTROBD;Data Source=LAPTOP-LUH08D1B\\BUSINESSSERVER;MultipleActiveResultSets=true";
        public static void inserirPessoa(Pessoa pessoa)
        {
            SqlConnection conexao = new SqlConnection(dataSource);
            SqlCommand cmd;
            Endereco endereco = pessoa.getEndereco();
            Telefone telefone = pessoa.getTelefone();
            TelefoneTipo telefoneTipo = telefone.getTelefoneTipo();
            try
            {
                //Salvar Endereço
                string query = "INSERT INTO dbo.Endereco (logradouro, numero, cep, bairro, cidade, uf ) " +
                                    "VALUES(@logradouro, @numero, @cep, @bairro, @cidade, @uf )";
                cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@logradouro", endereco.getLogradouro());
                cmd.Parameters.AddWithValue("@numero", endereco.getNumero());
                cmd.Parameters.AddWithValue("@cep", endereco.getCep());
                cmd.Parameters.AddWithValue("@bairro", endereco.getBairro());
                cmd.Parameters.AddWithValue("@cidade", endereco.getCidade());
                cmd.Parameters.AddWithValue("@uf", endereco.getUf());

                conexao.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandText = "select @@identity";
                string idEndereco = cmd.ExecuteScalar().ToString();


                //Salvar TipoTelefone
                query = "INSERT INTO dbo.Telefone_Tipo(Tipo) VALUES(@tipo)";
                cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@tipo", telefoneTipo.getTipo());

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandText = "select @@identity";
                string idTelefoneTipo = cmd.ExecuteScalar().ToString();



                //Salvar Telefone                
                query = "INSERT INTO dbo.Telefone (ddd, numero, tipo) " +
                            "VALUES(@ddd, @numero, @tipoId )";
                cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@ddd", telefone.getDdd());
                cmd.Parameters.AddWithValue("@numero", telefone.getNumero());
                cmd.Parameters.AddWithValue("@tipoId", idTelefoneTipo);


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandText = "select @@identity";
                string idTelefone = cmd.ExecuteScalar().ToString();


                //Salvar Pessoa
                query = "INSERT INTO dbo.Pessoa (nome, cpf, endereco) " +
                            "VALUES(@nome, @cpf, @enderecoId )";
                cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", pessoa.getNome());
                cmd.Parameters.AddWithValue("@cpf", pessoa.getCpf());
                cmd.Parameters.AddWithValue("@enderecoId", idEndereco);


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.CommandText = "select @@identity";
                string idPessoa = cmd.ExecuteScalar().ToString();



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

        }   

        public static void removerPessoa(int id)
        {
            SqlConnection conexao = new SqlConnection(dataSource);
            try
            {
                conexao.Open();
                string query = "DELETE FROM dbo.Pessoa WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static void atualizarPessoa(int id, Pessoa pessoa)
        {
            SqlConnection conexao = new SqlConnection(dataSource);
            try
            {
                conexao.Open();
                //Buscar Endereço da Pessoa a ser alterada
                string query = "SELECT * FROM dbo.Pessoa WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                int enderecoIdPessoaAlterada = 0;
                if (reader.Read())
                {
                enderecoIdPessoaAlterada = Convert.ToInt32(reader["ENDERECO"].ToString());
                }

                //Atualizar endereço
                Endereco endereco = pessoa.getEndereco();
                query = "UPDATE dbo.Endereco SET logradouro=@logradouro, " +
                    "numero=@numero, cep=@cep , bairro=@bairro , cidade=@cidade , uf=@uf WHERE id=@id ";                                  
                cmd = new SqlCommand(query, conexao);

                cmd.Parameters.AddWithValue("@logradouro", endereco.getLogradouro());
                cmd.Parameters.AddWithValue("@numero", endereco.getNumero());
                cmd.Parameters.AddWithValue("@cep", endereco.getCep());
                cmd.Parameters.AddWithValue("@bairro", endereco.getBairro());
                cmd.Parameters.AddWithValue("@cidade", endereco.getCidade());
                cmd.Parameters.AddWithValue("@uf", endereco.getUf());
                cmd.Parameters.AddWithValue("@id", 2);

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                //Atualizar Pessoa
                query = "UPDATE dbo.Pessoa SET ( nome=@nome, cpf=@cpf) WHERE id=@id";
                cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@nome", pessoa.getNome());
                cmd.Parameters.AddWithValue("@cpf", pessoa.getCpf());
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public static Pessoa buscarPessoa(long cpf)
        {
            SqlConnection conexao = new SqlConnection(dataSource);
            Pessoa pessoa = new Pessoa();
            try
            {
                conexao.Open();
                //Buscar Pessoa
                string query = "SELECT * FROM dbo.Pessoa WHERE cpf LIKE @cpf";
                SqlCommand cmd = new SqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@cpf", "%" + cpf + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    pessoa.setNome(reader["NOME"].ToString());
                    pessoa.setCpf(Convert.ToInt32(reader["CPF"].ToString()));
                    pessoa.setEnderecoId(Convert.ToInt32(reader["ENDERECO"].ToString()));
                }

            } catch (Exception ex)            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conexao.Close();
                
            }
            return pessoa;
        }
    }
}
