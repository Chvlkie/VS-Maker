using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMaker.Data
{
    public class EyeContactMusic
    {
     public byte TrainerClassId { get; set; }
        public uint EntryOffset { get; set; }
        public ushort EyeContactDay { get; set; }
        public ushort EyeContactNight { get; set; }
    }
}
