namespace MP15_Test1;
public enum Type
    {
        막대_아이스,
        콘_아이스,
        과자
    }

    public class Things : Menu
    {
        public Things(string name, Type type, int price,int bagcount) : base(name, type, price, bagcount)
        {
        }

        public static void Guid(int num)
        {
            Console.WriteLine($"** 상품 5개 이상 구입하시면 20% 할인 됩니다.");
            
            if (num == 4 || num == 5)
            {
                Console.WriteLine("** 과자는 2+1 행사중입니다. 20% 할인은 중복 적용되지 않습니다.");
            }
        }

        public static int DiscountPrice(int buyCount, int price, Type type, int discountRate, float DiscountRate)
        {
            int totalDiscount = 0;
            
            if (type == (Type)2 && buyCount >= 2) // 과자 2+1 행사
            {
                int free = 0;
                free = buyCount / 2;
                totalDiscount += free * 1700;
            }
           else if (buyCount >= 5) // 5개 이상 사면 20% 할인
            {
                totalDiscount += (int)(buyCount * price * DiscountRate);
            }
           
            return totalDiscount;
        }
        
        public static void Payment(int total, int pay)
        {
            if (total <= pay) // 거슬러주기
            {
                Console.WriteLine($"현금 {pay}원 받았습니다. 거스름돈 {pay-total}원 드립니다.");
            }
            else if (total > pay)  // 돈 부족
            {
                Console.WriteLine($"지불하신 금액이 {total-pay}원 부족합니다.");
                Console.WriteLine($"장바구니를 비웁니다");
            }
        }


    }
    