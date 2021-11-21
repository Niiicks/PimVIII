using System;
using System.Collections.Generic;
using System.Text;

namespace PimVIII.Models
{
    class PessoaTelefone
    {
        private int PessoaId;
        private int TelefoneId;

        public PessoaTelefone(int pessoaId, int telefoneId)
        {
            PessoaId = pessoaId;
            TelefoneId = telefoneId;
        }

        public int getPessoaId()
        {
            return this.PessoaId;
        }
        public int getTelefoneId()
        {
            return this.TelefoneId;
        }
    }

}
