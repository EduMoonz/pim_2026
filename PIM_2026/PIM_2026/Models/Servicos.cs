namespace PIM_2026.Models
{
    public class Servicos
    {
        public int Idservico { get; set; }
        public string Nome { get; set; }
        private Decimal preco;

        public Decimal Preco
        {
            get { return preco; }

            set
            {
                if (value >=0)
                {
                    preco = value;
                }
            }
            
        }
        public int Duracao { get; set; }
    }


}