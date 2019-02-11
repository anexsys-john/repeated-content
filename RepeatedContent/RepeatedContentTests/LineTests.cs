using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatedContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedContent.Tests
{
    [TestClass()]
    public class LineTests
    {
        [TestMethod()]
        public void LineTest()
        {
            int count = 4;
            string content = "This is test content";

            RepeatedLine line = new RepeatedLine(count, content);

            Assert.IsNotNull(line);
        }
    }
}