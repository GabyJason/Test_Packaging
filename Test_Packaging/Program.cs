using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Packaging
{
    class Program
    {
        static void Main(string[] args)
        {
            //Public
            Person James = new Person();
            James.sex = "男";
            James.age = 33;
            James.Say("Hi");

            //Private
            Box Cabinet = new Box();
            Cabinet.DataBox();
            Cabinet.GetBox();

        }

        //Public
        public class Person
        {
            public string sex;
            public int age;

            public void Say(string str)
            {
                Console.WriteLine($"{str} 性別：{sex}，年紀：{age}"  );
            }
        }

        //內含 private 處理
        public class Box
        {
            private double weight;
            private double length;
            private double width;            

            public void DataBox()
            {
                weight = 3;
                length = 50.5;               
                width = 20.3;
            }
            public void GetBox()
            {
                Console.WriteLine($"面積: {length}x{width}，重量：{weight}公斤");
             
            }

        }

    }
}
