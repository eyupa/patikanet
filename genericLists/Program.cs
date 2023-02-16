namespace genericLists;
class Program
{
    static void Main(string[] args)
    {
        //List<T> class
        //System. Collection.Generic namespace
        //T is a generic type parameter that will be replaced by a real type when an instance of the class is created
        //T can be any type: int, string, double, etc.
        //T can be a value type or a reference type
        List<int> numbers = new List<int>();
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);
        numbers.Add(60);
        List<string> colors = new List<string>();
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");
        colors.Add("Yellow");
        colors.Add("Orange");
        colors.Add("Purple");
        System.Console.WriteLine("numbers" + numbers.Count);
        System.Console.WriteLine("colors:" + colors.Count);


        //Display the contents of the lists
        Console.WriteLine("Numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        System.Console.WriteLine("Colors:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }


        numbers.ForEach(number => Console.WriteLine(number));
        colors.ForEach(color => Console.WriteLine(color));

        //Insert an item into the list at a specific index

        numbers.Insert(2, 25);
        colors.Insert(2, "Pink");
        //remove an item from the list
        numbers.Remove(40);
        colors.Remove("Orange");



        //remove an item from the list at a specific index
        numbers.RemoveAt(3);
        colors.RemoveAt(3);

        //remove all items from the list
        numbers.Clear();
        colors.Clear();
        //check if an item exists in the list
        if (numbers.Contains(10))
        {
            Console.WriteLine("10 is in the list");
        }
        else
        {
            Console.WriteLine("10 is not in the list");
        }
        //find the index of an item in the list
        int index = colors.IndexOf("Green");
        if (index != -1)
        {
            Console.WriteLine("Green is at index " + index);
        }
        else
        {
            Console.WriteLine("Green is not in the list");
        }


        //find the last index of an item in the list
        int lastIndex = colors.LastIndexOf("Green");
        if (lastIndex != -1)
        {
            Console.WriteLine("Green is at index " + lastIndex);
        }
        else
        {
            Console.WriteLine("Green is not in the list");
        }
        //contain the number of items in the list
        Console.WriteLine("numbers:" + numbers.Count);

        //eleman ile indexi bulma
        int index2 = colors.FindIndex(color => color == "Green");
        Console.WriteLine("Green is at index " + index2);
        System.Console.WriteLine(colors.BinarySearch("Green"));


        //convert a list to an array
        int[] numbersArray = numbers.ToArray();
        string[] colorsArray = colors.ToArray();
        //sort a list
        numbers.Sort();
        colors.Sort();


        //reverse a list
        numbers.Reverse();
        colors.Reverse();


        //copy a list to an array
        int[] numbersArray2 = new int[3];
        numbers.CopyTo(numbersArray2, 0);
        string[] colorsArray2 = new string[3];
        colors.CopyTo(colorsArray2, 0);


        //create a list from an array
        List<int> numbers3 = new List<int>(numbersArray);
        List<string> colors3 = new List<string>(colorsArray);

        string[] animals = { "Cat", "Dog", "Bird", "Fish" };
        List<string> animalsList = new List<string>(animals);
        foreach (string animal in animalsList)
            System.Console.WriteLine(animal);
        //create a list from another list
        List<int> numbers4 = new List<int>(numbers);
        List<string> colors4 = new List<string>(colors);

        //create a list with a specific capacity
        List<int> numbers5 = new List<int>(100);

        //create a list with a specific capacity and initial value
        //List<int> numbers6 = new List<int>(100, 0);
        //List<string> colors6 = new List<string>(100, "Red");

        //List içerisinde nesne tutmak
        List<Users> users = new List<Users>();
        Users user1 = new Users();
        user1.Name = "Ahmet";
        user1.Surname = "Yılmaz";
        user1.Age = 25;
        Users user2 = new Users();
        user2.Name = "Eyup";
        user2.Surname = "Agaogullari";
        user2.Age = 30;

        users.Add(user1);
        users.Add(user2);

        List<Users> yeniListe = new List<Users>();
        yeniListe.Add(new Users() { Name = "Ahmet2", Surname = "Yılmaz", Age = 25 });
        yeniListe.Add(new Users() { Name = "Eyup2", Surname = "Agaogullari", Age = 30 });

        foreach (Users user in users)
        {
            System.Console.WriteLine(user.Name);
            System.Console.WriteLine(user.Surname);
            System.Console.WriteLine(user.Age);
        }

        foreach (var user in yeniListe)
        {
            System.Console.WriteLine(user.Name);
            System.Console.WriteLine(user.Surname);
            System.Console.WriteLine(user.Age);
        }

        yeniListe.Clear();




    }
}


public class Users
{
    private string name;
    private string surname;
    private int age;
    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Age { get => age; set => age = value; }
}

