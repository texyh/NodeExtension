using Mailjet.Client;
using Mailjet.Client.Resources;
using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //var root = new Node(
            //    1,
            //    new Node(
            //        2, new Node(4)),
            //    new Node(
            //        3, new Node(5, new Node(6))));

            //var n = root;
            //while (n != null)
            //{
            //    Console.WriteLine(n.Data);
            //    n = n.Next();
            //}
        }
    }

    public class Node
    {
        private List<Node> _children;

        public Node(int data, params Node[] nodes)
        {
            Data = data;
            AddRange(nodes);
        }

        public Node Parent { get; set; }

        public IEnumerable<Node> Children
        {
            get
            {
                return _children != null
                    ? _children
                    : Enumerable.Empty<Node>();
            }
        }

        public int Data { get; private set; }

        public void Add(Node node)
        {
            Debug.Assert(node.Parent == null);

            if (_children == null)
            {
                _children = new List<Node>();
            }

            _children.Add(node);
            node.Parent = this;
        }

        public void AddRange(IEnumerable<Node> nodes)
        {
            foreach (var node in nodes)
            {
                Add(node);
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
