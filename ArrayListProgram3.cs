//Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.");
  
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