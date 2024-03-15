using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    internal class Node
    {
        public int Frequency;
        public char Value;
        public Node LeftChild;
        public Node RightChild;

        public Node(char value, int frequency, Node leftChild = default, Node rightChild = default)
        {
            Frequency = frequency;
            Value = value;
            LeftChild = leftChild;
            RightChild = rightChild;
        }
    }
}
