using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Leao : Mamifero
    {
        public Leao(
            string nome, 
            DateTime dataDeNascimento, 
            char sexo, 
            int idade, 
            bool carnivoro,
            bool peconhento, int mamas,bool pelos, string corPelo) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento,mamas,pelos,corPelo )
        {

        }
    }
}
