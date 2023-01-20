using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Onitorrinco : Mamifero, IAquatico, IOviparo
    {
        public Onitorrinco(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento, int qtdeDeMamas, bool pelos, string corDoPelo) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento, qtdeDeMamas, pelos, corDoPelo)
        {
            ViveEmTerra = true;
            Mergulho= true;
            AguaDoce = true;
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public void Botar()
        {
            Console.WriteLine("Botando Os ovos pra fora");
        }

        public void Chocar()
        {
            Console.WriteLine("Mantendo os ovos aquecidos");
            string chocando ="";

            for(int i = 0; i < 10; i++)
            {
                chocando += ".";
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(chocando);
            }
            Console.WriteLine("Os ovos ecludiram! parabéns mamãe!");
        }
    }
}
