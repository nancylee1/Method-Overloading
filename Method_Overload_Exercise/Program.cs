﻿//Exercise 1:
//Create a new Console app in Visual Studio Community.
//Create a method named Add, that accepts two integers and returns the sum of those two integers
//Now create an overload of the Add method to account for being able to add two decimals together
//Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
//If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
//You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
//For example:

//“5 dollars”

//"1 dollar”

//“16 dollars”

using Method_Overload_Exercise;

//Console.WriteLine(Methods.Add(5, 2));

//Console.WriteLine(Methods.Add(5.11m, 2.22m));

Console.WriteLine(Methods.Add(1.00m, 0.00m, true));

