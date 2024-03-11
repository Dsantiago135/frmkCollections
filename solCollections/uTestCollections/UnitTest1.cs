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
            Assert.AreEqual(0,testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsorderAscending());
            Assert.IsFalse(testMyStack.opItsorderDescending());
            Assert.AreEqual(100,testMyStack.opGetCapacity());
            CollectionAssert.AreEqual(new int[100],testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100,testMyStack.opGetGrowingFactor());
            #endregion
        }
    }
}
