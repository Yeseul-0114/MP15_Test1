namespace MP15_Test1;

public abstract class Menu
{
    // 멤버
    public string MenuName;
    public Type MenuType;
    public int Price;
    public int BagCount;

    // 생성자
    public Menu(string menuName, Type menuType, int price, int bagCount)
    {
        MenuName = menuName;
        MenuType = menuType;
        Price = price;
        BagCount = bagCount;
    }
    
    public static void PrintInfo(Menu[] things)
    {
        for(int i = 0 ; i < things.Length; i++)
        {
            Console.WriteLine($"{i+1}) {things[i].MenuName}_{things[i].MenuType} : {things[i].Price}원");

        }

    }

}