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
            SetupPokemonSprite();
            SetupPokemonAbility();
            loadingData = false;
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

            //LoadPokeSpirte(pokeId);
            //UpdatePokeSprite(pokeSprite);
        }

        private void SetupPokemonNature()
        {
        }

        private void SetupPokemonAbility()
        {
            (string Ability1, string Ability2) pokeAbilities = GetPokemonAbilityNames(trainerFile.party[partyIndex].pokeID ?? 0);
            pokeStat_Ability_comboBox.Items.Clear();
            pokeStat_Ability_comboBox.Items.Add(pokeAbilities.Ability1);

            //if the name " -" is returned for ability 2 then there is no ability 2
            if (pokeAbilities.Ability2.Equals(" -") || pokeAbilities.Ability2.Equals(pokeAbilities.Ability1) || gameFamily != gFamEnum.HGSS)
            {
                pokeStat_Ability_comboBox.Enabled = false;
            }
            else
            {
                pokeStat_Ability_comboBox.Items.Add(pokeAbilities.Ability2);
                pokeStat_Ability_comboBox.Enabled = true;
            }

            pokeStat_Ability_comboBox.SelectedIndex = TRAINER_PARTY_POKEMON_ABILITY_SLOT1_INDEX;
        }

        private (string Ability1, string Ability2) GetPokemonAbilityNames(int pokemonID)
        {
            return (mainform.abilityNames[mainform.pokemonSpeciesAbilities[pokemonID].Item1],
                    mainform.abilityNames[mainform.pokemonSpeciesAbilities[pokemonID].Item2]);
        }

        //private int LoadPokeSpirte(int speciesId)
        //{
        //    if (gameFamily == gFamEnum.DP)
        //    {
        //        if (!trainerSpriteMessage)
        //        {
        //            MessageBox.Show("Diamond and Pearl trainer sprites are compressed.\nAt the moment they cannot be viewed.", "Unable To View Trainer Sprite", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            trainerSpriteMessage = true;
        //        }
        //        return 0;
        //    }

        //    int tilesFileId = speciesId * 5;
        //    int paletteFileID = (tilesFileId + 1);
        //    string paletteFilename = paletteFileID.ToString("D4");
        //    pokemonPalette = new NCLR(gameDirs[DirNames.monSprites].unpackedDir + "\\" + paletteFilename, paletteFileID, paletteFilename);

        //    string tilesFilename = tilesFileId.ToString("D4");
        //    pokemonTile = new NCGR(gameDirs[DirNames.monSprites].unpackedDir + "\\" + tilesFilename, tilesFileId, tilesFilename);

        //    int spriteFileID = (tilesFileId + 2);
        //    string spriteFilename = spriteFileID.ToString("D4");
        //    pokemonSprite = new NCER(gameDirs[DirNames.monSprites].unpackedDir + "\\" + spriteFilename, spriteFileID, spriteFilename);

        //    return pokemonSprite.Banks.Length - 1;
        //}

        //private void UpdatePokeSprite(PictureBox pictureBox, int frameNumber = 0)
        //{
        //if (pokemonSprite == null)
        //{
        //    Console.WriteLine("Sprite is null!");
        //    return;
        //}

        //frameNumber = Math.Min(pokemonSprite.Banks.Length - 1, frameNumber);
        //pictureBox.Image = pokemonSprite.Get_Image(pokemonTile, pokemonPalette, frameNumber, pictureBox.Width, pictureBox.Height, false, false, false, true, true, -1, OAMenabled);
        //pictureBox.Update();
        //}

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
                        case TRAINER_PARTY_POKEMON_GENDER_DEFAULT_INDEX:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.NO_FLAGS;
                            break;

                        case TRAINER_PARTY_POKEMON_GENDER_MALE_INDEX:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.FORCE_MALE;
                            break;

                        case TRAINER_PARTY_POKEMON_GENDER_FEMALE_INDEX:
                            trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.FORCE_FEMALE;
                            break;
                    }
                }
                else
                {
                    trainerFile.party[partyIndex].genderAndAbilityFlags = PartyPokemon.GenderAndAbilityFlags.NO_FLAGS;
                }
            }
        }

        private void pokeStat_Ability_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}