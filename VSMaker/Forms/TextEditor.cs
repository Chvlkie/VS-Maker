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
            PopulateMessageEdit(messageText);

        }

        public void UpdateMessage(string text)
        {
            textEditor_Message.Text = text;
            UpdateTextPreview(textEditor_Message.Text);
        }

        private void PopulateMessageEdit(string text)
        {
            foreach (var item in displayTrainerMessage)
            {
                textEditor_pages.Tab
            }
        }

        private void textEditor_Message_TextChanged(object sender, EventArgs e)
        {
            UpdateTextPreview(textEditor_Message.Text);
        }

        private void UpdateTextPreview(string trainerText)
        {
            currentTrainerMessageIndex = 0;
            displayTrainerMessage = new List<string>();
            const string seperator1 = @"\r";
            const string seperator2 = @"\f";
            trainerText = trainerText.Replace("\\n", Environment.NewLine);
            var messageArray = trainerText.Split(new string[] { seperator1, seperator2 }, StringSplitOptions.None);
            foreach (var item in messageArray)
            {
                displayTrainerMessage.Add(item);
            }
            // Remove last item if blank line - is the case as trainer text formatted as ending with \n.
            if (displayTrainerMessage.Count() > 1 && string.IsNullOrEmpty(displayTrainerMessage.Last()))
            {
                displayTrainerMessage.Remove(displayTrainerMessage.Last());
            }
            trainer_Message.Font = new Font(vsMakerFont.VsMakerFontCollection.Families[0], trainer_Message.Font.Size);
            trainer_Message.Text = displayTrainerMessage[0];
            trainer_Message_Next_btn.Enabled = displayTrainerMessage.Count() > 1;
            trainer_Message_Back_btn.Enabled = false;
        }

        private void addLine_btn_Click(object sender, EventArgs e)
        {
            // If text has 2 lines, add 3rd line as \f
            if (displayTrainerMessage[currentTrainerMessageIndex].Split('\n').Length == 2)
            {
                textEditor_Message.Text += "\\f";
            }
            // If text has 3 lines, add new page \r
            else if (displayTrainerMessage[currentTrainerMessageIndex].Split('\n').Length == 3)
            {
                textEditor_Message.Text += "\\r";
                currentTrainerMessageIndex++;
            }
            else
            {
                textEditor_Message.Text += "\\f";
            }
        }
    }
}

