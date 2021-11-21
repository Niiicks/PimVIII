using System;
using System.Collections.Generic;
using System.Text;

namespace PimVIII.Models
{
    class Pessoa
    {
        private int Id;
        private string Nome;
        private long Cpf;
        private int EnderecoId;
        private Endereco Endereco;
        private Telefone Telefone;

        public Pessoa(string nome, long cpf, Endereco endereco, Telefone telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Telefone = telefone;
        }

        public Pessoa() { }

        public int getId()
        {
            return this.Id;
        }
        public void setNome(string nome)
        {
            this.Nome = nome;
        }
        public string getNome()
        {
            return this.Nome;
        }
        public void setCpf(long cpf)
        {
            this.Cpf = cpf;
        }
        public long getCpf()
        {
            return this.Cpf;
        }
        public void setEnderecoId(int enderecoId)
        {
            this.EnderecoId = enderecoId;
        }
        public int getEnderecoId()
        {
            return this.EnderecoId;
        }
        public void setEndereco(Endereco endereco)
        {
            this.Endereco = endereco;
        }
        public Endereco getEndereco()
        {
            return this.Endereco;
        }
        public void setTelefone(Telefone telefone)
        {
            this.Telefone = telefone;
        }
        public Telefone getTelefone()
        {
            return this.Telefone;
        }
    }
}
