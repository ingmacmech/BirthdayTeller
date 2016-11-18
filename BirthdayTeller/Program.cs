using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayTeller
{
    class Program
    {
        public struct person
        {
            public string firstName;
            public string familyName;
            public int day;
            public int month;
            public int year;
            public int age;
            public void setName(string p1, string p2){
                firstName = p1;
                familyName = p2;
            }
            public void setAge( int p1){
                age = p1;
            }
            public void setBirthday(int p1, int p2, int p3){
                day = p1;
                month = p2;
                year = p3;
            }
            public int CalcAge(int p1, int p2){
                return p2 - p1;
            }
        }
        static void Main(string[] args){
            person Rolf = new person();
            string date = System.DateTime.Now.ToShortDateString();
            string[] tempDay = new string[3];
            int tempAge = 0;
            
            tempDay = date.Split('.');

            Rolf.setName("Rolf", "Muster");
            Rolf.setBirthday(12, 8, 1990);
            tempAge = Rolf.CalcAge(Rolf.year, Convert.ToInt16(tempDay[2]));
            Rolf.setAge(tempAge);

            if(Rolf.day == Convert.ToInt16(tempDay[0]) & 
               Rolf.month == Convert.ToInt16(tempDay[1]) ){
                Console.WriteLine("Happy Birthday {0} {1} you are now {2}\n",
                                    Rolf.firstName, Rolf.familyName, Rolf.age);
            }
            else{
                Console.WriteLine("Sorry, today is not your birthday\n");
            }

            Console.WriteLine("Press any key to quit");

            Console.ReadKey();
        }
    }
}
