using System;
using System.Collections.Generic;

namespace ExcerciseOfBeginners
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine("*** EXCERCISES OF COURSE C# FOR BEGINNERS ***");
            Console.WriteLine();
            Console.WriteLine("Conditional Programs :");
            Console.WriteLine("\n1. Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display 'Valid' on the console. Otherwise, display 'Invalid'. (This logic is used a lot in applications where values entered into input boxes need to be validated.)");
            Console.WriteLine("2. Write a program which takes two numbers from the console and displays the maximum of the two.");
            Console.WriteLine("3. Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.");
            Console.WriteLine("4. Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.");

            Console.WriteLine("Loop Programs : ");
            Console.WriteLine("\n5. Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the result on the console.");
            Console.WriteLine("6. Write a program and continuously ask the user to enter a number or 'ok' to exit. Calculate the sum of all the previously entered numbers and display it on the console.");
            Console.WriteLine("7. Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.");
            Console.WriteLine("8. Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display 'You won'; otherwise, display 'You lost'.(To make sure the program is behaving correctly, you can display the secret number on the console first.)");
            Console.WriteLine("9. Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters '5, 3, 8, 1, 4', the program should display 8.");
            Console.WriteLine();
            Console.WriteLine("Arrays and List Programs : ");
            Console.WriteLine("\n10. When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.\n 1.1 .If no one likes your post, it doesn't display anything. \n 1.2 .If only one person likes your post, it displays: [Friend's Name] likes your post.\n 1.3 .If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.\n 1.4.If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.\n 1.5 .Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).Depending on the number of names provided, display a message based on the above pattern.");
            Console.WriteLine("11. Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.");
            Console.WriteLine("12. Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.");
            Console.WriteLine("13. Write a program and ask the user to continuously enter a number or type 'Quit' to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.");
            Console.WriteLine("14. Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display 'Invalid List' and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.");
            Console.WriteLine();
            Console.WriteLine("File Programs : ");
            Console.WriteLine("\n15. Write a program that reads a text file and displays the number of words.");
            Console.WriteLine("16. Write a program that reads a text file and displays the longest word in the file.");
            Console.WriteLine();
            Console.WriteLine("String Programs : ");
            Console.WriteLine("\n17. Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is'5-6-7-8-9' or '20-19-18-17-16', display a message: 'Consecutive'; otherwise, display 'Not Consecutive'.");
            Console.WriteLine("18. Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter without supplying an input, exit immediately; otherwise, check to see if there are any duplicates. If so, display 'Duplicate' on the console.");
            Console.WriteLine("19. Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).A valid time should be between 00:00 and 23:59. If the time is valid, display 'Ok'; otherwise, display 'Invalid Time'. If the user doesn't provide any values, consider it as invalid time.");
            Console.WriteLine("20. Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase convention. For example, if the user types: 'number of students', display 'NumberOfStudents'. Make sure the program is not dependent on the casing of the input. So if the input is 'NUMBER OF STUDENTS', it should still display 'NumberOfStudents'. If the user doesn't supply any words, display 'Error'.");
            Console.WriteLine("21. Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters 'inadequate', the program should display 6 on the console. Make sure the program calculates the number of vowels irrespective of the casing of the word (eg 'Inadequate', 'inadequate' and 'INADEQUATE' all include 6 vowels).");
            Console.WriteLine();
            
            Console.WriteLine("\nEnter Your Choice : ");
            var Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.Write("Enter a number between 1 to 10: ");
                    var input = Console.ReadLine();
                    var number = Convert.ToInt32(input);
                    if (number >= 1 && number <= 10)
                        Console.WriteLine("Valid");
                    else
                        Console.WriteLine("Invalid");
                    
                    break;

                case 2:

                    Console.Write("Enter a number: ");
                    var no1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter another number: ");
                    var no2 = Convert.ToInt32(Console.ReadLine());

                    var max = (no1 > no2) ? no1 : no2;
                    Console.WriteLine("Max is " + max);
                    
                    
                    break;

                case 3:
                    var landscape = "Landscape";
                    var portrait = "Portrait";

                    Console.Write("Image width: ");
                    var width = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Image height: ");
                    var height = Convert.ToInt32(Console.ReadLine());

                    var orientation = width > height ? landscape : portrait;
                    Console.WriteLine("Image orientation is " + orientation);


                    break;

                case 4:
                    Console.Write("What is the speed limit? ");
                    var speedLimit = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is the speed of this car? ");
                    var carSpeed = Convert.ToInt32(Console.ReadLine());

                    if (carSpeed < speedLimit)
                        Console.WriteLine("Ok");
                    else
                    {
                        const int kmPerDemeritPoint = 5;
                        var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                        if (demeritPoints > 12)
                            Console.WriteLine("License Suspended");
                        else
                            Console.WriteLine("Demerit points: " + demeritPoints);
                    }
                    
                    break;

                case 5:
                    var count = 0;
                    for (var i = 1; i <= 100; i++)
                    {
                        if (i % 3 == 0)
                            count++;
                    }
                    Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
                    
                    break;

                case 6:
                    var sum = 0;
                    while (true)
                    {
                        Console.Write("Enter a number (or 'ok' to exit): ");
                        var userInput = Console.ReadLine();

                        if (userInput.ToLower() == "ok")
                            break;

                        sum += Convert.ToInt32(userInput);
                    }
                    Console.WriteLine("Sum of all numbers is: " + sum);

                    break;

                case 7:
                    
                    Console.Write("Enter a number: ");
                    var Number = Convert.ToInt32(Console.ReadLine());

                    var factorial = 1;
                    for (var i = 1; i <= Number; i++)
                        factorial *= i;

                    Console.WriteLine("{0}! = {1}", Number, factorial);

                    break;

                case 8:

                    var number1 = new Random().Next(1, 10);

                    Console.WriteLine("Secret is " + number1);
                    for (var i = 0; i < 4; i++)
                    {
                        Console.Write("Guess the secret number: ");
                        var guess = Convert.ToInt32(Console.ReadLine());

                        if (guess == number1)
                        {
                            Console.WriteLine("You won!");
                            return;
                        }
                    }

                    Console.WriteLine("You lost!");

                    break;


                case 9:
                    Console.Write("Enter commoa separated numbers: ");
                    var UserInput = Console.ReadLine();

                    var numbers = UserInput.Split(',');

                    // Assume the first number is the max 
                    var maximum = Convert.ToInt32(numbers[0]);

                    foreach (var str in numbers)
                    {
                        var number2 = Convert.ToInt32(str);
                        if (number2 > maximum)
                            maximum = number2;
                    }

                    Console.WriteLine("Max is " + maximum);

                    break;

                case 10:

                    var names = new List<string>();

                    while (true)
                    {
                        Console.Write("Type a name (or hit ENTER to quit): ");

                        var userinput = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(userinput))
                            break;
                        names.Add(userinput);
                    }

                    if (names.Count > 2)
                        Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
                    else if (names.Count == 2)
                        Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                    else if (names.Count == 1)
                        Console.WriteLine("{0} likes your post.", names[0]);
                    else
                        Console.WriteLine();

                    break;

                case 11:
                    Console.Write("What's your name? ");
                    var name = Console.ReadLine();

                    var array = new char[name.Length];
                    for (var i = name.Length; i > 0; i--)
                        array[name.Length - i] = name[i - 1];

                    var reversed = new string(array);
                    Console.WriteLine("Reversed name: " + reversed);

                    break;

                case 12:
                    var number3 = new List<int>();

                    while (number3.Count < 5)
                    {
                        Console.Write("Enter a number: ");
                        var number4 = Convert.ToInt32(Console.ReadLine());
                        if (number3.Contains(number4))
                        {
                            Console.WriteLine("You've previously entered " + number4);
                            continue;
                        }

                        number3.Add(number4);
                    }
                    number3.Sort();

                    foreach (var number4 in number3)
                        Console.WriteLine(number4);

                    break;


                case 13:
                    var nUMBER = new List<int>();

                    while (true)
                    {
                        Console.Write("Enter a number (or 'Quit' to exit): ");
                        var iNPUT = Console.ReadLine();

                        if (iNPUT.ToLower() == "quit")
                            break;

                        nUMBER.Add(Convert.ToInt32(iNPUT));
                    }

                    var uniques = new List<int>();
                    foreach (var no in nUMBER)
                    {
                        if (!uniques.Contains(no))
                            uniques.Add(no);
                    }

                    Console.WriteLine("Unique numbers:");
                    foreach (var no in uniques)
                        Console.WriteLine(no);

                    break;

                case 14:
                    string[] elements;
                    while (true)
                    {
                        Console.Write("Enter a list of comma-separated numbers: ");
                        var uInput = Console.ReadLine();

                        if (!String.IsNullOrWhiteSpace(uInput))
                        {
                            elements = uInput.Split(',');
                            if (elements.Length >= 5)
                                break;
                        }

                        Console.WriteLine("Invalid List");
                    }

                    var nos = new List<int>();
                    foreach (var n in elements)
                        nos.Add(Convert.ToInt32(n));

                    var smallests = new List<int>();
                    while (smallests.Count < 3)
                    {
                        // Assume the first number is the smallest
                        var min = nos[0];
                        foreach (var n in nos)
                        {
                            if (n < min)
                                min = n;
                        }
                        smallests.Add(min);

                        nos.Remove(min);
                    }

                    Console.WriteLine("The 3 smallest numbers are: ");
                    foreach (var n in smallests)
                        Console.WriteLine(n);

                    break;

                case 15:
                  

                    String line;
                    int countWord = 0;

                    System.IO.StreamReader file = new System.IO.StreamReader(@"E:\C#Code\ExcerciseOfBeginners\ExcerciseOfBeginners\TestFile.txt");

                    while ((line = file.ReadLine()) != null)
                    {
                     
                        String[] words = line.Split(' ');
                        //Counts each word  
                        countWord = countWord + words.Length;
                    }

                    Console.WriteLine("Number of words present in given file: " + countWord);
                    file.Close();
            
                    break;

                case 16:
                    System.IO.StreamReader File = new System.IO.StreamReader(@"E:\C#Code\ExcerciseOfBeginners\ExcerciseOfBeginners\TestFile.txt");

                    string Line =File.ReadLine() ;
                    string[] Words = Line.Split(new[] { " " }, StringSplitOptions.None);
                    string word = "";
                    int ctr = 0;
                    foreach (String s in Words)
                    {
                        if (s.Length > ctr)
                        {
                            word = s;
                            ctr = s.Length;
                        }
                    }

                    Console.WriteLine(word);


                    break;

                case 17:

                    Console.Write("Enter a few numbers (eg 1-2-3-4): ");
                    var inputNo = Console.ReadLine();

                    var numbersList = new List<int>();
                    foreach (var num in inputNo.Split('-'))
                        numbersList.Add(Convert.ToInt32(num));

                    numbersList.Sort();

                    var isConsecutive = true;
                    for (var i = 1; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] != numbersList[i - 1] + 1)
                        {
                            isConsecutive = false;
                            break;
                        }
                    }

                    var message = isConsecutive ? "Consecutive" : "Not Consecutive";
                    Console.WriteLine(message);
                    
                    break;

                case 18:

                    Console.Write("Enter a few numbers (eg 1-2-3-4): ");
                    var inputno = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputno))
                        return;

                    var numberList = new List<int>();
                    foreach (var j in inputno.Split('-'))
                        numberList.Add(Convert.ToInt32(j));

                    var unique = new List<int>();
                    var includesDuplicates = false;
                    foreach (var i in numberList)
                    {
                        if (!unique.Contains(i))
                            unique.Add(i);
                        else
                        {
                            includesDuplicates = true;
                            break;
                        }
                    }

                    if (includesDuplicates)
                        Console.WriteLine("Duplicate");
                    break;

                case 19:

                    Console.Write("Enter time: ");
                    var inputTime = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputTime))
                    {
                        Console.WriteLine("Invalid Time");
                        return;
                    }

                    var components = inputTime.Split(':');
                    if (components.Length != 2)
                    {
                        Console.WriteLine("Invalid Time");
                        return;
                    }

                    try
                    {
                        var hour = Convert.ToInt32(components[0]);
                        var minute = Convert.ToInt32(components[1]);

                        if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                            Console.WriteLine("Ok");
                        else
                            Console.WriteLine("Invalid Time");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid Time");
                    }


                    break;
                case 20:

                    Console.Write("Enter a few words: ");
                    var inputWord = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputWord))
                    {
                        Console.WriteLine("Error");
                        return;
                    }

                    var variableName = "";
                    foreach (var wrd in inputWord.Split(' '))
                    {
                        var wordWithPascalCase = char.ToUpper(wrd[0]) + wrd.ToLower().Substring(1);
                        variableName += wordWithPascalCase;
                    }

                    Console.WriteLine(variableName);

                    break;


                case 21:

                    Console.Write("Enter a word: ");
                     
                    var inputword = Console.ReadLine().ToLower();

                    var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
                    var vowelsCount = 0;
                    foreach (var character in inputword)
                    {
                        if (vowels.Contains(character))
                            vowelsCount++;
                    }

                    Console.WriteLine(vowelsCount);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }
            
        }
    }
}
