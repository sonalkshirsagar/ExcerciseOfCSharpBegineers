//Write a program that reads a text file and displays the number of words.
                    int countWord = 0;

                    System.IO.StreamReader file = new System.IO.StreamReader(@"E:\C#Code\ExcerciseOfBeginners\ExcerciseOfBeginners\TestFile.txt");

                    while ((line = file.ReadLine()) != null)
                    {
                     
                        String[] words = line.Split(' ');
                        //Counts each word  
                        countWord = countWord + words.Length;
                    }

                    Console.WriteLine("Number of words present in given file: " + countWord);
                    file.Close();