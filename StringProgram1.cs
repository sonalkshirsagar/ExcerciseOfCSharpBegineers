//Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is'5-6-7-8-9' or '20-19-18-17-16', display a message: 'Consecutive'; otherwise, display 'Not Consecutive'.");
           
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