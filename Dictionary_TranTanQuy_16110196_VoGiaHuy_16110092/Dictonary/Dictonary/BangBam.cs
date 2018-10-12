using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Trần Tấn Quý
namespace Dictonary
{
    public class BangBam
    {
        public DSLK[] Table;
        public BangBam()
        {
            Table = new DSLK[100];
            for (int i = 0; i < 100; i++)
                Table[i] = new DSLK(); //khởi tạo một danh sách lk với n phần tử
        }
        public int Bam(char c)
        {
            if (c >= 'A' && c <= 'Z')       //nếu ký tự đầu là chữ in hoa từ A->Z, cộng 32 để chuyển
                c = (char)((int)c + 32);    //sang chữ thường, sau đó ép kiểu int cho ký tự
            return (int)c % 97;             //và hash với key là 97
        }
        public char GetFirstChar(string s)
        {
            return s[0];        //lấy ký tự đầu tiên nhằm cho mục đích hash
        }
        public void Duyet()
        {
            for (int i = 0; i < 100; i++)
                if (Table[i].Head != null)
                    Table[i].Duyet();           //Duyệt các phần tử trong dslk
        }
        //kiểm tra từ có tồn tại hay không
        public bool Search_Check(string s)
        {
            char c = GetFirstChar(s);
            int hash = Bam(c);
            Node p = new Node();
            while (p != null)
            {
                if (p.GetWord().Name == s) return true;
                p = p.pNext;
            }
            return false;
        }
        public string Search_Lookup(string s)
        {
            char c = GetFirstChar(s);
            int hash = Bam(c);
            bool check = Search_Check(s);
            string k = null;
            try
            {
                if (check == false) throw new Exception("This word doesn't exist!");
                Node p = new Node();
                p = Table[hash].Head;
                while (p != null)
                {
                    if (p.GetWord().Name == s) k = p.GetWord().Meaning;
                    p = p.pNext;
                }
                return k;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return k;
            }
        }
        //thêm từ
        public void Add(Word wd)
        {
            char c = GetFirstChar(wd.Name);
            int hash = Bam(c);
            bool check = Search_Check(wd.Name);
            try
            {
                if (check == true) throw new Exception("This word has been added!");
                Node p = new Node();
                p.CreateNode(wd);
                Table[hash].AddTail(p);
            }
            catch (Exception e)
            {

            }

        }
        //xóa từ
        public void RemoveWord (string s)
        {
            char c = GetFirstChar(s);
            int hash = Bam(c);
            if (s == Table[hash].Head.GetWord().Name)
                Table[hash].RemoveHead();
            else
            {
                Node p = new Node();
                p = Table[hash].SearchTruoc(s);
                try
                {
                    if (Table[hash].Head == null || p == null || Table[hash].Head == Table[hash].Tail || p.pNext == null)
                        throw new Exception();
                    Table[hash].RemoveAfter(p);
                    //Node q = p.GetNext();
                    //p.Next(q.GetNext());
                    //if (p.GetNext() == null)
                    //    Table[bam].Tail = p;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        //sửa từ
        public void EditWord(string name, string meaning)
        {
            char c = GetFirstChar(name);
            int hash  = Bam(c);
            bool check = Search_Check(name);
            try
            {
                if (check == false)
                {
                    throw new Exception("This word is not had in HashTable!!!");
                }
                Node p = new Node();
                p = Table[hash].Head;
                while (p != null)
                {
                    if (p.GetWord().Name == name)
                        p.word.Meaning = meaning;
                    p = p.pNext;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
