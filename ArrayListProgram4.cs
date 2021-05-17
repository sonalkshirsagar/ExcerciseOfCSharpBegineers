//Write a program and ask the user to continuously enter a number or type 'Quit' to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

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