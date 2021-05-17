//Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display 'Invalid List' and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.");
            
tring[] elements;
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