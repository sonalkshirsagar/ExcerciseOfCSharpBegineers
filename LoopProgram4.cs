//Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display 'You won'; otherwise, display 'You lost'.(To make sure the program is behaving correctly, you can display the secret number on the console first.)
           

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