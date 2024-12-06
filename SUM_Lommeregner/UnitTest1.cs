
namespace SUM_Lommeregner
{
    public class Tests
    {
        private Lommeregner lommeregner;

        [SetUp]
        public void Setup()
        {
            lommeregner = new Lommeregner();
        }

        [Test]
        public void PlusMethod_AddsTwoNumbers_CorrectSum()
        {
            // Arrange
            int tal1 = 5;
            int tal2 = 7;

            // Act
            int result = lommeregner.Plus(tal1, tal2);

            // Assert
            Assert.AreEqual(12, result); 
        }
    }
}
