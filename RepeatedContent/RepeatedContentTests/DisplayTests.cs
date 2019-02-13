using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using RepeatedContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent.Tests
{
    [TestClass()]
    public class DisplayTests
    {
        [TestMethod()]
        public void AddLinesToListBoxTest()
        {
            //arrange
            ListBox box = new ListBox();
            Display display = new Display();
            RepeatedLine line1 = new RepeatedLine(3, "This is some content", new List<string> { "file1", "file2", "file3" });
            RepeatedLine line2 = new RepeatedLine(8, "This is some more content", new List<string> { "file2", "file3" });

            //act
            display.AddLinesToListBox(box, new List<RepeatedLine> { line1, line2 });
            List<RepeatedLine> actual = (List<RepeatedLine>)box.DataSource;
            List<RepeatedLine> expected = new List<RepeatedLine> { line2, line1 };

            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ClearOutputMessageTest()
        {
            //arrange
            Display display = new Display();
            TextBox box = new TextBox();
            box.AppendText("this is test text");

            //act
            display.ClearOutputMessage(box);
            string actual = box.Text;
            string expected = "";

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}