using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistorCalculator.OhmCalculator
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        //A dictonary for band colors and its value  
        private readonly Dictionary<string, int> color = new Dictionary<string, int> { { "None", 0 }, { "Black", 0 }, { "Brown", 1 }, { "Red", 2 }, { "Orange", 3 }, { "Yellow", 4 }, { "Green", 5 }, { "Blue", 6 }, { "Violet", 7 }, { "Gray", 8 }, { "White", 9 } };

        //A dictonary for band colors and the multiplier value
        private readonly Dictionary<string, int> multiplier = new Dictionary<string, int> { { "None", 0 }, { "Black", 1 }, { "Brown", 10 }, { "Red", 100 }, { "Orange", 1000 }, { "Yellow", 10000 }, { "Green", 100000 }, { "Blue", 1000000 }, { "Violet", 10000000 }};

        //A dictionary for tolerance colors and its value 
        private readonly Dictionary<string, int> tolerance = new Dictionary<string, int> { { "None", 20 }, { "Brown", 1 }, { "Red", 2 }, { "Gold", 5 }, { "Silver", 10 } };

        //tolerance value in percentage 
        private int tolerancePercent = 0;

        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            int bandA = -1;
            int bandB = -1;
            int bandC = -1;


            //Checking first band color for it's value
            if (color.ContainsKey(bandAColor))
            {
                bandA = color[bandAColor] * 10;
            }else
            {
                return -1;
            }

            //Checking second band color for it's value
            if (color.ContainsKey(bandBColor))
            {
                bandB = color[bandBColor];
            }else
            {
                return -1;
            }

            //Checking third band for multiplyer value
            if (multiplier.ContainsKey(bandCColor))
            {
                bandC = multiplier[bandCColor];
            } else
            {
                return -1;
            }

            //storing the tolerance value
            if (tolerance.ContainsKey(bandDColor))
            {
                tolerancePercent = tolerance[bandDColor];
            }else
            {
                return -1;
            }

            return ((bandA + bandB) * bandC);
        }

        //This method will return the tolerance value
        public int getTolerance()
        {
            return tolerancePercent;
        }
    }
}
