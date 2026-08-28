namespace MP15_Test1;

public abstract class Menu
{
    // 멤버
    protected string MenuName;
    public Type MenuType;
    protected int Price { get; private set; }

    // 생성자
    public Menu(string menuName, Type menuType, int price)
    {
        MenuName = menuName;
        MenuType = menuType;
        Price = price;
    }
    
    public static void PrintInfo(Menu[] things)
    {
        for(int i = 0 ; i < things.Length; i++)
        {
            Console.WriteLine($"{i+1}) {things[i].MenuName}_{things[i].MenuType} : {things[i].Price}원");

        }

    }

}