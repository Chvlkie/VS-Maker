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

        private void pokeStat_Dv_slider_Scroll(object sender, EventArgs e)
        {
            pokeStat_Dv_num.Value = pokeStat_Dv_slider.Value;
        }

        private void pokeStat_Dv_num_ValueChanged(object sender, EventArgs e)
        {
            pokeStat_Dv_slider.Value = (int)pokeStat_Dv_num.Value;
        }
    }
}