using ResistorCalculator.OhmCalculator;
using System;
using Xunit;

namespace OhmValueCalculatorTest
{
    public class OhmValueCalculatorTests
    {
        [Fact]

        //Testing calculation for the first band color value
        public void TestFirstBand()
        {
            OhmValueCalculator ohm = new OhmValueCalculator();

            int value = ohm.CalculateOhmValue("None", "Black", "Black", "Brown");
            Assert.Equal(0, value);

            value = ohm.CalculateOhmValue("Black", "Black", "Black", "Brown");
            Assert.Equal(0, value);

            value = ohm.CalculateOhmValue("Brown", "Black", "Black", "Brown");
            Assert.Equal(10,value);

            value = ohm.CalculateOhmValue("Red", "Black", "Black", "Brown");
            Assert.Equal(20, value);

            value = ohm.CalculateOhmValue("Orange", "Black", "Black", "Brown");
            Assert.Equal(30, value);

            value = ohm.CalculateOhmValue("Yellow", "Black", "Black", "Brown");
            Assert.Equal(40, value);

            value = ohm.CalculateOhmValue("Green", "Black", "Black", "Brown");
            Assert.Equal(50, value);

            value = ohm.CalculateOhmValue("Blue", "Black", "Black", "Brown");
            Assert.Equal(60, value);

            value = ohm.CalculateOhmValue("Violet", "Black", "Black", "Brown");
            Assert.Equal(70, value);

            value = ohm.CalculateOhmValue("Gray", "Black", "Black", "Brown");
            Assert.Equal(80, value);

            value = ohm.CalculateOhmValue("White", "Black", "Black", "Brown");
            Assert.Equal(90, value);
        }

        //Testing calculation for the second band color value
        public void TestSecondBand()
        {
            OhmValueCalculator ohm = new OhmValueCalculator();

            int value = ohm.CalculateOhmValue("Brown", "None", "Black", "Brown");
            Assert.Equal(10, value);

            value = ohm.CalculateOhmValue("Brown", "Black", "Black", "Brown");
            Assert.Equal(10, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Black", "Brown");
            Assert.Equal(11, value);

            value = ohm.CalculateOhmValue("Brown", "Red", "Black", "Brown");
            Assert.Equal(12, value);

            value = ohm.CalculateOhmValue("Brown", "Orange", "Black", "Brown");
            Assert.Equal(13, value);

            value = ohm.CalculateOhmValue("Brown", "Yellow", "Black", "Brown");
            Assert.Equal(14, value);

            value = ohm.CalculateOhmValue("Brown", "Green", "Black", "Brown");
            Assert.Equal(15, value);

            value = ohm.CalculateOhmValue("Brown", "Blue", "Black", "Brown");
            Assert.Equal(16, value);

            value = ohm.CalculateOhmValue("Brown", "Violet", "Black", "Brown");
            Assert.Equal(17, value);

            value = ohm.CalculateOhmValue("Brown", "Gray", "Black", "Brown");
            Assert.Equal(18, value);

            value = ohm.CalculateOhmValue("Brown", "White", "Black", "Brown");
            Assert.Equal(19, value);
        }


        //Testing calculation for the third band color value
        public void TestThirdBand()
        {
            OhmValueCalculator ohm = new OhmValueCalculator();

            int value = ohm.CalculateOhmValue("Brown", "Brown", "None", "Brown");
            Assert.Equal(0, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Black", "Brown");
            Assert.Equal(11, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Brown", "Brown");
            Assert.Equal(110, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Red", "Brown");
            Assert.Equal(1100, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Orange", "Brown");
            Assert.Equal(11000, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Yellow", "Brown");
            Assert.Equal(110000, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Green", "Brown");
            Assert.Equal(1100000, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Blue", "Brown");
            Assert.Equal(11000000, value);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Violet", "Brown");
            Assert.Equal(110000000, value);



        }


        //Testing calculation for the fourth band color value
        public void TestFourthBand()
        {
            OhmValueCalculator ohm = new OhmValueCalculator();

            int value = ohm.CalculateOhmValue("Brown", "Brown", "Brown", "Brown");
            int tolerance = ohm.getTolerance();

            Assert.Equal(1, tolerance);


            value = ohm.CalculateOhmValue("Brown", "Brown", "Brown", "Red");
            tolerance = ohm.getTolerance();

            Assert.Equal(2, tolerance);


            value = ohm.CalculateOhmValue("Brown", "Brown", "Brown", "Gold");
            tolerance = ohm.getTolerance();

            Assert.Equal(5, tolerance);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Brown", "Silver");
            tolerance = ohm.getTolerance();

            Assert.Equal(10, tolerance);

            value = ohm.CalculateOhmValue("Brown", "Brown", "Brown", "None");
            tolerance = ohm.getTolerance();

            Assert.Equal(20, tolerance);


        }
    }
}
