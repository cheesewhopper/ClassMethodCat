using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    internal class Cat
    { 
        // cat the cs 는 설계도
        // internal , public
        public string Name; 
        public int Age; 

        private int Happiness = 50; // Happiness의 값이 변화가 없어야 해서 private 선언 

        //생성자는 무조건 public - 호출을 해야하기 때문 , retrun값이 없다.
        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            //this를 쓰는 이유
        }

        public void GetBorad()
        {
            Happiness = Happiness - 10;
            if (Happiness < 0)
                Happiness = 0;
        }

        public void play()
        {
            //함수
            Happiness = Happiness + 10;
            if (Happiness > 100)
                Happiness = 100;
        }
        public void Eat()
        {
            Happiness = Happiness + 20;
            if (Happiness > 100)
                Happiness = 100;
        }
        public string Express()
        {
            string message = "";

            if (Happiness >= 80)
                message = "Cat : Very happy";
            else if (Happiness >= 60)
                message = "Cat : Happy";
            else if (Happiness >= 40)
                message = "Cat : So so";
            else if (Happiness >= 20)
                message = "Cat : Gloomy";
            else
                message = "Cat : Sad";
            return this.Name + ": " + message;
            
        }

    }
}
