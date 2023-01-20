using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_POO.Classes
{
    internal class Reptil : Animal,IOviparo
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }


        public Reptil(
            string nome,
            DateTime dataDeNascimento,
            char sexo,
            int idade,
            bool carnivoro,
            bool peconhento,
            bool temEscamas, 
            bool temCasco) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento)
        {
            TemEscamas = temEscamas;
            TemCasco = temCasco;
        }
        public void Botar()
        {
            Console.WriteLine("Botando Os ovos pra fora");
        }

        public void Chocar()
        {
            Console.WriteLine("Mantendo os ovos aquecidos");
            string chocando = "";

            for (int i = 0; i < 10; i++)
            {
                chocando += ".";
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(chocando);
            }
            Console.WriteLine("Os ovos ecludiram! parabéns mamãe!");
        }
    }
}
