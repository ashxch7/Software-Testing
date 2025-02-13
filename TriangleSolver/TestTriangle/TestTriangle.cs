using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TestTriangle
{
    [TestFixture]
    public class TestTriangle
    {
        [Test]
        public void AnalyzeTriangle_AllSidesEqual_ReturnsEquilateral()
        {
            int sideA = 7;
            int sideB = 7;
            int sideC = 7;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }
        [Test]
        public void Analyzetriangle_TwoSidesEqual1_ReturnsIsosceles()
        {
            int sideA = 9;
            int sideB = 9;
            int sideC = 5;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void Analyzetriangle_TwoSidesEqual2_ReturnsIsosceles()
        {
            int sideA = 4;
            int sideB = 4;
            int sideC = 6;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }
        [Test]
        public void Analyzetriangle_TwoSidesEqual3_ReturnsIsosceles()
        {
            int sideA = 9;
            int sideB = 9;
            int sideC = 5;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }
        [Test]
        public void Analyzetriangle_AllSidesDifferent1_ReturnsScalene()
        {
            int sideA = 9;
            int sideB = 7;
            int sideC = 5;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }
        [Test]
        public void Analyzetriangle_AllSidesDifferent2_ReturnsScalene()
        {
            int sideA = 6;
            int sideB = 4;
            int sideC = 8;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }
        [Test]
        public void Analyzetriangle_AllSidesDifferent3_ReturnsScalene()
        {
            int sideA = 8;
            int sideB = 6;
            int sideC = 5;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }
        [Test]
        public void Analyzetriangle_AllSidesDifferent4_ReturnsScalene()
        {
            int sideA = 8;
            int sideB = 7;
            int sideC = 5;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }
        [Test]
        public void Analyzetriangle_AllSidesDifferent5_ReturnsScalene()
        {
            int sideA = 8;
            int sideB = 3;
            int sideC = 9;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }
        [Test]
        public void Analyzetriangle_ZeroSide1_ReturnsError()
        {
            int sideA = 0;
            int sideB = 3;
            int sideC = 9;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }
        [Test]
        public void Analyzetriangle_ZeroSide2_ReturnsError()
        {
            int sideA = 2;
            int sideB = 0;
            int sideC = 8;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }
        [Test]
        public void Analyzetriangle_ZeroSide3_ReturnsError()
        {
            int sideA = 5;
            int sideB = 6;
            int sideC = 0;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }
        [Test]
        public void Analyzetriangle_InvalidTriangle1_ReturnsInvalid()
        {
            int sideA = 1;
            int sideB = 2;
            int sideC = 3;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }
        [Test]
        public void Analyzetriangle_InvalidTriangle2_ReturnsInvalid()
        {
            int sideA = 2;
            int sideB = 3;
            int sideC = 1;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }
        [Test]
        public void Analyzetriangle_InvalidTriangle3_ReturnsInvalid()
        {
            int sideA = 3;
            int sideB = 2;
            int sideC = 1;
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }
    }
}
