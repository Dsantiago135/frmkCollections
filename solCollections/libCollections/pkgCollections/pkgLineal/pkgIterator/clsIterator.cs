using pkgServicies.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServicies.pkgCollections.pkgIterator
{
    public class clsIterator<T> : iIterator<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attLength = 0;
        protected int attCurrentIdx;
        protected T attCurrentItem;
        #endregion
        #region Operations
        #region Movement
        public bool opGoFirst()
        {
            throw new NotImplementedException();
        }
        public bool opGoPrevious()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGoFirstQuarter()
        {
            throw new NotImplementedException();
        }
        public bool opGoMiddle()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGoLastQuarter()
        {
            throw new NotImplementedException();
        }
        public bool opGoNext()
        {
            throw new NotImplementedException();
        }
        public bool opGoLast()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGo(int prmIdx)
        {
            throw new NotImplementedException();
        }
        public void opGoBack()
        {
            throw new NotImplementedException();
        }
        public void opGoForward()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Getter
        public int opGetLength()
        {
            return attLength;
        }
        public int opGetCurrentIdx()
        {
            return attCurrentIdx;
        }
        public T opGetCurrentItem()
        {
            return attCurrentItem;
        }
        #endregion
        #region Setter
        public bool opSetCurrentItem(T prmContent)
        {
            attCurrentItem=prmContent;
            return true;
        }
        #endregion
        #region Query
        public bool opIsValid(int prmIdx)
        {
            if (attLength == 0)return false;
            if (prmIdx >= attLength) return false;
            if (prmIdx < 0) return false;
            return true;
        }
        public bool opIsThereNext()
        {
            throw new NotImplementedException();
        }
        public bool opIsTherePrevious()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
