using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Data
{
    public class TrainerMessage
    {
        public int MessageId { get; set; }
        public int TrainerId { get; set; }
        public int MessageTriggerId { get; set; }
        public string MessageText { get; set; }
    }
}
