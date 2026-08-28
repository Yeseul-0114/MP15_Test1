namespace MP15_Test1;

public abstract class Menu
{
    // 멤버
    public string MenuName;
    public string MenuType;
    protected int Price { get; set; }

    // 생성자
    public Menu(string menuName, string menuType, int price)
    {
        MenuName = menuName;
        MenuType = menuType;
        Price = price;
    }
    
    
}