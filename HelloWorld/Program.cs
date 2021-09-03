using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jens!!");
        }

        public bool isLeapYear(int year) {
            
            if(year % 100 == 0 && year % 400 == 0){
                return true;
            } else if (year % 100 == 0) {
                return false;
            } else if(year % 4 == 0) {
                return true;
            } else {
                return false;
            }

        }
    }
}
