using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sqa_assignment_2;
using NUnit.Framework;

namespace TestTriangle
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test_GetSide1()
        {
            int l = 4;
            int w = 5;
            int b = 5;
            triangle.Analyze(l,b,w);
            int side1 = triangle.Getside1();
            Assert.AreEqual(l, side1);
        }
        [Test]
        public void Test_GetSide2()
        {
            int l = 4;
            int w = 5;
            int b = 5;
            triangle.Analyze(l, b, w);
            int side2 = triangle.Getside2();
            Assert.AreEqual(w, side2);
        }
        [Test]
        public void Test_GetSide3()
        {
            int l = 4;
            int w = 5;
            int b = 5;
            triangle.Analyze(l, b, w);
            int side3 = triangle.Getside3();
            Assert.AreEqual(b, side3);
        }
        [Test]
        public void ISEquilateral()
        {
            int l = 5;
            int w = 5;
            int b = 5;
            int type = triangle.Analyze(l,w,b);
            Assert.AreEqual(3, type);
        }
        [Test]
        public void ISIsosceles()
        {
            int l = 4;
            int w = 5;
            int b = 5;
            int type = triangle.Analyze(l, w, b);
            Assert.AreEqual(2, type);
        }
        [Test]
        public void IsScalene()
        {
            int l = 4;
            int w = 5;
            int b = 6;
            int type = triangle.Analyze(l, w, b);
            Assert.AreEqual(1, type);
        }
        [Test]
        public void NotCorrectInput()
        {
            int l = -4;
            int w = 5;
            int b = 6;
            int type = triangle.Analyze(l, w, b);
            Assert.AreEqual(4, type);
        }
        [Test]
        public void Test_GetSide1_Invalid()
        {
            int l = 4;
            int w = 5;
            int b = 5;
            triangle.Analyze(l, b, w);
            int side1 = triangle.Getside1();
            Assert.AreNotEqual(w, side1);
        }
        [Test]
        public void Test_GetSide2_Invalid()
        {
            int l = 4;
            int w = 5;
            int b = 5;
            triangle.Analyze(l, b, w);
            int side2 = triangle.Getside2();
            Assert.AreNotEqual(l, side2);
        }
        [Test]
        public void Test_GetSide3_Invalid()
        {
            int l = 4;
            int w = 5;
            int b = 5;
            triangle.Analyze(l, b, w);
            int side3 = triangle.Getside3();
            Assert.AreNotEqual(l, side3);
        }
    }
}
