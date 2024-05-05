using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServicies.pkgCollections.pkgNodes;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    internal class clsADTLinked<T> : clsADTLineal<T>, iADTLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsLinkedNode<T> attFirst;
        protected clsLinkedNode<T> attFirstQuarter;
        protected clsLinkedNode<T> attMiddle;
        protected clsLinkedNode<T> attLastQuarter;
        protected clsLinkedNode<T> attLast;
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
            return attFirst;
        }
        public clsLinkedNode<T> opGetFirstQuarter()
        {
            return attFirstQuarter;
        }
        public clsLinkedNode<T> opGetMiddle()
        {
            return attMiddle;
        }
        public clsLinkedNode <T> opGetLastQuarter() 
        {
            return attLastQuarter;
        }
        public clsLinkedNode<T> opGetLast()
        {
            return attLast;
        }
        #endregion
        #region Setter
        public bool opSetFirst(clsLinkedNode<T> prmNode)
        {
            this.attFirst = prmNode;
            return true;
        }
        public bool opSetFirstQuarter(clsLinkedNode<T> prmNode)
        {
            this.attFirstQuarter = prmNode;
            return true;
        }
        public bool opSetMiddle(clsLinkedNode<T> prmNode)
        {
            this.attMiddle = prmNode;
            return true;
        }
        public bool opSetLastQuarter(clsLinkedNode<T> prmNode)
        {
            this.attLastQuarter = prmNode;
            return true;
        }
        public bool opSetLast(clsLinkedNode<T> prmNode)
        {
            this.attLast= prmNode;
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
        public override bool opGoFirstQuarter()
        {
            if (attFirstQuarter == null) return false;
            attCurrentItem = attFirstQuarter.opGetItem();
            attCurrentIdx = (attLength / 4);
            return true;
        }
        public override bool opGoLastQuarter()
        {
            if (attLastQuarter == null) return false;
            attCurrentItem = attLastQuarter.opGetItem();
            attCurrentIdx = (attLength / 2) + (attLength / 4);
            return true;
        }
        #endregion
        #endregion
    }
}