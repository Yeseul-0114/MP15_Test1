namespace MP15_Test1;

public class Guest<T> : Menu
{
    public Guest(string menuName, Type menuType, int price) : base(menuName, menuType, price)
    {
    }

    private List<Menu> Bag = new List<Menu>() { };
    

    
}