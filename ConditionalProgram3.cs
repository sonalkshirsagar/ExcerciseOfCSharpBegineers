//Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

var landscape = "Landscape";
                    var portrait = "Portrait";

                    Console.Write("Image width: ");
                    var width = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Image height: ");
                    var height = Convert.ToInt32(Console.ReadLine());

                    var orientation = width > height ? landscape : portrait;
                    Console.WriteLine("Image orientation is " + orientation);
            