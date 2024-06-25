using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

using System;
using Лаб2;
using System.Collections.Generic;

namespace Тесты
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateQuater_1test()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", true },
                { "II", true },
                { "III", false },
                { "IV", true }
            };

            Circle circle = new Circle(new Point(195, 105), 50);

            Dictionary<string, bool> quadrants_ac;
            quadrants_ac = circle.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");
        }

        [TestMethod]
        public void CalculateQuater_2test()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", true },
                { "II", false },
                { "III", false },
                { "IV", false }
            };

            Circle circle = new Circle(new Point(195, 105), 40);

            Dictionary<string, bool> quadrants_ac;
            quadrants_ac = circle.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");
        }

        [TestMethod]
        public void CalculateQuater_3test()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", true },
                { "II", true },
                { "III", false },
                { "IV", false }
            };

            Circle circle = new Circle(new Point(155, 105), 20);

            Dictionary<string, bool> quadrants_ac;
            quadrants_ac = circle.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");
        }

        [TestMethod]
        public void CalculateQuater_4test()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", true },
                { "II", true },
                { "III", false },
                { "IV", false }
            };

            Circle circle = new Circle(new Point(195, 50), 90);

            Dictionary<string, bool> quadrants_ac;
            quadrants_ac = circle.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");
        }
    }
}
