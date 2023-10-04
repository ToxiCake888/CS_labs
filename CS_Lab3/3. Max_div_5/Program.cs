class golovoi_po_klave_sdfghjkhggfhjk
{
    static void Main()
    {
        
        int quantity_test()                                                     //func to check quantity < 1000
        {
            Console.WriteLine("quantity of numbers (under 1000) ");
            int quantity_check = Convert.ToInt32(Console.ReadLine());   
            if (quantity_check <1000)
            {
                return quantity_check;
            }
            else
            {
                return quantity_test();
            }
                
        }                                                                       //check end
        int quantity = quantity_test();
        
        int[] Arr_test = new int[quantity];
        for (int i = 0; i < quantity; i++)
        {

            int num_test()                                                      //num check
            {
                Console.WriteLine("insert numbers (under 30000) ");
                int num_check = Convert.ToInt32(Console.ReadLine());
                if (num_check < 30000)
                {
                    return num_check;
                }
                else
                {
                    return num_test();
                }
            }                                                                   //end num check

            int a = num_test();
            Arr_test[i] = a;
        }

        Array.Sort(Arr_test, 0, quantity);

        for (int i = 0; i < quantity;i++)                                       //write first element % 5 == 0
        {
            if (Convert.ToInt32(Arr_test[i]) % 5 == 0)
            {
                Console.Write("Answer: ");
                Console.WriteLine(Arr_test[i]);
                break;
            }
        }
        /*
         * foreach (var n in Arr_test)                                             // array write to debug
        {
            Console.Write(n);
            Console.Write(" ");
        }
        */
    }
}