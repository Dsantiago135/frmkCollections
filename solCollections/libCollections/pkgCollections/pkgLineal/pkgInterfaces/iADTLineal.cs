﻿using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgInterfaces
{
    internal interface iADTLineal<T> where T : IComparable<T>
    {   
        #region Query
        int opFind(T prmItem);
        bool opExists(T prmItem);
        bool opItsOrderedAscending();
        bool opItsOrderedDescending();
        #endregion
        #region Serialize/Deserialize
        T[] opToArray();
        String opToString();
        bool opToItems(T[] prmArray);
        #endregion
        #region CRUD
        bool opModify(int prmIdx, T prmItem);
        bool opRetrieve(int prmIdx, ref T prmItem);
        bool opReverse();
        #endregion
        #region Sort
        bool opBubbleSort(bool prmInAscinding);
        bool opQuickSort(bool prmInAsending);
        bool opMergeSort(bool prmInAsending);
        bool opInsertSort(bool prmInAsending);
        bool opCocktailSort(bool prmInAsending);
        #endregion
    }
}