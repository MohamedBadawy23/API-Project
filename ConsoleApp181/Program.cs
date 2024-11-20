namespace ConsoleApp181
{

    //1


    //enum WeekDays
    //        {
    //            Monday,
    //            Tuesday,
    //            Wednesday,
    //            Thursday,
    //            Friday,
    //            Saturday,
    //            Sunday
    //        }
    //2
    //public struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    //3

    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}
    //4

    //[Flags]
    //enum Permissions
    //    {
    //        None = 0,
    //        Read = 1,
    //        Write = 2,
    //        Delete = 4,
    //        Execute = 8
    //    }
    //5




    //[Flags]
    //    enum Colors
    //    {
    //        None = 0,
    //        Red = 1,
    //        Green = 2,
    //        Blue = 4
    //    }
    //6
    //struct Point
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}
    //7
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}

    class Program
        {
        static void Main(string[] args)
        {
            //foreach (string day in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            //2

            //Person[] persons = new Person[3];

            //persons[0].Name = "John Doe";
            //persons[0].Age = 25;

            //persons[1].Name = "Jane Smith";
            //persons[1].Age = 30;

            //persons[2].Name = "Bob Johnson";
            //persons[2].Age = 35;

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //3
            //string input = Console.ReadLine();

            //Season season;
            //if (Enum.TryParse(input, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Month range: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Month range: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Month range: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Month range: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season. Please try again.");
            //}


            //}
            //5
            //Console.Write("Enter a color (Red, Green, Blue): ");
            //string inputColor = Console.ReadLine();

            //Colors color;
            //if (Enum.TryParse(inputColor, out color))
            //{
            //    if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
            //    {
            //        Console.WriteLine($"{inputColor} ");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputColor} ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color");
            //}
            //6
            //    Console.Write("Enter X coordinate of point 1: ");
            //    int x1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter Y coordinate of point 1: ");
            //    int y1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter X coordinate of point 2: ");
            //    int x2 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter Y coordinate of point 2: ");
            //    int y2 = Convert.ToInt32(Console.ReadLine());

            //    Point point1 = new Point { X = x1, Y = y1 };
            //    Point point2 = new Point { X = x2, Y = y2 };

            //    double distance = CalculateDistance(point1, point2);

            //    Console.WriteLine($"The distance between the two points is: {distance:F2}");
            //}

            //static double CalculateDistance(Point point1, Point point2)
            //{
            //    int deltaX = point2.X - point1.X;
            //    int deltaY = point2.Y - point1.Y;

            //    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            //7
        //    Person[] persons = new Person[3];

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.Write($"Enter name of person {i + 1}: ");
        //        string name = Console.ReadLine();

        //        Console.Write($"Enter age of person {i + 1}: ");
        //        int age = Convert.ToInt32(Console.ReadLine());

        //        persons[i] = new Person { Name = name, Age = age };
        //    }

        //    Person oldestPerson = FindOldestPerson(persons);

        //    Console.WriteLine($"The oldest person is {oldestPerson.Name} with an age of {oldestPerson.Age}.");
        //}

        //static Person FindOldestPerson(Person[] persons)
        //{
        //    Person oldestPerson = persons[0];

        //    for (int i = 1; i < persons.Length; i++)
        //    {
        //        if (persons[i].Age > oldestPerson.Age)
        //        {
        //            oldestPerson = persons[i];
        //        }
        //    }

        //    return oldestPerson;


        }


        }
    
 }
