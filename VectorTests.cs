using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/**<remark>
 * Practice on unit testing.
 * Modular testing of the previously created Vector application.
 * Class Assert: https://msdn.microsoft.com/ru-ru/library/microsoft.visualstudio.testtools.unittesting.assert.aspx
</remark> */

namespace _20180405_UnitTesting.Tests
{
    [TestClass]
    public class VectorTests
    {
        private Vector vector1;
        private Vector vector2;

        /// <summary>
        /// Initial initialization for each separate test.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            vector1 = new Vector(2, 4, 6);
            vector2 = new Vector(1, 3, 5);            
        }

        /// <summary>
        /// Checking the overload of the binary operator +
        /// </summary>
        [TestMethod]
        public void AddVector()
        {
            // Arrange
            Vector expected = new Vector(3, 7, 11);

            // Act
            Vector actual = vector1 + vector2;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());   // Checking values for equality
        }

        // Checking the overload of the binary operator -
        [TestMethod]
        public void SubVector()
        {
            // Arrange
            Vector expected = new Vector(1, 1, 1);

            // Act
            Vector actual = vector1 - vector2;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());   // Checking values for equality
        }

        /// <summary>
        /// Verifying that the vectors are not null
        /// </summary>
        [TestMethod]
        public void IsNotNull()
        {
            Assert.IsNotNull(vector1);
            Assert.IsNotNull(vector2);
        }

        /// <summary>
        /// Checking input data types
        /// </summary>
        [TestMethod]
        public void TypeIsDouble()
        {
            Assert.IsInstanceOfType(vector1.X, typeof(double));
            Assert.IsInstanceOfType(vector1.Y, typeof(double));
            Assert.IsInstanceOfType(vector1.Z, typeof(double));
        }

        // Checking for a "conditional" overflow (except if the values of all coordinates are < 0)
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PointValueIsLessThanZero()
        {
            Vector vector3 = new Vector(-14, -105, -2);
        }
    }
}