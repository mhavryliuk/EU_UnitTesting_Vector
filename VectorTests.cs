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

        // Начальная инициализация для каждого отдельного теста.
        [TestInitialize]
        public void TestInitialize()
        {
            vector1 = new Vector(2, 4, 6);
            vector2 = new Vector(1, 3, 5);            
        }

        // Проверка перегрузки бинарного оператора +
        [TestMethod]
        public void AddVector()
        {
            // Arrange
            Vector expected = new Vector(3, 7, 11);

            // Act
            Vector actual = vector1 + vector2;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());   // Проверка значений на равенство
        }

        // Проверка перегрузки бинарного оператора -
        [TestMethod]
        public void SubVector()
        {
            // Arrange
            Vector expected = new Vector(1, 1, 1);

            // Act
            Vector actual = vector1 - vector2;

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString());   // Проверка значений на равенство
        }

        // Проверка, что векторы являются не null
        [TestMethod]
        public void IsNotNull()
        {
            Assert.IsNotNull(vector1);
            Assert.IsNotNull(vector2);
        }

        // Проверяем тип входных данных
        [TestMethod]
        public void TypeIsDouble()
        {
            Assert.IsInstanceOfType(vector1.X, typeof(double));
            Assert.IsInstanceOfType(vector1.Y, typeof(double));
            Assert.IsInstanceOfType(vector1.Z, typeof(double));
        }
        
        // Проверка на "условное" переполнение (исключение если значения всех координат < 0)
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PointValueIsLessThanZero()
        {
            Vector vector3 = new Vector(-14, -105, -2);
        }
    }
}