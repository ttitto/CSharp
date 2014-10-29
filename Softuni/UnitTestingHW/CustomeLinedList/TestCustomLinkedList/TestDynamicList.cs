using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLinkedList;

namespace TestCustomLinkedList
{
    [TestClass]
    public class TestDynamicList
    {
        private DynamicList<string> myList;

        [TestInitialize]
        public void MethodInitialize()
        {
            myList = new DynamicList<string>();
            myList.Add("firstString");
            myList.Add("secondString");
            myList.Add("thirdString");
            myList.Add("fourthString");
            myList.Add("fifthString");
        }

        [TestMethod]
        public void AddMethodShouldIncreaseTheElemetsCount()
        {
            Assert.AreEqual(5, myList.Count);
        }

        [TestMethod]
        public void AddMethodShouldAddNullWhenArgumentIsNull()
        {
            myList.Add(null);
            Assert.AreEqual(null, myList[5]);
        }

        [TestMethod]
        public void AddMethodShouldAddItemOnLastPosition()
        {
            myList.Add("newItem");
            Assert.AreEqual("newItem", myList[5]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexerShouldReturnExceptionWhenInvalidIndexRequested()
        {
            Console.WriteLine(myList[6]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexerShouldReturnExceptionWhenNegativeIndexRequested()
        {
            Console.WriteLine(myList[-1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexerShouldReturnExceptionWhenSettingElementOnInvalidPosition()
        {
            myList[6] = "insertedElement";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexerShouldReturnExceptionWhenSettingElementOnNegativePosition()
        {
            myList[-1] = "insertedElement";
        }

        [TestMethod]
        public void IndexerShouldAllowInsertingElementOnGivenPosition()
        {
            myList[2] = "insertedElement";
            Assert.AreSame("insertedElement", myList[2]);
            Assert.AreSame("secondString", myList[1]);
            Assert.AreSame("fourthString", myList[3]);
        }

        [TestMethod]
        public void IndexerShouldReturnTheRightElementOnGivenPosition()
        {
            Assert.AreSame("thirdString", myList[2]);
        }

        [TestMethod]
        public void RemoveAtShouldRemoveElementAtGivenPosition()
        {
            myList.RemoveAt(3);
            Assert.AreSame("fifthString", myList[3]);
        }

        [TestMethod]
        public void RemoveAtShouldRemoveElementAtGivenPositionWhenFirst()
        {
            myList.RemoveAt(0);
            Assert.AreSame("secondString", myList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtShouldRemoveElementAtGivenPositionWhenLast()
        {
            myList.RemoveAt(4);
            Console.WriteLine(myList[4]);
        }

        [TestMethod]
        public void RemoveAtShouldReturnTheElementOnTheGivenPosition()
        {
            var element = myList.RemoveAt(3);
            Assert.AreSame("fourthString", element);
        }

        [TestMethod]
        public void RemoveAtShouldDecreaseCount()
        {
            myList.RemoveAt(2);
            Assert.AreEqual(4, myList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtShouldThrowExceptionWhenRemovingFromNegativePosition()
        {
            myList.RemoveAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtShouldThrowExceptionWhenRemovingFromInvalidPosition()
        {
            myList.RemoveAt(6);
        }

        [TestMethod]
        public void RemoveShouldReturnTheIndexOfRemovedElement()
        {
            int index = myList.Remove("fourthString");
            Assert.AreEqual(3, index);
        }

        [TestMethod]
        public void RemoveShouldReturnMinus1WhenRemovingNonExistingElement()
        {
            var index = myList.Remove("fString");
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void RemoveShouldReorderTheElementsAfterRemoving()
        {
            myList.Remove("fourthString");
            Assert.AreSame("fifthString", myList[3]);
        }

        [TestMethod]
        public void RemoveShouldDecreaseCount()
        {
            myList.Remove("fourthString");
            Assert.AreEqual(4, myList.Count);
        }

        [TestMethod]
        public void IndexOfShouldReturnMinusOneWhenSearchingNonExistingItem()
        {
            var index = myList.IndexOf("fString");
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void IndexOfShouldReturnTheIndexOfSearchedItemWhenFirst()
        {
            var index = myList.IndexOf("firstString");
            Assert.AreEqual(0, index);
        }

        [TestMethod]
        public void IndexOfShouldReturnTheIndexOfSearchedItemWhenLast()
        {
            var index = myList.IndexOf("fifthString");
            Assert.AreEqual(4, index);
        }

        [TestMethod]
        public void IndexOfShouldReturnTheIndexOfSearchedItem()
        {
            var index = myList.IndexOf("secondString");
            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void ContainsShouldReturnTrueWhenItemExists()
        {
            var condition = myList.Contains("fourthString");
            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void ContainsShouldReturnFalseWhenItemNotExists()
        {
            var condition = myList.Contains("fouString");
            Assert.IsFalse(condition);
        }
    }
}
