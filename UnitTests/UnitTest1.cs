using NUnit.Framework;

namespace GUI_for_DB
{
    [TestFixture]
    public class Tests
    {
        private MainWindow MainWin;
        [SetUp]
        public void Setup()
        {
            MainWin = new MainWindow();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}