//Write a program and continuously ask the user to enter a number or 'ok' to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            


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
