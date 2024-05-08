using System;

namespace pkgServices.pkgCollections.pkgNodes.pkgInterfaces
{
    internal interface iLinkedNode<T> where T : IComparable<T>
    {
        #region Getter
        clsLinkedNode<T> opGetNext();
        #endregion
        #region Setter
        bool opSetNext(clsLinkedNode<T> prmNode);
        #endregion
    }
}
