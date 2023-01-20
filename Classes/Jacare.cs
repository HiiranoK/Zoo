using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Jacare : Reptil, IAquatico
    {
        public Jacare(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento, bool temEscamas, bool temCasco) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento, temEscamas, temCasco)
        {
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
