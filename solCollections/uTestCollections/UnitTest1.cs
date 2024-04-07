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
            #endregion
        }
        [TestMethod] 
        public void testBehindMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(clsVectorStack<int>.opGetMaxCapacity()-1);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(int.MaxValue/16 - 1, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[int.MaxValue/16 - 1], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(1, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testPushFirstItem() 
        {
            #region Setup
            testMyStack=new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItems[0] = 123;

            #endregion
            #region Test & Assert
            Assert.IsTrue (testMyStack.opPush(123));
            Assert.AreEqual(1,testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100,testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems,testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100,testMyStack.opGetGrowingFactor());
            Assert.AreEqual(123, testMyStack.opToArray()[0]);
            #endregion
        }
        [TestMethod]
        public void testPushNextItem()
        {
            #region Setup
            #endregion
            #region Test & Assert
            #endregion
        }
    }
}