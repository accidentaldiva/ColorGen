using System;
using System.Collections.Generic;
using System.Text;

namespace ColorGenerator
{
    public class Red

    {
        Random newcol = new Random(DateTime.Now.Second);

         List<string> redColorList = new List<string>
            {
            "Cherry",
            "Rose",
            "Jam",
            "Ruby",
            "Apple",
            "Wine"
        };

        List<string> descriptorNameRed = new List<string>
        {
            "Red", "Merlot", "Crimson", "Scarlet", "Mahogany", "Currant", "Blush"
        };

        int cIndex = newcol.Next(redColorList.Length);
        int dIndex = newcol.Next(descriptorNameRed.Length);
	{


    }

        }
        }
}
