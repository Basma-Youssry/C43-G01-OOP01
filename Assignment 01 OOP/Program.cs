namespace Assignment_01_OOP
{
    #region Q1
    //enum WeekDays : byte
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}
    #endregion

    #region Q2
    //enum Season
    //{

    //    Spring, Summer, Atumn, Winter

    //}





    #endregion

    #region Q3

    //[Flags]
    //enum Permissions
    //{
    //    Read = 1, Write = 2, Delete = 4, Exceute = 8
    //}


    #endregion

    #region Q4
    //enum Colors
    //{
    //    Red, Green, Blue
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Follow(Q1)


            //foreach(WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}


            #endregion


            #region Follow(Q2)
            //Console.WriteLine("Please Enter a season name");
            //string season = Console.ReadLine();

            
            //if(Enum.TryParse<Season>(season, true, out Season seasonOfYears))
            //{
            //    if (season?.Trim().ToLower() == "spring")
            //    {
            //        Console.WriteLine("march to may");
            //    }
            //    else if (season?.Trim().ToLower() == "summer")
            //    {
            //        Console.WriteLine("june to august");
            //    }
            //    else if (season?.Trim().ToLower() == "autumn")
            //    {
            //        Console.WriteLine("September to November");
            //    }
            //    else if (season?.Trim().ToLower() == "winter")
            //    {
            //        Console.WriteLine("December to February");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season enterd");
            //}


            #endregion

            #region Follow(Q3)
            //Permissions permission = (Permissions)3;

            //Console.WriteLine(permission); //Read, Write

            //Add
            //permission |= Permissions.Exceute; //Read, Write, Exceute

            // Console.WriteLine(permission);

            // if ((permission & Permissions.Exceute) == Permissions.Exceute)
            // {
            //     Console.WriteLine("Exceute permission is granted");
            // }
            // else
            // {
            //     Console.WriteLine("Exceute permission isn't granted");
            // }

            //Remove
            //permission &= ~Permissions.Write;
            //Console.WriteLine(permission);   //Read, Exceute

            //if ((permission & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is still granted");
            //}
            //else
            //{
            //    Console.WriteLine("Write is removed");
            //}
            #endregion

            #region Follow(Q4)
            //Console.Write("Please Enter a color:");

            //string input = Console.ReadLine();

            //if(Enum.TryParse<Colors>(input, true ,out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color");
            //}

            #endregion

        }
    }
}
