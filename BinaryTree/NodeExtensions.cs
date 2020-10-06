using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public static class NodeExtensions
    {
        public static Node Next(this Node node)
        {
            Node currentNode = node;
            Node currrentParentNode = node.Parent;

            var nextNode = node?.Children?.FirstOrDefault(x => x != null);
            
            while (nextNode == null && currrentParentNode != null)
            {
                var currentParentNodeChildren = currrentParentNode.Children;
                var currentNodeIndex = currentParentNodeChildren.ToList().FindIndex(x => x.GetHashCode() == currentNode.GetHashCode());
                nextNode = currentParentNodeChildren.Skip(currentNodeIndex + 1).Take(currentParentNodeChildren.Count() - 1 - currentNodeIndex)?.FirstOrDefault();
                currentNode = currrentParentNode;
                currrentParentNode = currrentParentNode.Parent;
            }

            return nextNode;
        }

    }
}
