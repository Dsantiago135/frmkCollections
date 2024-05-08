using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iStack<T> where T:IComparable<T>
    {
        #region CRUDs
        bool opPush(T prmItem);
        bool opPop(ref T prmItem);
        bool opPeek(ref T prmItem); 
        #endregion
    }
}