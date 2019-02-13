using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
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
    public class ExtensionTests
    {
        [TestMethod()]
        public void SortByTest()
        {
            // arrange
            ListBox box = new ListBox();
            List<string> items = new List<string> { "qwer", "asdf", "zxcv" };
            box.DataSource = items;

            // act
            box.SortBy<string>(word => word);
            List<string> actual = (List<string>)box.DataSource;
            List<string> expected = new List<string> { "asdf", "qwer", "zxcv" };

            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void SortByDescendingTest()
        {
            // arrange
            ListBox box = new ListBox();
            List<string> items = new List<string> { "qwer", "asdf", "zxcv" };
            box.DataSource = items;

            // act
            box.SortByDescending<string>(word => word);
            List<string> actual = (List<string>)box.DataSource;
            List<string> expected = new List<string> { "zxcv", "qwer", "asdf" };

            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ThenSortByTest()
        {
            // arrange
            ListBox box = new ListBox();
            Item item1 = new Item("trial", 4);
            Item item2 = new Item("hello", 4);
            Item item3 = new Item("shark", 4);
            Item item4 = new Item("hello", 5);
            box.DataSource = new List<Item> { item1, item2, item3, item4 };

            // act
            box.SortBy<Item>(item => item._content).ThenSortBy(line => line._count, box);
            List<Item> actual = (List<Item>)box.DataSource;
            List<Item> expected = new List<Item> { item2, item4, item3, item1 };

            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TestMethod()]
        public void ThenSortByDescendingTest()
        {
            // arrange
            ListBox box = new ListBox();
            Item item1 = new Item("trial", 4);
            Item item2 = new Item("hello", 4);
            Item item3 = new Item("shark", 4);
            Item item4 = new Item("hello", 5);
            box.DataSource = new List<Item> { item1, item2, item3, item4 };

            // act
            box.SortBy<Item>(item => item._content).ThenSortByDescending(line => line._count, box);
            List<Item> actual = (List<Item>)box.DataSource;
            List<Item> expected = new List<Item> { item4, item2, item3, item1 };

            //assert
            Assert.IsTrue(actual.SequenceEqual(expected));
        }
    }

    public struct Item
    {
        public string _content;
        public int _count;

        public Item(string content, int count)
        {
            _content = content;
            _count = count;
        }
    }
}