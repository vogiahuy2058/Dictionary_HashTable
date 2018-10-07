using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    public class BangBam
    {
        public int Bam(char c)
        {
            if (c >= 'A' && c <= 'Z')       //nếu ký tự đầu là chữ in hoa từ A->Z, cộng 32 để chuyển
                c = (char)((int)c + 32);    //sang chữ thường, sau đó ép kiểu int cho ký tự
            return (int)c % 97;             //và hash với key là 97
        }
    }
}
