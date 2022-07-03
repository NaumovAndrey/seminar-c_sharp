//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

class Program
{
    static double numbers(string user_number)
    {
        Console.Write(user_number);
        string str = Console.ReadLine();
        double num = Convert.ToDouble(str);
        return num;
    }
    static double distanceAB(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double resultat = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
        return resultat;
    }
    static void Main(string[] args)
    {
        try
        {
            double us_num_x1 = numbers("Enter a number X1: ");
            double us_num_y1 = numbers("Enter a number Y1: ");
            double us_num_z1 = numbers("Enter a number Z1: ");
            double us_num_x2 = numbers("Enter a number X2: ");
            double us_num_y2 = numbers("Enter a number Y2: ");
            double us_num_z2 = numbers("Enter a number Z2: ");

            double result = distanceAB(us_num_x1, us_num_y1, us_num_z1, us_num_x2, us_num_y2, us_num_z2);
            Console.WriteLine("The distance between two points is equal to " + result + " conditional units");
        }
        catch (Exception) { Console.WriteLine("Incorrect data");}
    }
}