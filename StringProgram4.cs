//Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase convention. For example, if the user types: 'number of students', display 'NumberOfStudents'. Make sure the program is not dependent on the casing of the input. So if the input is 'NUMBER OF STUDENTS', it should still display 'NumberOfStudents'. If the user doesn't supply any words, display 'Error'.

Console.Write("Enter a few words: ");
                    var inputWord = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputWord))
                    {
                        Console.WriteLine("Error");
                        return;
                    }

                    var variableName = "";
                    foreach (var wrd in inputWord.Split(' '))
                    {
                        var wordWithPascalCase = char.ToUpper(wrd[0]) + wrd.ToLower().Substring(1);
                        variableName += wordWithPascalCase;
                    }

                    Console.WriteLine(variableName);
