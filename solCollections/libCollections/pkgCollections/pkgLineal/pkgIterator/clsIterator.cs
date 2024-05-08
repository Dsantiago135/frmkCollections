using System;

namespace pkgServices.pkgCollections.pkgIterator
{
    public class clsIterator<T> : iIterator<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attLength = 0;
        protected int attCurrentIdx=-1;
        protected T attCurrentItem;
        #endregion
        #region Operations
        #region Movement
        public virtual bool opGoFirst()
        {
            throw new NotImplementedException();
        }
        public bool opGoPrevious()
        {
            if (!opIsTherePrevious()) return false;
            opGoBack();
            return true;
        }
        public virtual bool opGoFirstQuarter()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGoMiddle()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGoLastQuarter()
        {
            throw new NotImplementedException();
        }
        public bool opGoNext()
        {
            if (!opIsThereNext()) return false;
            opGoForward();
            return true;
        }
        public virtual bool opGoLast()
        {
            throw new NotImplementedException();
        }
        public virtual bool opGo(int prmIdx)
        {
            throw new NotImplementedException();
        }
        public virtual void opGoBack()
        {
            attCurrentIdx--;
        }
        public virtual void opGoForward()
        {
            attCurrentIdx++;
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
        public bool opItsEmpty()
        {
            if (attLength != 0) return false;
            return true;
        }
        public bool opIsThereNext()
        {
            if(attCurrentIdx>=attLength-1)return false;
            return true;
        }
        public bool opIsTherePrevious()
        {
            if(attCurrentIdx<=0) return false;
            return true;
        }
        #endregion
        #endregion
    }
}