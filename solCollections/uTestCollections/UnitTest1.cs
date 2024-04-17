using Microsoft.VisualStudio.TestTools.UnitTesting;
using pkgServicies.pkgCollections.pkgLineal.pkgVector;
using System;

namespace uTestCollections
{
    [TestClass]
    public class uTestVectorStack
    {
        private clsVectorStack<int> testMyStack;
        private int[] testExpectedItems;
        private int testExpectedItem;

        #region BuildersTest
        [TestMethod]
        public void testDefaultConstructor()
        {
            #region Setup

            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>();
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion            
        }
        [TestMethod]
        public void testValidCapacityConstructor()
        {
            #region Setup

            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(10);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(10, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[10], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testNegativeCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(-1);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testOverFLowCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(int.MaxValue);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testZeroCapacityConstructor()
        {
            #region Setup

            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(0);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion  
        }
        [TestMethod]
        public void testMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(clsVectorStack<int>.opGetMaxCapacity());
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(clsVectorStack<int>.opGetMaxCapacity(), testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[clsVectorStack<int>.opGetMaxCapacity()], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(0, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBeyondMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(clsVectorStack<int>.opGetMaxCapacity() + 1);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBehindMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(clsVectorStack<int>.opGetMaxCapacity() - 1);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(int.MaxValue / 16 - 1, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[int.MaxValue / 16 - 1], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(1, testMyStack.opGetGrowingFactor());
            #endregion
        }
        #endregion
        #region Push Tests
        [TestMethod]
        public void testPushFirstItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(123));
            Assert.AreEqual(1, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(123, testMyStack.opToArray()[0]);
            Assert.AreEqual(99, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            testMyStack.opToItems(testExpectedItems, 1);
            testExpectedItems = new int[100];
            testExpectedItems[0] = 456;
            testExpectedItems[1] = 123;

            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(456));
            Assert.AreEqual(2, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(98, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushLastItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 789, 456, 123, 0 }, 3);
            testExpectedItems = new int[4];
            testExpectedItems[0] = 987;
            testExpectedItems[1] = 789;
            testExpectedItems[2] = 456;
            testExpectedItems[3] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(987));
            Assert.AreEqual(4, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(0, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItemWithFullNoFlexibleCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 987, 789, 456, 123 });
            testExpectedItems = new int[4];
            testExpectedItems[0] = 987;
            testExpectedItems[1] = 789;
            testExpectedItems[2] = 456;
            testExpectedItems[3] = 123;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyStack.opPush(123));
            Assert.AreEqual(4, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(0, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItemWithFullFlexibleCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 987, 789, 456, 123 });
            testMyStack.opSetFlexible();
            testExpectedItems = new int[104];
            testExpectedItems[0] = 777;
            testExpectedItems[1] = 987;
            testExpectedItems[2] = 789;
            testExpectedItems[3] = 456;
            testExpectedItems[4] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(777));
            Assert.AreEqual(5, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(104, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsTrue(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(99, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItemWithHugeFullFlexibleCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[clsVectorStack<int>.opGetMaxCapacity() - 1]);
            testMyStack.opSetFlexible();
            testExpectedItems = new int[clsVectorStack<int>.opGetMaxCapacity()];
            testExpectedItems[0] = 777;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(777));
            Assert.AreEqual(clsVectorStack<int>.opGetMaxCapacity(), testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(clsVectorStack<int>.opGetMaxCapacity(), testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(0, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(0, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        #endregion
        #region Pop Tests
        [TestMethod]
        public void testPopWithFullCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 1, 2, 3, 4 },4);
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItem);
            Assert.AreEqual(3, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(1, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPopWithEmptyCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyStack.opPop(ref testExpectedItem));
            Assert.AreEqual(default, testExpectedItem);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(100, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPopNextItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 1, 2, 3, 4 }, 3);
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = 1;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItem);
            Assert.AreEqual(2, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(2, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        #endregion
        #region Peek Tests
        [TestMethod]
        public void testPeekWithFullCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 1, 2, 3, 4 });
            testExpectedItems = new int[4] { 1, 2, 3, 4 };
            testExpectedItem = 1;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPeek(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItem);
            Assert.AreEqual(4, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(0, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPeekWithEmptyCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyStack.opPeek(ref testExpectedItem));
            Assert.AreEqual(default, testExpectedItem);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(100, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPeekNextItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 1, 2, 3, 4 }, 3);
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = 1;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItems);
            Assert.AreEqual(3, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(1, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        #endregion
    }
    [TestClass]
    public class uTestVectorQueue
    {
        private clsVectorQueue<int> testMyQueue;
        private int[] testExpectedItems;
        private int testExpectedItem;

        #region BuildersTest
        [TestMethod]
        public void testDefaultConstructor()
        {
            #region Setup

            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>();
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion            
        }
        [TestMethod]
        public void testValidCapacityConstructor()
        {
            #region Setup

            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(10);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(10, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[10], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testNegativeCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(-1);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testOverFLowCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(int.MaxValue);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testZeroCapacityConstructor()
        {
            #region Setup

            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(0);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion  
        }
        [TestMethod]
        public void testMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(clsVectorQueue<int>.opGetMaxCapacity());
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(clsVectorQueue<int>.opGetMaxCapacity(), testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[clsVectorQueue<int>.opGetMaxCapacity()], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(0, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBeyondMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(clsVectorQueue<int>.opGetMaxCapacity() + 1);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBehindMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(clsVectorQueue<int>.opGetMaxCapacity() - 1);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(int.MaxValue / 16 - 1, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[int.MaxValue / 16 - 1], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(1, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        #endregion
        #region Push Tests
        [TestMethod]
        public void testPushFirstItem()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPush(123));
            Assert.AreEqual(1, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(123, testMyQueue.opToArray()[0]);
            Assert.AreEqual(99, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItem()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            testMyQueue.opToItems(testExpectedItems, 1);
            testExpectedItems = new int[100];
            testExpectedItems[0] = 456;
            testExpectedItems[1] = 123;

            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPush(456));
            Assert.AreEqual(2, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(98, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushLastItem()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 789, 456, 123, 0 }, 3);
            testExpectedItems = new int[4];
            testExpectedItems[0] = 987;
            testExpectedItems[1] = 789;
            testExpectedItems[2] = 456;
            testExpectedItems[3] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPush(987));
            Assert.AreEqual(4, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(4, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(0, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItemWithFullNoFlexibleCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 987, 789, 456, 123 });
            testExpectedItems = new int[4];
            testExpectedItems[0] = 987;
            testExpectedItems[1] = 789;
            testExpectedItems[2] = 456;
            testExpectedItems[3] = 123;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyQueue.opPush(123));
            Assert.AreEqual(4, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(4, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(0, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItemWithFullFlexibleCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 987, 789, 456, 123 });
            testMyQueue.opSetFlexible();
            testExpectedItems = new int[104];
            testExpectedItems[0] = 777;
            testExpectedItems[1] = 987;
            testExpectedItems[2] = 789;
            testExpectedItems[3] = 456;
            testExpectedItems[4] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPush(777));
            Assert.AreEqual(5, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(104, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsTrue(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(99, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItemWithHugeFullFlexibleCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[clsVectorQueue<int>.opGetMaxCapacity() - 1]);
            testMyQueue.opSetFlexible();
            testExpectedItems = new int[clsVectorQueue<int>.opGetMaxCapacity()];
            testExpectedItems[0] = 777;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPush(777));
            Assert.AreEqual(clsVectorQueue<int>.opGetMaxCapacity(), testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(clsVectorQueue<int>.opGetMaxCapacity(), testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(0, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(0, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        #endregion
        #region Pop Tests
        [TestMethod]
        public void testPopWithFullCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 1, 2, 3, 4 });
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItems);
            Assert.AreEqual(3, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(4, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(1, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPopWithEmptyCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testExpectedItems = new int[100];
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyQueue.opPop(ref testExpectedItem));
            Assert.AreEqual(default, testExpectedItems);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(100, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPopNextItem()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 1, 2, 3, 4 }, 3);
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = 1;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItems);
            Assert.AreEqual(2, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(4, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(2, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        #endregion
        #region Peek Tests
        [TestMethod]
        public void testPeekWithFullCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 1, 2, 3, 4 });
            testExpectedItems = new int[4] { 1, 2, 3, 4 };
            testExpectedItem = 1;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPeek(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItem);
            Assert.AreEqual(4, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(4, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(0, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPeekWithEmptyCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testExpectedItems = new int[100];
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyQueue.opPop(ref testExpectedItem));
            Assert.AreEqual(default, testExpectedItem);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(100, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPeekNextItem()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 1, 2, 3, 4 }, 3);
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = 1;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItems);
            Assert.AreEqual(3, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsorderAscending());
            Assert.IsFalse(testMyQueue.opItsorderDescending());
            Assert.AreEqual(4, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(1, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
        #endregion
    }
}