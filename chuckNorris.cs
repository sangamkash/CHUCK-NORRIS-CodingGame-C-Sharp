using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        var str = ToBinary(ConvertToByteArray(MESSAGE, Encoding.ASCII)).ToCharArray();
        bool changed = true;
        var output = "";
        var Lastbit = '_';
        Console.Error.WriteLine($"{MESSAGE} || {new string(str)}");
        for (var i = 0; i < str.Length; i++)
        {
            changed = Lastbit != str[i];
            if (changed)
            {
                if (i != 0)
                {
                    output += " ";
                }
                if (str[i] == '0')
                {
                    output += "00 0";
                }
                else
                {
                    output += "0 0";
                }
            }
            else
            {
                output += "0";
            }
            Lastbit = str[i];
        }
        Console.WriteLine(output);
    }

    public static byte[] ConvertToByteArray(string str, Encoding encoding)
    {
        return encoding.GetBytes(str);
    }
    public static String ToBinary(Byte[] data)
    {
        return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(7, '0')));
    }
}
