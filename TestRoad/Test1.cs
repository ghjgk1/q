using RoadLibrary;

namespace RoadWorksTests
{
    [TestClass]
    public class RoadWorkTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Очищаем статический список перед каждым тестом
            RoadWorks.Works.Clear();
        }

        [TestMethod]
        public void RoadWork_CalculateQ_ShouldCalculateCorrectly()
        {
            // Arrange
            var work = new RoadWorks(10, 20, 50);

            // Act
            double result = work.CalculateQ();

            // Assert
            Assert.AreEqual(10.00, result, 0.01); // 10 * 20 * 50 / 1000 = 10.00
        }

        [TestMethod]
        public void RoadWork_GetInfo_ShouldReturnCorrectString()
        {
            // Arrange
            var work = new RoadWorks(10.5, 20.3, 45.7);

            // Act
            string result = work.GetInfo();

            // Assert
            StringAssert.Contains(result, "Дорожные работы: Ширина=10,5м");
            StringAssert.Contains(result, "Длина=20,3м");
            StringAssert.Contains(result, "Масса/кв.м=45,7кг");
            StringAssert.Contains(result, $"Q={work.CalculateQ():F2}");
        }

        [TestMethod]
        public void RoadWork_StaticList_ShouldAddAndRemoveItems()
        {
            // Arrange
            var work1 = new RoadWorks(1, 2, 3);
            var work2 = new RoadWorks(4, 5, 6);
            var work3 = new RoadWorks(7, 8, 9);

            // Act - добавление
            RoadWorks.Works.Add(work1);
            RoadWorks.Works.Add(work2);
            RoadWorks.Works.Add(work3);

            // Assert
            Assert.AreEqual(3, RoadWorks.Works.Count);

            // Act - удаление
            RoadWorks.RemoveWorks(new List<RoadWorks> { work1, work3 });

            // Assert
            Assert.AreEqual(1, RoadWorks.Works.Count);
            Assert.AreEqual(work2, RoadWorks.Works[0]);
        }
    }

    [TestClass]
    public class ExtendedRoadWorkTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Очищаем статический список перед каждым тестом
            RoadWorks.Works.Clear();
        }

        [TestMethod]
        public void ExtendedRoadWork_CalculateQ_ShouldMultiplyBy1_1_WhenMonth5to8()
        {
            // Arrange
            var work = new ExtendedRoadWork(10, 20, 50, 6); // Месяц 6 (5-8)
            double baseQ = 10 * 20 * 50 / 1000; // 10.00

            // Act
            double result = work.CalculateQ();

            // Assert
            Assert.AreEqual(baseQ * 1.1, result, 0.01); // 11.00
        }

        [TestMethod]
        public void ExtendedRoadWork_CalculateQ_ShouldMultiplyBy1_6_WhenMonth3_4_9_10()
        {
            // Arrange
            var work1 = new ExtendedRoadWork(10, 20, 50, 3); // Месяц 3
            var work2 = new ExtendedRoadWork(10, 20, 50, 9); // Месяц 9
            double baseQ = 10 * 20 * 50 / 1000; // 10.00

            // Act & Assert
            Assert.AreEqual(baseQ * 1.6, work1.CalculateQ(), 0.01); // 16.00
            Assert.AreEqual(baseQ * 1.6, work2.CalculateQ(), 0.01); // 16.00
        }

        [TestMethod]
        public void ExtendedRoadWork_CalculateQ_ShouldMultiplyBy2_1_AndAddPx10_ForOtherMonths()
        {
            // Arrange
            var work1 = new ExtendedRoadWork(10, 20, 50, 1); // Месяц 1
            var work2 = new ExtendedRoadWork(10, 20, 50, 11); // Месяц 11
            var work3 = new ExtendedRoadWork(10, 20, 50, 12); // Месяц 12
            double baseQ = 10 * 20 * 50 / 1000; // 10.00

            // Act & Assert
            Assert.AreEqual(baseQ * 2.1 + 1 * 10, work1.CalculateQ(), 0.01); // 31.00
            Assert.AreEqual(baseQ * 2.1 + 11 * 10, work2.CalculateQ(), 0.01); // 131.00
            Assert.AreEqual(baseQ * 2.1 + 12 * 10, work3.CalculateQ(), 0.01); // 141.00
        }

        [TestMethod]
        public void ExtendedRoadWork_GetInfo_ShouldReturnCorrectStringWithMonth()
        {
            // Arrange
            var work = new ExtendedRoadWork(10.5, 20.3, 45.7, 5);

            // Act
            string result = work.GetInfo();

            // Assert
            StringAssert.Contains(result, "Дорожные работы (расширенные): Ширина=10,5м");
            StringAssert.Contains(result, "Длина=20,3м");
            StringAssert.Contains(result, "Масса/кв.м=45,7кг");
            StringAssert.Contains(result, "Месяц=5");
            StringAssert.Contains(result, $"Qp={work.CalculateQ():F2}");
        }

        [TestMethod]
        public void ExtendedRoadWork_Inheritance_ShouldWorkWithBaseClassList()
        {
            // Arrange
            var baseWork = new RoadWorks(1, 2, 3);
            var extendedWork = new ExtendedRoadWork(4, 5, 6, 7);

            // Act
            RoadWorks.Works.Add(baseWork);
            RoadWorks.Works.Add(extendedWork);

            // Assert
            Assert.AreEqual(2, RoadWorks.Works.Count);
            Assert.IsInstanceOfType(RoadWorks.Works[0], typeof(RoadWorks));
            Assert.IsInstanceOfType(RoadWorks.Works[1], typeof(ExtendedRoadWork));
        }
    }
}
