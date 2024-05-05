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
        #endregion
    }
}