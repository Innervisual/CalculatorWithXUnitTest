SistaMiniraknare

Hej, 
här kan man hitta XUnit testerna ifall de inte kommer med.

UnitTest1.cs


using SistaMiniraknare;
using System;
using Xunit;

namespace TestProject2

{
    public class UnitTest1
    {

        [Fact]
        public void testingAddition()
        {

            //Program.Addition(1, 1); Denna kan tas bort.

            Assert.Equal(2, Program.Addition(1, 1));
            //Assert.Equal(200, Program.Addition(100, 100));

        }

        [Fact]
        public void testingSubtraction()
        {
            Assert.Equal(0, Program.Subtraction(1, 1));

        }


        [Fact]
        public void testingMultiplication()
        {
            Assert.Equal(1, Program.Multiplication(1, 1));

        }


        [Fact]
        public void testingDivision()
        {
            Assert.Equal(1, Program.Division(1, 1));

        }



        [Fact]
        public void testingAdditionWithArray()
        {

            //Program.Addition(1, 1); Denna kan tas bort.

            double[] array1 = { 1.5, 5.0 };

            Assert.Equal(6.5, Program.Addition(array1));


        }

        [Fact]
        public void testingSubtractionWithArray()
        {


            double[] array1 = { 1.5, 5.0 };

            Assert.Equal(-3.5, Program.Subtraction(array1));


        }



        [Fact]

        public void tryingToDivideByZero()
        {

            double result = Program.Division(2, 0);
            Console.WriteLine(result);

            bool isnan = double.IsNaN(result);

            Assert.True(isnan);

        }


    }

}


-------------------------
