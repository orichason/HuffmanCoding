using System.Globalization;

namespace HuffmanCoding
{
    internal class Program
    {
        static Node EncodeMessage(string message, out HashSet<char> charactersUsed)
        {
            Dictionary<char, int> charactersFrequency = new()
            {
                ['a'] = 0,
                ['b'] = 0,
                ['c'] = 0,
                ['d'] = 0,
                ['e'] = 0,
                ['f'] = 0,
                ['g'] = 0,
                ['h'] = 0,
                ['i'] = 0,
                ['j'] = 0,
                ['k'] = 0,
                ['l'] = 0,
                ['m'] = 0,
                ['n'] = 0,
                ['o'] = 0,
                ['p'] = 0,
                ['q'] = 0,
                ['r'] = 0,
                ['s'] = 0,
                ['t'] = 0,
                ['u'] = 0,
                ['v'] = 0,
                ['w'] = 0,
                ['x'] = 0,
                ['y'] = 0,
                ['z'] = 0,
            };
            charactersUsed = new();

            foreach(var character in message)
            {
                charactersFrequency[character]++;
                charactersUsed.Add(character);
            }

            PriorityQueue<Node, int> queue = new();
            

            for (char i = 'a'; i <= 'z'; i++)
            {
                if (charactersFrequency[i] > 0)
                {
                    var node = new Node(i, charactersFrequency[i]);
                    queue.Enqueue(node, node.Frequency);
                }
            }

            do
            {
                Node leftChild = queue.Dequeue();
                Node rightChild = queue.Dequeue();
                Node parent = new Node(default, leftChild.Frequency + rightChild.Frequency, leftChild, rightChild);
                queue.Enqueue(parent, parent.Frequency);
            } while (queue.Count > 1);

            return queue.Dequeue();
        }

        static byte Search(Node root, HashSet<char> charactersUsed)
        {
            Dictionary<char, byte> encodedCharacters = new();

            foreach (var character in charactersUsed)
            {
                encodedCharacters.Add(character, 0);
            }

            Node current = root;



            //int count = 0;
            //while(count < charactersUsed.Count)
            //{
            //    Node current = root;

            //    while (current != null)
            //    {
            //        if(current.LeftChild.Value != default)
            //        {
            //            encodedCharacters[current.LeftChild.Value] = (byte)current.LeftChild.Frequency;
            //        }

            //        if(current.LeftChild != null)
            //        {
            //            current = current.LeftChild;
            //        }

            //        else
            //        {
            //            if(current.RightChild != null)
            //            {
            //                current = current.RightChild;
            //            }
            //        }
            //    }
            //}
        }
        static void Main(string[] args)
        {
            Node root = EncodeMessage("mississippi", out HashSet<char> charactersUsed);

            Search(root, charactersUsed);
        }
    }
}
