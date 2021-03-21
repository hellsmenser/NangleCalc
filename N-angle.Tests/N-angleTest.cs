using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N_angle.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleSquare_5_78returned()
        {
            //настройка
            int r = 5;
            double expected = Math.Round(78.53981633974483, 4);

            //выполнение
            Nangle n = new Nangle();
            double actual = n.CircleSquare(r);
            actual = Math.Round(actual, 4);

            //проверка
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleSquere_2_5_5_3returned()
        {
            //настрокай
            int a = 2;
            int b = 4;
            int c = 5;
            double expected = Math.Round(3.799671038392666, 4);

            //выполенние
            Nangle n = new Nangle();
            double actual = n.TriangleSquere(a, b, c);
            actual = Math.Round(actual, 4);

            //проверка
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void isRectangular_2_2_2_falseTerurned()
        {
            //настрокай
            int a = 2;
            int b = 2;
            int c = 2;
            bool expected = false;

            //выполенние
            Nangle n = new Nangle();
            bool actual = n.isRectangular(a, b, c);

            //проверка
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void isRectangular_3_4_5_trueTerurned()
        {
            //настрокай
            int a = 3;
            int b = 4;
            int c = 5;
            bool expected = true;

            //выполенние
            Nangle n = new Nangle();
            bool actual = n.isRectangular(a, b, c);

            //проверка
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrueNAngle_3_5_15returned()
        {
            //настройка
            int a = 3;
            int n = 5;
            double expected = Math.Round(15.484296605300704, 4);

            //выполенние
            Nangle na = new Nangle();
            double actual = na.TrueNAngle(a, n);
            actual = Math.Round(actual, 4);

            //проверка
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrueNAngle_5_12_247returned()
        {
            //настройка
            int a = 5;
            int n = 12;
            double expected = Math.Round(279.9038105676, 4);

            //выполенние
            Nangle na = new Nangle();
            double actual = na.TrueNAngle(a, n);
            actual = Math.Round(actual, 4);

            //проверка
            Assert.AreEqual(expected, actual);
        }
    }
}
