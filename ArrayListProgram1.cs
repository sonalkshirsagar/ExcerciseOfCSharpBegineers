// When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.\n 1.1 .If no one likes your post, it doesn't display anything. \n 1.2 .If only one person likes your post, it displays: [Friend's Name] likes your post.\n 1.3 .If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.\n 1.4.If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.\n 1.5 .Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name).Depending on the number of names provided, display a message based on the above pattern.");
            
ar names = new List<string>();

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
