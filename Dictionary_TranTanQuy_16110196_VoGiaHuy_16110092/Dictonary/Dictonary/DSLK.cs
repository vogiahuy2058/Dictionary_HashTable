using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    public class DSLK
    {
        public Node Head;
        public Node Tail;

        public DSLK()
        {
            Head = Tail = null;
        }
        public void AddHead(Node p)
        {
            if (Head == null)
                Head = Tail = p;
            else
            {
                p.Next(Head);
                // Cach 2:
                // p.pNext = Head;
                Head = p;
            }
        }
        public void AddTail(Node p)
        {
            if (Head == null)
                Head = Tail = p;
            else
            {
                Tail.Next(p);
                Tail = p;
            }
        }
        public void Duyet()
        {
            Node p = Head;
            try
            {
                if (p == null)
                    throw new Exception("Empty List");
                while (p != null)
                {
                    Console.WriteLine("{0} {1}", p.word.Name, p.word.Meaning);
                    p = p.pNext;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Node Search(string s)
        {
            Node p = Head;
            while (p != null)
            {
                if (p.GetWord().Name == s)
                    return p;
                p = p.pNext;
            }
            return null;
        }
        public Node SearchTruoc(string s)
        {
            Node p = Head.pNext;
            Node q = Head;
            if (Head != Tail)
            {
                while (p != null)
                {
                    if (p.GetWord().Name == s)
                        return q;
                    p = p.pNext;
                    q = q.pNext;
                }
            }
            return null;
        }
        public void AddAfter(Node p, Node q)
        {
            try
            {
                if (Head == null || Head == Tail || p == null)
                    throw new Exception("Can not Add");
                q.Next(p.GetNext());
                p.Next(q);
                if (p == Tail)
                    Tail = q;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void RemoveHead()
        {
            try
            {
                if (Head == null)
                    throw new Exception("Empty List");
                Node p = Head;
                Head = p.GetNext();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void RemoveAfter(Node p)
        {
            try
            {
                if (p.pNext == null || Head == null || Head == Tail || p == null)
                    throw new Exception("Can not Remove");
                Node q = p.GetNext();
                p.Next(q.GetNext());
                if (p.GetNext() == null)
                    Tail = p;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
