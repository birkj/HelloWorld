using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("Type a year to check if it is a leap year!");
            var input = Int32.Parse(Console.ReadLine());
            var output = p.getUserPromt(input);
            Console.WriteLine(output);


        }

        public string getUserPromt(int year) {
            if(isLeapYear(year) == true) {
                return "yay";
            } else {
                return "nay";
            }
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
