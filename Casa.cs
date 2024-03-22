namespace CalculoRetangulo
{
    public class Casa
    {
        public int Quarto;
        public int Cozinha;
        public int Sala;
        public int Banheiro;
        public int SalaDeJantar;
        public int Jogos;
        
        public Casa(int quarto, int banheiro)
        {
            Quarto = quarto;
            Banheiro = banheiro;
        }

         public Casa(int quarto, int banheiro, int cozinha) : this(quarto,banheiro)
        {
            Cozinha = cozinha;
        }

        public Casa(int quarto, int banheiro, int cozinha, int sala) : this(quarto, banheiro, cozinha)
        {
            Sala = sala;
        }

        // public Casa(int quarto, int banheiro, int cozinha)
        // {
        //     Quarto = quarto;
        //     Banheiro = banheiro;
        //     Cozinha = cozinha;        
        // }

        // public Casa(int quarto, int banheiro, int cozinha, int sala) 
        // {
        //     Quarto = quarto;
        //     Banheiro = banheiro;
        //     Cozinha = cozinha;
        //     Sala = sala;
        // }

        public override string ToString()
        {
            string mensagem = $"Quartos : {Quarto}\nBanheiros: {Banheiro} \nCozinha : {Cozinha}\nSala: {Sala}: \n "+
                              $"Sala de jantar: {SalaDeJantar}\n Jogos : {Jogos}";  
            return mensagem;
        }


    }
    
}