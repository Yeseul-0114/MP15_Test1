using System;
using System.Collections.Concurrent;
using MP15_Test1;
using Type = MP15_Test1.Type;

class Program
{
    public const string STOR_NAME = "무인 아이스크림 1호점";
    public const int DISCOUNT = 3;
    public const float DISCOUNT_RATE = 0.2f;

    public static List<Menu> bag = new List<Menu>() { };


    static void Main(string[] args)
    {
        int guestPayment = 0;
        int guestTotalCount = 0;
        int totalDiscount = 0;
        Menu[] ice = new Menu[]
        {
            new Things("바밤바", (Type)0, 600, 0),
            new Things("죠스바", (Type)0, 600, 0),
            new Things("브라보콘", (Type)1, 1500, 0),
            new Things("빵빠레", (Type)1, 1800, 0),
            new Things("죠리뽕", (Type)2, 1700, 0),
            new Things("꼬북칩", (Type)2, 1700, 0),
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

        for (int i = 0; i < 5; i++)
        {
            int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6) - 1;
            Console.WriteLine($"선택한 상품 {ice[menuNumber].MenuName}을 몇 개 구매하시겠습니까?");
            Things.Guid(menuNumber);
            int selec = ConsoleInput.ReadIntAtLeast("선택 수량 : ", 0);
            Console.WriteLine($"{ice[menuNumber].MenuName} x {selec}   총 {ice[menuNumber].Price * selec}원");
            ConsoleInput.Pause();

            Console.Clear();
            Console.WriteLine($"{ice[menuNumber].MenuName} x {selec}   총 {ice[menuNumber].Price * selec}원");
            int discount = Things.DiscountPrice(selec, ice[menuNumber].Price, ice[menuNumber].MenuType, DISCOUNT,
                DISCOUNT_RATE);
            int totalpayment = (ice[menuNumber].Price * selec) - totalDiscount;
            Console.WriteLine($"   ㄴ할인 금액은 {discount}원, 지불하실 금액은 {totalpayment}원 입니다.");

            ConsoleInput.Pause();
            Console.WriteLine($"어떻게 하시겠습니까?");
            Console.WriteLine($"1. 담기  2. 전체 비우기");
            int selecNum = ConsoleInput.ReadIntInRange("메뉴 선택 : ", 1, 2);

            if (selecNum == 1)
            {
                bag.Add(ice[menuNumber]);
                ice[menuNumber].BagCount += selec;
                totalDiscount += discount;

                Console.WriteLine($"추가로 담으시겠습니까?  1. 예  /  2. 아니오");
                int selecNum2 = ConsoleInput.ReadIntInRange("메뉴 선택 : ", 1, 2);
                if (selecNum2 == 1)
                {
                }
                else if (selecNum2 == 2)
                {
                    Console.WriteLine("결제 페이지로 넘어갑니다.");
                    break;
                }
            }
            else if (selecNum == 2)
            {
                bag.Clear();
                Console.WriteLine("장바구니를 비웁니다.");
            }
        }

        Console.WriteLine($"현금을 투입해주세요.");
        int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);

        for (int i = 0; i < bag.Count; i++)
        {
            guestPayment += (bag[i].Price * bag[i].BagCount) - totalDiscount;
            guestTotalCount += bag[i].BagCount;
        }

        Things.Payment(guestPayment, paid);

        Console.WriteLine();
        Console.WriteLine($"[{STOR_NAME}  영업을 종료합니다.]");
        Console.WriteLine($"      ㄴ 총 매출액 : {guestPayment} 원 /  총 판매 수량 : {guestTotalCount} 개");

    }

    static void Line()
    {
        Console.WriteLine("====================================");
    }
}


   
