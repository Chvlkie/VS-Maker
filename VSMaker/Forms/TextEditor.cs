using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSMaker.Data;
using VSMaker.Fonts;

namespace VSMaker.Forms
{
    public partial class TextEditor : Form
    {
        private VsMakerFont vsMakerFont;

        private int currentTrainerMessageIndex = 0;
        private List<string> displayTrainerMessage = new();
        private string messageText;
        private int trainerMessageId;
        public TextEditor(int trainerMessageId, string messageText, VsMakerFont vsMakerFont)
        {
            this.trainerMessageId = trainerMessageId;
            this.messageText = messageText;
            this.vsMakerFont = vsMakerFont;
            InitializeComponent();
            UpdateMessage(messageText);

        }

        public void UpdateMessage(string text)
        {
            textEditor_Message.Text = text;
            UpdateTextPreview(textEditor_Message.Text);
        }

        private void textEditor_Message_TextChanged(object sender, EventArgs e)
        {
            UpdateTextPreview(textEditor_Message.Text);
        }

        private static string ReadLine(string text, int lineNumber)
        {
            var reader = new StringReader(text);

            string line;
            int currentLineNumber = 0;

            do
            {
                currentLineNumber += 1;
                line = reader.ReadLine();
            }
            while (line != null && currentLineNumber < lineNumber);

            return (currentLineNumber == lineNumber) ? line :
                                                       string.Empty;
        }

        private void UpdateTextPreview(string trainerText)
        {
            currentTrainerMessageIndex = 0;
            displayTrainerMessage = new List<string>();
            const string seperator1 = @"\r";
            trainerText = trainerText.Replace("\\n", Environment.NewLine);
            trainerText = trainerText.Replace("\\f", Environment.NewLine);
            var messageArray = trainerText.Split(new string[] { seperator1 }, StringSplitOptions.None);
            foreach (var item in messageArray)
            {
                int numLines = item.Split('\n').Length;
                if (numLines == 3 && !string.IsNullOrEmpty(ReadLine(item, 3)))
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
        }

        private void trainerText_save_Click(object sender, EventArgs e)
        {
            RomFileSystem.UpdateTrainerTextMessages(textEditor_Message.Text, trainerMessageId);
        }
    }
}

