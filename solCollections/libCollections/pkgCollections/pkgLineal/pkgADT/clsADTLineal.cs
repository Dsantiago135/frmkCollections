using pkgServices.pkgCollections.pkgIterator;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using pkgServices.pkgCollections.pkgLineal.pkgLinked;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLineal<T> : clsIterator<T>, iADTLineal<T> where T : IComparable<T>
    {
        #region Attributes
        protected static int attMaxCapacity = int.MaxValue / 16;
        protected bool attItsOrderedAscending = false;
        protected bool attItsOrderedDescending = false;
        #endregion
        #region Operations
        #region Getter
        public static int opGetMaxCapacity()
        {
            return attMaxCapacity;
        }
        #endregion
        #region Query
        public int opFind(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opExists(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opItsOrderedAscending()
        {
            return attItsOrderedAscending;
        }
        public bool opItsOrderedDescending()
        {
            return attItsOrderedDescending;
        }
        #endregion
        #region Serialize/Deserialize
        public virtual T[] opToArray()
        {
            if (attLength == 0) return null;
            T[] varArrayItems = new T[attLength];
            opGoFirst();
            for (int varCount = 0; varCount < attLength; varCount++)
            {
                varArrayItems[varCount] = attCurrentItem;
                opGoNext();
            }
            return varArrayItems;
        }
        public string opToString()
        {
            throw new NotImplementedException();
        }
        public virtual bool opToItems(T[] prmArray)
        {
            throw new NotImplementedException();
        }
        public virtual bool opToItems(T[] prmArray, int prmItemsCount)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region CRUD
        public bool opModify(int prmIdx, T prmItem)
        {
            if (!opGo(prmIdx)) return false;
            return opSetCurrentItem(prmItem);
            ;
        }
        public bool opRetrieve(int prmIdx, ref T prmItem)
        {
            if (!opGo(prmIdx)) return false;
            prmItem = attCurrentItem;
            return true;
        }
        public bool opReverse()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Sort
        public bool opBubbleSort(bool prmInAscending)
        {
            {
                #region Validations
                if (attLength == 0) return false;
                if (prmInAscending && attItsOrderedAscending) return true;
                if (prmInAscending && attItsOrderedDescending) return true;
                #endregion
                T[] varArray = opToArray();

                for (int i = 0; i < attLength - 1; i++)
                {
                    for (int j = 0; j < attLength - 1 - i; j++)
                    {
                        if ((prmInAscending && varArray[j].CompareTo(varArray[j + 1]) > 0) ||
                            (!prmInAscending && varArray[j].CompareTo(varArray[j + 1]) < 0))
                        {
                            opSwap(varArray,j,j+1);
                        }
                    }
                }
                opToItems(varArray,attLength);
                attItsOrderedAscending = prmInAscending;
                attItsOrderedDescending = !prmInAscending;
                return true;
            }
        }
        public bool opQuickSort(bool prmInAscending)
        {
            #region Validations
            if (attLength == 0) return false;
            if (prmInAscending && attItsOrderedAscending) return true;
            if (!prmInAscending && attItsOrderedDescending) return true;
            #endregion

            T[] varArray = opToArray();
            int varLow = 0;
            int varHigh = attLength - 1;

            opQuickSort(varArray, varLow, varHigh);

            void opQuickSort(T[] prmArray, int prmLow, int prmHigh)
            {
                if (prmLow < prmHigh)
                {
                    int varPivote = opPartition(prmArray, prmLow, prmHigh);
                    opQuickSort(prmArray, prmLow, varPivote - 1);
                    opQuickSort(prmArray, varPivote + 1, prmHigh);
                }
            }
            int opPartition(T[] prmVarArray, int prmLow, int prmHigh)
            {
                T varPivote = prmVarArray[prmHigh];
                int i = prmLow - 1;

                for (int varCount = prmLow; varCount < prmHigh; varCount++)
                {
                    bool varCondition;
                    if (prmInAscending) varCondition = prmVarArray[varCount].CompareTo(varPivote) < 0;
                    else varCondition = prmVarArray[varCount].CompareTo(varPivote) > 0;

                    if (varCondition)
                    {
                        i++;
                        opSwap(prmVarArray, i, varCount);
                    }
                }

                opSwap(prmVarArray, i + 1, prmHigh);
                return i + 1;
            }
            opToItems(varArray, attLength);
            attItsOrderedAscending = prmInAscending;
            attItsOrderedDescending = !prmInAscending;
            return true;
        }
        public bool opMergeSort(bool prmInAscending)
        {
            #region Validations
            if (attLength == 0) return false;
            if (prmInAscending && attItsOrderedAscending) return true;
            if (!prmInAscending && attItsOrderedDescending) return true;
            #endregion
            T[] varArray = opToArray();
            opMergeSort(varArray, 0, attLength - 1);

            void opMergeSort(T[] prmArray, int prmLow, int prmHigh)
            {
                if (prmLow < prmHigh)
                {
                    int varMiddle = prmLow + (prmHigh - prmLow) / 2;
                    opMergeSort(prmArray, prmLow, varMiddle);
                    opMergeSort(prmArray, varMiddle + 1, prmHigh);
                    Merge(prmArray, prmLow, varMiddle, prmHigh);
                }
            }

            void Merge(T[] prmArray, int prmLow, int prmMid, int prmHigh)
            {
                int n1 = prmMid - prmLow + 1;
                int n2 = prmHigh - prmMid;

                T[] left = new T[n1];
                T[] right = new T[n2];

                Array.Copy(prmArray, prmLow, left, 0, n1);
                Array.Copy(prmArray, prmMid + 1, right, 0, n2);

                int i = 0;
                int j = 0;
                int k = prmLow;

                while (i < n1 && j < n2)
                {
                    if ((prmInAscending && left[i].CompareTo(right[j]) <= 0) ||
                        (!prmInAscending && left[i].CompareTo(right[j]) >= 0))
                    {
                        prmArray[k] = left[i];
                        i++;
                    }
                    else
                    {
                        prmArray[k] = right[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    prmArray[k] = left[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    prmArray[k] = right[j];
                    j++;
                    k++;
                }
            }
            opToItems(varArray, attLength);
            attItsOrderedAscending = prmInAscending;
            attItsOrderedDescending = !prmInAscending;
            return true;
        }
        public bool opInsertSort(bool prmInAscending)
        {
            #region Validations
            if (attLength == 0) return false;
            if (prmInAscending && attItsOrderedAscending) return true;
            if (!prmInAscending && attItsOrderedDescending) return true;
            #endregion

            T[] varArray = opToArray();

            for (int i = 1; i < attLength; i++)
            {
                T varKey = varArray[i];
                int j = i - 1;

                while (j >= 0 && ((prmInAscending && varArray[j].CompareTo(varKey) > 0) ||
                                  (!prmInAscending && varArray[j].CompareTo(varKey) < 0)))
                {
                    varArray[j + 1] = varArray[j];
                    j--;
                }

                varArray[j + 1] = varKey;
            }
            opToItems(varArray, attLength);
            attItsOrderedAscending = prmInAscending;
            attItsOrderedDescending = !prmInAscending;
            return true;
        }
        public bool opCocktailSort(bool prmInAscending)
        {
            #region Validations
            if (attLength == 0) return false;
            if (prmInAscending && attItsOrderedAscending) return true;
            if (!prmInAscending && attItsOrderedDescending) return true;
            #endregion

            T[] varArray = opToArray();

            bool varSwapped;
            int varStart = 0;
            int varEnd = attLength - 1;

            do
            {
                varSwapped = false;

                for (int varCount = varStart; varCount < varEnd; varCount++)
                {
                    if (prmInAscending)
                    {
                        if (varArray[varCount].CompareTo(varArray[varCount + 1]) > 0)
                        {
                            opSwap(varArray, varCount, varCount + 1);
                            varSwapped = true;
                        }
                    }
                    else
                    {
                        if (varArray[varCount].CompareTo(varArray[varCount + 1]) < 0)
                        {
                            opSwap(varArray, varCount, varCount + 1);
                            varSwapped = true;
                        }
                    }
                }

                if (!varSwapped) break;

                varSwapped = false;
                varEnd--;

                for (int varCount = varEnd - 1; varCount >= varStart; varCount--)
                {
                    if (prmInAscending)
                    {
                        if (varArray[varCount].CompareTo(varArray[varCount + 1]) > 0)
                        {
                            opSwap(varArray, varCount, varCount + 1);
                            varSwapped = true;
                        }
                    }
                    else
                    {
                        if (varArray[varCount].CompareTo(varArray[varCount + 1]) < 0)
                        {
                            opSwap(varArray, varCount, varCount + 1);
                            varSwapped = true;
                        }
                    }
                }

                varStart++;
            } while (varSwapped);
            opToItems(varArray, attLength);
            attItsOrderedAscending = prmInAscending;
            attItsOrderedDescending = !prmInAscending;
            return true;
        }
        public void opSwap(T[] prmVarArray, int prmLow, int prmHigh)
        {
            T varTemp = prmVarArray[prmLow];
            prmVarArray[prmLow] = prmVarArray[prmHigh];
            prmVarArray[prmHigh] = varTemp;
        }
        #endregion
        #endregion
    }
}