//Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.");
            

Console.Write("What's your name? ");
                    var name = Console.ReadLine();

                    var array = new char[name.Length];
                    for (var i = name.Length; i > 0; i--)
                        array[name.Length - i] = name[i - 1];

                    var reversed = new string(array);
                    Console.WriteLine("Reversed name: " + reversed);
