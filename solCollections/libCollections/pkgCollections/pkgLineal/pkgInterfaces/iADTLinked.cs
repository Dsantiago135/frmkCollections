using System;
using pkgServices.pkgCollections.pkgNodes;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTLinked<T> where T : IComparable<T>
    {
        #region Getter
        clsLinkedNode<T> opGetFirst();
        clsLinkedNode<T> opGetFirstQuarter();
        clsLinkedNode<T> opGetMiddle();
        clsLinkedNode<T> opGetLastQuarter();
        clsLinkedNode<T> opGetLast();
        #endregion
        #region Setter
        bool opSetFirst(clsLinkedNode<T> prmNode);
        bool opSetFirstQuarter(clsLinkedNode<T> prmNode);
        bool opSetMiddle(clsLinkedNode<T> prmNode);
        bool opSetLastQuarter(clsLinkedNode<T> prmNode);
        bool opSetLast(clsLinkedNode<T> prmNode);
        #endregion
    }
}