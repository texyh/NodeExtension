using ConsoleApp2;
using Mailjet.ConsoleApplication;
using System;
using Xunit;

namespace Test
{
    public class NodeExtensionsShould
    {
        [Fact]
        public void Return_Next_Node1()
        {
            var root = new Node(
                1,
                new Node(
                    2),
                new Node(
                    5));

            var n = root;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next();
            }

            // Test
            //
            n = root;
            Assert.Equal(1, n.Data);
            n = n.Next();
            Assert.Equal(2, n.Data);
            //n = n.Next();
            //Assert.Equal(3, n.Data);
            //n = n.Next();
            //Assert.Equal(4, n.Data);
            n = n.Next();
            Assert.Equal(5, n.Data);
            n = n.Next();
            //Assert.Equal(6, n.Data);
            //n = n.Next();
            //Assert.Equal(7, n.Data);
            //n = n.Next();
            
            Assert.Null(n);
        }

        [Fact]
        public void Return_Next_Node2()
        {
            var root = new Node(
                1,
                new Node(
                    2,
                    new Node(3),
                    new Node(4, new Node(9), new Node(10)),
                    new Node(8)),
                new Node(
                    5,
                    new Node(6),
                    new Node(7)));

            var n = root;
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next();
            }

            // Test
            //
            n = root;
            Assert.Equal(1, n.Data);
            n = n.Next();
            Assert.Equal(2, n.Data);
            n = n.Next();
            Assert.Equal(3, n.Data);
            n = n.Next();
            Assert.Equal(4, n.Data);
            n = n.Next();
            Assert.Equal(9, n.Data);
            n = n.Next();
            Assert.Equal(10, n.Data);
            n = n.Next();
            Assert.Equal(8, n.Data);
            n = n.Next();
            Assert.Equal(5, n.Data);
            n = n.Next();
            Assert.Equal(6, n.Data);
            n = n.Next();
            Assert.Equal(7, n.Data);
            n = n.Next();
            Assert.Null(n);
        }
    }
}
