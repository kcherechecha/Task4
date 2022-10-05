interface IGeoObj
{
    string GetInfo();
}

class River : IGeoObj
{
    private int x;
    public int y;
    public string name;
    public string description;
    private int speed;

    public River(int x, int y, string name, string description, int speed)
    {
        this.x = x;
        this.y = y;
        this.name = name;
        this.description = description;
        this.speed = speed;
    }
        
    public string GetInfo(int x, int y, string name, string description, int speed)
    {
        return "Coordinate X: " + x + "\n" + "Coordinate Y: " + y + "\n" + "Name: " + name + "\n" + "Description: " + description + "\n" + "Flow speed: " + speed + "km/h";
    }

    public string GetInfo()
    {
        throw new NotImplementedException();
    }
}

class Mountain : IGeoObj
{
    private int x;
    public int y;
    public string name;
    public string description;
    private int hight;

    public Mountain(int x, int y, string name, string description, int hight)
    {
        this.x = x;
        this.y = y;
        this.name = name;
        this.description = description;
        this.hight = hight;
    }
    
    public string GetInfo(int x, int y, string name, string description, int hight)
    {
        return "Coordinate X: " + x + "\n" + "Coordinate Y: " + y + "\n" + "Name: " + name + "\n" + "Description: " + description + "\n" + "Mountain's highest spot: " + hight + "m";

    }
    public string GetInfo()
    {
        throw new NotImplementedException();
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
        int speed;
        int hight;
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
            River riv = new River(x,y,name,description,speed);
            Console.WriteLine("Type 1 to get information about your object");
            check = Convert.ToInt32(Console.ReadLine());
            while (check != 1)
            {
                Console.WriteLine("Incorrect input. Try again");
                check = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(riv.GetInfo(x, y, name, description, speed));
            }
        else if (obj == "MOUNTAIN")
        {
            Console.WriteLine("Enter the highest spot of the mountain");
            hight = Convert.ToInt32(Console.ReadLine());
            Mountain mount = new Mountain(x,y, name, description, hight);
            Console.WriteLine("Type 1 to get information about your object");
            check = Convert.ToInt32(Console.ReadLine());
            while (check != 1)
            {
                Console.WriteLine("Incorrect input. Try again");
                check = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(mount.GetInfo(x, y, name, description, hight));
            }
    }
}