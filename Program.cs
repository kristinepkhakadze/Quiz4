using System;
using System.Linq;
using System.Collections.Generic;



                 Console.WriteLine("-------- First Problem ---------");

int[] arr = new int[] { 1, 2, 4, 2, 5, 23, 1 };
Console.Write("The numbers in the array  are : \n");
Console.Write("  1, 2, 4, 2, 5, 23, 1\n");

var n = from x in arr
group x by x into y
select y;
Console.WriteLine("\nThe number and the Frequency are : \n");
foreach (var arrNo in n)
{
Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
}


                 Console.WriteLine("-------- Second Problem ---------");

 string str;

    Console.WriteLine("\nLINQ : Display the characters and frequency of character from giving string");
    Console.WriteLine("Input the string : ");
    str = Console.ReadLine();
    Console.Write("\n");

    var FreQ = from x in str
               group x by x into y
               select y;
    Console.Write("The frequency of the characters are :\n");
    foreach (var ArrEle in FreQ)
    {
        Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
    }


                 Console.WriteLine("-------- Third Problem ---------");

Console.WriteLine("\nLINQ : Find the uppercase words in a string : ");
string strNew;

Console.Write("Input the string : ");
strNew = Console.ReadLine();

var ucWord = WordFilt(strNew);
Console.Write("\nThe UPPER CASE words are :\n ");
foreach (string strRet in ucWord)
{
    Console.WriteLine(strRet);
}

	static IEnumerable<string> WordFilt(string mystr)
{
    var upWord = mystr.Split(' ')
                .Where(x => String.Equals(x, x.ToUpper(),
                StringComparison.Ordinal));

    return upWord;

}

                Console.WriteLine("-------- Forth Problem ---------");



                Console.WriteLine("-------- Fifth Problem ---------");

string str1 = "aabbddd fffffff";

var mostFrequentCharacter = str1.GroupBy(c => c).OrderByDescending(c => c.Count()).First().Key;

Console.Write("\nMost frequent character is :\n");
Console.Write(mostFrequentCharacter);
        
	