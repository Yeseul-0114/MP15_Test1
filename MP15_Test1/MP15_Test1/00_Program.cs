using System;
using System.Collections.Concurrent;
using MP15_Test1;
using Type = MP15_Test1.Type;

class Program
{
    public const string STOR_NAME = "무인 아이스크림 1호점";
    public const int DISCOUNT = 3;
    public const float DISCOUNT_RATE = 0.2f;
    
    public List<Menu> Bag = new List<Menu>() { };

    static void Main(string[] args)
    {
        
        Menu[] ice = new Menu[]
        {
            new Things("바밤바", (Type)0, 600),
            new Things("죠스바", (Type)0, 600),
            new Things("브라보콘", (Type)1, 1500),
            new Things("빵빠레", (Type)1, 1800),
            new Things("죠리뽕", (Type)2, 1700),
            new Things("꼬북칩", (Type)2, 1700),
        };
        
        Line();
        Console.WriteLine($"[{STOR_NAME}] 주문 키오스크");
        Line();
        Console.WriteLine("[구매하실 상품을 선택하세요.]");
        Menu.PrintInfo(ice);
        Line();
        Console.WriteLine("[장바구니]");
        Line();
        Console.WriteLine();
        int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6)-1;
        Console.WriteLine($"선택한 상품 {ice[menuNumber].MenuName}을 몇 개 구매하시겠습니까?");
        Things.Guid(menuNumber);
        int selec = ConsoleInput.ReadIntAtLeast("선택 수량 : ", 0); 
        Console.WriteLine($"{ice[menuNumber].MenuName} x {selec}   총 {ice[menuNumber].Price * selec}원");
        ConsoleInput.Pause();
        
        Console.Clear(); // 이 친구는 어디까지 지우는지 선택 불가능한가
        Console.WriteLine($"{ice[menuNumber].MenuName} x {selec}   총 {ice[menuNumber].Price * selec}원");
        int totalDiscount = Things.DiscountPrice(selec,ice[menuNumber].Price,ice[menuNumber].MenuType,DISCOUNT,DISCOUNT_RATE );
        int totalpayment = (ice[menuNumber].Price * selec) - totalDiscount;
        Console.WriteLine($"   ㄴ할인 금액은 {totalDiscount}원, 지불하실 금액은 {totalpayment}원 입니다.");
        
        ConsoleInput.Pause();
        Console.WriteLine($"어떻게 하시겠습니까?");
        Console.WriteLine($"1. 담기  2. 전체 비우기  3. 결제  4. 영업종료");
        int selecNum = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 4);

        switch (selecNum)
        {
            case 1: 
                break;
            case 2 :
                break;

            case 3:
                Console.WriteLine($"현금을 투입해주세요.");
                int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);
                Things.Payment(totalpayment,paid);
                break;
            case 4:
                Console.WriteLine();
                Console.WriteLine($"[{STOR_NAME}  영업을 종료합니다.]");
                Console.WriteLine($"      ㄴ 총 매출액 : {totalpayment} 원 /  총 판매 수량 : {selec} 개");
                break;
        }
        
        
        
        





    }
    static void Line()
    {
        Console.WriteLine("====================================");
    }
}

   
