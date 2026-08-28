using  System;
class Program
{
        public const string STOR_NAME = "무인 아이스크림 1호점";
        public const int DISCOUNT = 3;
        public const float DISCOUNT_RATE = 0.2f;

        void Main(string[] args)
        {
                Line();
                Console.WriteLine($"[{STOR_NAME}] 주문 키오스크");
                Line();
                Console.WriteLine("[구매하실 상품을 선택하세요.]");

        }

        public void Line()
        {
                Console.WriteLine("====================================");
        }
}

