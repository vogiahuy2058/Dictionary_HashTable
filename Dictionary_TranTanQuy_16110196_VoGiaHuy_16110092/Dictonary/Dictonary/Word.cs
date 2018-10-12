using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Trần Tấn Quý
namespace Dictonary
{
    public class Word
    {
        private string name;
        private string meaning;
        public Word(string name, string meaning)
        {
            this.name = name;
            this.meaning = meaning;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Meaning
        {
            set { meaning = value; }
            get { return meaning; }
        }
    }
}
