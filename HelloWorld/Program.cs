using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
                var p = new Program();
                Console.WriteLine("Type a year to check if it is a leap year!");
                var input = Console.ReadLine();
                var output = p.getUserPromt(input);
                Console.WriteLine(output);
        }
        public string getUserPromt(string year) 
        
        {
            if(isLeapYear(year) == true) 
            {
                return "yay";
            } else 
            {
                return "nay";
            }
        }

        public bool isLeapYear(string year) {

            var input = Int32.Parse(year);

            if(input < 1582) {
                throw new YearLessThan1582Exception("Du skal skrive et år før 1582");
            }
        
                 if(input % 100 == 0 && input % 400 == 0){
                return true;
                } else if (input % 100 == 0) {
                    return false;
                } else if(input % 4 == 0) {
                    return true;
                } else {
                    return false;
                }
            } 
            
           

        }
    }

