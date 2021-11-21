using System;
using System.Collections.Generic;
using System.Text;

namespace PimVIII.Models
{
    class Endereco
    {
        private int Id;
        private string Logradouro;
        private int Numero;
        private int Cep;
        private string Bairro;
        private string Cidade;
        private string Uf;
        private List<Pessoa> Pessoas;

        public Endereco(string logradouro, int numero, int cep, string bairro, string cidade, string uf)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }

        public Endereco(){}

        public int getId()
        {
            return this.Id;
        }
        public void setLogradouro(string logradouro)
        {
            this.Logradouro = logradouro;
        }
        public string getLogradouro()
        {
            return this.Logradouro;
        }
        public void setNumero(int numero)
        {
            this.Numero = numero;
        }
        public int getNumero()
        {
            return this.Numero; 
        }
        public void setCep(int cep)
        {
            this.Cep = cep;
        }
        public int getCep()
        {
            return this.Cep;
        }
        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }
        public string getBairro()
        {
            return this.Bairro;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public string getCidade()
        {
            return this.Cidade;
        }
        public void setUf(string uf)
        {
            this.Uf = uf;
        }
        public string getUf()
        {
            return this.Uf;
        }
        public void setId(int id)
        {
            this.Id = id;
        }

    }
}
