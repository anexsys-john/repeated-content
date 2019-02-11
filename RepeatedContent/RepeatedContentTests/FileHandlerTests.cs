using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatedContent;
using System;
using System.IO;
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
        public void FileHandlerTest()
        {
            // arrange
            Directory.CreateDirectory("testDirectory");
            Directory.SetCurrentDirectory("testDirectory");
            for (int i = 0; i < 2; i++)
            {
                File.Create($"{i.ToString()}.txt");
            }
            Directory.CreateDirectory("level1TestDirectory");
            Directory.CreateDirectory("level1TestDirectory2");

            Directory.SetCurrentDirectory("level1TestDirectory");
            for (int i = 0; i < 2; i++)
            {
                File.Create($"{i.ToString()}.txt");
            }

            Directory.SetCurrentDirectory("../level1TestDirectory2");
            for (int i = 0; i < 2; i++)
            {
                File.Create($"{i.ToString()}.txt");
            }

            Directory.SetCurrentDirectory("../");

            List<string> expected = new List<string>();
            for (int i = 0; i < 2; i++)
            {
                expected.Add($"{Directory.GetCurrentDirectory()}\\{i.ToString()}.txt");
                expected.Add($"{Directory.GetCurrentDirectory()}\\level1TestDirectory\\{i.ToString()}.txt");
                expected.Add($"{Directory.GetCurrentDirectory()}\\level1TestDirectory2\\{i.ToString()}.txt");
            }
            expected.Sort();

            // act
            FileHandler handler = new FileHandler(Directory.GetCurrentDirectory());
            List<string> actual = handler.Files;
            actual.Sort();
            bool equal = true;

            // assert
            for (int i = 0; i < actual.Count; i++)
            {
                if (!actual[i].Equals(expected[i]))
                {
                    equal = false;
                    break;
                }
            }
            Assert.IsTrue(equal);
        }
    }
}