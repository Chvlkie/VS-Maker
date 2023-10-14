using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSMaker.ROMFiles;

namespace VSMaker.Forms
{
    public partial class ChooseMoves : Form
    {
        private readonly Mainform mainform;
        private int partyIndex;
        private TrainerFile trainerFile;

        public ChooseMoves(Mainform mainform, int partyIndex, TrainerFile trainerFile)
        {
            this.mainform = mainform;
            this.partyIndex = partyIndex;
            this.trainerFile = trainerFile;
            InitializeComponent();
        }
    }
}
