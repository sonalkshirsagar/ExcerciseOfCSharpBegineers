//Write a program which takes two numbers from the console and displays the maximum of the two.

Console.Write("Enter a number: ");
                    var no1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter another number: ");
                    var no2 = Convert.ToInt32(Console.ReadLine());

                    var max = (no1 > no2) ? no1 : no2;
                    Console.WriteLine("Max is " + max);
                    
                    
                    break;
            