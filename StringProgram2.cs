//Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter without supplying an input, exit immediately; otherwise, check to see if there are any duplicates. If so, display 'Duplicate' on the console.");
            

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
                    