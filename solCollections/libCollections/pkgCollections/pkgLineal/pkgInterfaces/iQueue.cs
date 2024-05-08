using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iQueue<T> where T : IComparable<T>
    {
        #region CRUDs
        bool opPush(T prmItem);
        bool opPop(ref T prmItem);
        bool opPeek(ref T prmItem); 
        #endregion
    }
}