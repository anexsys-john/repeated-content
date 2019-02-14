using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatedContent;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent.Tests
{
    [TestClass()]
    public class FileHandlerTests
    {
        [TestMethod()]
        public void GetAllFilesTest()
        {
            //arrange
            Directory.SetCurrentDirectory("getAllDirectories");
            List<string> expectedFiles = new List<string>();
            List<string> names = new List<string>
            {
                "1",
                "2",
                "test1\\1",
                "test1\\2",
                "test2\\1",
                "test2\\2"
            };
            foreach (string file in names)
            {
                string newFile = $"{Directory.GetCurrentDirectory()}\\{file}.txt";
                expectedFiles.Add(newFile);
            }

            //act
            FileHandler handler = new FileHandler(Directory.GetCurrentDirectory(), new ErrorReporter());
            List<string> actual = handler.Files;

            //assert
            Assert.IsTrue(actual.SequenceEqual(expectedFiles));
        }
    }
}