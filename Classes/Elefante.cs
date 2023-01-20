using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Elefante : Mamifero
    {
        public Elefante(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento, int qtdeDeMamas, bool pelos, string corDoPelo) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento, qtdeDeMamas, pelos, corDoPelo)
        {
        }
    }
}
