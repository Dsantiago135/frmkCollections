using System;

namespace pkgServices.pkgCollections.pkgNodes.pkgInterfaces
{
    internal interface iDoubleLinkedNode<T> where T : IComparable<T>
    {
        #region Getter
        clsDoubleLinkedNode<T> opGetPrevious();
        clsDoubleLinkedNode<T> opGetNext();
        #endregion
        #region Setter
        bool opSetPrevious(clsDoubleLinkedNode<T> prmNode);
        bool opSetNext(clsDoubleLinkedNode<T> prmNode);
        #endregion
    }
}