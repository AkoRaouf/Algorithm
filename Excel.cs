using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Excel
{
    public string ConvertToTitle(int n)
    {
        List<char> list = new List<char>();
        for (; n > 0; n /= 26) list.Add((char)('A' + --n % 26));

        list.Reverse();
        return new string(list.ToArray());
    }
}