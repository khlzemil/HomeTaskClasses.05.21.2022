using System;

class HomeWork
{
    public static void Main()
    {

        CheckWord('T', "Emil Quluzade", "Tural Ismayilov", "Elnur Abiyev");

    }

    static void CheckWord(char checkLetter, params string[] word)
    {
        string[] CheckedArr = new string[0];
        int k = 0;
        for(int i = 0; i < word.Length; i++)
        {
            foreach (char item in word[i])
            {
                if(item == checkLetter)
                {
                    Array.Resize(ref CheckedArr, i+1);
                   CheckedArr[k] = word[i];
                  k++;
                }
            }
        } 
        foreach(string elem in CheckedArr)
        {
            Console.WriteLine(elem);
        }
    }


}