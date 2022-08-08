
class Hero
{
    public string Name;

    public string Sex;
    public string Rase;
    public string Class;
    Dictionary Skills =new Dictionary<string, int>()
    {
        {"сила",0},
        {"удача",0},
        {"ловкость",0},
        {"харизма",0},
        {"эмпатия",0},
        {"красноречие",0},

    } 
}




class Program
{
    static void SelectRase(Hero )
    {
        string[] namesRase = {"Люди", "Эльфы", "Гномы", "Орки", "Гоблины"};
        Console.WriteLine("Выбери свою расу");
        Select(nameRase);
        string RaseHero = namesRace[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали расу" + RaseHero);

    }

    static void SelectSex()
    {
        string[] namesSex = {"мужской", "женский"};
        Console.WriteLine("Выбери пол");
        Select(namesSex);
        string SexHero = namesSex[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали пол" + SexHero);

    }


    static void SelectClass()
    {
        string[] namesClass = {"Воин", "Разбойник", "Маг", "Вор"};
        Console.WriteLine("Выбери класс");
        Select(namesClass);
        string ClassHero = namesClass[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали класс" + ClassHero);

    }
        static void Select(string[] words)

        for(int i = 0; i < words.Length-1; i++)
        {
            Console.Write(i+1 + " - " + words[i] + ", ");
        }
        
            Console.Write(words.Length + " - " + words[words.Length-1] +".");
            Console.WriteLine("");
            
        
    }  

    static void Main(string[] args)
    {
        Hero myHero = new Hero();
        Console.WriteLine("Как вас зовут");
        my()
       SelectRase(myHero);
       SelectSex(myHero);
       SelectClass(myHero);
    }
}
    
