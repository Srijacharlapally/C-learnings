using System;

namespace PracticingBasics
{
    public class EnumPractice 
    {
        enum MyColors  //Example of Pascal case
        {
            Red=1,
            Blue=2,
            White=3,
            Black=4,
            Yellow=5,
        }
        public void TestEnum()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            
            // MyColors myColor = (MyColors)3;//Example of camel class
            MyColors myColor = (MyColors)input;
            if(input<=5)
            {
                if (myColor==MyColors.Red)
                {
                    Console.WriteLine("Red");
                }
                else if (myColor==MyColors.Blue)
                {
                    Console.WriteLine("Blue");
                }
                else if (myColor==MyColors.White)
                {
                    Console.WriteLine("White");
                }
                else if (myColor==MyColors.Black)
                {
                    Console.WriteLine("Black");
                }
                else if (myColor==MyColors.Yellow)`
                {
                    Console.WriteLine("Yellow");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            
    
        }
    }
}


    