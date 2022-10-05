abstract class GeoObj
{
    public static int x;
    public static int y;
    public static string name;
    public static string description;
    public GeoObj(int _x, int _y, string _name, string _description)
    {
        x = _x;
        y = _y;
        name = _name;
        description = _description;
    }
    virtual public string GetInfo(int x, int y, string name, string description, int speed, int hight)
    {
        return "Coordinate X: " + x + "\n" + "Coordinate Y: " + y + "\n" + "Name: " + name + "\n" + "Description: " + description + "\n";
    }
}
class River : GeoObj
{
    private int speed;
    public River(int _speed) : base(x, y, name, description)
    {
        speed = _speed;
    } 
    public override string GetInfo(int x, int y, string name, string description, int speed, int hight)
    {
        return "Coordinate X: " + x + "\n" + "Coordinate Y: " + y + "\n" + "Name: " + name + "\n" + "Description: " + description + "\n" + "Flow speed: " + speed + "km/h";
    }
}
class Mountain : GeoObj
{
    private int hight;
    public Mountain(int _hight) : base(x, y, name, description)
    {
        hight = _hight;
    }
    public override string GetInfo(int x, int y, string name, string description, int speed, int hight)
    {
        return "Coordinate X: " + x + "\n" + "Coordinate Y: " + y + "\n" + "Name: " + name + "\n" + "Description: " + description + "\n" + "Mountain's highest spot: " + hight + "m";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int x;
        int y;
        string name;
        string description;
        string obj;
        int speed = 0;
        int hight = 0;
        int check;
        Console.WriteLine("Enter the coordinate X of the object");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the coordinate Y of the object");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name of the object");
        name = Console.ReadLine();
        Console.WriteLine("Enter the description of the object");
        description = Console.ReadLine();
        Console.WriteLine("Choose wether the object is a RIVER or a MOUNTAIN");
        obj = Console.ReadLine();
        while (obj != "RIVER" && obj != "MOUNTAIN")
        {
            Console.WriteLine("Incorrect input. Try again");
            obj = Console.ReadLine();
        }
        if (obj == "RIVER")
        {
            Console.WriteLine("Enter the flow speed");
            speed = Convert.ToInt32(Console.ReadLine());
            River riv = new River(speed);
            Console.WriteLine("Type 1 to get information about your object");
            check = Convert.ToInt32(Console.ReadLine());
            while (check != 1)
            {
                Console.WriteLine("Incorrect input. Try again");
                check = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(riv.GetInfo(x, y, name, description, speed, hight));
            }
        else if (obj == "MOUNTAIN")
        {
            Console.WriteLine("Enter the highest spot of the mountain");
            hight = Convert.ToInt32(Console.ReadLine());
            Mountain mount = new Mountain(hight);
            Console.WriteLine("Type 1 to get information about your object");
            check = Convert.ToInt32(Console.ReadLine());
            while (check != 1)
            {
                Console.WriteLine("Incorrect input. Try again");
                check = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mount.GetInfo(x, y, name, description, speed, hight));
            }
    }
}