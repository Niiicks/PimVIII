using System;
using System.Collections.Generic;
using System.Text;

namespace PimVIII.Models
{
    class Telefone
    {
        private int Id;
        private int Ddd;
        private int Numero;
        private TelefoneTipo TelefoneTipo;

        public Telefone(int ddd, int numero, TelefoneTipo telefoneTipo)
        {
            this. Ddd = ddd;
            this.Numero = numero;
            this.TelefoneTipo = telefoneTipo;
        }

        public int getId()
        {
            return this.Id;
        }
        public void setDdd(int ddd)
        {
            this.Ddd = ddd;
        }
        public int getDdd()
        {
            return this.Ddd;
        }
        public void setNumero(int numero)
        {
            this.Numero = numero;
        }
        public int getNumero()
        {
            return this.Numero;
        }
        public void setTelefoneTipo(TelefoneTipo telefoneTipo)
        {
            this.TelefoneTipo = telefoneTipo;
        }
        public TelefoneTipo getTelefoneTipo()
        {
            return this.TelefoneTipo;
        }
    }
}
