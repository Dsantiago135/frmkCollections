using System;
using System.Diagnostics;

namespace pkgServicies.pkgCollections.pkgNodes.pkgInterfaces
{
    internal interface iNode<T> where T : IComparable<T>
    {
        #region Getter
        T opGetItem();
        #endregion
        #region Setter
        bool opSetItem(T prmcontent); 
        #endregion
    }
}
