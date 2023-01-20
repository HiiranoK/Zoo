namespace Exercicio_POO.Classes
{
    public class Animal 
    {
        public string Nome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
        public char Sexo { get; private set; }
        public int Idade { get; private set; }
        public bool Carnivoro { get; private set; }
        public bool Peconheto { get; private set; }
        
        public Animal(string nome, DateTime dataDeNascimento, char sexo, int idade, bool carnivoro, bool peconhento) 
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Idade = idade;
            Carnivoro = carnivoro;
            Peconheto= peconhento;
        }

        public void Movimentar() { }
        public void Comunicar() { }
        public void Alimentar() { }
    }
}
