using System;

class adsad
{
    static void Main()
    {
        int counter = 0;
        int[] arr = new int[5] { 0,1,2,3,4};
        foreach (int i in arr)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (i > 0)
            {
                if (arr[i] > arr[i - 1])
                {
                    counter+=1;
                }
                else if(arr[i] < arr[i - 1])
                {
                    counter-=1;
                }
            }
        }
     
        if (counter == 4)
        {
            Console.WriteLine("vozrastaet");
        }
        else if(counter == -4)
        {
            Console.WriteLine("ybuviaet");
        }
        else
        {
            Console.WriteLine("ne uporiadochen");
        }
    }
}