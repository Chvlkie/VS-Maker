using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMaker.Data
{
    public class MoveCategory
    {
        public static class Descriptions
        {
            public const string Physical = "Physical";
            public const string Special = "Special";
            public const string Status = "Status";
        }

        public static string GetDescriptionById(ushort category)
        {
            return category switch
            {
                0 => Descriptions.Physical,
                1 => Descriptions.Special,
                2 => Descriptions.Status,
                _ => Descriptions.Physical,
            };
        }
    }
}
