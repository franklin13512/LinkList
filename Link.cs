using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                Number++;
            }
            else
            {
                Node PreNode = Head;
                for (int i = 0; i <Index - 1 ; i++)
                {
                    PreNode = PreNode.Next;
                }

                Node NewNode = new Node(Data);
                NewNode.Next = PreNode.Next;
                PreNode.Next = NewNode;

                Number++;
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

        public T GetData(int Index)
        {
            if (Index < 0 || Index > Number)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }
            else
            {
                Node CurNode = Head;
                for (int i = 0; i < Index; i++)
                {
                    CurNode = CurNode.Next;
                }

                return CurNode.Data;
            }
        }

        public T GetFirstData()
        {
            return GetData(0);
        }

        public T GetLastData()
        {
            return GetData(Number - 1);
        }

        public void SetData(int Index, T NewData)
        {
            if (Index < 0 || Index > Number)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }
            else
            {
                Node CurNode = Head;
                for (int i = 0;i < Index ;i++)
                {
                    CurNode = CurNode.Next;
                }
                CurNode.Data = NewData;
            }
        }

        public bool IsContain(T TData)
        {
            Node CurNode = Head;
            for (int i = 0; i < Number; i++)
            {
                if (CurNode.Data.Equals(TData))
                {
                    return true;
                }
                CurNode = CurNode.Next;
            }
            return false;
        }

        public T RemoveByIndex(int Index)
        {
            if (Index < 0 || Index > Number)
            {
                throw new ArgumentOutOfRangeException("溢出");
            }

            if (Index == 0)
            {
                Node DelNode = Head;
                Head = Head.Next;
                Number--;

                return DelNode.Data;
            }
            else
            {
                Node PreNode = Head;
                for(int i = 0; i < Index - 1 ; i++)
                {
                    PreNode = PreNode.Next;
                }

                Node DelNode = PreNode.Next;
                PreNode.Next = DelNode.Next;
                Number--;

                return DelNode.Data;

            }
        }

        public void RemoveByData(T TData)
        {
            if (Head.Data.Equals(TData))
            {
                Head = Head.Next;
                Number--;
            }
            else
            {
                Node PreNode = null;
                Node CurNode = Head;

                while (CurNode != null)
                {
                    if (CurNode.Data.Equals(TData))
                    {
                        break;
                    }

                    PreNode = CurNode;
                    CurNode = CurNode.Next;
                }

                if (CurNode != null)
                {
                    //PreNode.Next = PreNode.Next.Next;
                    PreNode.Next = CurNode.Next;
                    Number--;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder AllNode = new StringBuilder();
            Node CurNode = Head;
            while (CurNode != null)
            {
                AllNode.Append(CurNode.Data + " => ");
                CurNode = CurNode.Next;
            }
            AllNode.Append("Null");

            return AllNode.ToString();
        }
    }
}
