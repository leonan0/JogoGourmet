using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet
{
    public class Caracteristica
    {
        public string Descricao { get; set; }

        public Caracteristica(string descricao)
        {
            this.Descricao = descricao;

        }

        public string GetDescricao()
        {
            return this.Descricao;
        }



    }
}
