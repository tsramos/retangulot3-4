

namespace CalculoRetangulo.Entidades
{
    public class Pessoa
    {
        public int Id;
        public string Nome;
        public string SegundoNome;
        public string NomeDoMeio;
        public string Sobrenome;

        public Pessoa()
        {
            Id = 1;
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public double Sum(double n1, double n2){
            return n1 + n2;
        }

        public double Sum(string n1, double n2)
        {
            double correctNumber = double.Parse(n1);
            return correctNumber + n2;
        }

        public double Sum(double n1, string n2)
        {
            return n1;
        }

        public double Sum(double n1, double n2 , double n3)
        {
            return n1+n2+n3;
        }

    }
}
