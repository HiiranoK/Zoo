using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class DragaoDeComodo : Reptil
    {
        public DragaoDeComodo(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento, bool temEscamas, bool temCasco) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento, temEscamas, temCasco)
        {
        }


    }
}
