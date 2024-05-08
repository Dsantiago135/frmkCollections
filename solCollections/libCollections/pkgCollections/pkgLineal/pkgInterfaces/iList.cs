using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iList<T> where T : IComparable<T>
    {
        #region CRUDs
        bool opAdd(T prmItem);
        bool opInsert(int prmIdx, T prmItem);
        bool opRemove(int prmIdx, ref T prmItem); 
        #endregion

    }
}