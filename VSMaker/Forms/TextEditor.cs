using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSMaker.Forms
{
    public partial class TextEditor : Form
    {
        private string messageText;
        public TextEditor(int trainerMessageId, string messageText)
        {
            this.messageText = messageText;
            InitializeComponent();
            SetMessageText();
        }

        public void SetMessageText()
        {
            textEditor_Message.Text = messageText;
        }

    }
}
