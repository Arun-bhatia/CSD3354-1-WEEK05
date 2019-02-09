using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_1_WEEK05
{

    public class Node
    {
        public String floor;
        public Node next;

        public Node(String fl)
        {
            floor = fl;
            next = null;
        }
        public void Print()
        {
            Console.Write("|" + floor + "|-->");
            if (next != null)
            {
                next.Print();
            }
        }
        public void AddFloor(String floor)
        {
            if (next == null)
            {
                next = new Node(floor);
            }
            else
            {
                next.AddFloor(floor);
            }
        }
    }
    //new class
    class Program
    {
        static void Main(string[] args)
        {
            Node newfloor = new Node("Ground Floor");
            newfloor.AddFloor("First Floor");
            newfloor.AddFloor("Second floor");
            newfloor.Print();
        }
    }
}
