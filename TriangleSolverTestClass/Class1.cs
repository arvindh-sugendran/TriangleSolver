using NUnit.Framework;
using NUnit.Framework.Legacy;
using TriangleSolver;

namespace TriangleSolverTestClass
{
    public class TriangleSolverTestClass
    {
        [TestFixture]
        public class TriangleSolverTestClassForEquilateralTriangle
        {
            [Test]
            public void AnalyzeTriangle_WithInput6and6and6_OutputValidEquilateralTriangle()
            {
                // Arrange
                int firstSide = 6;
                int secondSide = 6;
                int thirdSide = 6;

                string expected = "A triangle is formed and it is an EQUILATERAL";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

        }

        public class TriangleSolverTestClassForIscoscelesTriangle
        {
            [Test]
            public void AnalyzeTriangle_WithInput6and6and10_OutputValidIsoscelesTriangle()
            {
                // Arrange
                int firstSide = 6;
                int secondSide = 6;
                int thirdSide = 10;

                string expected = "A triangle is formed and it is an ISOSCELES";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }


            [Test]
            public void AnalyzeTriangle_WithInput7and8and8_OutputValidIsoscelesTriangle()
            {
                // Arrange
                int firstSide = 7;
                int secondSide = 8;
                int thirdSide = 8;

                string expected = "A triangle is formed and it is an ISOSCELES";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput9and5and9_OutputValidIsoscelesTriangle()
            {
                // Arrange
                int firstSide = 9;
                int secondSide = 5;
                int thirdSide = 9;

                string expected = "A triangle is formed and it is an ISOSCELES";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }
    }
}
