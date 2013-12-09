using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SandwichMaker2
{
    class Sandwich
    {

        private int[] sandwichConstruction;
        private int currentSize;

        public int Size { get; private set;}
        public string Name { get; set; }
        public double Calories { get; private set; }

        public Sandwich()
        {
            sandwichConstruction = new int[10];
            sandwichConstruction[0] = 100;
            sandwichConstruction[1] = 200;
            Size = 10;
            currentSize = 2;
        }

        public void AddProduct(int id)
        {
            if (currentSize < Size)
            {
                sandwichConstruction[currentSize - 1] = id;
                sandwichConstruction[currentSize] = 200;
                currentSize++;
            }
            else
            {
                // BURGER IS VOL
            }
        }

        public void DeleteProduct(int pos)
        {
            if (sandwichConstruction[pos - 1] != 100 && sandwichConstruction[pos - 1] != 200)
            {
                sandwichConstruction = RemoveIndices(sandwichConstruction, pos-1);
                currentSize--;
            }
        }

        public void MoveProductUp(int pos)
        {
            if (sandwichConstruction[pos - 1] != 100) // FIX IF
            {
                int a = sandwichConstruction[pos - 1];
                int b = sandwichConstruction[pos];

                sandwichConstruction[pos - 1] = b;
                sandwichConstruction[pos] = a;
            }
        }

        public void MoveProductDown(int pos)
        {
            if (sandwichConstruction[pos - 1] != 100) // FIX IF
            {
                int a = sandwichConstruction[pos - 2];
                int b = sandwichConstruction[pos-1];

                sandwichConstruction[pos - 2] = b;
                sandwichConstruction[pos-1] = a;
            }
        }

        public int GetConstruction(int id)
        {
            return sandwichConstruction[id];
        }

        public void MakeSandwich()
        {

        }

        private int[] RemoveIndices(int[] IndicesArray, int Pos)
        {
            int[] newIndicesArray = new int[IndicesArray.Length];

            int i = 0;
            int j = 0;
            while (i < IndicesArray.Length)
            {
                if (i != Pos)
                {
                    newIndicesArray[j] = IndicesArray[i];
                    j++;
                }
                i++;
            }
            return newIndicesArray;
        }
    }
}
