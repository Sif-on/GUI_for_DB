using NUnit.Framework;
using GUI_for_DB;
using System;


namespace GUI_for_DB
{
    [TestFixture]
    public class Tests
    {
        /*private MainWindow MainWin;*/
        [SetUp]
        public void Setup()
        {
            /*MainWin = new MainWindow();*/
        }

        [Test]
        public void Test1()
        {

            
        }


        // Проверка конфига с паролями для подключения к БД.
        [TestCase("./GUI_for_DB/MigratedPharmacyDatabase/", "App.Config", true)]
        public void VectorAdd(string path, string name_file, bool expected)
        {
            bool result = System.IO.File.Exists($"{path}{name_file}");
            if (expected != result)
                Assert.Fail(message: $"Каталог по пути {path} не содержит файл {name_file}.");
        }
    }
}