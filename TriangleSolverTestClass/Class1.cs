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
    }
}
