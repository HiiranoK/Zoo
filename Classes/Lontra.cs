using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Lontra : Mamifero, IAquatico
    {
        public Lontra(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento, int qtdeDeMamas, bool pelos, string corDoPelo) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento, qtdeDeMamas, pelos, corDoPelo)
        {
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
