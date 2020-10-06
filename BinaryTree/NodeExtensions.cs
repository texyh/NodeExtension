using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BinaryTree
{
    public static class NodeExtensions
    {
        public static Node Next(this Node node)
        {
            Node currentNode = node;
            Node currrentParentNode = node.Parent;

            var nextNode = node?.Children?.FirstOrDefault();
            
            while (nextNode == null && currrentParentNode != null)
            {
                var currentParentNodeChildren = currrentParentNode.Children.ToArray();
                var currentNodeIndex = Array.FindIndex(currentParentNodeChildren,  x => x.GetHashCode() == currentNode.GetHashCode());
                nextNode = currentNodeIndex < currentParentNodeChildren.Count() - 1 ? currentParentNodeChildren[currentNodeIndex + 1] : null;
                currentNode = currrentParentNode;
                currrentParentNode = currrentParentNode.Parent;
            }

            return nextNode;
        }

        //public static Node(this IEnumerable<Node> nodes ) GetNext

    }
}
