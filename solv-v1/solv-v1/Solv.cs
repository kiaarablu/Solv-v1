using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_v1
{



    public class Box
    {
        public int Value;
        public Box Address;
    }
    public class Process
    {
        public bool BoxIsNull()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        Box head = null;
        public void AddFirst(int meghdar)
        {

            if (BoxIsNull())
            {
                Box first = new Box();
                head = first;
                head.Value = meghdar;
                head.Address = null;
            }
            else
            {
                Box secound = new Box();
                secound.Value = meghdar;
                secound.Address = head;
                head = secound;

            }

        }
        public void AddLast(int val)
        {
            if (BoxIsNull())
            {

                Box last = new Box();
                last.Value = val;
                last.Address = null;
                head = last;
            }
            else
            {
                Box box = new Box();
                box.Value = val;
                Box box1 = head;

                while (box1.Address != null)
                {
                    box1 = box1.Address;
                }
                box1.Address = box;
                box.Value = val;
            }
        }
        public void Solve(Box start)
        {
            if (start == null)
            {
                return;
            }
            Console.WriteLine(start.Value);
            if (start.Address != null)
            {
                Solve(start.Address.Address);
            }

            Console.WriteLine(start.Value);
        }
        public void printsolv()
        {
            Solve(head);
        }

        public void Print()
        {
            var crnt = head;
            while (crnt != null)
            {
                Console.WriteLine(crnt.Value);
                crnt = crnt.Address;
            }

        }


    }
}



