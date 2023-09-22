

using ForeachAndDvimaciaiArrays;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] input = { 2, 3, 4, 3 };
            double expected = 3;

            double actual = Program.calculateAverage(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double[] input = { -2, -3, -4, -3 };
            double expected = -3;

            double actual = Program.calculateAverage(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] input = { 2, -7, 4, -3, 5 };
            int[] expected = { 2, 4, 5, 0, 0 };

            int[] actual = Program.returnPositiveNumber(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] input = { 2, 3, 4, 5, 6 };
            int[] expected = { 2, 3, 4, 5, 6 };

            int[] actual = Program.returnPositiveNumber(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] input = { 200, 500, 1000, 400, 300 };
            int expected = 360;

            int actual = Program.calculateGPM(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] input = { 200, 500, -1000, -400, 300 };
            int expected = -60;

            int actual = Program.calculateGPM(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            string input = "Mes visi kartu eisim ir rinksim grybus";
            string[] expected = { "kartu", "eisim", "rinksim", "grybus", null, null, null };

            string[] actual = Program.GetLongerWord(input);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            string input = "pirmas testas vos nenuzude manes";
            string[] expected = { "pirmas", "testas", "nenuzude", "manes", null };

            string[] actual = Program.GetLongerWord(input);

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}