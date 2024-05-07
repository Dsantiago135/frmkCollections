using System;

namespace pkgServicies.pkgCollections.pkgIterator
{
    internal interface iIterator<T> where T : IComparable<T>
    {
        #region Movement
        bool opGoFirst();
        bool opGoPrevious();
        bool opGoMiddle();
        bool opGoNext();
        bool opGoLast();
        bool opGo(int prmIdx);
        void opGoBack();
        void opGoForward();
        #endregion
        #region Getter
        int opGetLength();
        int opGetCurrentIdx();
        T opGetCurrentItem();
        #endregion
        #region Setter
        bool opSetCurrentItem(T prmContent);
        #endregion
        #region Query
        bool opIsValid(int prmIdx);
        bool opItsEmpty();
        bool opIsThereNext();
        bool opIsTherePrevious();
        #endregion
    }
}
