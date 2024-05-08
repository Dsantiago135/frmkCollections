using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgNodes;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLinked<T> : clsADTLineal<T>, iADTLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsLinkedNode<T> attFirst = default;
        protected clsLinkedNode<T> attFirstQuarter = default;
        protected clsLinkedNode<T> attMiddle = default;
        protected clsLinkedNode<T> attLastQuarter = default;
        protected clsLinkedNode<T> attLast = default;
        protected clsLinkedNode<T> attCurrentNode = new clsLinkedNode<T>();
        #endregion
        #region Operations
        #region Builders
        public clsADTLinked()
        {
        }
        #endregion
        #region Getter
        public clsLinkedNode<T> opGetFirst()
        {
            if (!opGoFirst()) return null;
            attFirst = attCurrentNode;
            return attFirst;
        }
        public clsLinkedNode<T> opGetFirstQuarter()
        {
            if (!opGoFirstQuarter()) return null;
            attFirstQuarter = attCurrentNode;
            return attFirstQuarter;
        }
        public clsLinkedNode<T> opGetMiddle()
        {
            if (!opGoMiddle()) return null;
            attMiddle = attCurrentNode;
            return attMiddle;
        }
        public clsLinkedNode <T> opGetLastQuarter() 
        {
            if (!opGoLastQuarter()) return null;
            attLastQuarter = attCurrentNode;
            return attLastQuarter;
        }
        public clsLinkedNode<T> opGetLast()
        {
            if (!opGoLast()) return null;
            attLast = attCurrentNode;
            return attLast;
        }
        #endregion
        #region Setter
        public bool opSetFirst(clsLinkedNode<T> prmNode)
        {
            attFirst = prmNode;
            return true;
        }
        public bool opSetFirstQuarter(clsLinkedNode<T> prmNode)
        {
            attFirstQuarter = prmNode;
            return true;
        }
        public bool opSetMiddle(clsLinkedNode<T> prmNode)
        {
            attMiddle = prmNode;
            return true;
        }
        public bool opSetLastQuarter(clsLinkedNode<T> prmNode)
        {
            attLastQuarter = prmNode;
            return true;
        }
        public bool opSetLast(clsLinkedNode<T> prmNode)
        {
            attLast= prmNode;
            return true;
        }
        #endregion
        #region Serialize/Deserialize
        public override bool opToItems(T[] prmArray)
        {
            if (prmArray == null) return false;
            if (prmArray.Length == 0) return false;
            if (prmArray.Length > attMaxCapacity) return false;
            attFirst = new clsLinkedNode<T>(prmArray[0]);
            attMiddle = attFirst;
            clsLinkedNode<T> varPreviousNode = attFirst;
            clsLinkedNode<T> varCurrentNode = attFirst;
            for (int varIdx=1;varIdx<prmArray.Length;varIdx++)
            {
                varCurrentNode = new clsLinkedNode<T>(prmArray[varIdx]);
                varPreviousNode.opSetNext(varCurrentNode);
                if(varIdx==(prmArray.Length/4)) attFirstQuarter = varCurrentNode;
                if (varIdx == (prmArray.Length / 2)) attMiddle = varCurrentNode;
                if (varIdx == ((prmArray.Length / 2) + (prmArray.Length/4))) attLastQuarter = varCurrentNode;
                varPreviousNode = varCurrentNode;
            }
            attLast = varCurrentNode;
            attitsOrdenedAscending = false;
            attitsOrdenedDescending = false;
            return true;
        }
        public override T[] opToArray()
        {
            if (attLength==0) return null;
            T[] varArrayItems= new T[attLength];
            for (int varCount=0;varCount<attLength;varCount++)
            {
                opGoFirst();
                varArrayItems[varCount]=attCurrentItem;
                opGoNext();
            }
            return varArrayItems;
        }
        #endregion
        #region Iterator
        public override bool opGo(int prmIdx)
        {
            if (!opIsValid(prmIdx)) return false;
            if (prmIdx < attLength/4) opGoFirst();
            if (prmIdx >= attLength/4 && prmIdx < attLength/2) opGoFirstQuarter();
            if (prmIdx >= attLength/2 && prmIdx < ((attLength/2) + (attLength/4)))opGoMiddle();
            if (prmIdx >= ((attLength/2) + (attLength/4)))opGoLastQuarter();
            if (prmIdx == attLength-1)opGoLast();
            while (attCurrentIdx < prmIdx)
                opGoNext();
            return true;
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
            attCurrentNode = attFirstQuarter;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = (attLength / 4);
            return true;
        }
        public override bool opGoMiddle()
        {
            if (attMiddle == null) return false;
            attCurrentNode = attMiddle;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = attLength / 2;
            return true;
        }
        public override bool opGoLastQuarter()
        {
            if (attLastQuarter == null) return false;
            attCurrentNode = attLastQuarter;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = (attLength / 2) + (attLength / 4);
            return true;
        }
        public override bool opGoLast()
        {
            if (attLast == null) return false;
            attCurrentNode = attLast;
            attCurrentItem = attCurrentNode.opGetItem();
            attCurrentIdx = attLength - 1;
            return true;
        }
        #endregion
        #endregion
    }
}