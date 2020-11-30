using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet
{
    public class PratosCaracteristicas
    {
        public Caracteristica Caracteristica { get; set; }

        public Prato Prato { get; set; }

        public PratosCaracteristicas(Prato prato, Caracteristica caracteristica)
        {
            this.Caracteristica = caracteristica;
            this.Prato = prato;
        }
    }
}
