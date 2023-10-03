namespace VSMaker.Forms
{
    public partial class PokemonEditor : Form
    {
        private readonly Mainform mainform;
        private int pokemonId;

        public PokemonEditor(Mainform mainform, int pokemonId)
        {
            this.mainform = mainform;
            this.pokemonId = pokemonId;
            InitializeComponent();
        }
    }
}