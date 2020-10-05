using Mailjet.Client;
using Mailjet.Client.Resources;
using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Mailjet.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse("2", out var result);
            Console.WriteLine(result);
            var a = new Dictionary<string, string>();
            a.Add("2", null);
            var b = a.FirstOrDefault(x => x.Value == null);
       
            a.Add(a.Count.ToString(), "ddd");
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
