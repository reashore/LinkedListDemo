
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListdemo;

namespace LinkedListDemo.Tests
{
	[TestClass]
	public class LinkedListTests
	{
		[TestMethod]
		public void EmptyListHasCountOfZero()
		{
			// arrange
			LinkedList2<long> linkedListLong = new LinkedList2<long>();

			// act

			// assert
			Assert.AreEqual(0, linkedListLong.Count);
		}

		//-----------------------------------------------------

		[TestMethod]
		public void AddAndRemoveItemFromHeadOfList()
		{
			// arrange
			LinkedList2<long> linkedListLong = new LinkedList2<long>();

			// act
			const long value = 5;
			linkedListLong.AddToHead(value);
			long removedValue = linkedListLong.RemoveFromHead();

			// assert
			Assert.AreEqual(0, linkedListLong.Count);
			Assert.AreEqual(value, removedValue);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void RemovingFromHeadOfEmptyListThrowsInvalidOperationException()
		{
			// arrange
			LinkedList2<long> linkedListLong = new LinkedList2<long>();

			// act
			linkedListLong.RemoveFromHead();

			// assert
		}

		[TestMethod]
		public void AddNItemsToHeadOfListYieldsCountOfN()
		{
			// arrange
			LinkedList2<long> linkedListLong = new LinkedList2<long>();
			const int numberItemsToAdd = 5;

			// act
			for (int n = 1; n <= 5; n++)
			{
				linkedListLong.AddToHead(n);
			}

			// assert
			Assert.AreEqual(numberItemsToAdd, linkedListLong.Count);
		}

		//-----------------------------------------------------

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void RemovingFromTailOfEmptyListThrowsInvalidOperationException()
		{
			// arrange
			LinkedList2<long> linkedListLong = new LinkedList2<long>();

			// act
			linkedListLong.RemoveFromTail();

			// assert
		}

		[TestMethod]
		public void AddNItemsToTailYieldsCountOfN()
		{
			// arrange
			LinkedList2<long> linkedListLong = new LinkedList2<long>();
			const int numberItemsToAdd = 5;

			// act
			for (int n = 1; n <= 5; n++)
			{
				linkedListLong.AddToTail(n);
			}

			// assert
			Assert.AreEqual(numberItemsToAdd, linkedListLong.Count);
		}


		[TestMethod]
		public void AddAndRemoveItemFromTailOfList()
		{
			// arrange
			LinkedList2<long> linkedListLong = new LinkedList2<long>();

			// act
			const long value = 5;
			linkedListLong.AddToTail(value);
			long removedValue = linkedListLong.RemoveFromTail();

			// assert
			Assert.AreEqual(0, linkedListLong.Count);
			Assert.AreEqual(value, removedValue);
		}

        //-----------------------------------------------------

        [TestMethod]
        public void RetrieveByIndex()
        {
            // arrange
            LinkedList2<long> linkedListLong = new LinkedList2<long>();
            const long value1 = 10;
            linkedListLong.AddToHead(value1);

            // act
            long value2 = linkedListLong[0];

            // assert
            Assert.AreEqual(value1, value2);
        }

        [TestMethod]
        public void AssignByIndex()
        {
            // arrange
            LinkedList2<long> linkedListLong = new LinkedList2<long>();
            const long value1 = 10;
            linkedListLong.AddToHead(value1);

            // act
            const long value2 = 20;
            linkedListLong[0] = value2;
            long value3 = linkedListLong[0];

            // assert
            Assert.AreEqual(value2, value3);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void OutofRangeIndex()
        {
            // arrange
            LinkedList2<long> linkedListLong = new LinkedList2<long>();

            // act
            long value = linkedListLong[0];

            // assert
        }

		//[TestMethod]
		//public void AddAndRemoveItemFromList()
		//{
		//    // arrange
		//    // act
		//    // assert
		//}
	}
}
