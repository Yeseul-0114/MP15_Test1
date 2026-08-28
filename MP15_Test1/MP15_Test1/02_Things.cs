namespace MP15_Test1;

public enum Type
{
    StickIce,
    ConIce,
    Snack
}

public class Things : Menu
{
    public Things(string name, Type type, int price) : base(name, type, price)
    {
    }

    private Menu[] ice = new Menu[]
    {
        new Things("바밤바",(Type)0, 600),
        new Things("죠스바",(Type)0, 600),
        new Things("브라보콘",(Type)1, 1500),
        new Things("죠리뽕",(Type)2, 1700),
        new Things("꼬북칩",(Type)2, 1700),
    };
    
    
    
}
