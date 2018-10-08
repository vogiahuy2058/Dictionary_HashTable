using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    public class Node
    {
        public Word word; 
        public Node pNext; 

        public Node()
        {
            word = new Word(null, null);
            pNext = null;
        }
        public void CreateNode(Word wd)
        {
            word.Name = wd.Name;
            word.Meaning = wd.Meaning;
            pNext = null;
        }
        public void Next(Node x)
        {
            pNext = x; // ham thay doi pNext
        }
        public Word GetWord()
        {
            return word;
        }
        public Node GetNext()
        {
            return pNext;
        }
    }
}
