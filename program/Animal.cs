using System;

namespace CSClass32
{
    public class Animal
    {
        public int Age { set; get; }
        public Animal()
        {
            this.Age = 0;
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잡니다.");
        }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
    }
}