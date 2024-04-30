using System;

namespace pkgServicies.pkgCollections.pkgIterator
{
    public class clsIterator<T> where T : IComparable<T>
    {
        #region Attributes
        protected int attLength = 0;
        protected int attCurrentIdx;
        protected T attCurrentItem;
        #endregion
        #region Operations
        public virtual bool opGo(int prmidx)
        {
            throw new NotImplementedException();
        }
        public bool opIsValid(int index)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
