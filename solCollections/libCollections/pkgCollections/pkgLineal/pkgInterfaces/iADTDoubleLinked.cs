using System;
using pkgServices.pkgCollections.pkgNodes;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Getter
        clsDoubleLinkedNode<T> opGetFirst();
        clsDoubleLinkedNode<T> opGetFirstQuarter();
        clsDoubleLinkedNode<T> opGetMiddle();
        clsDoubleLinkedNode<T> opGetLastQuarter();
        clsDoubleLinkedNode<T> opGetLast();
        #endregion
        #region Setter
        bool opSetFirst(clsDoubleLinkedNode<T> prmNode);
        bool opSetFirstQuarter(clsDoubleLinkedNode<T> prmNode);
        bool opSetMiddle(clsDoubleLinkedNode<T> prmNode);
        bool opSetLastQuarter(clsDoubleLinkedNode<T> prmNode);
        bool opSetLast(clsDoubleLinkedNode<T> prmNode);
        #endregion
    }
}