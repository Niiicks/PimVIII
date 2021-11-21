using System;
using System.Collections.Generic;
using System.Text;

namespace PimVIII.Models
{
    class TelefoneTipo
    {
        private int Id;
        private string Tipo;

        public TelefoneTipo(string tipo)
        {
            Tipo = tipo;
        }
        public int getId()
        {
            return this.Id;
        }
        public void setTipo(string tipo)
        {
            this.Tipo = tipo;
        }
        public string getTipo()
        {
            return this.Tipo;
        }
    }
}
