using pkgServicies.pkgCollections.pkgNodes;
using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTLinked<T> where T : IComparable<T>
    {
        #region Getter
        clsLinkedNode<T> opGetFirst();
        clsLinkedNode<T> opGetMiddle();
        clsLinkedNode<T> opGetLast();
        #endregion
        #region Setter
        bool opSetFirst(clsLinkedNode<T> prmNode);
        bool opSetMiddle(clsLinkedNode<T> prmNode);
        bool opSetLast(clsLinkedNode<T> prmNode);
        #endregion
    }
}