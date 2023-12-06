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

        //private PaletteBase pokemonPalette;
        //private SpriteBase pokemonSprite;
        //private ImageBase pokemonTile;

        private List<PokemonForm> pokemonForms = new();

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
            SetupPokemonAbility();
            SetupGenderComboBox();
            SetupForm();
            SetupPokemonSprite();
            SetupBallSeals();
            SetPokemonAbility();
            SetPokemonGender();
            loadingData = false;
        }

        private void SetPokemonAbility()
        {
            if (trainerFile.party[partyIndex].genderAndAbilityFlags.HasFlag(PartyPokemon.GenderAndAbilityFlags.ABILITY_SLOT2))
                pokeStat_Ability_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_ABILITY_SLOT2_INDEX;
            else
                pokeStat_Ability_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_ABILITY_SLOT1_INDEX;
        }

        private void SetupPokemonSprite()
        {
            //to do
            int pokeId = trainerFile.party[partyIndex].pokeID ?? 0;

            if (gameFamily != gFamEnum.DP)
            {
                int formId = trainerFile.party[partyIndex].formID;
                if (formId > 0)
                {
                    pokeId = PokemonForms.GetPokemonForms(pokeId, mainform.hgEngine).Find(x => x.FormId == formId).SpeciesId;
                }
            }
        }

        private (string ability1, string ability2) GetPokemonAbilityNames(int pokemonID)
        {
            return (mainform.abilityNames[mainform.pokemonSpeciesAbilities[pokemonID].Item1],
                    mainform.abilityNames[mainform.pokemonSpeciesAbilities[pokemonID].Item2]);
        }

        private void SetupPokemonAbility()
        {
            (string ability1, string ability2) currentPartyPokemonAbilities = GetPokemonAbilityNames(trainerFile.party[partyIndex].pokeID ?? 0);
            pokeStat_Ability_comboBox.Items.Clear();
            pokeStat_Ability_comboBox.Items.Add(currentPartyPokemonAbilities.ability1);

            //if the name " -" is returned for ability 2 then there is no ability 2
            if (currentPartyPokemonAbilities.ability2.Equals(" -") || currentPartyPokemonAbilities.ability2.Equals(currentPartyPokemonAbilities.ability1) || gameFamily != gFamEnum.HGSS)
            {
                pokeStat_Ability_comboBox.Enabled = false;
            }
            else
            {
                pokeStat_Ability_comboBox.Items.Add(currentPartyPokemonAbilities.ability2);
                pokeStat_Ability_comboBox.Enabled = true;
            }
        }

        private void SetupBallSeals()
        {
            pokeStat_BallSeal_comboBox.Items.Clear();
            foreach (var item in BallSeals.Seals)
            {
                pokeStat_BallSeal_comboBox.Items.Add(item.Name);
            }

            if (trainerFile.party[partyIndex].ballSeals > 27)
            {
                pokeStat_BallSeal_comboBox.SelectedIndex = 0;
            }
            else
            {
                pokeStat_BallSeal_comboBox.SelectedIndex = trainerFile.party[partyIndex].ballSeals;
            }
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
                ushort formId = pokeStat_Form_comboBox.Enabled ? trainerFile.party[partyIndex].formID : (ushort)0;
                pokeStat_Form_comboBox.SelectedIndex = formId;
            }
            else
            {
                pokeStat_Form_comboBox.Enabled = false;
            }
        }

        private void pokeStat_Dv_slider_Scroll(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                pokeStat_Dv_num.Value = pokeStat_Dv_slider.Value;
            }
        }

        private void pokeStat_Dv_num_ValueChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                pokeStat_Dv_slider.Value = (int)pokeStat_Dv_num.Value;
                trainerFile.party[partyIndex].difficulty = (byte)pokeStat_Dv_slider.Value;
            }
        }

        private void SetPokemonGender()
        {
            int pokemonId = trainerFile.party[partyIndex].pokeID ?? 0;
            int currentPokemonGenderRatio = mainform.pokemonSpecies[pokemonId].GenderRatioMaleToFemale;
            PartyPokemon.GenderAndAbilityFlags currentPokemonGenderAndAbilityFlags = trainerFile.party[partyIndex].genderAndAbilityFlags;

            if (gameFamily == gFamEnum.HGSS)
            {
                switch (currentPokemonGenderRatio)
                {
                    case GENDER_RATIO_MALE:
                        pokeStat_Gender_comboBox.SelectedIndex = Gender.PokemonGenders.Male;
                        pokeStat_Gender_comboBox.Enabled = false;
                        break;

                    case GENDER_RATIO_FEMALE:
                        pokeStat_Gender_comboBox.SelectedIndex = Gender.PokemonGenders.Female;
                        pokeStat_Gender_comboBox.Enabled = false;
                        break;

                    case GENDER_RATIO_GENDERLESS:
                        pokeStat_Gender_comboBox.SelectedIndex = Gender.PokemonGenders.Default;
                        pokeStat_Gender_comboBox.Enabled = false;
                        break;

                    default:
                        pokeStat_Gender_comboBox.Enabled = true;

                        if (currentPokemonGenderAndAbilityFlags.HasFlag(PartyPokemon.GenderAndAbilityFlags.FORCE_MALE))
                            pokeStat_Gender_comboBox.SelectedIndex = Gender.PokemonGenders.Male;
                        else if (currentPokemonGenderAndAbilityFlags.HasFlag(PartyPokemon.GenderAndAbilityFlags.FORCE_FEMALE))
                            pokeStat_Gender_comboBox.SelectedIndex = Gender.PokemonGenders.Female;
                        else
                            pokeStat_Gender_comboBox.SelectedIndex = Gender.PokemonGenders.Default;
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
                ushort formId = (ushort)pokeStat_Form_comboBox.SelectedIndex;
               
                trainerFile.party[partyIndex].formID = formId;

                mainform.ShowPartyPokemonPic((byte)partyIndex);
            }
        }

        private void pokeStat_Gender_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }

                if (hasMoreThanOneGender((int)trainerFile.party[partyIndex].pokeID, mainform.pokemonSpecies) && gameFamily == gFamEnum.HGSS)
                {
                    switch (pokeStat_Gender_comboBox.SelectedIndex)
                    {
                        case Gender.PokemonGenders.Default:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.NO_FLAGS;
                            break;

                        case Gender.PokemonGenders.Male:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.FORCE_MALE;
                            break;

                        case Gender.PokemonGenders.Female:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.FORCE_FEMALE;
                            break;
                    }
                }
                else
                    trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.NO_FLAGS;

                if (pokeStat_Ability_comboBox.SelectedIndex == TRAINER_PARTY_POKEMON_ABILITY_SLOT2_INDEX)
                {
                    trainerFile.party[partyIndex].genderAndAbilityFlags |= PartyPokemon.GenderAndAbilityFlags.ABILITY_SLOT2;
                }
            }
        }

        private void pokeStat_Ability_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }

                if (hasMoreThanOneGender((int)trainerFile.party[partyIndex].pokeID, mainform.pokemonSpecies) && gameFamily == gFamEnum.HGSS)
                {
                    switch (pokeStat_Gender_comboBox.SelectedIndex)
                    {
                        case Gender.PokemonGenders.Default:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.NO_FLAGS;
                            break;

                        case Gender.PokemonGenders.Male:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.FORCE_MALE;
                            break;

                        case Gender.PokemonGenders.Female:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.FORCE_FEMALE;
                            break;
                    }
                }
                else
                    trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.NO_FLAGS;

                if (pokeStat_Ability_comboBox.SelectedIndex == TRAINER_PARTY_POKEMON_ABILITY_SLOT2_INDEX)
                {
                    trainerFile.party[partyIndex].genderAndAbilityFlags |= PartyPokemon.GenderAndAbilityFlags.ABILITY_SLOT2;
                }
            }
        }

        private void pokeStat_BallSeal_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                trainerFile.party[partyIndex].ballSeals = (ushort)pokeStat_BallSeal_comboBox.SelectedIndex;
            }
        }
    }
}