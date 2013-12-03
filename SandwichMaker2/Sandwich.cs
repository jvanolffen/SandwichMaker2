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

        }

        public void MoveProductUp(int pos)
        {

        }

        public void MoveProductDown(int pos)
        {

        }

        public int GetConstruction(int id)
        {
            return sandwichConstruction[id];
        }

        public void MakeSandwich()
        {

        }
    }
}
