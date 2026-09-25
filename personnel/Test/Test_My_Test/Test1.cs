using Test
  

namespace Test_My_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestLaSommeDixEtDixEgalVingt()
        {
            //Arrange
            int x = 10;
            int y = 10;
            int z = -15;

            //Act
            int res = MyMath.Somme(x, y);
            int res2 = MyMath.Somme(x, z);

            //Assert
            Assert.AreEqual(20, res);
            Assert.AreEqual(-5, res2);
        }
    }
}
