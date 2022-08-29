   Console.Write("Enter a number to check if palindrome: ");
    int a = int.Parse(Console.ReadLine());

        string str = a.ToString();
        if(str[0]==str[4] && str[1]==str[3])
        {
            Console.WriteLine( "Палиндром");
        }
    else
    {
        Console.WriteLine( "Не палиндром"); 
    }