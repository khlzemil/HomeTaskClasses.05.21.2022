using System;

class HomeWork
{
    public static void Main()
    {
        int[] CustomSort1 = {8, 5, 9, 3, 4, 7, 1};
        CustomSort(CustomSort1);
    }


    static void CustomSort(int[] arr)
    {
   
        int change = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    change = arr[i];
                    arr[i] = arr[j];
                    arr[j] = change;
                }
            }
           
        }    
        foreach (int item in arr)
        {
            Console.WriteLine(item);

        }
    }
}
            