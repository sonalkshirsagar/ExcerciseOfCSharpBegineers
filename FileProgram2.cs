//Write a program that reads a text file and displays the longest word in the file.

System.IO.StreamReader File = new System.IO.StreamReader(@"E:\C#Code\ExcerciseOfBeginners\ExcerciseOfBeginners\TestFile.txt");

                    string Line =File.ReadLine() ;
                    string[] Words = Line.Split(new[] { " " }, StringSplitOptions.None);
                    string word = "";
                    int ctr = 0;
                    foreach (String s in Words)
                    {
                        if (s.Length > ctr)
                        {
                            word = s;
                            ctr = s.Length;
                        }
                    }

                    Console.WriteLine(word);
