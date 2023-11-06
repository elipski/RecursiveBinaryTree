using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rextester
{

    // expanded Node class
    public sealed class Node
    {

        public Node(int value, Node[] children = null)
        {
            this.Value = value;
            this.Children = children;

        }
        public int Value { get; set; }

        public Node[] Children { get; set; } 
    }


    public class Program

    {
        static int total = 0;
        public static Node[] sumNodes(Node node)
        {
            total += node.Value;
            Console.WriteLine("node.Value: " + node.Value);
            Node[] next = node.Children;
            if (next != null)
                foreach(var nn in next) sumNodes(nn);
            return next;
        }  

        public static void Main(string[] args)
        {

            //var n = new Node(1, new Node[] { new Node(2, new Node[] { new Node(4), new Node(7), new Node(2) }), new Node(-1, new Node[] { new Node(3) }) });
            var n = new Node(1, new Node[] { new Node(2, new Node[] { new Node(4), new Node(7), new Node(2) }), new Node(-1, new Node[] { new Node(3, new Node[] { new Node(4), new Node(6) }) }) });
            sumNodes(n);
            Console.WriteLine("Total: " + total);

        }

    }
}

