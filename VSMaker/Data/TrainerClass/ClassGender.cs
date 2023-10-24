using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMaker.Data
{
    public class ClassGender
    {
        public int TrainerClassId { get; set; }
        public int GenderId { get; set; }
        public long Offset { get; set; }
        public string GenderDescription { get; set; }
    }
}
