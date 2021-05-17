//Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters '5, 3, 8, 1, 4', the program should display 8.");
            
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
