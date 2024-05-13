using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTDoubleLinked<T> :clsADTLineal<T>, iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsDoubleLinkedNode<T> attFirst = default;
        protected clsDoubleLinkedNode<T> attFirstQuarter = default;
        protected clsDoubleLinkedNode<T> attMiddle = default;
        protected clsDoubleLinkedNode<T> attLastQuarter = default;
        protected clsDoubleLinkedNode<T> attLast = default;
        protected clsDoubleLinkedNode<T> attCurrentNode = new clsDoubleLinkedNode<T>();
        #endregion
        #region Operations
        #region Builders
        public clsADTDoubleLinked ()
        {
        }
        #endregion
        #region Getter
        public clsDoubleLinkedNode<T> opGetFirst()
        {
            if (!opGoFirst()) return null;
            attFirst = attCurrentNode;
            return attFirst;
        }
        public clsDoubleLinkedNode<T> opGetFirstQuarter()
        {
            if (!opGoFirstQuarter()) return null;
            attFirstQuarter = attCurrentNode;
            return attFirstQuarter;
        }
        public clsDoubleLinkedNode<T> opGetMiddle()
        {
            if (!opGoMiddle()) return null;
            attMiddle = attCurrentNode;
            return attMiddle;
        }
        public clsDoubleLinkedNode<T> opGetLastQuarter()
        {
            if (!opGoLastQuarter()) return null;
            attLastQuarter = attCurrentNode;
            return attLastQuarter;
        }
        public clsDoubleLinkedNode<T> opGetLast()
        {
            if (!opGoLast()) return null;
            attLast = attCurrentNode;
            return attLast;
        }
        #endregion
        #region Setter
        public bool opSetFirst(clsDoubleLinkedNode<T> prmNode)
        {
            attFirst = prmNode;
            return true;
        }
        public bool opSetFirstQuarter(clsDoubleLinkedNode<T> prmNode)
        {
            attFirstQuarter = prmNode;
            return true;
        }
        public bool opSetMiddle(clsDoubleLinkedNode<T> prmNode)
        {
            attMiddle = prmNode;
            return true;
        }
        public bool opSetLastQuarter(clsDoubleLinkedNode<T> prmNode)
        {
            attLastQuarter = prmNode;
            return true;
        }
        public bool opSetLast(clsDoubleLinkedNode<T> prmNode)
        {
            attLast = prmNode;
            return true;
        }
        #endregion
        #region Serialize/Deserialize
        public override bool opToItems(T[] prmArray)
        {
            if (prmArray == null) return false;
            if (prmArray.Length == 0) return false;
            attFirst = new clsDoubleLinkedNode<T>(prmArray[0]);
            attMiddle = attFirst;
            clsDoubleLinkedNode<T> varPreviousNode = attFirst;
            clsDoubleLinkedNode<T> varCurrentNode = attFirst;
            for (int varIdx = 1; varIdx < prmArray.Length; varIdx++)
            {
                varCurrentNode = new clsDoubleLinkedNode<T>(prmArray[varIdx]);
                varPreviousNode.opSetNext(varCurrentNode);
                if (varIdx == (prmArray.Length / 4)) attFirstQuarter = varCurrentNode;
                if (varIdx == (prmArray.Length / 2)) attMiddle = varCurrentNode;
                if (varIdx == ((prmArray.Length / 2) + (prmArray.Length / 4))) attLastQuarter = varCurrentNode;
                varPreviousNode = varCurrentNode;
            }
            attLast = varCurrentNode;
            attLength = prmArray.Length;
            attitsOrdenedAscending = false;
            attitsOrdenedDescending = false;
            return true;
        }
        public override T[] opToArray()
        {
            if (attLength == 0) return null;
            T[] varArrayItems = new T[attLength];
            opGoFirst();

            for (int varCount = 0; varCount < attLength; varCount++)
            {
                varArrayItems[varCount] = attCurrentItem;
                opGoNext();
            }
            return varArrayItems;
        }
        #endregion
        #region Iterator
        public override bool opGo(int prmIdx)
        {
            if (!opIsValid(prmIdx)) return false;
            if (prmIdx < attLength / 4) opGoFirst();
            if (prmIdx >= attLength / 4 && prmIdx < attLength / 2) opGoFirstQuarter();
            if (prmIdx >= attLength / 2 && prmIdx < ((attLength / 2) + (attLength / 4))) opGoMiddle();
            if (prmIdx >= ((attLength / 2) + (attLength / 4))) opGoLastQuarter();
            if (prmIdx == attLength - 1) opGoLast();
            while (attCurrentIdx < prmIdx)
                opGoNext();
            return true;
        }
        public override void opGoBack()
        {
            base.opGoBack();
            attCurrentNode = attCurrentNode.opGetPrevious();
            attCurrentItem = attCurrentNode.opGetItem();
        }
        public override void opGoForward()
        {
            base.opGoForward();
            attCurrentNode = attCurrentNode.opGetNext();
            attCurrentItem = attCurrentNode.opGetItem();
        }
        public override bool opGoFirst()
        {
            if (attFirst == null) return false;
            attCurrentNode = attFirst;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = 0;
            return true;
        }
        public override bool opGoFirstQuarter()
        {
            if (attFirstQuarter == null) return false;
            attCurrentNode= attFirstQuarter;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = (attLength / 4);
            return true;
        }
        public override bool opGoMiddle()
        {
            if (attMiddle == null) return false;
            attCurrentNode = attMiddle;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = attLength/2;
            return true;
        }
        public override bool opGoLastQuarter()
        {
            if(attLastQuarter == null)return false;
            attCurrentNode = attLastQuarter;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = (attLength / 2) + (attLength / 4);
            return true;
        }
        public override bool opGoLast()
        {
            if (attLast == null) return false;
            attCurrentNode =attLast ;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = attLength-1;
            return true;
        }
        #endregion
        #region Utilities
        public bool opSetAccessDoors()
        {
            if (attLength == 0) return false;
            T[] varArray = opToArray();
            opToItems(varArray);
            if (attLength == 1)
            {
                opGoFirst();
                attFirst = attCurrentNode;
                attFirstQuarter = attCurrentNode;
                attMiddle = attCurrentNode;
                attLastQuarter = attCurrentNode;
                attLast = attCurrentNode;
            }
            return true;
        }
        #endregion
        #endregion
    }
}