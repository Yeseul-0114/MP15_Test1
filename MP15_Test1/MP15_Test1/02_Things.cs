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

    public static int DiscountPrice(int buyCount,int price,Type type, float DiscountRate)
    {
        int totalDiscount = 0;
        if (buyCount >= 5) // 5개 이상 사면 20% 할인
        {
            totalDiscount = (int)(buyCount * price * DiscountRate);
        }
        else if (type == Type.Snack && buyCount >= 2) // 과자 2+1 행사
        {
            int free = 0;
            free = buyCount / 2;
            totalDiscount = free * 1700;
        }
        else
        {
        }

        return totalDiscount;
    }

}
