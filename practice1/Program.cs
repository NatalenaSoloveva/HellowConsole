
class Hero 
{
    public string Name;
    public string Sex;
    public string Rase;
    public string Class;
Dictionary<string,int> Skills = new Dictionary<string, int>()
 {
        {"сила",0},
        {"удача",0},
        {"ловкость",0},
        {"харизма",0},
        {"эмпатия",0},
        {"красноречие",0},
 };
}





    




class Program
{
    

    static void SelectRase(Hero myHero)
    {
        string[] namesRase = {"Люди","Эльфы","Гномы","Орки","Гоблины"};
        Console.WriteLine("Выбери свою расу");
        Select(namesRase);
        string RaseHero = namesRase[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали расу " + RaseHero);
        myHero.Rase = RaseHero;
    }


        



    static void SelectSex(Hero myHero)
    {
        string[] namesSex = {"мужской", "женский"};
        Console.WriteLine("Выбери пол");
        Select(namesSex);
        string SexHero = namesSex[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали пол " + SexHero);
        myHero.Sex = SexHero;    
    }


    static void SelectClass(Hero myHero)
    {
        string[] namesClass = {"Воин", "Разбойник", "Маг", "Вор"};
        Console.WriteLine("Выбери класс");
        Select(namesClass);
        string ClassHero = namesClass[Convert.ToInt32(Console.ReadLine())-1];
        Console.WriteLine("Вы выбрали класс " + ClassHero);
        myHero.Class = ClassHero;   
    }
        
static void Select(string[] words)
{
     for(int i = 0; i < words.Length-1; i++)
        {
            Console.Write(i+1 + "-" + words[i] + ", ");
        }
        Console.Write(words.Length + "-" + words[words.Length-1] + ".");
        Console.WriteLine("");

}






    static void Main(string[] args)
    {
       Hero myHero = new Hero();
       Console.WriteLine("как вас зовут?");
       myHero.Name = Console.ReadLine();
       SelectRase(myHero);
       SelectSex(myHero);
       SelectClass(myHero);

       Console.WriteLine("все наши характеристики");
       Console.WriteLine("ваше имя " + myHero.Name);
       Console.WriteLine("ваше пол " + myHero.Sex);
       Console.WriteLine("ваша " + myHero.Rase);
       Console.WriteLine("ваш класс " + myHero.Class);
    }

    
}