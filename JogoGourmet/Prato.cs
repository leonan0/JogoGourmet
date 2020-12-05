using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet
{
    public class Prato
    {
        public string Nome { get; set; }
        public string Caracateristica { get; set; }

        public Prato(string nome, string caracteristica)
        {
            this.Nome = nome;
            this.Caracateristica = caracteristica;

        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetCaracteristica()
        {

            return this.Caracateristica;

        }

    }
}
