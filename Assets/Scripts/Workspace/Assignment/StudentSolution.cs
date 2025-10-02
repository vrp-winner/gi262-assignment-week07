using System;
using System.Collections.Generic;
using Debug = AssignmentSystem.Services.AssignmentDebugConsole;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public void LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Debug.Log(index);
        }

        public void LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == target)
                    {
                        row = i;
                        col = j; 
                        break; // break for j
                    }
                }

                if (row != -1 && col != -1)
                {
                    break; // break for i
                }
            }

            Debug.Log($"({row}, {col})");
        }

        public void LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;
            
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                // int mid = (left + right) / 2;
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else
                {
                    if (array[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            Debug.Log(index);
        }

        #endregion

        #region Assignment

        public void AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int first = -1;
            int last = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (first == -1)
                    {
                        first = i;
                    }
                    last = i;
                }
            }

            if (first == -1)
            {
                Debug.Log("-1");
            }
            else
            {
                Debug.Log(first);
                Debug.Log(last);
            }
        }

        public void AS02_FindMaxLessThan(int[] array, int target)
        {
            Array.Sort(array);

            int result = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target)
                {
                    result = array[i];
                }
                else
                {
                    break;
                }
            }

            Debug.Log(result);
        }

        public void AS03_FindRange(int[] array, int min, int max)
        {
            Array.Sort(array);

            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    Debug.Log(array[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Debug.Log("Empty");
            }
        }

        #endregion

        #region Extra

        public void EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            Array.Sort(enemyHPs);

            int currentMana = 0;

            foreach (int hp in enemyHPs)
            {
                if (currentMana + hp <= mana)
                {
                    Debug.Log(hp);
                    currentMana += hp;
                }
                else
                {
                    break;
                }
            }
        }

        #endregion
    }
}