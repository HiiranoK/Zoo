﻿using Exercicio_POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO.Classes
{
    internal class Coruja : Ave, IVoar
    {
        public Coruja(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento, bool rapina, bool corPena) : base(nome, dataDeNascimento, sexo, idade, carnivoro, peconhento, rapina, corPena)
        {
        }

        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
