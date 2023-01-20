using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Interfaces
{
    internal interface IVoar
    {
        public void Voar();
        public int AltitudeMaximaEmMetros { get; set; }

        public double VelocidadeDoVoo { get; set; }
    }
}
