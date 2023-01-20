using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    public class Ave : Animal
    {
        public bool Rapina { get; set; }
        public bool CorPena { get; set; }

        public Ave(
            string nome, 
            DateTime dataDeNascimento,
            char sexo,
            int idade,
            bool carnivoro,
            bool peconhento,
            bool rapina, 
            bool corPena) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento)
        {
            Rapina = rapina;
            CorPena = corPena;
        }

      
    }
}
