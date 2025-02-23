namespace learning;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello World!"); //This prints while adding a new line at the end
        // Console.ReadLine(); //Waits for person to enter a char

        int age = 23; //Initializing and Declaring in the same line OR
        int age2; //Initializing first
        age2 = 16; //Declaring then
        Console.WriteLine(age2);
        
        //Other Datatypes
        long bigNumber = 9007199254740992L; //The 'l' tells it that it is a long
        Console.WriteLine(long.MaxValue);
        
        double negative = -55.2D;
        Console.WriteLine(negative);
        
        float precision = 3.14F; //C# compiler always thinks of decimals as doubles so you need to mention 'F' at the end.
        Console.WriteLine(precision);
        
        //We can also initialize like this
        int a = 10,
            b = 20,
            c = 30;
        //This makes the code look cleaner and we need to add less int.

        string name = "Neil"; //You need to add speech marks for strings
        char letter = 'a'; //and single quotation marks for chars
        Console.WriteLine(letter);

        string textAge = "16";
        int age3 = Convert.ToInt32(textAge); //Converts string to int 32 bit
        Console.WriteLine(age3);

        string textFloat = "22.23";
        float float2 = Convert.ToSingle(textFloat); //for this we need to convert to single because by definition, a float is a single.
        Console.WriteLine(float2);

        bool value = true;
        bool isMale = true;

        // string test;
        // test = Console.ReadLine(); //This can be used to input datd
        // Console.WriteLine(test);

        age3++; //increment by 1 //if the ++ is before then the increment is done before
        Console.WriteLine(age3);
        age3--; //decrement by 1
        Console.WriteLine(age3);
        
        string textString = "Hello World!";
        textString += "My name is Neil Arora!";
        Console.WriteLine(textString); //String concatenation
        
        //Char Addition
        char letter2 = 'a';
        letter2 += 'b';
        Console.WriteLine(letter2); //This just adds the ASCII value and gives the correspondence

        var age4 = 10; //The compiler will decide the datatype but we need to initialize and declare together.
        const int vat = 20; //We cannot change this value now
        
        int number = 0123434; //The int ignore all zeroes before the number so it is best to store this as a string
        Console.WriteLine(number);
        string textNumber = "0123345";
        Console.WriteLine(textNumber); //This way the zero is retained.
        Console.WriteLine("Your number is: " + textNumber); //string concatenation
        
        // Console.Write("Please enter a number: ");
        // int ageIn = Convert.ToInt32(Console.ReadLine());
        // // if (ageIn >= 18)
        // // {
        // //     Console.WriteLine("You are 18 or older");
        // // }
        // // else if (ageIn < 18)
        // // {
        // //     Console.WriteLine("You are a minor");
        // // }
        // Console.Write("Please enter another number: ");
        // int ageIn2 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("The multiple of these two numbers is: " + (ageIn*ageIn2));
        */
        //Switch Case
        /*
        Console.Write("Please enter any day of the week in number: ");
        switch (Convert.ToInt32(Console.ReadLine())) //pass the variable as the argument
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wednesday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("Saturday"); break;
            case 7: Console.WriteLine("Sunday"); break;
            default: Console.WriteLine("Please enter a valid day."); break; //acts as else statement
        }
        */
        
        //For Loop
        // for (int j = 0;
        //      j < 5;
        //      j++)
        // {
        //     Console.WriteLine(j);
        // }
        //
        // for (int i = 0; i < 10; i += 2)
        // {
        //     Console.WriteLine(i);
        // }
        /*
        Console.Write("Please enter how many times you want to print: ");
        int j = Convert.ToInt32(Console.ReadLine());
        if (j <= 0)
        {
            Console.WriteLine("Nothing happens");
        }
        else if (j < 100)
        {
            for (int i = 1;
                 i <= j;
                 i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Enter smaller number");
        }
        */
        
        //While loops
        int i = 0;
        while (i<=10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
