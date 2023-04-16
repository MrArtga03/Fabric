using ClassLibrary1.Classes;
using ClassLibrary1.ClassesCreators;

class Program
{
    static void Main(string[] args)
    {
        Developer developer = new PanelDeveloper("Панельный застройщик Ком партия!");
        House house1 = developer.Create();


        developer = new WoodDeveloper("Деревянный застройщик Ком партия!");
        House house2 = developer.Create();
    }
}