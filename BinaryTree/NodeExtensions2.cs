using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public static class NodeExtensions2
    {
        public static Node Next2(this Node node)
        {
            var nextNodeData = node.Data + 1;
            Node currentNode = node;
            Node currrentParentNode = node.Parent;

            var nextNode = Find(nextNodeData, node.Children);

            while (nextNode == null && currrentParentNode != null)
            {
                nextNode = Find(nextNodeData, currrentParentNode.Children.Where(x => x.Data != currentNode.Data).ToList());
                currentNode = currrentParentNode;
                currrentParentNode = currrentParentNode.Parent;
            }

            return nextNode;
        }

        public static Node Find(int value, IEnumerable<Node> nodeChildren)
        {
            if (nodeChildren == null || !nodeChildren.Any())
            {
                return null;
            }

            var nextNode = nodeChildren.FirstOrDefault(x => x.Data == value);

            if (nextNode == null)
            {
                foreach (var node in nodeChildren)
                {
                    if (node.Data == value)
                    {
                        return node;
                    }

                    nextNode = Find(value, node.Children);

                    if (nextNode != null)
                    {
                        break;
                    }
                }
            }

            return nextNode;
        }

    }
}
