using System;

namespace pkgServicies.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTLineal<T> where T : IComparable<T>
    {
        #region Getters
        int opGetLength();
        #endregion
        #region Query
        int opFind(T prmItem);
        bool opExists(T prmItem);
        bool opItsEmpty();
        bool opIsValidIndex(int index);
        bool opItsorderAscending();
        bool opItsorderDescending();
        #endregion
        #region Serialize/Deserialize
        T[] opToArray();
        String opToString();
        bool opToItems(T prmArray);
        #endregion
        #region CRUD
        bool opModify(int prmIdx, T prmItem);
        bool opRetrieve(int prmIdx, ref T prmItem);
        #endregion
    }
}
