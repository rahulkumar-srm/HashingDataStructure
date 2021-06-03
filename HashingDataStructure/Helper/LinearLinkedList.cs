using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingDataStructure.Helper
{
    internal class LinearLinkedList
    {
        internal Node SortedInsert(ref Node node, int num)
        {
            Node tempNode, prevNode, newNode;

            newNode = new Node(num);
            tempNode = node;
            prevNode = null;

            if (node == null)
            {
                node = newNode;
            }
            else
            {
                while (tempNode != null && tempNode.Data < num)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.Next;
                }

                if (tempNode == node)
                {
                    newNode.Next = node;
                    node = newNode;
                }
                else
                {
                    prevNode.Next = newNode;
                    newNode.Next = tempNode;
                }
            }

            return node;
        }

        internal Node Search(Node node, int key)
        {
            while (node != null)
            {
                if (node.Data == key)
                {
                    return node;
                }

                node = node.Next;
            }

            return null;
        }
    }
}
