using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServicies.pkgCollections.pkgNodes;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    internal class clsADTDoubleLinked<T> :clsADTLineal<T>, iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsDoubleLinkedNode<T> attFirst;
        protected clsDoubleLinkedNode<T> attFirstQuarter;
        protected clsDoubleLinkedNode<T> attMiddle;
        protected clsDoubleLinkedNode<T> attLastQuarter;
        protected clsDoubleLinkedNode<T> attLast;
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
            return attFirst;
        }
        public clsDoubleLinkedNode <T> opGetFirstQuarter()
        {
            return attFirstQuarter;
        }
        public clsDoubleLinkedNode <T> opGetMiddle()
        {
            return attMiddle;
        }
        public clsDoubleLinkedNode<T> opGetLastQuarter()
        {
            return attLastQuarter;
        }
        public clsDoubleLinkedNode<T> opGetLast()
        {
            return attLast;
        }
        #endregion
        #region Setter
        public bool opSetFirst(clsDoubleLinkedNode<T> prmNode)
        {
            this.attFirst = prmNode;
            return true;
        }
        public bool opSetFirstQuarter(clsDoubleLinkedNode<T> prmNode)
        {
            this.attFirstQuarter = prmNode;
            return true;
        }
        public bool opSetMiddle(clsDoubleLinkedNode<T> prmNode)
        {
            this.attMiddle = prmNode;
            return true;
        }
        public bool opSetLastQuarter(clsDoubleLinkedNode<T> prmNode)
        {
            this.attLastQuarter = prmNode;
            return true;
        }
        public bool opSetLast(clsDoubleLinkedNode<T> prmNode)
        {
            this.attLast = prmNode;
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
            attitsOrdenedAscending = false;
            attitsOrdenedDescending = false;
            return true;
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
        public override bool opGoFirstQuarter()
        {
            if (attFirstQuarter == null) return false;
            attCurrentItem = attFirstQuarter.opGetItem();
            attCurrentIdx = (attLength / 4);
            return true;
        }
        public override bool opGoLastQuarter()
        {
            if(attLastQuarter == null)return false;
            attCurrentItem = attLastQuarter.opGetItem();
            attCurrentIdx = (attLength / 2) + (attLength / 4);
            return true;
        }
        #endregion
        #endregion
    }
}