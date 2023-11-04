using VSMaker.Resources;
using VSMaker.ROMFiles;

namespace VSMaker.CommonFunctions
{
    /// <summary>
    /// Class to store ROM data from GEN IV Pokémon games
    /// </summary>

    public class RomInfo
    {
        public static string folderSuffix = "_VSMaker_contents";
        public static string romID { get; private set; }
        public static string fileName { get; private set; }
        public static string workDir { get; private set; }
        public static string arm9Path { get; private set; }
        public static string overlayTablePath { get; set; }
        public static string overlayPath { get; set; }

        public static gLangEnum gameLanguage { get; private set; }
        public static gVerEnum gameVersion { get; private set; }
        public static gFamEnum gameFamily { get; private set; }

        public static uint synthOverlayLoadAddress = 0x023C8000;
        public static uint arm9spawnOffset { get; private set; }

        public static int initialMoneyOverlayNumber { get; private set; }
        public static uint initialMoneyOverlayOffset { get; private set; }

        public static int cameraTblOverlayNumber { get; private set; }
        public static uint[] cameraTblOffsetsToRAMaddress { get; private set; }

        public static int prizeMoneyTableOverlayNumber { get; private set; }
        public static uint prizeMoneyTableOffset { get; private set; }
        public static int prizeMoneyTableSize { get; private set; }

        public static uint classGenderOffsetToRAMAddress { get; internal set; }

        public static uint headerTableOffset { get; private set; }

        public static uint conditionalMusicTableOffsetToRAMAddress { get; internal set; }
        public static uint encounterMusicTableOffsetToRAMAddress { get; internal set; }

        public static uint vsTrainerEntryTableOffsetToRAMAddress { get; internal set; }
        public static uint vsPokemonEntryTableOffsetToRAMAddress { get; internal set; }
        public static uint effectsComboTableOffsetToRAMAddress { get; internal set; }

        public static uint vsTrainerEntryTableOffsetToSizeLimiter { get; internal set; }
        public static uint vsPokemonEntryTableOffsetToSizeLimiter { get; internal set; }
        public static uint effectsComboTableOffsetToSizeLimiter { get; internal set; }

        public static uint OWTableOffset { get; internal set; }
        public static string OWtablePath { get; private set; }

        public static string TrainerTablePath { get; private set; }

        public static uint monIconPalTableAddress { get; private set; }
        public static uint monSpritePalTableAddress { get; private set; }

        public static int nullEncounterID { get; private set; }
        public static int abilityNamesTextNumber { get; private set; }
        public static int attackNamesTextNumber { get; private set; }
        public static int[] pokemonNamesTextNumbers { get; private set; }
        public static int itemNamesTextNumber { get; private set; }
        public static int itemScriptFileNumber { get; internal set; }
        public static int trainerClassMessageNumber { get; private set; }
        public static int trainerNamesMessageNumber { get; private set; }
        public static int trainerTextMessageNumber { get; private set; }
        public static int locationNamesTextNumber { get; private set; }
        public static int moveInfoTextNumber { get; private set; }

        public static string internalNamesLocation { get; private set; }
        public static readonly byte internalNameLength = 16;
        public static int cameraSize { get; private set; }

        public Dictionary<List<uint>, (Color background, Color foreground)> MapCellsColorDictionary;
        public static SortedDictionary<uint, (uint spriteID, ushort properties)> OverworldTable { get; private set; }
        public static uint[] overworldTableKeys { get; private set; }
        public static Dictionary<uint, string> ow3DSpriteDict { get; private set; }

        public static Dictionary<ushort, string> ScriptCommandNamesDict { get; private set; }
        public static Dictionary<string, ushort> ScriptCommandNamesReverseDict { get; private set; }

        public static Dictionary<ushort, string> ScriptActionNamesDict { get; private set; }
        public static Dictionary<string, ushort> ScriptActionNamesReverseDict { get; private set; }

        public static Dictionary<ushort, byte[]> ScriptCommandParametersDict { get; private set; }

        public static Dictionary<ushort, string> ScriptComparisonOperatorsDict { get; private set; }
        public static Dictionary<string, ushort> ScriptComparisonOperatorsReverseDict { get; private set; }

        public static SortedDictionary<uint, (uint trainerId, ushort messageTriggerId)> TrainerTable { get; private set; }
        public static List<(long Offset, uint trainerClassId, uint prizeMoney)> PrizeMoneyData { get; set; }
        public static uint[] TrainerMessageIds { get; private set; }

        public enum gVerEnum : byte
        {
            Diamond, Pearl, Platinum,
            HeartGold, SoulSilver,
            Black, White,
            Black2, White2
        }

        public enum gFamEnum : byte
        {
            NULL,
            DP,
            Plat,
            HGSS,
            BW,
            BW2
        }

        public enum gLangEnum : byte
        {
            English,
            Japanese,

            Italian,
            Spanish,
            French,
            German
        }

        public enum DirNames : byte
        {
            personalPokeData,

            synthOverlay,
            dynamicHeaders,

            textArchives,
            matrices,

            maps,
            exteriorBuildingModels,
            buildingConfigFiles,
            buildingTextures,
            mapTextures,
            areaData,

            eventFiles,
            OWSprites,

            scripts,
            encounters,

            trainerProperties,
            trainerParty,
            trainerGraphics,

            monIcons,
            monSprites,

            interiorBuildingModels,
            learnsets,

            trainerTextTable,
            trainerTextOffset,
        };

        public static Dictionary<DirNames, (string packedDir, string unpackedDir)> gameDirs { get; private set; }

        #region Constructors (1)

        public RomInfo(string id, string romName, bool useSuffix = true)
        {
            if (!useSuffix)
            {
                folderSuffix = "";
            }

            workDir = Path.GetDirectoryName(romName) + "\\" + Path.GetFileNameWithoutExtension(romName) + folderSuffix + "\\";
            arm9Path = workDir + @"arm9.bin";
            overlayTablePath = workDir + @"y9.bin";
            overlayPath = workDir + "overlay";
            internalNamesLocation = workDir + @"data\fielddata\maptable\mapname.bin";

            try
            {
                gameVersion = PokeDatabase.System.versionsDict[id];
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("The ROM you attempted to load is not supported.\nYou can only load Gen IV Pokémon ROMS, for now.", "Unsupported ROM",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            romID = id;
            fileName = romName;

            LoadGameFamily();
            LoadGameLanguage();

            SetNarcDirs();
            SetHeaderTableOffset();
            SetNullEncounterID();

            SetAbilityNamesTextNumber();
            SetAttackNamesTextNumber();
            SetPokemonNamesTextNumber();
            SetItemNamesTextNumber();
            SetItemScriptFileNumber();
            SetLocationNamesTextNumber();
            SetTrainerNamesMessageNumber();
            SetTrainerClassMessageNumber();
            SetTrainerTextMessageNumber();
            SetMoveInfoTextNumber();
            /* System */
            ScriptCommandParametersDict = BuildCommandParametersDatabase(gameFamily);

            ScriptCommandNamesDict = BuildCommandNamesDatabase(gameFamily);
            ScriptActionNamesDict = BuildActionNamesDatabase(gameFamily);
            ScriptComparisonOperatorsDict = BuildComparisonOperatorsDatabase(gameFamily);

            ScriptCommandNamesReverseDict = ScriptCommandNamesDict.Reverse();
            ScriptActionNamesReverseDict = ScriptActionNamesDict.Reverse();
            ScriptComparisonOperatorsReverseDict = ScriptComparisonOperatorsDict.Reverse();
        }

        #endregion Constructors (1)

        #region Methods (22)

        public static Dictionary<ushort, string> BuildCommandNamesDatabase(gFamEnum gameFam)
        {
            Dictionary<ushort, string> commonDictionaryNames;
            Dictionary<ushort, string> specificDictionaryNames;

            switch (gameFam)
            {
                case gFamEnum.DP:
                    commonDictionaryNames = ScriptDatabase.DPPtScrCmdNames;
                    specificDictionaryNames = ScriptDatabase.DPScrCmdNames;
                    break;

                case gFamEnum.Plat:
                    commonDictionaryNames = ScriptDatabase.DPPtScrCmdNames;
                    specificDictionaryNames = ScriptDatabase.PlatScrCmdNames;
                    break;

                default:
                    commonDictionaryNames = ScriptDatabase.HGSSScrCmdNames;
#if true
                    specificDictionaryNames = new Dictionary<ushort, string>();
#else
                        specificDictionaryNames = ScriptDatabase.CustomScrCmdNames;
#endif
                    break;
            }
            return commonDictionaryNames.Concat(specificDictionaryNames).ToLookup(x => x.Key, x => x.Value).ToDictionary(x => x.Key, g => g.First());
        }

        public static Dictionary<ushort, byte[]> BuildCommandParametersDatabase(gFamEnum gameFam)
        {
            Dictionary<ushort, byte[]> commonDictionaryParams;
            Dictionary<ushort, byte[]> specificDictionaryParams;

            switch (gameFam)
            {
                case gFamEnum.DP:
                    commonDictionaryParams = ScriptDatabase.DPPtScrCmdParameters;
                    specificDictionaryParams = ScriptDatabase.DPScrCmdParameters;
                    break;

                case gFamEnum.Plat:
                    commonDictionaryParams = ScriptDatabase.DPPtScrCmdParameters;
                    specificDictionaryParams = ScriptDatabase.PlatScrCmdParameters;
                    break;

                default:
                    commonDictionaryParams = ScriptDatabase.HGSSScrCmdParameters;
#if true
                    specificDictionaryParams = new Dictionary<ushort, byte[]>();
#else
                        specificDictionaryParams = ScriptDatabase.CustomScrCmdParameters;
#endif
                    break;
            }
            return commonDictionaryParams.Concat(specificDictionaryParams).ToLookup(x => x.Key, x => x.Value).ToDictionary(x => x.Key, g => g.First());
        }

        public static Dictionary<ushort, string> BuildActionNamesDatabase(gFamEnum gameFam)
        {
            switch (gameFam)
            {
                case gFamEnum.DP:
                case gFamEnum.Plat:
                    return ScriptDatabase.movementsDictIDName;

                default:
#if false
                    var commonDictionaryParams = ScriptDatabase.movementsDictIDName;
                    var customDictionaryParams = ScriptDatabase.customMovementsDictIDName;
                    return commonDictionaryParams.Concat(customDictionaryParams).ToLookup(x => x.Key, x => x.Value).ToDictionary(x => x.Key, g => g.First());
#else
                    return ScriptDatabase.movementsDictIDName;
#endif
            }
        }

        public static Dictionary<ushort, string> BuildComparisonOperatorsDatabase(gFamEnum gameFam)
        {
            switch (gameFam)
            {
                case gFamEnum.DP:
                case gFamEnum.Plat:
                case gFamEnum.HGSS:
                    return ScriptDatabase.comparisonOperatorsDict;

                default:
                    var commonDict = ScriptDatabase.comparisonOperatorsDict;
                    var appendixDict = ScriptDatabase.comparisonOperatorsGenVappendix;
                    return commonDict.Concat(appendixDict).ToLookup(x => x.Key, x => x.Value).ToDictionary(x => x.Key, g => g.First());
            }
        }

        public static void Set3DOverworldsDict()
        {
            ow3DSpriteDict = new Dictionary<uint, string>()
            {
                [91] = "brown_sign",
                [92] = "red_sign",
                [93] = "gray_sign",
                [94] = "route_sign",
                [95] = "blue_sign", //to fix this one (gym_sign)
                [96] = "blue_sign",
                [101] = "dawn_platinum",
                //[174] = "dppt_suitcase",
            };
        }

        public static void SetHeaderTableOffset()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            headerTableOffset = 0xEEDBC;
                            break;

                        case gLangEnum.Spanish:
                            headerTableOffset = 0xEEE08;
                            break;

                        case gLangEnum.Italian:
                            headerTableOffset = 0xEED70;
                            break;

                        case gLangEnum.French:
                            headerTableOffset = 0xEEDFC;
                            break;

                        case gLangEnum.German:
                            headerTableOffset = 0xEEDCC;
                            break;

                        case gLangEnum.Japanese:
                            headerTableOffset = gameVersion == gVerEnum.Diamond ? (uint)0xF0D68 : 0xF0D6C;
                            break;
                    }
                    break;

                case gFamEnum.Plat:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            headerTableOffset = 0xE601C;
                            break;

                        case gLangEnum.Spanish:
                            headerTableOffset = 0xE60B0;
                            break;

                        case gLangEnum.Italian:
                            headerTableOffset = 0xE6038;
                            break;

                        case gLangEnum.French:
                            headerTableOffset = 0xE60A4;
                            break;

                        case gLangEnum.German:
                            headerTableOffset = 0xE6074;
                            break;

                        case gLangEnum.Japanese:
                            headerTableOffset = 0xE56F0;
                            break;
                    }
                    break;

                case gFamEnum.HGSS:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            headerTableOffset = 0xF6BE0;
                            break;

                        case gLangEnum.Spanish:
                            headerTableOffset = gameVersion == gVerEnum.HeartGold ? 0xF6BC8 : (uint)0xF6BD0;
                            break;

                        case gLangEnum.Italian:
                            headerTableOffset = 0xF6B58;
                            break;

                        case gLangEnum.French:
                            headerTableOffset = 0xF6BC4;
                            break;

                        case gLangEnum.German:
                            headerTableOffset = 0xF6B94;
                            break;

                        case gLangEnum.Japanese:
                            headerTableOffset = 0xF6390;
                            break;
                    }
                    break;
            }
        }

        public static void SetupSpawnSettings()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    initialMoneyOverlayNumber = 52;
                    initialMoneyOverlayOffset = 0x1E4;
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            arm9spawnOffset = 0xF2B9C;
                            break;

                        case gLangEnum.Spanish:
                            arm9spawnOffset = 0xF2BE8;
                            break;

                        case gLangEnum.Italian:
                            arm9spawnOffset = 0xF2B50;
                            break;

                        case gLangEnum.French:
                            arm9spawnOffset = 0xF2BDC;
                            break;

                        case gLangEnum.German:
                            arm9spawnOffset = 0xF2BAC;
                            break;

                        case gLangEnum.Japanese:
                            arm9spawnOffset = 0xF4B48;
                            break;
                    }
                    break;

                case gFamEnum.Plat:
                    initialMoneyOverlayNumber = 57;
                    initialMoneyOverlayOffset = 0x1EC;
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            arm9spawnOffset = 0xEA12C;
                            break;

                        case gLangEnum.Spanish:
                            arm9spawnOffset = 0xEA1C0;
                            break;

                        case gLangEnum.Italian:
                            arm9spawnOffset = 0xEA148;
                            break;

                        case gLangEnum.French:
                            arm9spawnOffset = 0xEA1B4;
                            break;

                        case gLangEnum.German:
                            arm9spawnOffset = 0xEA184;
                            break;

                        case gLangEnum.Japanese:
                            arm9spawnOffset = 0xE9800;
                            break;
                    }
                    break;

                case gFamEnum.HGSS:
                    initialMoneyOverlayNumber = 36;
                    initialMoneyOverlayOffset = 0x2FC;
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            arm9spawnOffset = 0xFA17C;
                            break;

                        case gLangEnum.Spanish:
                            arm9spawnOffset = gameVersion == gVerEnum.HeartGold ? 0xFA164 : (uint)0xFA16C;
                            break;

                        case gLangEnum.Italian:
                            arm9spawnOffset = 0xFA0F4;
                            break;

                        case gLangEnum.French:
                            arm9spawnOffset = 0xFA160;
                            break;

                        case gLangEnum.German:
                            arm9spawnOffset = 0xFA130;
                            break;

                        case gLangEnum.Japanese:
                            arm9spawnOffset = 0xF992C;
                            break;
                    }
                    break;
            }
        }

        public static void PrepareCameraData()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    cameraTblOverlayNumber = 5;
                    cameraTblOffsetsToRAMaddress = gameLanguage.Equals(gLangEnum.Japanese) ? (new uint[] { 0x4C50 }) : (new uint[] { 0x4908 });
                    cameraSize = 24;
                    break;

                case gFamEnum.Plat:
                    cameraTblOverlayNumber = 5;
                    cameraTblOffsetsToRAMaddress = new uint[] { 0x4E24 };
                    cameraSize = 24;
                    break;

                case gFamEnum.HGSS:
                    cameraTblOverlayNumber = 1;
                    cameraSize = 36;
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                        case gLangEnum.Spanish:
                        case gLangEnum.French:
                        case gLangEnum.German:
                        case gLangEnum.Italian:
                            cameraTblOffsetsToRAMaddress = new uint[] { 0x532C, 0x547C };
                            break;

                        case gLangEnum.Japanese:
                            cameraTblOffsetsToRAMaddress = new uint[] { 0x5324, 0x5474 };
                            break;
                    }
                    break;
            }
        }

        public static void PreparePrizeMoneyData()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    prizeMoneyTableOverlayNumber = 11;
                    prizeMoneyTableOffset = gameLanguage.Equals(gLangEnum.Japanese) ? (uint)0x32960 : 0x32960;
                    prizeMoneyTableSize = 98;
                    break;

                case gFamEnum.Plat:
                    prizeMoneyTableOverlayNumber = 16;
                    prizeMoneyTableOffset = 0x359E0;
                    prizeMoneyTableSize = 105;
                    break;

                case gFamEnum.HGSS:
                    prizeMoneyTableOverlayNumber = 12;
                    prizeMoneyTableSize = 516;
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                        case gLangEnum.Spanish:
                        case gLangEnum.French:
                        case gLangEnum.German:
                        case gLangEnum.Italian:
                            prizeMoneyTableOffset = 0x34C04;
                            break;

                        case gLangEnum.Japanese:
                            prizeMoneyTableOffset = 0x34C04;
                            break;
                    }
                    break;
            }
        }

        public static void PrepareTrainerClassGenderData()
        {
            switch (gameFamily)
            {
                case gFamEnum.HGSS:
                    switch (gameLanguage)
                    {
                        case gLangEnum.Spanish:
                            classGenderOffsetToRAMAddress = gameVersion == gVerEnum.HeartGold ? (uint)0x0735f8 : 0x073600;
                            break;

                        case gLangEnum.English:
                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.German:
                            classGenderOffsetToRAMAddress = 0x073600;
                            break;

                        case gLangEnum.Japanese:
                            classGenderOffsetToRAMAddress = 0x073098;
                            break;
                    }
                    break;

                case gFamEnum.Plat:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            classGenderOffsetToRAMAddress = 0x793b4;
                            break;

                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                        case gLangEnum.German:
                            classGenderOffsetToRAMAddress = 0x079454;
                            break;

                        case gLangEnum.Japanese:
                            classGenderOffsetToRAMAddress = 0x078c8c;
                            break;
                    }
                    break;
            }
        }

        public static void SetTrainerTable()
        {
            TrainerTablePath = workDir + "\\unpacked\\trainerTextTable\\0000";
        }

        public static void SetConditionalMusicTableOffsetToRAMAddress()
        {
            switch (gameFamily)
            {
                case gFamEnum.HGSS:
                    switch (gameLanguage)
                    {
                        case gLangEnum.Spanish:
                            conditionalMusicTableOffsetToRAMAddress = gameVersion == gVerEnum.HeartGold ? (uint)0x667D0 : 0x667D8;
                            break;

                        case gLangEnum.English:
                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.German:
                            conditionalMusicTableOffsetToRAMAddress = 0x667D8;
                            break;

                        case gLangEnum.Japanese:
                            conditionalMusicTableOffsetToRAMAddress = 0x66238;
                            break;
                    }
                    break;
            }
        }

        public static void SetBattleEffectsData()
        {
            switch (gameFamily)
            {
                case gFamEnum.HGSS:
                    switch (gameLanguage)
                    {
                        case gLangEnum.Spanish:
                            vsPokemonEntryTableOffsetToRAMAddress = gameVersion == gVerEnum.HeartGold ? (uint)0x518CC : 0x518D4;
                            vsTrainerEntryTableOffsetToRAMAddress = gameVersion == gVerEnum.HeartGold ? (uint)0x51888 : 0x51890;
                            effectsComboTableOffsetToRAMAddress = gameVersion == gVerEnum.HeartGold ? (uint)0x517C0 : 0x517C8;
                            break;

                        case gLangEnum.English:
                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.German:
                            vsPokemonEntryTableOffsetToRAMAddress = 0x518D4;
                            vsTrainerEntryTableOffsetToRAMAddress = 0x51890;
                            effectsComboTableOffsetToRAMAddress = 0x517C8;
                            break;

                        case gLangEnum.Japanese:
                            vsPokemonEntryTableOffsetToRAMAddress = 0x5136C;
                            vsTrainerEntryTableOffsetToRAMAddress = 0x51328;
                            effectsComboTableOffsetToRAMAddress = 0x51260;
                            break;
                    }
                    vsPokemonEntryTableOffsetToSizeLimiter = vsPokemonEntryTableOffsetToRAMAddress - 0xA;
                    vsTrainerEntryTableOffsetToSizeLimiter = vsTrainerEntryTableOffsetToRAMAddress - 0xA;
                    effectsComboTableOffsetToSizeLimiter = effectsComboTableOffsetToRAMAddress - 0x1E;
                    break;

                case gFamEnum.Plat:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            effectsComboTableOffsetToRAMAddress = 0x51BE0;
                            break;

                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                        case gLangEnum.German:
                            effectsComboTableOffsetToRAMAddress = 0x51C84;
                            break;

                        case gLangEnum.Japanese:
                            effectsComboTableOffsetToRAMAddress = 0x514C0;
                            break;
                    }
                    break;
            }
        }

        public static void SetEncounterMusicTableOffsetToRAMAddress()
        {
            switch (gameFamily)
            {
                case gFamEnum.HGSS:
                    switch (gameLanguage)
                    {
                        case gLangEnum.Spanish:
                            encounterMusicTableOffsetToRAMAddress = gameVersion == gVerEnum.HeartGold ? (uint)0x550D8 : 0x550E0;
                            break;

                        case gLangEnum.English:
                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.German:
                            encounterMusicTableOffsetToRAMAddress = 0x550E0;
                            break;

                        case gLangEnum.Japanese:
                            encounterMusicTableOffsetToRAMAddress = 0x54B44;
                            break;
                    }
                    break;

                case gFamEnum.Plat:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            encounterMusicTableOffsetToRAMAddress = 0x5563C;
                            break;

                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                        case gLangEnum.German:
                            encounterMusicTableOffsetToRAMAddress = 0x556E0;
                            break;

                        case gLangEnum.Japanese:
                            encounterMusicTableOffsetToRAMAddress = 0x54F04;
                            break;
                    }
                    break;

                case gFamEnum.DP:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            encounterMusicTableOffsetToRAMAddress = 0x4AD3C;
                            break;

                        case gLangEnum.Italian:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                        case gLangEnum.German:
                            encounterMusicTableOffsetToRAMAddress = 0x4ADAC;
                            break;

                        case gLangEnum.Japanese:
                            encounterMusicTableOffsetToRAMAddress = 0x4D9AC;
                            break;
                    }
                    break;
            }
        }

        public static void SetMonIconsPalTableAddress()
        {
            switch (RomInfo.gameFamily)
            {
                case gFamEnum.DP:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6B838, 4), 0);
                            break;

                        case gLangEnum.Italian:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6B874, 4), 0);
                            break;

                        case gLangEnum.German:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6B894, 4), 0);
                            break;

                        case gLangEnum.Japanese:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6FDEC, 4), 0);
                            break;
                    }
                    break;

                case gFamEnum.Plat:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x79F80, 4), 0);
                            break;

                        case gLangEnum.Italian:
                        case gLangEnum.German:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x7A020, 4), 0);
                            break;

                        case gLangEnum.Japanese:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x79858, 4), 0);
                            break;
                    }
                    break;

                case gFamEnum.HGSS:
                default:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                        case gLangEnum.Italian:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74408, 4), 0);
                            break;

                        case gLangEnum.German:
                            if (gameVersion == gVerEnum.HeartGold)
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74408, 4), 0);
                            }
                            else
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74400, 4), 0);
                            }
                            break;

                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                            if (gameVersion == gVerEnum.HeartGold)
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74400, 4), 0);
                            }
                            else
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74408, 4), 0);
                            }
                            break;

                        case gLangEnum.Japanese:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x73EA0, 4), 0);
                            break;
                    }
                    break;
            }
        }

        public static void SetMonIconsSpriteTableAddress()
        {
            switch (RomInfo.gameFamily)
            {
                case gFamEnum.DP:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6B838, 4), 0);
                            break;

                        case gLangEnum.Italian:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6B874, 4), 0);
                            break;

                        case gLangEnum.German:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6B894, 4), 0);
                            break;

                        case gLangEnum.Japanese:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x6FDEC, 4), 0);
                            break;
                    }
                    break;

                case gFamEnum.Plat:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x79F80, 4), 0);
                            break;

                        case gLangEnum.Italian:
                        case gLangEnum.German:
                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x7A020, 4), 0);
                            break;

                        case gLangEnum.Japanese:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x79858, 4), 0);
                            break;
                    }
                    break;

                case gFamEnum.HGSS:
                default:
                    switch (gameLanguage)
                    {
                        case gLangEnum.English:
                        case gLangEnum.Italian:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74408, 4), 0);
                            break;

                        case gLangEnum.German:
                            if (gameVersion == gVerEnum.HeartGold)
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74408, 4), 0);
                            }
                            else
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74400, 4), 0);
                            }
                            break;

                        case gLangEnum.French:
                        case gLangEnum.Spanish:
                            if (gameVersion == gVerEnum.HeartGold)
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74400, 4), 0);
                            }
                            else
                            {
                                monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x74408, 4), 0);
                            }
                            break;

                        case gLangEnum.Japanese:
                            monIconPalTableAddress = BitConverter.ToUInt32(DSUtils.ARM9.ReadBytes(0x73EA0, 4), 0);
                            break;
                    }
                    break;
            }
        }

        private void SetItemScriptFileNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    itemScriptFileNumber = 370;
                    break;

                case gFamEnum.Plat:
                    itemScriptFileNumber = 404;
                    break;

                default:
                    itemScriptFileNumber = 141;
                    break;
            }
        }

        private void SetNullEncounterID()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                case gFamEnum.Plat:
                    nullEncounterID = ushort.MaxValue;
                    break;

                case gFamEnum.HGSS:
                    nullEncounterID = Byte.MaxValue;
                    break;
            }
        }

        private void SetAbilityNamesTextNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    abilityNamesTextNumber = 552;
                    break;

                case gFamEnum.Plat:
                    abilityNamesTextNumber = 610;
                    break;

                case gFamEnum.HGSS:
                    abilityNamesTextNumber = 720;
                    break;

                default:
                    break;
            }
        }

        private void SetMoveInfoTextNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    moveInfoTextNumber = 587;
                    break;

                case gFamEnum.Plat:
                    moveInfoTextNumber = 646;
                    break;

                case gFamEnum.HGSS:
                    moveInfoTextNumber = 749;
                    break;

                default:
                    break;
            }
        }

        private void SetAttackNamesTextNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    attackNamesTextNumber = 588;
                    break;

                case gFamEnum.Plat:
                    attackNamesTextNumber = 647;
                    break;

                default:
                    attackNamesTextNumber = gameLanguage == gLangEnum.Japanese ? 739 : 750;
                    break;
            }
        }

        private void SetItemNamesTextNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    itemNamesTextNumber = 344;
                    break;

                case gFamEnum.Plat:
                    itemNamesTextNumber = 392;
                    break;

                default:
                    itemNamesTextNumber = gameLanguage == gLangEnum.Japanese ? 219 : 222;
                    break;
            }
        }

        private void SetLocationNamesTextNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    locationNamesTextNumber = 382;
                    break;

                case gFamEnum.Plat:
                    locationNamesTextNumber = 433;
                    break;

                default:
                    locationNamesTextNumber = gameLanguage == gLangEnum.Japanese ? 272 : 279;
                    break;
            }
        }

        private void SetPokemonNamesTextNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    pokemonNamesTextNumbers = new int[2] { 362, 363 };
                    break;

                case gFamEnum.Plat:
                    pokemonNamesTextNumbers = new int[7] { 412, 413, 712, 713, 714, 715, 716 }; //413?
                    break;

                case gFamEnum.HGSS:
                    pokemonNamesTextNumbers = gameLanguage.Equals(gLangEnum.Japanese) ? new int[1] { 232 } : new int[7] { 237, 238, 817, 818, 819, 820, 821 }; //238?
                    break;
            }
        }

        private void SetTrainerNamesMessageNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    trainerNamesMessageNumber = 559;
                    if (gameLanguage.Equals(gLangEnum.Japanese))
                    {
                        trainerNamesMessageNumber -= 9;
                    }
                    break;

                case gFamEnum.Plat:
                    trainerNamesMessageNumber = 618;
                    break;

                default:
                    trainerNamesMessageNumber = 729;
                    if (gameLanguage == gLangEnum.Japanese)
                    {
                        trainerNamesMessageNumber -= 10;
                    }
                    break;
            }
        }

        private void SetTrainerClassMessageNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    trainerClassMessageNumber = 560;
                    if (gameLanguage.Equals(gLangEnum.Japanese))
                    {
                        trainerClassMessageNumber -= 9;
                    }
                    break;

                case gFamEnum.Plat:
                    trainerClassMessageNumber = 619;
                    break;

                default:
                    trainerClassMessageNumber = 730;
                    if (gameLanguage.Equals(gLangEnum.Japanese))
                    {
                        trainerClassMessageNumber -= 10;
                    }
                    break;
            }
        }

        private void SetTrainerTextMessageNumber()
        {
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    trainerTextMessageNumber = 558;
                    if (gameLanguage.Equals(gLangEnum.Japanese))
                    {
                        trainerTextMessageNumber -= 9;
                    }
                    break;

                case gFamEnum.Plat:
                    trainerTextMessageNumber = 617;
                    break;

                default:
                    trainerTextMessageNumber = 728;
                    if (gameLanguage == gLangEnum.Japanese)
                    {
                        trainerTextMessageNumber -= 10;
                    }
                    break;
            }
        }

        public string GetBuildingModelsDirPath(bool interior) => interior ? gameDirs[DirNames.interiorBuildingModels].unpackedDir : gameDirs[DirNames.exteriorBuildingModels].unpackedDir;

        public string GetRomNameFromWorkdir() => workDir.Substring(0, workDir.Length - folderSuffix.Length - 1);

        public static int GetHeaderCount() => (int)new FileInfo(internalNamesLocation).Length / internalNameLength;

        public static List<string> GetLocationNames() => new TextArchive(locationNamesTextNumber).Messages;

        public static List<string> GetSimpleTrainerNames() => new TextArchive(trainerNamesMessageNumber).Messages;

        public static string[] GetTrainerMessages() => new TextArchive(trainerTextMessageNumber).Messages.ToArray();

        public static string GetSingleTrainerClassName(int id) => new TextArchive(trainerClassMessageNumber).Messages[id];

        public static string[] GetTrainerClassNames() => new TextArchive(trainerClassMessageNumber).Messages.ToArray();

        public static string[] GetItemNames() => new TextArchive(itemNamesTextNumber).Messages.ToArray();

        public static string[] GetItemNames(int startIndex = 0, int? count = null)
        {
            TextArchive itemNames = new TextArchive(itemNamesTextNumber);
            return itemNames.Messages.GetRange(startIndex, count == null ? itemNames.Messages.Count - 1 : (int)count).ToArray();
        }

        public static string[] GetPokemonNames(int messageNumber = 0) => new TextArchive(pokemonNamesTextNumbers[messageNumber]).Messages.ToArray();

        public static List<string> GetMoveInfo() => new TextArchive(moveInfoTextNumber).Messages;
        public static string[] GetAbilityNames() => new TextArchive(abilityNamesTextNumber).Messages.ToArray();

        public static string[] GetAttackNames() => new TextArchive(attackNamesTextNumber).Messages.ToArray();

        public static int GetLearnsetFilesCount() => Directory.GetFiles(gameDirs[DirNames.learnsets].unpackedDir).Length;

        public static int GetPersonalFilesCount() => Directory.GetFiles(gameDirs[DirNames.personalPokeData].unpackedDir).Length;

        public int GetAreaDataCount() => Directory.GetFiles(gameDirs[DirNames.areaData].unpackedDir).Length;

        public int GetMapTexturesCount() => Directory.GetFiles(gameDirs[DirNames.mapTextures].unpackedDir).Length;

        public int GetBuildingTexturesCount() => Directory.GetFiles(gameDirs[DirNames.buildingTextures].unpackedDir).Length;

        public int GetMatrixCount() => Directory.GetFiles(gameDirs[DirNames.matrices].unpackedDir).Length;

        public int GetTextArchivesCount() => Directory.GetFiles(gameDirs[DirNames.textArchives].unpackedDir).Length;

        public int GetMapCount() => Directory.GetFiles(gameDirs[DirNames.maps].unpackedDir).Length;

        public int GetEventCount() => Directory.GetFiles(gameDirs[DirNames.eventFiles].unpackedDir).Length;

        public int GetScriptCount() => Directory.GetFiles(gameDirs[DirNames.scripts].unpackedDir).Length;

        public int GetBuildingCount(bool interior) => Directory.GetFiles(GetBuildingModelsDirPath(interior)).Length;

        public static int GetEventFileCount() => Directory.GetFiles(RomInfo.gameDirs[DirNames.eventFiles].unpackedDir).Length;

        #endregion Methods (22)

        #region System Methods

        private void LoadGameLanguage()
        {
            switch (romID)
            {
                case "ADAE":
                case "APAE":
                case "CPUE":
                case "IPKE":
                case "IPGE":
                    gameLanguage = gLangEnum.English;
                    break;

                case "ADAS":
                case "APAS":
                case "CPUS":
                case "IPKS":
                case "IPGS":
                case "LATA":
                    gameLanguage = gLangEnum.Spanish;
                    break;

                case "ADAI":
                case "APAI":
                case "CPUI":
                case "IPKI":
                case "IPGI":
                    gameLanguage = gLangEnum.Italian;
                    break;

                case "ADAF":
                case "APAF":
                case "CPUF":
                case "IPKF":
                case "IPGF":
                    gameLanguage = gLangEnum.French;
                    break;

                case "ADAD":
                case "APAD":
                case "CPUD":
                case "IPKD":
                case "IPGD":
                    gameLanguage = gLangEnum.German;
                    break;

                default:
                    gameLanguage = gLangEnum.Japanese;
                    break;
            }
        }

        private void LoadGameFamily()
        {
            switch (gameVersion)
            {
                case gVerEnum.Diamond:
                case gVerEnum.Pearl:
                    gameFamily = gFamEnum.DP;
                    break;

                case gVerEnum.Platinum:
                    gameFamily = gFamEnum.Plat;
                    break;

                case gVerEnum.HeartGold:
                case gVerEnum.SoulSilver:
                    gameFamily = gFamEnum.HGSS;
                    break;
            }
        }

        private static void SetNarcDirs()
        {
            Dictionary<DirNames, string> packedDirsDict = null;
            switch (gameFamily)
            {
                case gFamEnum.DP:
                    string suffix = "";
                    if (!gameLanguage.Equals(gLangEnum.Japanese))
                        suffix = "_release";

                    packedDirsDict = new Dictionary<DirNames, string>()
                    {
                        [DirNames.personalPokeData] = gameVersion == gVerEnum.Pearl ? @"data\poketool\personal_pearl\personal.narc" : @"data\poketool\personal\personal.narc",
                        [DirNames.synthOverlay] = @"data\data\weather_sys.narc",
                        [DirNames.textArchives] = @"data\msgdata\msg.narc",

                        [DirNames.matrices] = @"data\fielddata\mapmatrix\map_matrix.narc",

                        [DirNames.maps] = @"data\fielddata\land_data\land_data" + suffix + ".narc",
                        [DirNames.exteriorBuildingModels] = @"data\fielddata\build_model\build_model.narc",
                        [DirNames.buildingConfigFiles] = @"data\fielddata\areadata\area_build_model\area_build.narc",
                        [DirNames.buildingTextures] = @"data\fielddata\areadata\area_build_model\areabm_texset.narc",
                        [DirNames.mapTextures] = @"data\fielddata\areadata\area_map_tex\map_tex_set.narc",
                        [DirNames.areaData] = @"data\fielddata\areadata\area_data.narc",

                        [DirNames.eventFiles] = @"data\fielddata\eventdata\zone_event" + suffix + ".narc",
                        [DirNames.OWSprites] = @"data\data\mmodel\mmodel.narc",

                        [DirNames.scripts] = @"data\fielddata\script\scr_seq" + suffix + ".narc",

                        [DirNames.trainerProperties] = @"data\poketool\trainer\trdata.narc",
                        [DirNames.trainerParty] = @"data\poketool\trainer\trpoke.narc",
                        [DirNames.trainerGraphics] = @"data\poketool\trgra\trfgra.narc",
                        [DirNames.trainerTextTable] = @"data\poketool\trmsg\trtbl.narc",
                        [DirNames.trainerTextOffset] = @"data\poketool\trmsg\trtblofs.narc",

                        [DirNames.monIcons] = @"data\poketool\icongra\poke_icon.narc",

                        [DirNames.encounters] = @"data\fielddata\encountdata\" + char.ToLower(gameVersion.ToString()[0]) + '_' + "enc_data.narc",
                        [DirNames.learnsets] = workDir + @"data\poketool\personal\wotbl.narc",
                    };
                    break;

                case gFamEnum.Plat:
                    packedDirsDict = new Dictionary<DirNames, string>()
                    {
                        [DirNames.personalPokeData] = @"data\poketool\personal\pl_personal.narc",
                        [DirNames.synthOverlay] = @"data\data\weather_sys.narc",
                        [DirNames.dynamicHeaders] = @"data\debug\cb_edit\d_test.narc",

                        [DirNames.textArchives] = @"data\msgdata\" + gameVersion.ToString().Substring(0, 2).ToLower() + '_' + "msg.narc",

                        [DirNames.matrices] = @"data\fielddata\mapmatrix\map_matrix.narc",

                        [DirNames.maps] = @"data\fielddata\land_data\land_data.narc",
                        [DirNames.exteriorBuildingModels] = @"data\fielddata\build_model\build_model.narc",
                        [DirNames.buildingConfigFiles] = @"data\fielddata\areadata\area_build_model\area_build.narc",
                        [DirNames.buildingTextures] = @"data\fielddata\areadata\area_build_model\areabm_texset.narc",
                        [DirNames.mapTextures] = @"data\fielddata\areadata\area_map_tex\map_tex_set.narc",
                        [DirNames.areaData] = @"data\fielddata\areadata\area_data.narc",

                        [DirNames.eventFiles] = @"data\fielddata\eventdata\zone_event.narc",
                        [DirNames.OWSprites] = @"data\data\mmodel\mmodel.narc",

                        [DirNames.scripts] = @"data\fielddata\script\scr_seq.narc",

                        [DirNames.trainerProperties] = @"data\poketool\trainer\trdata.narc",
                        [DirNames.trainerParty] = @"data\poketool\trainer\trpoke.narc",
                        [DirNames.trainerGraphics] = @"data\poketool\trgra\trfgra.narc",
                        [DirNames.trainerTextTable] = @"data\poketool\trmsg\trtbl.narc",
                        [DirNames.trainerTextOffset] = @"data\poketool\trmsg\trtblofs.narc",

                        [DirNames.monIcons] = @"data\poketool\icongra\pl_poke_icon.narc",

                        [DirNames.encounters] = @"data\fielddata\encountdata\" + gameVersion.ToString().Substring(0, 2).ToLower() + '_' + "enc_data.narc",
                        [DirNames.learnsets] = @"data\poketool\personal\wotbl.narc",
                    };
                    break;

                case gFamEnum.HGSS:
                    packedDirsDict = new Dictionary<DirNames, string>()
                    {
                        [DirNames.personalPokeData] = @"data\a\0\0\2",
                        [DirNames.synthOverlay] = @"data\a\0\2\8",
                        [DirNames.dynamicHeaders] = @"data\a\0\5\0",

                        [DirNames.textArchives] = @"data\a\0\2\7",

                        [DirNames.matrices] = @"data\a\0\4\1",

                        [DirNames.maps] = @"data\a\0\6\5",
                        [DirNames.exteriorBuildingModels] = @"data\a\0\4\0",
                        [DirNames.buildingConfigFiles] = @"data\a\0\4\3",
                        [DirNames.buildingTextures] = @"data\a\0\7\0",
                        [DirNames.mapTextures] = @"data\a\0\4\4",
                        [DirNames.areaData] = @"data\a\0\4\2",

                        [DirNames.eventFiles] = @"data\a\0\3\2",
                        [DirNames.OWSprites] = @"data\a\0\8\1",

                        [DirNames.scripts] = @"data\a\0\1\2",
                        //ENCOUNTERS FOLDER DEPENDS ON VERSION
                        [DirNames.trainerProperties] = @"data\a\0\5\5",
                        [DirNames.trainerParty] = @"data\a\0\5\6",
                        [DirNames.trainerGraphics] = @"data\a\0\5\8",
                        [DirNames.trainerTextTable] = @"data\a\0\5\7",
                        [DirNames.trainerTextOffset] = @"data\a\1\3\1",

                        [DirNames.monIcons] = @"data\a\0\2\0",

                        [DirNames.interiorBuildingModels] = @"data\a\1\4\8",
                        [DirNames.learnsets] = @"data\a\0\3\3",
                    };

                    //Encounter archive is different for SS
                    packedDirsDict[DirNames.encounters] = gameVersion == gVerEnum.HeartGold ? @"data\a\0\3\7" : @"data\a\1\3\6";
                    break;
            }

            gameDirs = new Dictionary<DirNames, (string packedDir, string unpackedDir)>();
            foreach (KeyValuePair<DirNames, string> kvp in packedDirsDict)
            {
                gameDirs.Add(kvp.Key, (workDir + kvp.Value, workDir + @"unpacked" + '\\' + kvp.Key.ToString()));
            }
        }

        public static void ReadTrainerTable()
        {
            SetTrainerTable();
            TrainerTable = new SortedDictionary<uint, (uint trainerId, ushort messageTriggerId)>();
            using BinaryReader idReader = new(new FileStream(TrainerTablePath, FileMode.Open));
            idReader.BaseStream.Position = 0;

            uint messageId = 0;

            while (idReader.BaseStream.Position != idReader.BaseStream.Length)
            {
                uint trainerId = idReader.ReadUInt16();
                ushort messageTypeId = idReader.ReadUInt16();
                TrainerTable.Add(messageId, (trainerId, messageTypeId));
                messageId++;
            }

            TrainerMessageIds = TrainerTable.Keys.ToArray();
        }

        public static void ReadPrizeMoneyTable()
        {
            PreparePrizeMoneyData();
            PrizeMoneyData = new();

            // Decompress Overlay if game is HGSS
            if (DSUtils.OverlayIsCompressed(prizeMoneyTableOverlayNumber) && gameFamily == gFamEnum.HGSS)
            {
                DSUtils.DecompressOverlay(prizeMoneyTableOverlayNumber);
            }
            using BinaryReader idReader = new(new FileStream(DSUtils.GetOverlayPath(prizeMoneyTableOverlayNumber), FileMode.Open));
            idReader.BaseStream.Position = prizeMoneyTableOffset;

            long streamSize = (idReader.BaseStream.Position + prizeMoneyTableSize);

            uint count = 0; // trainerId counter for DP and platinum table
            while (idReader.BaseStream.Position <= streamSize)
            {
                long offset = idReader.BaseStream.Position;
                if (gameFamily == gFamEnum.HGSS)
                {
                    uint trainerClassId = idReader.ReadUInt16();
                    uint prizeMoney = idReader.ReadUInt16();
                    PrizeMoneyData.Add((offset, trainerClassId, prizeMoney));
                }
                else
                {
                    uint prizeMoney = idReader.ReadByte();
                    PrizeMoneyData.Add((offset, count, prizeMoney));
                    count++;
                }
            }
            var test = PrizeMoneyData;
        }

        #endregion System Methods
    }
}