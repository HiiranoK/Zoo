using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Morcego : Mamifero, IVoar
    {
        public Morcego(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento, int mamas, bool pelos, string corPelo,int altitudeVoo, double velocidadeVoo) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento,mamas,pelos,corPelo)
        {
            AltitudeMaximaEmMetros = altitudeVoo;
            VelocidadeDoVoo = velocidadeVoo;
        }

        public int AltitudeMaximaEmMetros { get; set ; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar()
        {
            Console.WriteLine($"Voando a altitudede {AltitudeMaximaEmMetros*0,8} numa velocidade média de {VelocidadeDoVoo*0.8}");
        }
    }
}
