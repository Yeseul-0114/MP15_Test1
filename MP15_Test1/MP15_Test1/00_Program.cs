using System;
using MP15_Test1;
using Type = MP15_Test1.Type;

class Program
{
    public const string STOR_NAME = "무인 아이스크림 1호점";
    public const int DISCOUNT = 3;
    public const float DISCOUNT_RATE = 0.2f;

    static void Main(string[] args)
    {
        Menu[] ice = new Menu[]
        {
            new Things("바밤바", (Type)0, 600),
            new Things("죠스바", (Type)0, 600),
            new Things("브라보콘", (Type)1, 1500),
            new Things("죠리뽕", (Type)2, 1700),
            new Things("꼬북칩", (Type)2, 1700),
        };

        Line();
        Console.WriteLine($"[{STOR_NAME}] 주문 키오스크");
        Line();
        Console.WriteLine();
        Console.WriteLine("[구매하실 상품을 선택하세요.]");
        Menu.PrintInfo(ice);
        Console.WriteLine();
        Line();
        Console.WriteLine("[장바구니]");
        Line();
        
        


      
    }
    static void Line()
    {
        Console.WriteLine("====================================");
    }
}

   
