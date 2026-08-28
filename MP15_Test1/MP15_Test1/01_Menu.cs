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
    
    public void PrintInfo()
    {
        Console.WriteLine($"{MenuName}_{MenuType} : {Price}원");
        
    }

}