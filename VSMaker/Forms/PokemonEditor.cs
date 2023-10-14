using VSMaker.Data;
using VSMaker.ROMFiles;

namespace VSMaker.Forms
{
    public partial class PokemonEditor : Form
    {
        private readonly Mainform mainform;
        private int partyIndex;
        private TrainerFile trainerFile;

        public PokemonEditor(Mainform mainform, int partyIndex, TrainerFile trainerFile)
        {
            this.mainform = mainform;
            this.partyIndex = partyIndex;
            this.trainerFile = trainerFile;
            InitializeComponent();
            SetupStatEditor();
        }

        private void SetupStatEditor()
        {
            pokeStat_Dv_num.Value = trainerFile.party[partyIndex].difficulty;
        }

        private void pokeStat_Dv_slider_Scroll(object sender, EventArgs e)
        {
            pokeStat_Dv_num.Value = pokeStat_Dv_slider.Value;      
        }

        private void pokeStat_Dv_num_ValueChanged(object sender, EventArgs e)
        {
            pokeStat_Dv_slider.Value = (int)pokeStat_Dv_num.Value;
            trainerFile.party[partyIndex].difficulty = (byte)pokeStat_Dv_slider.Value;
        }
    }
}