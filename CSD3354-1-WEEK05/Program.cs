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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node myNode = new Node("Ground Floor");
            myNode.next = new Node("First Floor");
            myNode.next.next = new Node("Second Floor");

            myNode.Print();
        }
    }
}
