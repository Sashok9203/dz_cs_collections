using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class TowersOfHanoi
    {
        private Tower tower1,tower2,tower3;
        private readonly int diskCount;
        private readonly int maxLength;
        private int steps; 
        public TowersOfHanoi(int diskCount ,int printDelay,int X,int Y)
        {
            steps = 1;
            this.diskCount = diskCount;
            maxLength = diskCount * 2 - 1;
            tower1 = new(diskCount, maxLength, printDelay, X, Y);
            tower1.Init();
            tower2 = new(diskCount, maxLength, printDelay, X+ maxLength +3, Y);
            tower3 = new(diskCount, maxLength, printDelay, X + (maxLength + 3)*2, Y);
        }
        public void Start()
        {
            tower1.DrawChange = true;
            tower2.DrawChange = true;
            tower3.DrawChange = true;
            while (tower3.Count != diskCount)
            {

                if (tower3.Count == 0 && tower1.Count != 0 || tower1.Count != 0 && tower1.Peek() < tower3.Peek())
                        tower3.Push(tower1.Pop());
                else if (tower1.Count == 0 && tower3.Count != 0 || tower3.Count != 0 && tower3.Peek() < tower1.Peek())
                        tower1.Push(tower3.Pop());
                  
                if (tower2.Count == 0 && tower1.Count != 0 || tower1.Count != 0 && tower1.Peek() < tower2.Peek())
                        tower2.Push(tower1.Pop());
                else if (tower1.Count == 0 && tower2.Count != 0 || tower2.Count != 0 && tower2.Peek() < tower1.Peek())
                        tower1.Push(tower2.Pop());

                if (tower3.Count != diskCount)
                {
                    if (tower3.Count == 0 && tower2.Count != 0 || tower2.Count != 0 && tower2.Peek() < tower3.Peek())
                        tower3.Push(tower2.Pop());
                    else if (tower2.Count == 0 && tower3.Count != 0 || tower3.Count != 0 && tower3.Peek() < tower2.Peek())
                        tower2.Push(tower3.Pop());
                }
            }

        }
    }
}
