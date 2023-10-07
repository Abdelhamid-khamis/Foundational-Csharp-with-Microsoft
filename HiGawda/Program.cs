// using System;

// namespace MyApp // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

// Console.WriteLine("Hello, World!");


using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        // ----------------------------- 03. Language Syntax -------------------------------------

        // Syntax is the grammar of the language
        // Each element has its own color, which represents sth acoording to CS syntax.
        // blue: keywords or instructional words for the complier, it directs the compiler.
        //      it tells the compiler what's the preceding word means.
        // Turqouise: classes
        // {} : Curly braces represent code block(punch of statements, open fridge, then put sth
        // on fridge shelf, close the fridge).
        // White spaces and pressing Enter(adding new lines) are neglected regarding to the compiler.
        // dot: tells the compliler that the preceding word is a child of the previous word(class).
        // e.g: Console.WriteLine :: Console is a class(parent)
        // WL is a method belongs to the console parent.
        // "Hello, World!": string data type, Some text that Compiler doesn't care of its meaning.
        // yellow: special character which the compiler process it as a sth, e.g. add new line.



        // ----------------------------- 04. Writing to Console -------------------------------------

        // Console.WriteLine("Hello");   tells the console to write hello.
        // discussed main points regarding Console class ops, such as
        // Console Class attributes {ForegroundColor, BackgroundColor, Title}
        // Console Class Methods {ReadKey(), WriteLine()}
        // cw is a shortcut for Console.WriteLine();


        Console.WriteLine(
            "Writes the specified string value, followed by the current line terminator \n"
        );
        System.Console.Write("Prints a text but doesn't append a new line to the end.");
        Console.ForegroundColor = ConsoleColor.Red; // sets the font color to green.
        Console.BackgroundColor = ConsoleColor.Green; // sets the bg color to green.
        Console.Title = "C FUndamentals"; // sets a title to the console bar.
        // Console.ReadKey(); // obtains the next character or function key pressed by the user.


        // ----------------------------- 05. Variables & Data Types -------------------------------------

        //  Variables used to store data, and enable reusing of the value.
        /*
          * Variables are temporary values you store in the computer's memory.
          * Before you can use a variable, you have to declare it.
          * To declare a variable, you first select a data type for the kind of data you want
                to store, and then give the variable a name that follows the rules.
        */

        // Compilers reserve a space for each character, so if I added the same line of code,
        //  This doesn't mean it takes the same memory space.
        // Variable Naming Rules:
        // starts with a character or Underscore but not numbers.
        // not a reserved keyword e.g. static..but _static/@static is valid but not prefered.
        // Descriptive, self-explainatory Names dateOfBirth not dob.

        // You must assign a value before using it, the variable takes a default value of its own type.
        // string value :: null - boolean :: false - integer::0
        // but Csharp is restrictive to unassigning values to variables, to avoid unexpected behaviour.

        string statementToPrint = "Hello, Passionate Coder."; // declaration & Initialization.
        Console.WriteLine(statementToPrint);


        /*
        Variable names should use camel case, which is a style of writing that uses 
            a lower-case letter at the beginning of the first word and an upper-case letter 
            at the beginning of each subsequent word. 
                For example, string thisIsCamelCase;.
        
        */


        // Variable name examples
        char userOption;

        int gameScore;

        decimal particlesPerMillion;

        bool processedCustomer;

        /*
            there are many data types, but you'll focus on just a few for now:

            string for words, phrases, or any alphanumeric data for presentation, not calculation
            char for a single alphanumeric character
            int for a whole number
            decimal for a number with a fractional component
            bool for a true/false value
        */


        /*
        * You must assign (set) a value to a variable before you can retrieve (get) a value from a variable.
        * You can initialize a variable by assigning a value to the variable at the point of declaration.
        * Assignment happens from right to left.
        * You use a single equals character as the assignment operator.
        * To retrieve the value from the variable, you merely use the variable's name.
        */

        /* *[The var keyword ]
        * The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
        * You'll likely see the var keyword as you read other people's code; however, you should use the data type when possible.        * You use a single equals character as the assignment operator.
        */


        /* [Challenge: Display literal and variable values]
            In this challenge, you'll write code that 
                will combine literal and variable values into a single message.

            Store the following values in variables:
                Bob
                3
                34.4

            Write code in the .NET Editor to display the following message:
                Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
        
        */

        string firstName = "Bob";
        int luckNumber = 3;
        double decimalNumber = 34.4;

        Console.Write($"Hello, {firstName}! You have {luckNumber} messages in your inbox. The temperature is {decimalNumber} celsius.");




        Console.WriteLine(34.40M);  // outputs 34.40


        /*
            [Summary] Store and retrieve data using literal and variable values in C#

            Your goal was to display a formatted message using a combination of literal and variable values.
            Using basic C# syntax, you created literal values of several different data types. You declared variables, and also set and retrieved values from those variables. You also initialized variables, and learned how to use the var keyword to implicitly type a variable by inferring the type from the initialization.
        */



        // ----------------------------- 06. Boolean DataType -------------------------------------

        // It's the lowest size in memory, contains two values true or false.
        // You can use the full struct name Boolean or the shortcut bool.
        // bool isAlive = 1;    produce an error
        Boolean isAlive = false;
        Console.WriteLine(isAlive);

        bool boolean1 = false,
            boolean2 = false; // You can declare multiple vars at the same line, but they must be from the same data type.

        bool result1 = boolean1 & boolean2; // evaluate from left to right, and it checks both terms, regardless the value of the 1st term.
        bool result2 = boolean2 && boolean1; // ¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬, but it checks if the 1st term is false, it would stop checking the other term.
        // so it's more efficient in terms of performance.
        // It's called short circuit operator.

        bool result3 = boolean1 | boolean2; // pibe operator |
        bool result4 = boolean1 || boolean2;

        bool result5 = !boolean1; // NOT operation

        bool result6 = boolean1 ^ boolean2; // XOR, caret operator, returns true if 2 vars are different(one is true & the other is false)

        // ----------------------------- 07. Char Data Type -------------------------------------

        Console.ReadLine(); // The star means it's used more frequent
        // 1 -> 49      A -> 65
        // ASCII    -> American standard code information interchange.
        // Coding system for characters represented by a number in the ASCII table
        Console.WriteLine("Write any character then press Enter>>");
        int c = Console.Read(); // Reads character by character
        // So if I entered ABC it would output The ASCII code of the 1st letter only.
        // I should type 3 read methods to retrieve the 3 characters.

        char d = 'A';
        Console.WriteLine(c);
        Console.WriteLine((int)d);

        // Create a console app that prints the ascii table for small & capital a-z letters
        // and for numbers from 0-9


        // ----------------------------- 08. & 09. String Data Type -------------------------------------
        // = Escape Special characters - Unicode escape characters  - Verbatim strings 
            // String Concatenation- String Templates=
        // You can't build an app without using strings.
        // Strings are a number(array) of characters between double qoutes " ".
        // Array is a list/collection of homogenous elements.
        // Compiler deals with strings as any normal text e.g. "Console.WriteLine();" is a text.
        Console.WriteLine("Console.WriteLine();");

        
        // ---- 08.1. Escape Special characters ---- are dealed with different way than normal strings, such as:
        // backslash n : When executed, Add new line, then continue ("Hello\nWorld")
        // backslash t : Adds new tab(4 spaces)
        // \\n add another backslash before the special character, to escape executing spec char.
        // TO display a file path: you use the \\ to display a single backslash.
        Console.WriteLine("Hello \"World\"!"); // To handle that situation, use the \" escape sequence:

        Console.WriteLine("Hello\nWorld!");
        Console.WriteLine("Hello\tWorld!");
        /* [Output] Hello
                    World!
                    Hello   World!
        */

        // What if you need to use the backslash for other purposes, like to display a file path?
        Console.WriteLine("c:\\source\\repos"); // To solve this problem, you use the \\ to display a single backslash.
        /*
        [Output]
        c:\source\repos
        */


        // ---- 08.1.1.  Unicode escape characters ---- \u
        //  using the \u escape sequence, 
            // then a four-character code representing some character in Unicode (UTF-16).
            // But there are some consoles, don't support unicode literals

        // Kon'nichiwa World
        Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");



        // ----  08.2. Verbatim strings ---- : Add @ before string 1st qoutes, like f"" in python
        // A verbatim string literal will keep all whitespace and characters without the need 
            // to escape the backslash. To create a verbatim string, 
                // use the @ directive before the literal string.
                // Formating Text
                // Supports multi line strings
                // Escape special characters

        string raoufKhlief =
            @"Sba7 Elfol\n\n
            
                            llnas Elkol";

        Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
        /* [Output]
        c:\source\repos    
            (this is where your code goes)
        
        */




        // The final code for using, escape special chracters, verbatim strings, escape Unicode characters
        Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ..\n");
        Console.WriteLine("Invoice: 1021\t\tComplete!");
        Console.WriteLine("Invoice: 1022\t\tComplete!");
        Console.WriteLine("\nOutput Directory:\t");
        Console.Write(@"c:\invoices");

        // To generate Japanese invoices:
        // Nihon no seikyū-sho o seisei suru ni wa:
        Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
        // User command to run an application
        Console.WriteLine(@"c:\invoices\app.exe -j");



        /*
        Generating invoices for customer "Contoso Corp" ..

        Invoice: 1021            Complete!
        Invoice: 1022            Complete!

        Output Directory:
        c:\invoices

        日本の請求書を生成するには：
            c:\invoices\app.exe -j

        */


        /* [Recap]
            * Use character escape sequences when you need to insert a special character into a literal string, like a tab \t, new line \n, or a double quotation mark \".
            * Use an escape character for the backslash \\ when you need to use a backslash in all other scenarios.
            * Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
            * Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
            * Unicode characters may not print correctly depending on the application.


        */






        // ----- 08.2. String Concatenation ---- (+ operator , ):
            // String concatenation allows you to combine smaller literal and variable strings into a single string.
        string hello = "Hello";
        string world = "World";
        // !Avoid creating intermediate variables if adding them doesn't increase readability.
            // !Avoid This -> string message = greeting + " " + firstName + "!"; 
        
        Console.WriteLine(hello + " " + world);



        //  ----- 08.4. String Templates(Interpolation) ----- : 
            // Add $ dollar sign before string 1st qoutes, like f"" in python
            // Formatted strings
            // Supports code execution within string
        string name = "Mohamed";
        Console.WriteLine("Hello, " + name + "\nWelcome to Our C# Course"); // Normal Way
        Console.WriteLine($"Hello, {name} \nWelcome to Our C# Course"); // String Template


        //  ----- 08.4.1 Combine verbatim literals and string interpolation ----- : 
        string projectName = "First-Project";
        Console.WriteLine($@"C:\Output\{projectName}\Data");

        /*Output

        C:\Output\First-Project\Data
        */


        /* [challenge .2]
        In this challenge, you'll print instructions to the end user to let them know 
        where your application will output data files. You won't be actually 
        creating any files -- you're only interested in displaying formatted 
        instructions to the console window.
        */

        /* [The desired output]
        View English output:
        c:\Exercise\ACME\data.txt

        Посмотреть русский вывод:
        c:\Exercise\ACME\ru-RU\data.txt

        */


        string projectName = "ACME";

        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.WriteLine(
        $@"View English output:
            c:\Exercise\{projectName}\data.txt
        
        {russianMessage}:
            c:\Exercise\{projectName}\ru-RU\data.txt ");



    /* [Summary] https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/8-summary

    Your goal was to write code that formats strings with special characters, such as double quotes,
    new lines, tabs, and other white space, as well as unicode characters. 
    You also combined strings using two different techniques.

    Using character escape sequences, you added special characters in your literal strings by 
        either using special escaping sequences or using verbatim strings. 
        You added Unicode characters from other language sets like Japanese Kanji 
        and Russian Cyrillic in your literal strings. You used simple string concatenation 
        with the + symbol, and upgraded to string interpolation for combining values into 
        a string template.

    Without the ability to format your output, you would be severely restricted in what kinds of 
        information you could present to the user. However, now you can provide your users 
        with sophisticated instructions and feedback with a wide variety of formatting, 
        symbols, and languages.





    */

























        // 08.5. String Input
        // string? Console.ReadLine()  -> This is called signature
        // 1st parameter means, it returns string, nomatter the question mark.

        string fname = "";
        System.Console.Write("Please Enter Your name: ");
        fname = Console.ReadLine(); // Waiting for the user to type sth, then hits Enter.
        Console.WriteLine($"Welcome {fname}");

        // 08.6. String Attributes & Methods
        // Methods
        // .ToUpper() -                                  .ToLower()
        // .StartsWith(string value, comparisonType) -  .EndsWith()
        // .IndexOf(string value, comparisonType)
        // .LastIndexOf(string value, comparisonType)
        // .Replace(string oldValue, string? newValue)

        // Attributes
        // .Length

        Console.WriteLine($"Length= {fname.Length}");
        Console.WriteLine($"upperCase= {fname.ToUpper()}");
        Console.WriteLine($"lowerCase= {fname.ToLower()}");
        // Upper characters are different than lower ones, each have their own ASCII code.

        Console.WriteLine($"nameStartsWithA?= {fname.StartsWith("A")}");
        // bool string.StartsWith(string value) (+ 3 overloads) - return type bool
        // Compare the case condition of the letter

        Console.WriteLine(
            $"nameStartsWithA?= {fname.StartsWith("A", StringComparison.OrdinalIgnoreCase)}"
        );
        // StringComparison.OrdinalIgnoreCase : Ignore character case


        Console.WriteLine($"Length= {fname.EndsWith("ed", StringComparison.OrdinalIgnoreCase)}");

        Console.WriteLine(
            $"nameStartsWithA?= {fname.IndexOf("A", StringComparison.OrdinalIgnoreCase)}"
        );
        // StringComparison.OrdinalIgnoreCase : Add this every time you want the method to ignore the char case.
        // searches form ltr, and it returns the 1st occurence of the character

        Console.WriteLine(
            $"nameStartsWithA?= {fname.LastIndexOf("A", StringComparison.OrdinalIgnoreCase)}"
        );
        // Searches from ltr, but returns the last occurence of the character.


        System.Console.WriteLine(
            fname.Replace("Abdelhamid", "Hamid", StringComparison.OrdinalIgnoreCase)
        );
        // string string.Replace(string oldValue, string? newValue - replace old with gold



        // Strings Task:
        // Ask the user to enter two words,
        // 1st Enter original string                "Mohamed Elmahdy"
        // 2nd old part that you want to replace.   "Elmahdy"
        // 3rd: New part to be replaced with.       "Ahmed"

        Console.Write(@"Please Enter Your Full Name: ");
        string fullName = Console.ReadLine();

        Console.Write(@"Please Enter The part you want to replace: ");
        string oldValue = Console.ReadLine();
        System.Console.WriteLine($"Your Full name is: {fullName}");

        Console.Write(@"Please Enter The part you want to replaced with: ");
        string newValue = Console.ReadLine();
        System.Console.WriteLine(
            $"Your Full name is: {fullName}, and the new is {fullName.Replace(oldValue, newValue, StringComparison.OrdinalIgnoreCase)}"
        );

        // ----------------------------- 10. Numeric Data Type -------------------------------------

        // It's a strength point that the lang has numerous numeric data types.
        // Because It would reserve the optimal memory(space) for each numeric data type.
        // int uint - long ulong - float - double  --> 6 They are very easy

        int int1 = 0;
        int int2 = 50;
        int int3 = -50;
        // Int is a whole number that cannot has fractions, could be pos/neg/zero


        uint uint1 = 0; // Hold alt key like using shift, then choose the words you want to replace
        uint uint2 = 50;
        uint uint3 = -50; // signs aren't allowed, so it produces an assignment error
        // Unsigned which means you can't use neg values beacause it contains a sign.

        // There are three axis in diffrentiating btn different numeric data types, they are:
        // Memory Size(Space that it reserve), Min Value, Max Value

        System.Console.WriteLine($"Int Memory Size: {sizeof(int)}"); // 4 means 4 byte = 32 bit
        System.Console.WriteLine($"uint Memory Size: {sizeof(uint)}"); // int & uint have the same space
        System.Console.WriteLine("--------------------------------------");
        System.Console.WriteLine($"Int Memory Size: {int.MinValue}"); // -2 billion
        System.Console.WriteLine($"uint Memory Size: {uint.MinValue}"); // 0 because it can't be negative
        System.Console.WriteLine("--------------------------------------");
        System.Console.WriteLine($"Int Memory Size: {int.MaxValue}"); // 2 billion
        System.Console.WriteLine($"uint Memory Size: {uint.MaxValue}"); // 4 billion, double int

        // So int & uint, long & ulong have the same memory space
        // int has the range of from negative 2 positive
        // uint has the range of all positives, that's why it has larger max value


        // long - ulong -- 15:00 " 010
        System.Console.WriteLine($"long Memory Size: {sizeof(long)}"); // 4 means 4 byte = 32 bit
        System.Console.WriteLine($"ulong Memory Size: {sizeof(ulong)}"); // int & uint have the same space
        System.Console.WriteLine("------------------------------long--------");
        System.Console.WriteLine($"long Memory Size: {long.MinValue}"); // -2 billion
        System.Console.WriteLine($"ulong Memory Size: {ulong.MinValue}"); // 0 because it can't be negative
        System.Console.WriteLine("--------------------------------------");
        System.Console.WriteLine($"long Memory Size: {long.MaxValue}"); // 2 billion
        System.Console.WriteLine($"ulong Memory Size: {ulong.MaxValue}"); // 4 billion, double int

        // ----------------------------- 11. Arithmetic Operators -------------------------------------

        /*  [Arithmetic Operators]
            * Addition (+)            6 plus 2
            * Subtraction (-)         6 minus 2
            * Multiplication (*)      2 times/multiplied by 3
            * Division (/)            6 divided by 3
            * Remainder(Modulus) (%)  6 remainder 2       6 divided by 2 is 3 & the remainder is 1
            * Exponentiation (**)     6 to the power 3

            !operand + operand =
        */
        int x = 25; // explicitly variable declaration
        int y = 10;
        var z = x / y; // Tells the compiler to determine the dt according to the variable actual dt
        // implicitly variable declaration, check dt of z(if z is double so var would be double)

        System.Console.WriteLine($"{x} + {y} = {x + y}");
        System.Console.WriteLine($"{x} - {y} = {x - y}");
        System.Console.WriteLine($"{x} * {y} = {x * y}");
        System.Console.WriteLine($"{x} / {y} = {x / y}"); // int/int -> result is int
        // double/double -> double
        // ! int/double -> double
        // (Double has a higher range than int, so it returns the data type with the highest range)
        System.Console.WriteLine($"{x} % {y} = {x % y}"); // 25 divided by 10 is 2 & the remainder is 5[result]

        // ----------------------------- 12. Operator Precedence -------------------------------------
        /*
            PEDMAS[ltr] - Please Excuse My Dear Aunt Sam.
                Operation with higher precedence, been dealt as Elbasha in execution.
                Paranthesis forces the operation to be the highest precedence.
        */
        Console.WriteLine($"5 + 3 * 2 = {5 + 3 * 2}");

        // ----------------------------- 13. Assignment Operators -------------------------------------

        int q = 10;
        q += 5; // Compound assignment, with all data types & the 5 operations
        q -= 5;
        q *= 5;
        q /= 5;
        q %= 5; // it works as well. [o/p: 0]

        int e;
        int r;
        int t;
        e = r = t = 8; // Multiple assignment(Must be of the same data tpe)

        // ----------------------------- 14. Increment & Decrement Operators -------------------------------------
        /*
            pre-increment[++var] & post-increment[var++] {decrement also}
        */
        int prefix = 2;
        int postfix = 3;

        ++prefix; // [pre = the signs are pre, pre assigning, Increment/Decrement]
        postfix++; // [post = the signs are post the variable -> Post Assigning the value, Increment/Decrement]

        Console.WriteLine(5 * ++prefix); // pre is to be executed 1st, but not the case for post.
        //PE'pre'DMAS


        // ----------------------------- 15. Comparison Operators -------------------------------------
        /** [Comparison Operators] -> bool O/P
            ** is Equal (==)
            ** is not Equal (!=)
            ** Greater Than (>)
            ** Less Than  (<)
            ** Greater Than or Equal (>=)
            ** Less Than or Equal (<=)
        */

        System.Console.WriteLine($"x==5? {x == 5}");

        // ----------------------------- 16. Parse strings(Casting to strings) -------------------------------------
        // Parse mean analysis which means converting from specific DT to a different dt.
        // Calculate the age of a user from two specific dates
        System.Console.Write("Enter ur birth year: ");
        string year = Console.ReadLine(); // I have to cast the string dt to numeric, to do some calculations with
        int intYear = int.Parse(year); // First I write the required to convert dt(struct)(int)
        // then call the method parse, and put the old dt as an argument
        // Converts the string representation of a number to its 32-bit signed integer equivalent.

        Console.WriteLine($"Your age until 2023 = {2023 - intYear}");

        string x = "1243" + 10; // This acts like a normal Concatenation
        string p = "1243" * 10; // This produces an error, cuz no other operations are allowed rather than +
        // Operator '*' cannot be applied to operands of type 'string' and 'int'


        // ----------------------------- 17. Control flow -------------------------------------

        // Like the train lane operator, who changes the route of the trains on different lanes, according to specific criterion(condition)

        // A program to check wheather a number is even or odd
        System.Console.WriteLine("Please Enter a number: ");
        string number = Console.ReadLine();
        int parsedNumber = int.Parse(number);

        // The most necessary part is if keyword, other keywords(else if, else ) are optional
        if (parsedNumber % 2 == 0)
        {
            System.Console.WriteLine($"The number {parsedNumber} is even");
            // system is a namespace
            // Console is a class
            // WriteLine is a class method
            // string is a class
            // int dt is a struct
        } // after finishing the if block, then I start an else block
        else if (parsedNumber == 0)
        {
            System.Console.WriteLine($"The number {parsedNumber} is neither odd nor even");
        }
        else if (parsedNumber % 2 != 0)
        {
            System.Console.WriteLine($"The number {parsedNumber} is odd");
        }

        if (intYear == 0)
        {
            System.Console.WriteLine($"Please enter a valid value.");
        }

        // ----------------------------- 18. Debugger -------------------------------------
        /*
            Debugger tools allows you to trace the problems, and hopefully solving it
            This is done by step by step execution of the code, using breakpoints
        */





        // ----------------------------- 19. Arrays -------------------------------------
        /*  [Arrays]
            - Array is a collection of homogenous elements[of the same data type]
            - Array declaration: add [] after dt, and use {}
            - Array indexing[accessing an element]
            - Array sorting     Array.Sort();
            - Array copying

        */


        // Array declaration: I'll declare a normal variable, but I'll add [] after the DataType.
        // int videos =
        // int[] videos =            add [] after dt
        // int[] videos = {};        use curly braces instead of square

        int[] ints = { 1, 2, };
        System.Console.WriteLine($"The index of 2 is {ints[1]}, and the position is {ints[1] + 1}");

        Array.Sort(ints); // The arg is --> int[] array <-- an array

        int[] ints2 = new int[7]; // The new array is from the data type integer, and it'll hold 7 elements
        // new int[7]: The initial length of the new array
        Array.Copy(ints, ints2, ints.Length);
        // Array sourceArray
        // Array destinationArray
        // int length
        // ints2: is the new array that data would been copied to, so I specified the initial
        // length for it, so that it can hold the copied 7 elements from the sourceArray



        // ----------------------------- 20. for loop -------------------------------------
        /*  [Loops: for loop]
            - Loop is repeating sth(statement-condition..) for a determined/undetermined number of times
            - looping number of times
                - for (start; end; step){}
                - start     [normal assignment_initialization]
                - end       condition(bool)       [variable operator  (length-known_number)]
                - step      variable increment/decrement
            - looping through an array of elements
                - foreach([assignment_declaration without semicolon      in      array]){}
            - change loop steps countS


        */

        //     - looping number of times
        for (int counter = 0; counter < 5; counter++)
        {
            System.Console.WriteLine($"Counting..{counter}");
        }

        int[] numbers = { 50, 60, 70, 80, 90, 100, 120 };
        for (int index = 0; index < numbers.Length; index += 2)
        {
            System.Console.WriteLine(numbers[index] + ".");
        }

        //     - looping through an array of elements
        foreach (int num in ints2)
        {
            System.Console.WriteLine($"{num}");
        }

        /*
            Assignment 1: Print the ASCII table for upper&lower letters from A-Z
                                & numbers from 0:9
        */
        char[] letters = { 'a', 'b' };
        foreach (char letter in letters)
        {
            System.Console.WriteLine((int)letter);
        }

        /*
            Assignment 2: ASk the user to enter 5 numbers, then add them to any array, sort them, then
                            print the array
        */




        // ----------------------------- 21. Control flow & Ternary Operators -------------------------------------
        /*  [المعامل الثلاثى]
            It's an alternative for the if else statement, but it must return a value.
            Single assignment statement, that must return a value.
            dt variableName = (condition ? valueIfTrue : valueIfFalse);


        */


        // The next two block of statements are equal, but the last are easier in implementation
        for (int i = 0; i <= 9; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine($"The number {i} is even.");
            }
            else if (i % 2 != 0)
            {
                System.Console.WriteLine($"The number {i} is odd.");
            }
        }

        for (int i = 0; i <= 9; i++)
        {
            string ternaryStatement = (
                i % 2 == 0 ? $"The number {i} is even." : $"The number {i} is odd."
            );
            System.Console.WriteLine(ternaryStatement);
        }

        // ----------------------------- 22. foreach loop -------------------------------------
        /*
        - It's an optimized way of the normal "for loop", which deals better with arrays or collections.
        - Allows you to access array elements very easily.
        - Doesn't contain a counter, but for loops contains
        */

        char[] numbersCh = { '0', '1', '2', '3', '4', '5', '6', '7', };

        // The next two block of statements are equal, but the last are easier in implementation
        for (int i = 0; i < numbersCh.Length; i++)
        {
            System.Console.WriteLine($"The ascii code for {numbersCh[i]} = {(int)numbersCh[i]}");
        }

        foreach (char digit in numbersCh)
        {
            System.Console.WriteLine($"The ascii code for {digit} is {(int)digit}");
        }















        
    }   // End of main method



static void ForForeachLoops___23()
{
        // ----------------------------- 23. for/foreach loops Training -------------------------------------
        /*  [For/Foreach Training]
            * Create an application to reverse a dynamic array using 'for'
            * Create an application to calculate average of dynamic array of numbers using 'for each'
            // Dynamic array: the user would specify the array size and its inputs
                // dynamic array are different than hard coding things, e.g. determined array size
        */

        //* Create an application to reverse a dynamic array using 'for'

        string[] cars = { "BMW", "Audi", "Porsche" };
        string[] newCars = { };

        for (int i = cars.Length; i >= 0; i--)
        {
            newCars.Append(cars[i - 1]);
        }

        System.Console.WriteLine(newCars);

        // Create an application to calculate average of dynamic array of numbers using 'for each'
        int[] numbersToBeAveraged = { 1, 2, 3, 4, 5, 6, 7, };
        int result = 0;

        foreach (int numberinho in numbersToBeAveraged)
        {
            result += numberinho;
        }

        System.Console.WriteLine(
            $"The average of the array: {numbersToBeAveraged} is {result / numbersToBeAveraged.Length}"
        );

        //* Create an application to reverse a dynamic array using 'for'
        System.Console.Write("Enter array number of items[Array size]: "); // Text prompt, prefered to be done using dot write

        int arraySize = int.Parse(Console.ReadLine());

        int[] numbersEnteredByUser = new int[arraySize]; // dynamic array

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Enter array element #{i + 1}");
            numbersEnteredByUser[i] = int.Parse(Console.ReadLine());
        }

        int[] reversedNumbers = new int[arraySize];
        for (int i = arraySize - 1; i >= 0; i--)
        {
            reversedNumbers[arraySize - i - 1] = numbersEnteredByUser[i];
        }

        foreach (int number in numbersEnteredByUser)
            System.Console.WriteLine(number); // I can delete curly braces, if the for loop contains single statement

        foreach (int number in reversedNumbers)
        {
            System.Console.WriteLine(number);
        }
}


static void DoWhileLoops___24()
{
        // ----------------------------- 24. Do/While Loops -------------------------------------

        /*
            - 2 methods allows me to execute a code block, undetermined number of times as long as,
                a specific criteria/condition is true.
        */



        int numberoo = 2;

        /*
        do[execute the following code]
        while(طالما) [as long as the condition specified is true]

        do executes at least for one time.
            - DO EXECUTES 1ST, THEN CHECKS THE CONDITION, THEN EXECUTES WHILE TRUE.
            - WHILE CHECKS THE CONDITION 1ST, THEN EXECUTES WHILE TRUE
        */

        do
        {
            System.Console.WriteLine(numberoo++);
        } while (numberoo <= 10);

        while (numberoo <= 10)
        {
            System.Console.WriteLine(numberoo++);
        }

        // Write a program that capitalizes any given text by the user, and exit only when 'exit' is typed.
        Console.Write("Please, Enter the text to be capitalized: ");
        string textInput = Console.ReadLine();
        string exitCondition = "Exit";

        do
        {
            System.Console.WriteLine(textInput.ToUpper());
        } while (textInput != exitCondition.ToLower());
    
}

static void ControlFlowSwitchStatement___25()
{
        // ----------------------------- 25. Control flow: [Switch statement] -------------------------------------

        /*  [Control flow [3. Switch statement]]    1.if statement  2. Ternary operator
            - Switch statement is a way to control the flow of execution, according to a single variable value
            -
            - You use it when, the control flow depends on the value of a single variable

        */


        System.Console.Write("Please Enter a string");
        string input = Console.ReadLine();

        System.Console.WriteLine("Please select an option: ");
        System.Console.WriteLine("1. Convert to capital");
        System.Console.WriteLine("2. Convert to small");
        System.Console.WriteLine("3. print the string length");

        string selectedOption = Console.ReadLine();

        if (selectedOption == "1")
        {
            System.Console.WriteLine(input.ToUpper());
        }
        else if (selectedOption == "2")
        {
            System.Console.WriteLine(input.ToLower());
        }
        else if (selectedOption == "3")
        {
            System.Console.WriteLine(input.Length);
        }
        else
        {
            System.Console.WriteLine("Invalid Option");
        }

        // The next two block of statements are equal, but the last are easier in implementation

        System.Console.Write("Please Enter a string");
        string input = Console.ReadLine();

        System.Console.WriteLine("Please select an option: ");
        System.Console.WriteLine("1. Convert to capital");
        System.Console.WriteLine("2. Convert to small");
        System.Console.WriteLine("3. print the string length");

        switch (selectedOption)
        {
            // = if (selectedOption == "1")
            case "1": // = if(selectedOption == 1) {}
                Console.WriteLine(input.ToUpper());
                break;
            case "2": // = if(selectedOption == 2) {}
                Console.WriteLine(input.ToLower());
                break;
            case "3": // = if(selectedOption == 3) {}
                Console.WriteLine(input.Length);
                break;
            default: // = else{}
                System.Console.WriteLine("Invalid Option");
                break;
        }
    
}

static void Methods___26_27()
{
        // ----------------------------- 26. Methods[Functions] -------------------------------------

        /*
            - Method is a code unit, that allows me to divide the system into small chunks of code
                each unit do a simple specific task.
            - I use methods, when I have to reuse a block of code, in different places, which supports
                the principle of DRY(Don't repeat yourself) and supports the reusability of the code.
        
            - void[means nothing, will run felkonafa] return type is none
            - Parameters are what needed for the method. e.g. cw needs a string to print
            - put static before the return type
            - Start naming the method with a verb(جملة فعلية). e.g. sendEmail,

            [2]
            - You return a value from method
        */


        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, };
        calculateAverage(numbers); // Method call/invokation

        // Here an example of xml documentation, I write the description btn the xml tags
        /// <summary>
        /// Calculates the average for an array of numbers
        /// </summary>
        /// <param name="numbers">The array to calculate its average</param>
        /// <param name="printToConsole">Determine whether to print the result to the console or not.</param>
        /// <returns>returns the average</returns>
        static void calculateAverage(int[] numbers, bool printToConsole = default)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Length;
            System.Console.WriteLine($"Average is = [{average}]");
        }

        // ----------------------------- 27. Methods[Functions] 2 -------------------------------------
        /*
            - Return value from method,
            
            - Single responsablilty means that the code unit is responsible for doing one thing, read only or write only.
                e.g. Console.WriteLine . . . . . . . . . . is responsible for writing an o/p only, not to return a value
                - Return from method, instead of void, i put the dataType ehat I want the method to return.
                    - then at the last line of the method, I tell the console what to return after the return keyword.
                    - Anycode after the return line, won't be exceuted.
        
            - Optional Arguments, I give a default value for the arg 'bool printToConsole = false'
                which means if The user didn't provide a value for the variable, use this default value.

                - static double calculateAverage(int[] numbers): The inside brackets are called:
                    - Method arguments/parameters/inputs

                - (int[] numbers, bool printToConsole = false), I want to add an option for the user if he wants to
                print the o/p to the console or not, so I provide the true/false dataType which is bool,
                then I'll add the argument 'printToConsole', then I'll get a problem which that
                I have entered 1 arg for the method before, but now it keep asking me for the second argument(input),
                and this won't be helpful if I have used this method several times before,
                so now comes the role of the optional method arguments,

                - [bool printToConsole = false] Optional args are written between square braces in the method signature.
                - Optional args must be the last method arguments.
            - If you have 3 arguments, You can skip the 2nd arg by keeping its place empty 1st , , 3rd
                You can also call the argument by its name '1st , printSumToConsole: true'.
            
        */

        // Declare a new array of integers
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, };
        calculateAverage(numbers); // Method call/invokation

        // Here an example of xml documentation, I write the description btn the xml tags
        /// <summary>
        /// Calculates the average for an array of numbers
        /// </summary>
        /// <param name="numbers">The array to calculate its average</param>
        /// <param name="printToConsole">Determine whether to print the result to the console or not.</param>
        /// <returns>returns the average</returns>
        static double calculateAverage(int[] numbers, bool printToConsole = default) // 1. put 'double' instead of 'void'
        {
            // todo: add sumToConsole optional argument
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Length;
            if (printToConsole)
            {
                System.Console.WriteLine($"Average is = [{average}]");
            }

            return average; // 2. tell the console what to return after the return keyword
        }
    
}

static void Comments___28()
{
        // ----------------------------- 28. Comments  -------------------------------------
        /*
            - A comment is important for your team collegues, but it's not important for the console.
                isn't readable or executed by the console or the IDE(which means no intellisense are provided when writing comments).
            - single/multi line comment, //, Multiline, Usually used in license agreement, or Author information.
            - Todo comment(visual studio): Ofcourse there is task mgmt tools, but this is also could be used easily in a program that is full of tasks & folders & files
                1. // todo: Convert array from int[] to long[]
                2. view tab, task list
            - XML documentation comment[Doc strings in python]: Method description
                - add /// before the method signature
                - write the description btn the xml tags
                - build tab, rebuild command, if intellisense didn't get the documentation yet.
        */    
}

static void TrainingArrayFindings___29()
{
          // ----------------------------- 29. Training(Array Findings)  -------------------------------------

        /*  [Training]
            - Ask the user to enter the number of items in an integer array.
            - Ask the user to enter the items of this array.
            - Find the smallest number in the array.
            - Find the greatest number in the array.
            - Calculate the average of the array.
        */

        Console.WriteLine("Please enter the number of items: ");
        int arraySize2 = int.Parse(System.Console.ReadLine());
        int[] numberino = new int[arraySize2];
        for (int i = 0; i < arraySize2; i++)
        {
            System.Console.WriteLine($"Enter the number #{i + 1} of array size{arraySize2}");
            numberino[i] = int.Parse(System.Console.ReadLine());
        }

        // Find the smallest/greatest/avg number in the array.
        int sum = 0,
            lowest = int.MaxValue,
            highest = 0; // valid because the same data type

        foreach (int numberinhoNumber in numberino)
        {
            sum += numberinhoNumber;

            if (highest < numberinhoNumber)
            {
                highest = numberinhoNumber;
            }

            if (lowest > numberinhoNumber) // I set the smallest number to the maximum value of int, to avoid zero result
            {
                lowest = numberinhoNumber;
            }
        }

        double calculatedAverage = sum / arraySize2; // Float could be used also

        System.Console.WriteLine($"The highest number in {numberino} is: {highest}");
        System.Console.WriteLine($"The lowest number in {numberino} is: {lowest}");
        System.Console.WriteLine($"The Average number in {numberino} is: {calculatedAverage}");  
}

static void TrainingPalindromeWords___30()
{
            // ----------------------------- 30. Training(Palindrome Words)  -------------------------------------
        /*  [Training]
            - Ask the user to enter any word.
            - Check if the word is palindrome or not?

            Note:
                - Palindrome is a word that can be read the same way from both sides>
                    e.g. dad, MOM, Nun
        */



        static void isPalindrome(string word)
        {
            System.Console.Write("Enter the word you want to be checked: ");
            string word = Console.ReadLine().ToLower();
            // worsArray = word.Split('');
            string reversedWord = "";
            bool isPalindrome = false;

            for (int i = word.Length; i >= 0; i--)
            {
                reversedWord += i;
            }

            if (reversedWord == word)
            {
                isPalindrome = true;
                System.Console.WriteLine("The Word: " + word + " Is Palindrome.");
            }
            else
            {
                isPalindrome = false;
                System.Console.WriteLine("The Word: " + word + " Isn't Palindrome.");
            }
        }

        isPalindrome("Dad");
}

static void ValueReferenceTypes___31()
{
// ----------------------------- 31. Value Types & Reference Types  -------------------------------------

        /*
            When ur app run, it reserves a space in the memory, and it's called a memory space,
                this space consists of two parts (a stack(V) and a heap(R).)
            - Value type is: primitive dataType {int, uint, decimal, double, long, ulong, char}, structs
                Its values get stored in stack
            - Reference Type is: array, string(cuz its an array of characters)
                Its values get stored in the heap
                when you declared an array, the memory address of the values get stored in the stack,
                    So I sent the address(reference) of the array, that's why it's called reference type.
        */


        int num1 = 5;
        int num2 = num1; // It won't take the memory address of num1, but would look for it's value
        // then reservs 4 bytes in the memory space, and stores it in the stack
        // num1 has a memory address & num2 has another memory address, even if they have the same value
        num1 = 10;
        System.Console.WriteLine($"Num1={num1}"); // Num1= 10
        System.Console.WriteLine($"Num2={num2}"); // Num1= 5

        int[] numbers1 = { 1 };
        int[] numbers2 = numbers1; // It would take the memory address of numbers1
        // then reservs 4 bytes in the memory space, and stores it in the stack
        // numbers1 & numbers1 have the same memory address, even if they have the same value
        numbers1[0] = 10; // it's called number1 of zero equals ten
        System.Console.WriteLine($"Numbers[0] = {numbers1[0]}"); // 10
        System.Console.WriteLine($"Numbers2[0] = {numbers2[0]}"); // 10(The same)

        static void DuplicateValue(int number)
        {
            number *= 2;
        }

        static void DuplicateArrayValues(int[] numbers)
        {
            // This would change the value of numbers, cuz it's a reference type
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
        }

        int num = 5; // reserved 4 bytes in the memory space, and stored it in the stack
        DuplicateValue(num); // This wouldn't change the value of num, cuz it's a value type

        string str = "Hello";
        str += " World"; // Here I took a copy of the str value, then created a new address for
        // the str variable, so there are two strings in the memory of the same data type, and this a source of memory leakage, but thanks to automatic garbage collection they got deleted after a while

}



static void TypeCasting___32()
{
// ----------------------------- 32. Type Casting  -------------------------------------
        /*  [Type Casting]
        - Implicit Casting: You didn't do any efforts or use any method, it depends on the size of both dataTypes, it agrees converting from the small size data type, to the bigger size data type.
            بحول ضمنياً طالما التحويل مسموح بيه

        - Explicit Casting: You're here writing your signature that you're responsible of the data conversion you want to make.
            You're the person who changes from a bigger data type to the smaller one
            Open parantheses, then type the small size dataTYpe you want to cast to, inside braces.
            بصرح بأنى عايز احول

As long as the compiler is able to comperhend/handle the small size dt to a bigger size dt, it would convert it implicitly.
but not the case for float and integer, even if they are  bytes size, but the data representation is different, Data loss may occur if converted.

        */


        int i = 5;

        // Implicit Casting
        float f = i;
        double d = i;
        double d2 = f;

        // Those would produce an error
        float f2 = d2; // Cannot implicitly convert type 'double' to 'float'. An explicit conversion exists (are you missing a cast?)
        int i2 = d;
        int i3 = f; // Cannot implicitly convert type 'float' to 'int'. An explicit conversion exists (are you missing a cast?)

        // Explicit Casting
        double d3 = 4.13;
        int i3 = (int)d3; // 4, we threw the decimal part in trash, and I'm responsible of this data loss.

        System.Console.WriteLine(i3.ToString()); // .ToString(), this method converts anything{data structures, objects} to string

}
        



static void StringFormatting___33() 
  {
        // ----------------------------- 33. String Formatting --------------------------------------
        /*
        * - Basic Formatting(تهيئة بسيطة): It depends on the indexing system, passing an array of elements after the 1st parameter in the string dot format method
        * - Control Spacing
        * - Format Arguments(0.00, N2, C2)

        . There is an imp link in this video description
        */
        // Commits: Completed Tutorial 33. String Formatting



        string str1 = "Hello {0,15}, My name is {1} ----- {0} ---- {1}"; // 0 & 1 are placeholders with zero indexing system
                                    // you can control the variable specified space, by adding a 2nd arg, between the square braces
                                    // It adds spaces from ltr, It's used mainly in defining column widths.
        str1 = string.Format(str1, "Hameed", "Khamis"); // string dot format is one of the most imp string methods, it takes the string then the array of string template args.
        // all parameters after the 1st parameters, could be considered as an array of elements, with zero indexing system{0, 1}


        double salary = 10000;
        string urBalance = "Your salary is {0:C2}";  // C2: This is a 'C'urrency and add '2' digits after the amount.   
                                                    // This will add a dollar sign before the number, this happened because of UI Culture & Globalization.
        string urBalance2 = "Your salary is {0:N5}";  // N5: This is a 'N'umber and add '5' digits after the amount.  
                                                    // This won't add a dollar sign before the number 
                                                    // N5 = 0.00000
        System.Console.WriteLine(string.Format(urBalance, salary));
        System.Console.WriteLine(string.Format(urBalance2, salary));
        

  }


static void StringSplitJoin___34() 


  {
        // ----------------------------- 34. String Split & Join --------------------------------------
        /* 
         * How to split a string into an array?
            * string.split(seperator:',') -> Splits the 'string' to an 'arrayOfStrings'
         * How to join an array to a string?
            * string.join(seperator, arrayOfStrings) -> Joins an 'arrayOfStrings' to a 'string'.

        */
        // 

        // Almahdy recalled the dyn array definition steps, which was: 
        /*
            1. Asking the user to enter the number of array elements(arraySize).
            2. Loop number of iterartions equals the arraySize.
            3. Ask the user to enter the elements of the array one by one.
        */

    // Create a dyn array, and calculate its average, it's an easier way to do a dyn array.
    System.Console.WriteLine("Please Enter a list of numbers seperated by commas: ");
    string input = Console.ReadLine();
    string[] numbers = input.Split(separator:",");  // outputs: string[] - an arrayOfStrings
    
    int sum = 0;
    foreach (string number in numbers)
    {
        sum += int.Parse(number);
    }

    System.Console.WriteLine("Average = " + sum / numbers.Length);



    // Join example
    string[] words = { "Hello, ", "Passionate", "Coders"};
    string joinedString = string.Join(' ', words);      // outputs: string - a string 
    System.Console.WriteLine(joinedString);

  }

static void StringBuilder___35() 


  {
        // ----------------------------- 35. StringBuilder --------------------------------------
        /*
         * Said before that strings are reference type and immutable type(its value can't be changed, unless I created a new copy of it.)
         * When to use strings?
            * Simple and little concatinations(2/3), small size strings, to avoid value duplications
        * When to use stringBuilder?
            * More concationations and bigger size strings
         * StringBuilders works internally with linkedlists, which means it has small stringBuilders under the hood works together.
        */

    string str = "Hello";   // Here Console saved a memory address for this string - 1st string in memory
    str = "Hello, World";   // saved a new memory address for this string - 2nd string in memory
    str += ", I Love Coding";   // saved a new memory address for this string - 3rd string in memory

    // Memory looks like a house consists of some number of rooms, You won't give a room for evey guest visits u, because this would cause a problem.
        // Technically speaking, strings numbers, operations and memory garbage collections are important factors that affect ur program performance.
    

    
    StringBuilder stringBuilded = new StringBuilder();  // This could be simplified to new(); - because it knows the data type already
                                                        // Could initially determine the capacity between braces -> new StringBuilder(4096) ~ 4 kilo bytes

            // String builder is also an array of characters(deals internally like a normal string), and it reserves by default 16 bytes(characters)
            System.Console.WriteLine($"String Builder Length, {stringBuilded.Length}");         // 0 cuz it's empty now
            System.Console.WriteLine($"String Builder Capacity, {stringBuilded.Capacity}");     // 16 cuz 16 bytes (16 is the default memory reservation size)
                                                                                                // It reserves with multiplies of 16, 16-32-...-2billion
                                                                                                // Don't now care about how stringBuilder capacity extends or increase
            System.Console.WriteLine($"String Builder Max Capacity, {stringBuilded.MaxCapacity}");  // 2 billion, The maximum size you can reserve in memory.

    stringBuilded.Append("Hello, ");
    stringBuilded.Append("World.");

    stringBuilded.AppendLine("I Love passionate coders.")    // Appends a copy of the specified string followed by the default line terminato r(\n) to the end of the current StringBuilder object.
  }

static void CompilationProcess___36() 


  {
        // ----------------------------- 36. Compilation Process--------------------------------------
        /*  1. Compilation Process in .Net
            --------------------------------
        *   Source Code 
                --C# Compiler--> 
        *   [Intermediate Language[IL] - Micorsoft Intermediate Lang[MSIL] - Common Intermediate Lang[CIL] ]    = dll file in the project bin folder
        *       --Common Language Runtime(CLR) - Just-in-time compilation(JIT) embedded tool/program --> 
        *    Machine Code
        *
        *   the compilation process in C# involves the following steps:

            1- Lexical analysis: The source code is broken down into tokens.

            2- Syntax analysis: The tokens are analyzed to check for any syntax errors.

            3- Semantic analysis: The code is analyzed to check for any semantic errors.

            4- Code generation: The compiler generates an intermediate language code (IL or MSIL).

            5- Optimization: The IL code is optimized to improve performance.

            6- Execution: The IL code is executed by the .NET runtime, which JIT compiles it into machine code specific to the platform it is running on.
        */
        // 

        // Compiled languages are (VB.net, C#, F#, cpp.net, java), which means there is a compiler that converts ur readable/understandable code, to a massive machine code, that machine(CPU) can understand.

        // IDE Calls the compiler to compile the file.
        // When build solution, bin & obj folders are created by the compiler.
        // exe file is created because it's a console app/wpf app, and also outputs a dll file.

        // You can get the IL of the source code by typing 'ildasm/text/dll file name' in developer cmd, this is called IL Disassembler

        // DotNet Languages are managed code, except C++ could be managed or unmanaged code.
            // Managed(Targets the virtual machine not the processors directly) or Unmanaged code(When compiler produces Direct machine code, is usually unmanaged, and usually because even .Net languages could target processor directly)
        // CLR is a virtual machine that runs and takes the IL from ur program, and with The JITer tool starts to convert the IL into M/C code, according to ur working machine processor(64/32)
            // You won't face, bad Image format or processor architecture problems.
        // Any language uses IL(.Net, Java), are a bit slower in the startup beacause of the compilation process to IL to Machine code, but after this all called and converted code parts are ran instantly.
            // but It's kind of smart that actually CLR & JITer converts/compiles the IL on-demand, which means it only convert methods when they get called.

        // IL manages Memory mgmt, it takes care of memory allocation & deallocation, automatically memory garbage collection, security boundaries[no process overlaps with another process], this in contrast of CPP which there you have to allocate and deallocate memory to avoid memory leakage.

        // MC[M/c Code] are represented using Hexadecimal to make the code readable.
        // Common means that all .NET languages are converted to IL, whether you write(VB.net, C#, F#) it gets converted to IL Code, that's why it's called common.

        // TODO: Read about CTS(Common type system) and CLS(common lang specs).

  }
static void ClassesObjects___37___________() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Constructor___38() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Properties___39() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Namespaces___40() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void AccessModifiers___41() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void ConstantReadonlyVariables___42() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Namespaces___43() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Namespaces___44() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Namespaces___45() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Namespaces___46() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void Namespaces___47() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___48() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___49() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___50() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___51() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___52() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___53() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }

static void StringSplitJoin___54() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___55() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___56() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }
static void StringSplitJoin___57() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }

static void StringSplitJoin___58() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }

static void StringSplitJoin___59() 


  {
        // ----------------------------- 33. String Formatting at 7:00 min --------------------------------------
        /*
         * 
         * 
         * 
        */
        // 



  }


static void OOP() 
  {
    // ----------------------------- OOP -------------------------------------
        /*
            OOP is a Programming paradigm/style/approach
            منهجية أو طريقة تفكير أو رؤيتك ومنظورك للسيستم اللى بتبنيه هتبقى ازاى

            - backthen in C & VB6, we used the imperative or procedural approach, and the primitive data types
                by the time, those approaches and those primitive datatypes
                become no longer able to satisfy the complexity in business requirements, that's when oop tookplace.

            - OOP inspired from the nature, every thing is an object interacts with each other,
                and each object has some attributes[hair color, gender] and do some action[eat-sleep].

            - Object is an instance[example] of a class, class is a blueprint for the object.
            - Class is a blueprint/metadata[map] for the object, tells u the attributes & actions that the object can have/do.
                but the real actual representing data itself is stored in the object.
                e.g. Class Man: Property[name, hairColor, eyeColor, height]     Action[eat, sleep, walk]
                        object: actual_data["Mohamed", "brown", "blue", 176]

            OOP is built on 4 pillars:
                - Inheritance: عندى بيزكلاس فيها شوية بروبيرتيز و اكشنز، وعندى درايفد/سب/تشايلد كلاس بيورث من البيزكلاس الخصائص والحاجات بتاعته
                    Two subclasses[Man,Woman], inherit the attributes of the baseclass[human]
                    Two subclasses[Cat,Dog], inherit the attributes of the baseclass[Animal]
                
                
                - Encapsulation: بتحمى البروبيتيس او الخصائص من انها بتعدل فيها بشكل خاطئ او يتحط قيم غير صحيحة،
                 فبحط ميثود هى اللى بتعدل ف القيم وقبلما تحط القيم بتعمل فاليديشن على الداتا اللى مديهالها وتتحقق منها
                
                - Polymorphism: تعدد الاشكال او الاوجه، الكلاس اللى اسمها انيمال جواها بيهافيور ميثود اسمها ميك_ساوند،
                    ولكن كل كلاس ساحب منه عملها بطريقة مختلفة، فالكلب هوهو،
                    والقطة نونوت، فبالتالى هو نفس البيهافيور بس التنفيذ بتاعه اختلف مع اختلاف الكلاسز
                
                - Abstraction:بعزل أو بخلى الامبليمنتيشن لوجيك بتاع سلوك معين للاوبجكت بتاعى، بخبيه او بعزلك عن تفاصيله
                    انت مبتشوفش ايه الحاجات اللى بتتنفذ اثناء صرافة مكنة سحب الفلوس، دى معلومة معزولة عنك
                    انت بتشغل العربية وانت متعرفش دورة البنزين عاملة ازاى، انت بتمشى وخلاص

        */
  }




}

