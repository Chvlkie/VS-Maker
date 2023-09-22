using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VSMaker.Fonts
{
    public class VsMakerFont
    {
        public PrivateFontCollection VsMakerFontCollection;
        public void InitializePokemonDsFont()
        {
            //Create your private font collection object.
            VsMakerFontCollection = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.pokemon_ds_font.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.pokemon_ds_font;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            VsMakerFontCollection.AddMemoryFont(data, fontLength);
        }
    }
}
