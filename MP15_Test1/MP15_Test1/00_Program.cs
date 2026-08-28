using System;
using MP15_Test1;

class Program 
{
    
    public const string STOR_NAME = "무인 아이스크림 1호점";
    public const int DISCOUNT = 3;
    public const float DISCOUNT_RATE = 0.2f;
    
    
    static void Main(string[] args)
    {   
        
        Line();
        Console.WriteLine($"[{STOR_NAME}] 주문 키오스크");
        Line();
        Console.WriteLine("[상품 목록]");
        PrintInfo();
        

    }

    public static void Line()
    {
        Console.WriteLine("====================================");
    }
    
}

