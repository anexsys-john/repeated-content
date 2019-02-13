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
            FileHandler handler = new FileHandler(Directory.GetCurrentDirectory(), new ErrorReporter());
            //List<string> expected = new List<string>
            //{

            //}

            //act
            string current = Directory.GetCurrentDirectory();
            handler.GetAllFiles("./getAllDirectories");
            List<string> actual = handler.Files;

            //assert
            Assert.Fail();
        }
    }
}