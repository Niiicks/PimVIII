using PimVIII.Dao;
using PimVIII.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimVIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InserirPessoa_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco("Rua Teste Busca Bosco", 170, 05303000, "pinheiros", "São Paulo", "SP");
            TelefoneTipo telefoneTipo = new TelefoneTipo("Celular");
            Telefone telefone = new Telefone(11, 44844444, telefoneTipo);
            Pessoa pessoa = new Pessoa("Teste Busca", 10101010, endereco, telefone);
            PessoaDao.inserirPessoa(pessoa);
        }

        private void ExcluirPessoa_Click(object sender, EventArgs e)
        {

            PessoaDao.removerPessoa(Convert.ToInt32(txtIdPessoa.Text));
        }

        private void AlterarPessoa_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco("Rua Maria Bosco", 710, 0999900, "Curitiba", "Parana", "PR");
            TelefoneTipo telefoneTipo = new TelefoneTipo("Celular");
            Telefone telefone = new Telefone(11, 1111111, telefoneTipo);
            Pessoa pessoa = new Pessoa("Maria", 33333333, endereco, telefone);
            int idPessoaAtualizada = Convert.ToInt32(txtIdPessoa.Text);
            PessoaDao.atualizarPessoa(idPessoaAtualizada , pessoa);
        }

        private void buscarPessoa_Click(object sender, EventArgs e)
        {
            PessoaDao.buscarPessoa(10101010);
        }
    }
}
