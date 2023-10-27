using VSMaker.Fonts;

namespace VSMaker.Forms
{
    public partial class TextEditor : Form
    {
        private VsMakerFont vsMakerFont;

        private int currentTrainerMessageIndex;
        private List<string> displayTrainerMessage = new();
        private readonly string message;
        private readonly int trainerMessageId;
        private readonly Mainform mainform;
        private readonly string seperator = @"\r";
        private bool unsavedChanges = false;

        public TextEditor(Mainform mainform, int trainerMessageId, string message, VsMakerFont vsMakerFont)
        {
            this.mainform = mainform;
            this.trainerMessageId = trainerMessageId;
            this.message = message;
            this.vsMakerFont = vsMakerFont;
            InitializeComponent();
            UpdateMessage(message);
            trainerText_Undo.Enabled = false;
            trainerText_redo.Enabled = false;
        }

        public void UpdateMessage(string text)
        {
            textEditor_Message.Text = text;
            UpdateTextPreview(textEditor_Message.Text);
        }

        private void textEditor_Message_TextChanged(object sender, EventArgs e)
        {
            UpdateTextPreview(textEditor_Message.Text);
            trainerText_Undo.Enabled = textEditor_Message.CanUndo;
            trainerText_redo.Enabled = textEditor_Message.CanRedo;
            unsavedChanges = textEditor_Message.CanUndo;
        }

        private static string? ReadLine(string text, int lineNumber)
        {
            var reader = new StringReader(text);

            string line;
            int currentLineNumber = 0;

            do
            {
                currentLineNumber++;
                line = reader.ReadLine();
            }
            while (line != null && currentLineNumber < lineNumber);

            return (currentLineNumber == lineNumber) ? line : string.Empty;
        }

        private void UpdateTextPreview(string trainerText)
        {
            currentTrainerMessageIndex = 0;
            displayTrainerMessage = new List<string>();
            trainerText = trainerText.Replace("\\n", Environment.NewLine);
            trainerText = trainerText.Replace("\\f", Environment.NewLine);
            foreach (var item in trainerText.Split(new string[] { seperator }, StringSplitOptions.None))
            {
                int numLines = item.Split('\n').Length;
                if (numLines >= 3 && !string.IsNullOrEmpty(ReadLine(item, 3)))
                {
                    string text1 = ReadLine(item, 1) + Environment.NewLine + ReadLine(item, 2);
                    string text2 = ReadLine(item, 2) + Environment.NewLine + ReadLine(item, 3);

                    displayTrainerMessage.Add(text1);
                    displayTrainerMessage.Add(text2);
                }
                else
                {
                    displayTrainerMessage.Add(item);
                }
            }

            // Remove last item if blank line - is the case as trainer text formatted as ending with \n.
            if (displayTrainerMessage.Count > 1 && string.IsNullOrEmpty(displayTrainerMessage.Last()))
            {
                displayTrainerMessage.Remove(displayTrainerMessage.Last());
            }
            trainer_Message.Font = new Font(vsMakerFont.VsMakerFontCollection.Families[0], trainer_Message.Font.Size);
            trainer_Message.Text = displayTrainerMessage[0];
            trainer_Message_Next_btn.Enabled = displayTrainerMessage.Count > 1;
            trainer_Message_Back_btn.Enabled = false;
        }

        private void trainer_Message_Next_btn_Click(object sender, EventArgs e)
        {
            currentTrainerMessageIndex++;
            trainer_Message_Back_btn.Enabled = currentTrainerMessageIndex > 0;
            trainer_Message_Next_btn.Enabled = currentTrainerMessageIndex < displayTrainerMessage.Count - 1;

            if (currentTrainerMessageIndex < displayTrainerMessage.Count)
            {
                trainer_Message.Text = displayTrainerMessage[currentTrainerMessageIndex];
            }
            else
            {
                currentTrainerMessageIndex--;
            }
        }

        private void trainer_Message_Back_btn_Click(object sender, EventArgs e)
        {
            currentTrainerMessageIndex--;
            trainer_Message_Back_btn.Enabled = currentTrainerMessageIndex > 0;
            trainer_Message_Next_btn.Enabled = currentTrainerMessageIndex >= 0;

            if (currentTrainerMessageIndex >= 0)
            {
                trainer_Message.Text = displayTrainerMessage[currentTrainerMessageIndex];
            }
            else
            {
                currentTrainerMessageIndex++;
            }
        }

        private void textEditor_Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Z && e.Control && textEditor_Message.CanUndo)
            {
                textEditor_Message.Undo();
                trainerText_Undo.Enabled = textEditor_Message.CanUndo;
            }
            if (e.KeyCode == Keys.Y && e.Control && textEditor_Message.CanRedo)
            {
                textEditor_Message.Redo();
                trainerText_redo.Enabled = textEditor_Message.CanRedo;
            }
        }

        private void trainerText_save_Click(object sender, EventArgs e)
        {
            RomFileSystem.UpdateTrainerTextMessages(textEditor_Message.Text, trainerMessageId);
            mainform.RefreshTrainerMessages();
        }

        private void trainerText_Undo_Click(object sender, EventArgs e)
        {
            if (textEditor_Message.CanUndo)
            {
                textEditor_Message.Undo();
                trainerText_Undo.Enabled = textEditor_Message.CanUndo;
            }
        }

        private void trainerText_redo_Click(object sender, EventArgs e)
        {
            if (textEditor_Message.CanRedo)
            {
                textEditor_Message.Redo();
                trainerText_redo.Enabled = textEditor_Message.CanRedo;
            }
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (unsavedChanges)
            {
                var choice = MessageBox.Show("You have unsaved changes.\nDo you wish to discard these changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}