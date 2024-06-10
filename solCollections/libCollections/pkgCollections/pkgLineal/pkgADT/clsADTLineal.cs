﻿using pkgServices.pkgCollections.pkgIterator;
using pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;

namespace pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTLineal<T> : clsIterator<T>, iADTLineal<T> where T : IComparable<T>
    {
        #region Attributes
        protected static int attMaxCapacity = int.MaxValue / 16;
        protected bool attitsOrdenedAscending = false;
        protected bool attitsOrdenedDescending = false;
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
            return attitsOrdenedAscending;
        }
        public bool opItsOrderedDescending()
        {
            return attitsOrdenedDescending;
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
            #region Validations
            if (attLength == 0) return false;
            if (prmInAscending && attitsOrdenedAscending) return true;
            if (!prmInAscending && attitsOrdenedDescending) return true; 
            #endregion

            T[] varArray = opToArray();

                if (prmInAscending)
                {
                    for (int i = 0; i < attLength - 1; i++)
                    {
                        for (int varCount = 0; varCount < attLength - 1 - i; varCount++)
                        {
                            if (varArray[varCount].CompareTo(varArray[varCount + 1]) > 0)
                            {
                                T varTemCopy = varArray[varCount];
                                varArray[varCount] = varArray[varCount + 1];
                                varArray[varCount + 1] = varTemCopy;
                            }
                        }
                    }
                    attitsOrdenedAscending = true;
                    attitsOrdenedDescending = false;
                }
                else
                {
                    for (int i = 0; i < attLength - 1; i++)
                    {
                        for (int j = 0; j < attLength - 1 - i; j++)
                        {
                            if (varArray[j].CompareTo(varArray[j + 1]) < 0)
                            {
                                T varTemCopy = varArray[j];
                                varArray[j] = varArray[j+1];
                                varArray[j+1] = varTemCopy;
                            }
                        }
                    }
                    attitsOrdenedAscending = false;
                    attitsOrdenedDescending = true;
                }
            return true;
        }
        public bool opQuickSort(bool prmInAscending)
        {
            #region Validations
            if (attLength == 0) return false;
            if (prmInAscending && attitsOrdenedAscending) return true;
            if (!prmInAscending && attitsOrdenedDescending) return true;
            #endregion
            T[] varArray = opToArray();
            int varLow = 0;
            int varHigh = attLength-1;

            opQuickSort(varArray, varLow, varHigh);
            void opQuickSort(T[] prmArray, int prmLow, int prmHigh)
            {
                if (prmLow < prmHigh)
                {
                    int varPivote = opPartition(prmArray, prmLow, prmHigh);
                    opQuickSort(prmArray, prmLow, varPivote - 1);
                    opQuickSort(prmArray, varPivote + 1, varPivote - 1);
                }
                if (prmInAscending)
                {
                    attitsOrdenedAscending = true;
                    attitsOrdenedDescending = false;
                }
                else
                {
                    attitsOrdenedAscending = false;
                    attitsOrdenedDescending = true;
                }
            }
            int opPartition(T[] prmVarArray, int prmLow, int prmHigh)
            {
                T varPivote = prmVarArray[prmHigh];
                int i = prmLow - 1;

                if(prmInAscending){
                    for (int varCount = prmLow; varCount < prmHigh; varCount++)
                    {
                        if (prmVarArray[varCount].CompareTo(varPivote) < 0)
                        {
                            i++;
                            opSwap(prmVarArray, i, varCount);
                        }
                    }
                }
                else
                {
                    for (int varCount = prmLow; varCount < prmHigh; varCount++)
                    {
                        if (prmVarArray[varCount].CompareTo(varPivote) > 0)
                        {
                            i++;
                            opSwap(prmVarArray, i, varCount);
                        }
                    }
                }
                opSwap(prmVarArray, i + 1, prmHigh);

                return i + 1;
            }
            void opSwap(T[] prmVarArray, int prmLow, int prmHigh)
            {
                T varTemp = prmVarArray[prmLow];
                prmVarArray[prmLow] = prmVarArray[prmHigh];
                prmVarArray[prmHigh] = varTemp;
            }

            return true;
        }
        public bool opMergeSort(bool prmInAscending)
        {
            #region Validations
            if (attLength == 0) return false;
            if (prmInAscending && attitsOrdenedAscending) return true;
            if (!prmInAscending && attitsOrdenedDescending) return true;
            #endregion
            T[] varArray = opToArray();

            return true;
        }
        public bool opInsertSort(bool prmInAsending)
        {
            throw new NotImplementedException();
        }
        public bool opCocktailSort(bool prmInAsending)
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}