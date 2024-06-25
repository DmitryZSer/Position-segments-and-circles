using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using Лаб2;
namespace Тесты
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void Line_test1()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", false },
                { "II", true },
                { "III", true },
                { "IV", true }
            };

            Line line = new Line(new Point(105, 100), new Point(180, 250));

            Dictionary<string, bool> quadrants_ac = line.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");
        }

        [TestMethod]
        public void Line_test2()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", true },
                { "II", false },
                { "III", false },
                { "IV", true }
            };

            Line line = new Line(new Point(195, 100), new Point(180, 200));

            Dictionary<string, bool> quadrants_ac = line.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");
        }

        [TestMethod]
        public void Line_test3()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", true },
                { "II", false },
                { "III", false },
                { "IV", false }
            };

            Line line = new Line(new Point(155, 100), new Point(180, 50));

            Dictionary<string, bool> quadrants_ac = line.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");
        }

        [TestMethod]
        public void Line_test4()
        {
            Dictionary<string, bool> quadrants_ex = new Dictionary<string, bool>
            {
                { "I", true },
                { "II", true },
                { "III", false },
                { "IV", false }
            };

            Line line = new Line(new Point(70, 100), new Point(180, 140));

            Dictionary<string, bool> quadrants_ac = line.CalculateQuater();

            CollectionAssert.AreEqual(quadrants_ex, quadrants_ac, "Пройдено");

        }
    }
}
