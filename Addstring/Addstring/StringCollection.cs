using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AddString
{
    class StringCollection : IStringCollection
    {
        private Node _nodeStack;

        public StringCollection()
        {
        }

        public void AddString(string s)
        {
            Node newNode = new Node(s);
            if (Interlocked.CompareExchange(ref _nodeStack, newNode, newNode.Next) == newNode.Next )
            {
                return;
            }
            else
            {
                SpinWait spin = new SpinWait();
                do
                {
                    spin.SpinOnce();
                    newNode.Next = _nodeStack;
                }
                while (Interlocked.CompareExchange(ref _nodeStack, newNode, newNode.Next) != newNode.Next);
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Node current = _nodeStack;
            while(current != null)
            {
                builder.Append(current.Item);

                if (current.Next != null)
                {
                    builder.Append(',');
                }
            }
            return builder.ToString();
        }

        private class Node
        {
            public string Item { get; set; }
            public Node Next { get; set; }

            public Node(string val)
            {
                Item = val;
            }
        }
    }

}
