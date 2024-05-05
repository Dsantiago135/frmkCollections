using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServicies.pkgCollections.pkgNodes;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgADT
{
    internal class clsADTDoubleLinked<T> : iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Attributes

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
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetLast()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetMiddle()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Setter
        public bool opSetFirst(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetLast(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetMiddle(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}