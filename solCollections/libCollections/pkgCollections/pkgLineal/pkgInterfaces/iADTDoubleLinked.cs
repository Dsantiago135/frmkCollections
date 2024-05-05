using pkgServicies.pkgCollections.pkgNodes;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Getter
        clsDoubleLinkedNode<T> opGetFirst();
        clsDoubleLinkedNode<T> opGetMiddle();
        clsDoubleLinkedNode<T> opGetLast();
        #endregion
        #region Setter
        bool opSetFirst(clsDoubleLinkedNode<T> prmNode);
        bool opSetMiddle(clsDoubleLinkedNode<T> prmNode);
        bool opSetLast(clsDoubleLinkedNode<T> prmNode);
        #endregion
    }
}