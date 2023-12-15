class sad
{
    static void Main()
    {
        Console.WriteLine("word: ");
        string word = Console.ReadLine();

        bool isPalindrome = IsPalindrome(word);

        if (isPalindrome)
        {
            Console.WriteLine("palindrome");
        }
        else
        {
            Console.WriteLine("is not palidrome");
        }
    }

    static bool IsPalindrome(string word)
    {
        int length = word.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (word[i] != word[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
