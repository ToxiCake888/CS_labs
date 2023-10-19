using System;


class asdsadas
{

    static void Main()
    {
        int[] arr =new int[10];
        int el_zero_counter = 0, el_noteven_endfive = 0, el_noteven_endfive_sum=0, el_max = 0, el_min = 100,sum=0 , el_max_pos =0 , el_min_pos = 0 , even=0 , not_even=0, el_endnine_divthree=0 , el_endnine_divthree_sum = 0;
        long multiplication = 1;

        for (int i = 0; i < 10; i++)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 101);
            arr[i] = number;

            sum += number;
            multiplication *= number;

            if (number % 2 == 0)
            {
                even += 1;
                if (number == 0)
                {
                    even -= 1;
                    el_zero_counter += 1;
                    el_min = 0;
                }
            }
            else
            {
                not_even += 1;
                if (number % 5 == 0 && number % 10 != 0)
                {
                    el_noteven_endfive += 1;
                    el_noteven_endfive_sum += number;
                }
                if ((number-9) % 10 == 0 && number % 3 == 0)
                {
                    el_endnine_divthree_sum += number;
                    el_endnine_divthree += 1;
                }
            }
            if (number > el_max)
            {
                el_max = number;
                el_max_pos = i;
            }
            if (number < el_min)
            {
                el_min = number;
                el_min_pos = i;
            }


        }

    foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("sum " + sum);
        Console.WriteLine("multiplication " + multiplication);

        Console.WriteLine("even "+even);
        Console.WriteLine("not even " + not_even);
        Console.WriteLine("zero elements " + el_zero_counter);

        Console.WriteLine("not even , end with five " + el_noteven_endfive);
        Console.WriteLine("not even , end with five sum " + el_noteven_endfive_sum);

        Console.WriteLine("max " + el_max);
        Console.WriteLine("max position " + el_max_pos);
        Console.WriteLine("min " + el_min);
        Console.WriteLine("min position " + el_min_pos);

        Console.WriteLine("end 9, div 3 " + el_endnine_divthree);
        Console.WriteLine("end 9, div 3 sum " + el_endnine_divthree_sum);
    }
}
