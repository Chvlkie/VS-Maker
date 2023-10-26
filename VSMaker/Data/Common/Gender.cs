using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSMaker.Data
{
    public static class Gender
    {
        public static class Descriptions
        {
            public const string Male = "Male ♂";
            public const string Female = "Female ♀";
            public const string None = "None";
        }

        public static string GetDescriptionById(int genderId)
        {
            return genderId switch
            {
                0 => Descriptions.Male,
                1 => Descriptions.Female,
                2 => Descriptions.None,
                _ => Descriptions.None,
            };
        }
    }
}
