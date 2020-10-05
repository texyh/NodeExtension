using Mailjet.ConsoleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public static class NodeExtensions
    {
        public static Node Next(this Node node)
        {
            Node currentNode = node;
            Node currrentParentNode = node.Parent;

            var nextNode = node?.Children?.FirstOrDefault();

            while(nextNode == null && currrentParentNode != null)
            {
                var currentParentNodeChildren = currrentParentNode.Children;
                var currentNodeIndex = currentParentNodeChildren.ToList().FindIndex(x => x.Data == currentNode.Data);
                nextNode = currentParentNodeChildren.Skip(currentNodeIndex + 1).Take((currentParentNodeChildren.Count() - 1) - currentNodeIndex)?.FirstOrDefault();
                currentNode = currrentParentNode;
                currrentParentNode = currrentParentNode.Parent;
            }

            return nextNode;
        }

    }
}
