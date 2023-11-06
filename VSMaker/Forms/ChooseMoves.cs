using System.Data;
using VSMaker.CommonFunctions;
using VSMaker.ROMFiles;

namespace VSMaker.Forms
{
    public partial class ChooseMoves : Form
    {
        private readonly Mainform mainform;
        private int partyIndex;
        private TrainerFile trainerFile;
        private List<ComboBox> moveComboBoxes;
        private List<RichTextBox> moveInfos;
        private List<TextBox> PPs;
        private List<TextBox> powers;
        private List<TextBox> accuracys;
        private List<TextBox> types;
        private List<TextBox> categories;
        private bool loadingData = false;

        public ChooseMoves(Mainform mainform, int partyIndex, TrainerFile trainerFile)
        {
            this.mainform = mainform;
            this.partyIndex = partyIndex;
            this.trainerFile = trainerFile;

            InitializeComponent();
            loadingData = true;
            moveComboBoxes = new List<ComboBox>
            {
                move1_comboBox,
                move2_comboBox,
                move3_comboBox,
                move4_comboBox,
            };
            moveInfos = new List<RichTextBox>
            {
                moveInfoText1,
                moveInfoText2,
                moveInfoText3,
                moveInfoText4,
            };

            PPs = new List<TextBox>
            {
                pp1,
                pp2,
                pp3,
                pp4,
            };

            powers = new List<TextBox>
            {
                power1,
                power2,
                power3,
                power4
            };

            accuracys = new List<TextBox>
            {
                accuracy1,
                acc2,
                acc3,
                acc4
            };

            categories = new List<TextBox>
            {
                category1,
                cat2,
                cat3,
                cat4
            };

            types = new List<TextBox>
            {
                type1,
                type2,
                type3,
                type4
            };

            SetupMoves();
            loadingData = false;
        }

        private void SetupMoves()
        {
            if (trainerFile.party[partyIndex].moves == null)
            {
                trainerFile.party[partyIndex].moves = new ushort[4];
            }
            for (int i = 0; i < 4; i++)
            {
                if (moveComboBoxes[i].Items.Count > 0)
                {
                    moveComboBoxes[i].Items.Clear();
                }
                moveComboBoxes[i].Items.Add("-----");
                foreach (var item in mainform.moves.Where(x => x.MoveId > 0).ToList())
                {
                    moveComboBoxes[i].Items.Add(item.MoveName);
                }

                moveComboBoxes[i].SelectedIndex = trainerFile.party[partyIndex].moves[i];


                moveInfos[i].Text = mainform.moves[moveComboBoxes[i].SelectedIndex].DisplayMoveInfo;
                var move = RomInfo.ReadMoveData(trainerFile.party[partyIndex].moves[i]);
                PPs[i].Text = move.PP.ToString();
                powers[i].Text = move.Power.ToString();
                accuracys[i].Text = move.Accuracy.ToString();
                types[i].Text = move.DisplayType;
                categories[i].Text = move.DisplayCategory;

            }
        }

        private void move1_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                trainerFile.party[partyIndex].moves[0] = (ushort)move1_comboBox.SelectedIndex;
                moveInfos[0].Text = mainform.moves[moveComboBoxes[0].SelectedIndex].DisplayMoveInfo;
                var move = RomInfo.ReadMoveData(moveComboBoxes[0].SelectedIndex);
                PPs[0].Text = move.PP.ToString();
                powers[0].Text = move.Power.ToString();
                accuracys[0].Text = move.Accuracy.ToString();
                types[0].Text = move.DisplayType;
                categories[0].Text = move.DisplayCategory;
            }
        }

        private void move2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                trainerFile.party[partyIndex].moves[1] = (ushort)move2_comboBox.SelectedIndex;
                moveInfos[1].Text = mainform.moves[moveComboBoxes[1].SelectedIndex].DisplayMoveInfo;
                var move = RomInfo.ReadMoveData(moveComboBoxes[1].SelectedIndex);
                PPs[1].Text = move.PP.ToString();
                powers[1].Text = move.Power.ToString();
                accuracys[1].Text = move.Accuracy.ToString();
                types[1].Text = move.DisplayType;
                categories[1].Text = move.DisplayCategory;
            }
        }

        private void move3_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                trainerFile.party[partyIndex].moves[2] = (ushort)move3_comboBox.SelectedIndex;
                moveInfos[2].Text = mainform.moves[moveComboBoxes[2].SelectedIndex].DisplayMoveInfo;
                var move = RomInfo.ReadMoveData(moveComboBoxes[2].SelectedIndex);
                PPs[2].Text = move.PP.ToString();
                powers[2].Text = move.Power.ToString();
                accuracys[2].Text = move.Accuracy.ToString();
                types[2].Text = move.DisplayType;
                categories[2].Text = move.DisplayCategory;
            }
        }

        private void move4_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loadingData)
            {
                if (!mainform.unsavedChanges)
                {
                    mainform.SetUnsavedChanges(true);
                }
                trainerFile.party[partyIndex].moves[3] = (ushort)move4_comboBox.SelectedIndex;
                moveInfos[3].Text = mainform.moves[moveComboBoxes[3].SelectedIndex].DisplayMoveInfo;
                var move = RomInfo.ReadMoveData(moveComboBoxes[3].SelectedIndex);
                PPs[3].Text = move.PP.ToString();
                powers[3].Text = move.Power.ToString();
                accuracys[3].Text = move.Accuracy.ToString();
                types[3].Text = move.DisplayType;
                categories[3].Text = move.DisplayCategory;
            }
        }
    }
}