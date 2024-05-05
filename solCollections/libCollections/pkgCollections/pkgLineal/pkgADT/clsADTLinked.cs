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
        #endregion
    }
}