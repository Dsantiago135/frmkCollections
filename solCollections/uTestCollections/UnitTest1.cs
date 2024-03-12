using Microsoft.VisualStudio.TestTools.UnitTesting;
using pkgServicies.pkgCollections.pkgLineal.pkgVector;
using System;

namespace uTestCollections
{
    [TestClass]
    public class uTestVectorStack
    {
        private clsVectorStack<int> testMyStack;

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
            Assert.AreEqual(100, testMyStack.opGetCapacity());
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
            Assert.AreEqual(10, testMyStack.opGetCapacity());
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
            Assert.AreEqual(100, testMyStack.opGetCapacity());
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
            Assert.AreEqual(100, testMyStack.opGetCapacity());
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
            Assert.AreEqual(100, testMyStack.opGetCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion  
        }
        [TestMethod]
        public void testPush() 
        {
            #region Setup
            testMyStack=new clsVectorStack<int>();
            #endregion
            #region Test & Assert
            Assert.IsTrue (testMyStack.opPush(123));
            Assert.AreEqual(1,testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100,testMyStack.opGetCapacity());
            CollectionAssert.AreEqual(new int[100],testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100,testMyStack.opGetGrowingFactor());
            Assert.AreEqual(123, testMyStack.opToArray()[0]);
            #endregion
        }
    }
}