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
                mainform.moveNames.Where(x => x != "-").ToList().ForEach(x => moveComboBoxes[i].Items.Add(x));

                if (trainerFile.party[partyIndex].moves == null)
                {
                    moveComboBoxes[i].SelectedIndex = 0;
                }
                else
                {
                    moveComboBoxes[i].SelectedIndex = trainerFile.party[partyIndex].moves[i];
                }
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
            }
        }
    }
}