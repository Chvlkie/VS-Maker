using System.Data;
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
            SetupMoves();
            loadingData = false;
        }

        private void SetupMoves()
        {
            if (trainerFile.party[partyIndex].moves == null)
            {
                trainerFile.party[partyIndex].moves = new ushort[4];
                for (int i = 0; i < 4; i++)
                {
                    trainerFile.party[partyIndex].moves[i] = 0;
                }
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

                if (trainerFile.party[partyIndex].moves == null)
                {
                    moveComboBoxes[i].SelectedIndex = 0;
                }
                else
                {
                    moveComboBoxes[i].SelectedIndex = trainerFile.party[partyIndex].moves[i];
                }

                moveInfos[i].Text = mainform.moves[moveComboBoxes[i].SelectedIndex].DisplayMoveInfo;
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
            }
        }
    }
}