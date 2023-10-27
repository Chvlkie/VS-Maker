using VSMaker.CommonFunctions;
using VSMaker.Data;
using VSMaker.ROMFiles;
using static VSMaker.CommonFunctions.RomInfo;
using static VSMaker.ROMFiles.SpeciesFile;

namespace VSMaker.Forms
{
    public partial class PokemonEditor : Form
    {
        private readonly Mainform mainform;
        private int partyIndex;
        private int pokemonId;
        private TrainerFile trainerFile;
        private bool loadingData = false;

        private List<PokemonForm> pokemonForms = new();
        private const int TRAINER_PARTY_POKEMON_GENDER_DEFAULT_INDEX = 0;
        private const int TRAINER_PARTY_POKEMON_GENDER_MALE_INDEX = 1;
        private const int TRAINER_PARTY_POKEMON_GENDER_FEMALE_INDEX = 2;

        private const int TRAINER_PARTY_POKEMON_ABILITY_SLOT1_INDEX = 0;
        private const int TRAINER_PARTY_POKEMON_ABILITY_SLOT2_INDEX = 1;

        public PokemonEditor(Mainform mainform, int partyIndex, TrainerFile trainerFile)
        {
            this.mainform = mainform;
            this.partyIndex = partyIndex;
            this.trainerFile = trainerFile;
            pokemonId = (int?)trainerFile.party[partyIndex].pokeID ?? 0;
            loadingData = true;
            InitializeComponent();
            SetupStatEditor();
            SetupGenderComboBox();
            SetupForm();
            loadingData = false;
        }

        private void SetupStatEditor()
        {
            pokeStat_Dv_num.Value = trainerFile.party[partyIndex].difficulty;
        }

        private void SetupGenderComboBox()
        {
            pokeStat_Gender_comboBox.Items.Clear();
            pokeStat_Gender_comboBox.Items.Add(Gender.Descriptions.Default);
            pokeStat_Gender_comboBox.Items.Add(Gender.Descriptions.Male);
            pokeStat_Gender_comboBox.Items.Add(Gender.Descriptions.Female);
            SetPokemonGender();
        }

        private void SetupForm()
        {
            if (RomInfo.gameFamily != RomInfo.gFamEnum.DP)
            {
                GetPokemonFormNames(pokemonId);
                pokeStat_Form_comboBox.Items.Clear();
                foreach (var item in pokemonForms)
                {
                    pokeStat_Form_comboBox.Items.Add(item.Description);
                }

                pokeStat_Form_comboBox.Enabled = pokemonForms.Count > 1;
                pokeStat_Form_comboBox.SelectedIndex = pokeStat_Form_comboBox.Enabled ? trainerFile.party[partyIndex].formID : 0;
            }
            else
            {
                pokeStat_Form_comboBox.Enabled = false;
            }
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

        private void SetPokemonGender()
        {
            int currentPokemonGenderRatio = mainform.pokemonSpecies[pokemonId].GenderRatioMaleToFemale;
            PartyPokemon.GenderAndAbilityFlags currentPokemonGenderAndAbilityFlags = trainerFile.party[partyIndex].genderAndAbilityFlags;

            if (gameFamily == gFamEnum.HGSS)
            {
                switch (currentPokemonGenderRatio)
                {
                    case GENDER_RATIO_MALE:
                        pokeStat_Gender_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_GENDER_MALE_INDEX;
                        pokeStat_Gender_comboBox.Enabled = false;
                        break;

                    case GENDER_RATIO_FEMALE:
                        pokeStat_Gender_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_GENDER_FEMALE_INDEX;
                        pokeStat_Gender_comboBox.Enabled = false;
                        break;

                    case GENDER_RATIO_GENDERLESS:
                        pokeStat_Gender_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_GENDER_DEFAULT_INDEX;
                        pokeStat_Gender_comboBox.Enabled = false;
                        break;

                    default:
                        pokeStat_Gender_comboBox.Enabled = true;

                        if (currentPokemonGenderAndAbilityFlags.HasFlag(PartyPokemon.GenderAndAbilityFlags.FORCE_MALE))
                            pokeStat_Gender_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_GENDER_MALE_INDEX;
                        else if (currentPokemonGenderAndAbilityFlags.HasFlag(PartyPokemon.GenderAndAbilityFlags.FORCE_FEMALE))
                            pokeStat_Gender_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_GENDER_FEMALE_INDEX;
                        else
                            pokeStat_Gender_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_GENDER_DEFAULT_INDEX;
                        break;
                }
            }
        }

        private void GetPokemonFormNames(int pokemonID)
        {
            pokemonForms = PokemonForms.GetPokemonForms(pokemonID, mainform.hgEngine);
        }

        private void pokeStat_Form_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                trainerFile.party[partyIndex].formID = (ushort)pokeStat_Form_comboBox.SelectedIndex;
                mainform.ShowPartyPokemonPic((byte)partyIndex);


            }
        }
    }
}