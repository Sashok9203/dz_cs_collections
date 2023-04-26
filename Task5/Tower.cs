using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Tower 
    {
        private Stack<int> tower;
        private int maxLength;
        private int diskCount;
        private int printDelay;

        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public bool DrawChange { get; set; }
        public Tower(int diskCount,int maxLenght,int pDelay, int X, int Y)
        {
            Xpos = X;
            Ypos = Y;   
            tower = new();
            printDelay = pDelay;
            this.maxLength = maxLenght;
            this.diskCount = diskCount;
        }
        public void Init()
        {
            for (int i = maxLength; i > 0; i -= 2)
                tower.Push(i);
        }
        public void Push(int value)
        {
            tower.Push(value);
            if (DrawChange) Print(printDelay);
        }

        public int Peek() => tower.Peek();

        public int Pop()
        {
            int tmp = tower.Pop();
            if (DrawChange) Print(0);
            return tmp;
        }

        public int Count => tower.Count;

        public bool IsEmpty => tower.Count == 0;

        public void Print( int printDelay)
        {
            string tmp = new string(' ', maxLength);
            for (int i = 0; i < diskCount; i++)
            {
                Console.SetCursorPosition(Xpos, Ypos + i);
                Console.Write(tmp);
            }
                 
            int Y = Ypos;
            int X = Xpos;   
            Y += diskCount - tower.Count;
            Console.SetCursorPosition(Xpos, Ypos);
            foreach (var item in tower)
            {
                Console.SetCursorPosition(X + (maxLength - item) / 2, Y++);
                Console.Write(new string('*', item));
            }
            Thread.Sleep(printDelay);
        }

    }
}
