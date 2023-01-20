using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Mamifero: Animal
    {
        public int QtdeDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CordDoPelo { get; set; }

        public Mamifero(
            string nome,
            DateTime dataDeNascimento,
            char sexo,
            int idade,
            bool carnivoro,
            bool peconhento,
            int qtdeDeMamas,
            bool pelos, 
            string corDoPelo) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento)
        {
            QtdeDeMamas = qtdeDeMamas;
            Pelos = pelos;
            CordDoPelo= corDoPelo;
        }

        public void Amamentar() { }
    }
}
