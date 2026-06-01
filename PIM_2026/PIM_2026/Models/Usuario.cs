namespace PIM_2026.Models
{
    public abstract class Usuario
    {
        // ENCAPSULAMENTO
        private string senha;
        public string Nome { get; set; }
        public string Email { get; set; }

        // propriedade encapsulada
        public string Senha
        {
            get { return senha; }

            set
            {
                if (value.Length >= 6)
                {
                    senha = value;
                }
            }
        }

        // POLIMORFISMO
        public abstract string TipoUsuario();
    }
}