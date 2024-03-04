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

        public class TriangleSolverTestClassForScaleneTriangle
        {
            [Test]
            public void AnalyzeTriangle_WithInput5and8and10_OutputValidScaleneTriangle()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 8;
                int thirdSide = 10;

                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput12and9and15_OutputValidScaleneTriangle()
            {
                // Arrange
                int firstSide = 12;
                int secondSide = 9;
                int thirdSide = 15;

                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput7and10and11_OutputValidScaleneTriangle()
            {
                // Arrange
                int firstSide = 7;
                int secondSide = 10;
                int thirdSide = 11;

                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput17and13and6_OutputValidScaleneTriangle()
            {
                // Arrange
                int firstSide = 17;
                int secondSide = 13;
                int thirdSide = 6;

                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput9and7and14_OutputValidScaleneTriangle()
            {
                // Arrange
                int firstSide = 9;
                int secondSide = 7;
                int thirdSide = 14;

                string expected = "A triangle is formed and it is a SCALENE";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }
        }

        public class TriangleSolverTestClassForInvalidTriangleWithZeroLength
        {
            [Test]
            public void AnalyzeTriangle_WithInput0and9and7_OutputInvalidTriangleWithZeroLength()
            {
                // Arrange
                int firstSide = 0;
                int secondSide = 9;
                int thirdSide = 7;

                string expected = "INVALID triangle - a zero was entered";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput5and0and8_OutputInvalidTriangleWithZeroLength()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 0;
                int thirdSide = 8;

                string expected = "INVALID triangle - a zero was entered";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput9and5and0_OutputInvalidTriangleWithZeroLength()
            {
                // Arrange
                int firstSide = 9;
                int secondSide = 5;
                int thirdSide = 0;

                string expected = "INVALID triangle - a zero was entered";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

        }

        public class TriangleSolverTestClassForNoTriangleFormedWithNonZeroLength
        {
            [Test]
            public void AnalyzeTriangle_WithInput4and3and7_OutputNoTriangleFormedWithNonZeroLength()
            {
                // Arrange
                int firstSide = 4;
                int secondSide = 3;
                int thirdSide = 7;

                string expected = "A triangle is not formed based on the input values";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput5and2and3_OutputNoTriangleFormedWithNonZeroLength()
            {
                // Arrange
                int firstSide = 5;
                int secondSide = 2;
                int thirdSide = 3;

                string expected = "A triangle is not formed based on the input values";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

            [Test]
            public void AnalyzeTriangle_WithInput4and5and9_OutputNoTriangleFormedWithNonZeroLength()
            {
                // Arrange
                int firstSide = 4;
                int secondSide = 5;
                int thirdSide = 9;

                string expected = "A triangle is not formed based on the input values";

                // Act
                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                // Assert
                ClassicAssert.AreEqual(expected, actual);
            }

        }


    }
}
