using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProject
{
    internal class Link<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T Data, Node Next)
            {
                this.Data = Data;
                this.Next = Next;
            }

            public Node(T Data)
            {
                this.Data = Data;
                this.Next = null;
            }

            public override string ToString()
            {
                return Data.ToString();
            }

        }

        private Node Head;
        private int Number;

        public Link()
        {
            Head = null;
            Number = 0;
        }

        public int Count
        {
            get { return Number; }
        }

        public bool IsEmpty
        {
            get { return Number == 0; }
        }

        public void Add(int Index, T Data)
        {
            if (Index < 0 || Index > Number)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }

            if (Index == 0)
            {
                Node NewNode = new Node(Data);
                NewNode.Next = Head;
                Head = NewNode;
            }
            else
            {
                Node PreNode = Head;
                for (int i = 0; i < Number - 1 ; i++)
                {
                    PreNode = PreNode.Next;
                }

                Node NewNode = new Node(Data);
                NewNode.Next = PreNode.Next;
                PreNode.Next = NewNode;
            }
        }

        public void AddAtFirst(T Data)
        {
            Add(0, Data);
        }

        public void AddAtLast(T Data)
        {
            Add(Number, Data);
        }

    }
}
